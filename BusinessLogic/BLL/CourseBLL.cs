using DTO.Model;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BLL
{
    public class CourseBLL
    {

        public Course getCourse(int id)
        {
            //if (id < 0) throw new IndexOutOfRangeException();
            return CourseRepository.getCourse(id);
        }
        public void AddCourse(Course course)
        {

            CourseRepository.AddCourse(course);
        }
        public void EditCourse(Course course)
        {
            CourseRepository.EditCourse(course);
        }

        public void DeleteCourse(Course course)
        {
            CourseRepository.DeleteCourse(course);
        }

        public List<Course> AllCourses()
        {
            return CourseRepository.AllCourses();
        }


    }
}
