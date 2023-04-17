using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappers
{
    internal class CourseMapper
    {

        public static DTO.Model.Course Map(Course course)
        {
            return new DTO.Model.Course(course.CourseId, course.CourseName);
        }
        public static Course Map(DTO.Model.Course course)
        {
            return new Course(course.CourseId, course.CourseName);
        }


        internal static void Update(DTO.Model.Course course, Course dataCourse)
        {
            dataCourse.CourseName = course.CourseName;
        }


        //Tilføjet, dog ikke sikker på at det er den der skal bruges.
        internal static List<DTO.Model.Course> Map(List<Course> courses)
        {
            List<DTO.Model.Course> retur = new List<DTO.Model.Course>();
            foreach (Course course in courses)
            {
                retur.Add(CourseMapper.Map(course));
            }
            return retur;
        }

        //Tilføjet, den der fik det til at fungere, så man kan få vist alle studerende
        internal static List<DTO.Model.Course> Map(DbSet<Course> courses)
        {
            List<DTO.Model.Course> retur = new List<DTO.Model.Course>();
            foreach (Course course in courses)
            {
                retur.Add(CourseMapper.Map(course));
            }
            return retur;
        }


    }
}
