using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }
        public Course(int courseId, string courseName) 
        { 
            CourseId = courseId;
            CourseName = courseName;
            Students = new List<Student>();
        }
        public Course()
        {
        }
    }
}
