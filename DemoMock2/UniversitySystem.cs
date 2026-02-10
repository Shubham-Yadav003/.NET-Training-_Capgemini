using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            try
            {
                if (AvailableCourses.ContainsKey(code))
                {
                    throw new ArgumentException($"Course with code {code} already exists. ");
                }
                // 2. Create Course object
                Course obj = new Course(code, name, credits, maxCapacity, prerequisites);
                // 3. Add to AvailableCourses
                AvailableCourses.Add(code, obj);
                Console.WriteLine($"Course {code} added successfully.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            try
            {
                if (Students.ContainsKey(id))
                {
                    throw new ArgumentException($"Student with ID {id} already exists.");
                }
                // 2. Create Student object
                Student obj = new Student(id, name, major, maxCredits, completedCourses);
                // 3. Add to Students dictionary
                Students.Add(id, obj);
                Console.WriteLine($"Student {name} added successfully.");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
            try
            {
                if (!Students.ContainsKey(studentId))
                {
                    throw new ArgumentException($"Student with ID {studentId} does not exist.");
                }
                if (!AvailableCourses.ContainsKey(courseCode))
                {
                    throw new ArgumentException($"Course with code {courseCode} does not exist.");
                }

                // 2. Call student.AddCourse(course)
                Student student = Students[studentId];
                if (student.AddCourse(AvailableCourses[courseCode]))
                {
                    Console.WriteLine($"Student {studentId} successfully registered for course {courseCode}.");
                    return true;
                }
                return false;
                // 3. Display meaningful messages
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            try
            {
                if (!Students.ContainsKey(studentId))
                {
                    throw new ArgumentException($"Student with ID {studentId} does not exist");
                }
                // 2. Call student.DropCourse(courseCode)
                Student student = Students[studentId];
                if (student.DropCourse(courseCode))
                {
                    Console.WriteLine($"Student {studentId} successfully dropped course {courseCode}.");
                    return true;
                }
                return false;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        public void DisplayAllCourses()
        {
            // TODO:
            // Display course code, name, credits, enrollment info
            if (AvailableCourses.Count == 0)
            {
                Console.WriteLine("No courses available.");
                return;
            }
            Console.WriteLine("\nAvailable Courses:");
            foreach (var elem in AvailableCourses)
            {
                Console.WriteLine($"Course Code: {elem.Value.CourseCode} | Course Name: {elem.Value.CourseName} | Credits: {elem.Value.Credits} | Enrollment: {elem.Value.GetEnrollmentInfo()}");
            }
        }

        public void DisplayStudentSchedule(string studentId)
        {
            // TODO:
            // Validate student existence
            try
            {
                if (!Students.ContainsKey(studentId))
                {
                    throw new ArgumentException($"Student with ID {studentId} does not exist");
                }
                // Call student.DisplaySchedule()
                Student student = Students[studentId];
                student.DisplaySchedule();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void DisplaySystemSummary()
        {
            // TODO:
            // Display total students, total courses, average enrollment
            Console.WriteLine("\n=== System Summary ===");
            int students = Students.Count;
            int courses = AvailableCourses.Count;
            double averageEnrollment = AvailableCourses.Count > 0 ? AvailableCourses.Values.Average(c => int.Parse(c.GetEnrollmentInfo().Split('/')[0])) : 0;

            Console.WriteLine($"Total Students: {students}");
            Console.WriteLine($"Total Courses: {courses}");
            Console.WriteLine($"Average Enrollment: {averageEnrollment:F2}");
        }
    }
}
