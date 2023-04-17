using DataAccess.Context;
using DataAccess.Mappers;

using Microsoft.EntityFrameworkCore;
using DataAccess.Model;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccess.Repositories
{
    public class StudentRepository
    {



        public static DTO.Model.Student getStudent(int id)
        {
            using (StudentContext context = new StudentContext())
            {
                //Maybe throw exception if not found
                return StudentMapper.Map(context.Students.Where(e => e.StudentId == id).First());
            }
        }
        public static void AddStudent(DTO.Model.Student student)
        {
            using (StudentContext context = new StudentContext())
            {
                context.Students.Add(StudentMapper.Map(student));
                context.SaveChanges(); 
            }
        }

        public static void EditStudent(DTO.Model.Student student)
        {
            using (StudentContext context = new StudentContext())
            {
              
                Model.Student dataStu = context.Students.Where(e => e.StudentId == student.StudentId).First();
                StudentMapper.Update(student, dataStu);
     
                context.SaveChanges();
            }
        }

        public static void DeleteStudent(DTO.Model.Student student)
        {

            using (StudentContext context = new StudentContext())
            {
                Model.Student datastu = StudentMapper.Map(student);
                context.Entry(datastu).State =Microsoft.EntityFrameworkCore.EntityState.Deleted;
                 context.SaveChanges();
            }

        }
        //Skal huske validering ift. delete, hvis en person ikke findes.
        //Gør det samme som ved edit, bare med deleted i stedet for modified.

        //public static List<Course> getAllCourses()
        //{
        //    using (StudentContext context = new StudentContext)
        //    {

        //    }
        //}

 
        public static List<DTO.Model.Student> AllStudents() 
        {
            using (StudentContext context = new StudentContext())
            {
                return StudentMapper.Map(context.Students);
            }
        }
    }
}
