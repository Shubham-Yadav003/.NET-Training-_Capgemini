using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Student Class
    // =========================
    public class Student
    {
        public string StudentId { get; private set; }
        public string Name { get; private set; }
        public string Major { get; private set; }
        public int MaxCredits { get; private set; }

        public List<string> CompletedCourses { get; private set; }
        public List<Course> RegisteredCourses { get; private set; }

        public Student(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            StudentId = id;
            Name = name;
            Major = major;
            MaxCredits = maxCredits;
            CompletedCourses = completedCourses ?? new List<string>();
            RegisteredCourses = new List<Course>();
        }

        public int GetTotalCredits()
        {
            // TODO: Return sum of credits of all RegisteredCourses
            int sum = 0;
            foreach(var elem in RegisteredCourses)
            {
                sum += elem.Credits;
            }

            return sum;
        }

        public bool CanAddCourse(Course course)
        {
            // TODO:
            // 1. Course should not already be registered
            if (RegisteredCourses.Any(c => c.CourseCode == course.CourseCode))
            {
                throw new ArgumentException($"Course {course.CourseCode} already registered!");
            }
            // 2. Total credits + course credits <= MaxCredits
            int count = 0;
            foreach(var elem in RegisteredCourses)
            {
                count += elem.Credits;
            }

            if (count + course.Credits > MaxCredits)
            {
                throw new ArgumentException($"Cannot add course. Total credits would exceed maximum.");
            }
            // 3. Course prerequisites must be satisfied
            if (!course.HasPrerequisites(CompletedCourses))
            {
                throw new ArgumentException($"Course {course.CourseCode} requires prerequisite courses.");
            }
            return true;
        }

        public bool AddCourse(Course course) // to do
        {
            // TODO:
            // 1. Call CanAddCourse
            try
            {
                if (!CanAddCourse(course))
                {
                    return false;
                }
                // 2. Check course capacity
                if (course.IsFull())
                {
                    throw new InvalidOperationException($"Course {course.CourseCode} is full.");
                }
                // 3. Add course to RegisteredCourses
                RegisteredCourses.Add(course);
                // 4. Call course.EnrollStudent()
                course.EnrollStudent();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public bool DropCourse(string courseCode)
        {
            // TODO:
            // 1. Find course by code
            var course = RegisteredCourses.FirstOrDefault(c => c.CourseCode == courseCode);
            if (course == null)
            {
                throw new ArgumentException($"Course {courseCode} not found in student schedule.");
            }
            // 2. Remove from RegisteredCourses
            RegisteredCourses.Remove(course);
            // 3. Call course.DropStudent()
            course.DropStudent();
            return true;
        }

        public void DisplaySchedule() // to do
        {
            // TODO:
            // Display course code, name, and credits
            // If no courses registered, display appropriate message
            if (RegisteredCourses.Count == 0)
            {
                Console.WriteLine("No courses registered.");
                return;
            }
            Console.WriteLine($"Schedule for {Name} ({StudentId}):");
            foreach(var elem in RegisteredCourses)
            {
                Console.WriteLine($"Course Code: {elem.CourseCode} CourseName: {elem.CourseName} Credits: {elem.Credits}");
            }
        }
    }
}
