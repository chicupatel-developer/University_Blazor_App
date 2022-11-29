using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseNumber { get; set; }
        public ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
