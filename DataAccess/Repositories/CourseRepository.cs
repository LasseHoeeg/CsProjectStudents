using DataAccess.Context;
using DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CourseRepository
    {
        public static DTO.Model.Course getCourse(int id)
        {
            using (StudentContext context = new StudentContext())
            {
                //Maybe throw exception if not found
                return CourseMapper.Map(context.Courses.Where(e => e.CourseId == id).First()); 
            }
        }
        public static void AddCourse(DTO.Model.Course course)
        {
            using (StudentContext context = new StudentContext())
            {
                context.Courses.Add(CourseMapper.Map(course));
                context.SaveChanges();
            }
        }

        public static void EditCourse(DTO.Model.Course course)
        {
            using (StudentContext context = new StudentContext())
            {

                Model.Course dataCou = context.Courses.Where(e => e.CourseId == course.CourseId).First();
                CourseMapper.Update(course, dataCou);

                context.SaveChanges();
            }
        }

        public static void DeleteCourse(DTO.Model.Course course)
        {

            using (StudentContext context = new StudentContext())
            {
                Model.Course dataCou = CourseMapper.Map(course);
                context.Entry(dataCou).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }

        }
        //Skal huske validering ift. delete, hvis en person ikke findes.
        //Gør det samme som ved edit, bare med deleted i stedet for modified.



        public static List<DTO.Model.Course> AllCourses()
        {
            using (StudentContext context = new StudentContext())
            {
                return CourseMapper.Map(context.Courses);
            }
        }



    }
}
