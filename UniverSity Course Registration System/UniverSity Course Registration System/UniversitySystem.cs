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
                Course obj = new Course(code, name, creadits, maxCapacity, prerequisites);
                // 3. Add to AvailableCourses
                AvailableCourses.Add(code, obj);
                throw new NotImplementedException();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Meassage);
            }
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            try
            {
                if (Student.ContainsKey(id))
                {
                    throw new ArgumentException($"Student with ID {id} already exists.");
                }
                // 2. Create Student object
                Student obj = new Student(id, name, major, maxCredits, completedCourses);
                // 3. Add to Students dictionary
                Students.Add(id, obj);
            }

            //throw new NotImplementedException();
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
            try
            {
                if (Students.ContainsKey(studentId))
                {
                    throw new ArgumentException($"Student with ID {studentId} already exists.");
                }
                else if (AvailableCourses.ContainsKey(courseCode))
                {
                    throw new ArgumentException($"Course with code {courseCode} already exists.");
                }



                // 2. Call student.AddCourse(course)
                Student obj = new Student();
                obj.AddCourse(AvailableCourses[courseCode]);
                Console.WriteLine($"Student {studentId} successfully registered for course {courseCode}.");
                return true;
                // 3. Display meaningful messages
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            try
            {
                // 2. Call student.DropCourse(courseCode)
                if (!Students.ContainsKey(studentId))
                {
                    throw new ArgumentException($"Student with ID {studentId} does not exist");
                }

                Student obj = new Student();
                obj.DropCourse(courseCode);
                return true;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            
        }

        public void DisplayAllCourses()
        {
            // TODO:
            // Display course code, name, credits, enrollment info
            foreach (var elem in AvailableCourses)
            {
                Console.WriteLine($"Course Code: {elem.Value.CourseCode} Course Name: {elem.Value.CourseName} Credits: {elem.Value.Credits} Enrollment: {elem.Value.CurrentEnrollment()}");
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

                Student obj = new Student();
                obj.DisplaySchedule();
            }
            // Call student.DisplaySchedule()
          catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DisplaySystemSummary()
        {
            // TODO:
            // Display total students, total courses, average enrollment

            int students = Students.Count;
            int courses = AvailableCourses.Count;
            double averageEnrollment = AvailableCourses.Count > 0 ? AvailableCourses.Values.Average(c => c.CurrentEnrollment()) : 0;

            Console.WriteLine($"Total Students: {students} Total Courses: {courses} averageEnrollment: {averageEnrollment}");
        }
    }
}
