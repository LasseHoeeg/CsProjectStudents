using DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccess.Mappers
{
    internal class StudentMapper
    {

        public static DTO.Model.Student Map(Student student)
        {
            return new DTO.Model.Student(student.StudentId, student.Name);
        }
        public static Student Map(DTO.Model.Student student)
        {
            return new Student(student.StudentId, student.Name);
        }

 
        internal static void Update(DTO.Model.Student student, Student dataemp)
        {
            dataemp.Name = student.Name;
        }


        //Tilføjet, dog ikke sikker på at det er den der skal bruges.
        internal static List<DTO.Model.Student> Map(List<Student> students)
        {
            List<DTO.Model.Student> retur = new List<DTO.Model.Student>();
            foreach (Student student in students)
            {
                retur.Add(StudentMapper.Map(student));
            }
            return retur;
        }

        //Tilføjet, den der fik det til at fungere, så man kan få vist alle studerende
        internal static List<DTO.Model.Student> Map(DbSet<Student> students)
        {
            List<DTO.Model.Student> retur = new List<DTO.Model.Student>();
            foreach (Student student in students)
            {
                retur.Add(StudentMapper.Map(student));
            }
            return retur;
        }


        //Gjort færdig
        //internal static DTO.Model.CourseDetails Map(Course course) //detailS
        //{
        //    DTO.Model.CourseDetails retur = new DTO.Model.CourseDetails();
        //    retur.CourseName = course.CourseName;
        //    retur.Students = StudentMapper.Map(course.Students);
        //    return retur;
        //}


    }
}
