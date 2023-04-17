using DataAccess.Repositories;
using DTO.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BusinessLogic.BLL
{
    public class StudentBLL
    {

        public Student getStudent(int id)
        {
            //if (id < 0) throw new IndexOutOfRangeException();
            return StudentRepository.getStudent(id);
        }
        public void AddStudent(Student student)
        {
            //valider employee
            StudentRepository.AddStudent(student);
        }
        public void EditStudent(Student student)
        {
            StudentRepository.EditStudent(student);
        }

        public void DeleteStudent(Student student) {
            StudentRepository.DeleteStudent(student);
        }

        public List<Student> AllStudents()
        {
            return StudentRepository.AllStudents();
        }

     



        //public Student getCourseDetail(int courseId)
        //{
        //    //if (id < 0) throw new IndexOutOfRangeException();
        //    return StudentRepository.getCourse(courseId);
        //}
    }



}
