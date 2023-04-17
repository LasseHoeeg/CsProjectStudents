using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model
{
    public class Course
    {
        public List<Student> Students { get; set; }

        public string CourseName { get; set; }

        public int CourseId { get; set; }

        public Course(int courseID, string courseName)
        {
            CourseId = courseID;
            CourseName = courseName;
            Students = new List<Student>();
        }

        public Course() { }
    }
}
