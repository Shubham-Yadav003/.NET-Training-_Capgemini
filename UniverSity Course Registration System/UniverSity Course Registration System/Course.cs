using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // Course Class
    // =========================
    public class Course
    {
        public string CourseCode { get; private set; }
        public string CourseName { get; private set; }
        public int Credits { get; private set; }
        public int MaxCapacity { get; private set; }
        public List<string> Prerequisites { get; private set; }

        private int CurrentEnrollment;

        public Course(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            CourseCode = code;
            CourseName = name;
            Credits = credits;
            MaxCapacity = maxCapacity;
            Prerequisites = prerequisites ?? new List<string>();
            CurrentEnrollment = 0;
        }

        public bool IsFull()
        {
            // TODO: Return true if CurrentEnrollment >= MaxCapacity
            if(Course.CurrentEnrollment > Course.MaxCapacity)
            {
                return true;
            }
            return false;
        }

        public bool HasPrerequisites(List<string> completedCourses)
        {
            // TODO: Check if ALL prerequisites exist in completedCourses
            
        }

        public void EnrollStudent()
        {
            // TODO:
            // 1. Throw InvalidOperationException if course is full
            try
            {
                if (IsFull())
                {
                    throw new InvalidOperationException($"Course {CourseCode} is full. Cannot enroll more students.");
                }
                Course obj = new Course();
                obj.CurrentEnrollment = CurrentEnrollment + 1;
                // 2. Otherwise increment CurrentEnrollment
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void DropStudent()
        {
            // TODO: Decrement CurrentEnrollment only if greater than zero
            throw new NotImplementedException();
        }

        public string GetEnrollmentInfo()
        {
            return $"{CurrentEnrollment}/{MaxCapacity}";
        }
    }
}
