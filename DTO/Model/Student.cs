using System.ComponentModel.DataAnnotations;

namespace DTO.Model
{
    public class Student
    {

        public int StudentId { get; set; }

        public string Name { get; set; }
   
        public Student()
        {

        }
        public Student(int studentId, string name)
        {
            StudentId = studentId;
            Name = name;
        }

        public override string ToString()
        {
            return Name + ", " + StudentId;
        }

    }
}