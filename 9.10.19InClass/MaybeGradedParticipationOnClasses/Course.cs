//@author Dalton Newport
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaybeGradedParticipationOnClasses
{
    class Course
    {

        public int CourseID { get; set; }
        public int CourseNumber { get; set; }
        public string CourseName { get; set; }
        public string Subject { get; set; }
        public string Instructor { get; set; }

        public Course()
        {
            CourseID = 0;
            CourseNumber = 0;
            CourseName = string.Empty;
            Subject = string.Empty;
            Instructor = string.Empty;
        }

        public override string ToString()
        {
            return $"\nCourse ID: {CourseID}\nCourse Number: {CourseNumber}\nCourse Name: {CourseName}\nSubject: {Subject}\nInstructor: {Instructor}";
        }
    }
}
