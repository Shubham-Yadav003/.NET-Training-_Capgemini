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
            try
            {
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

                if (count + course.Credits <= course.MaxCapacity)
                {
                    return true;
                }
                return false;
                // 3. Course prerequisites must be satisfied
            }
            
        }

        public bool AddCourse(Course course) // to do
        {
            // TODO:
            // 1. Call CanAddCourse
            if (Student.CanAddCourse(course))
            {
                RegisteredCourses.Add(course);
            }
            // 2. Check course capacity
            // 3. Add course to RegisteredCourses
            // 4. Call course.EnrollStudent()
            Course obj = new Course();
           if(obj.EnrollStudent())
            {
                return true;
            }
            return false;
           
        }

        public bool DropCourse(string courseCode)
        {
            // TODO:
            // 1. Find course by code
            // 2. Remove from RegisteredCourses
            // 3. Call course.DropStudent()
            throw new NotImplementedException();
        }

        public void DisplaySchedule() // to do
        {
            // TODO:
            // Display course code, name, and credits
            // If no courses registered, display appropriate message
            foreach(var elem in RegisteredCourses)
            {
                Console.Writeline($"Course Code: {elem.CourseCode} CourseName: {elem.CourseName} Credits: {elem.Credits}");
            }
        }
    }
}
