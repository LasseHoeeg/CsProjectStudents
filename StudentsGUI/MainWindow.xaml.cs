using BusinessLogic.BLL;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace StudentsGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        StudentBLL bll = new StudentBLL();
        Student stu;
        private void Vis_Click(object sender, RoutedEventArgs e)
        {
            stu = bll.getStudent(Int32.Parse(Input.Text));
            NavnText.Text = stu.Name;
            IdText.Text = stu.StudentId +"";

        }

        private void Opdater_Click(object sender, RoutedEventArgs e)
        {
       
            stu.Name = InputNavn.Text;
            bll.EditStudent(stu);
        }

        private void Tilfoej_Click(object sender, RoutedEventArgs e)
        {
        //Id auto-genereres i SQL.
            Student stu = new Student();
            stu.Name = InputNavn.Text;
                bll.AddStudent(stu);

        }

        private void SletKnap_Click(object sender, RoutedEventArgs e)
        {
            bll.DeleteStudent(bll.getStudent(Int32.Parse(Input.Text)));
        }

        private void VisAlleStuderende_Click(object sender, RoutedEventArgs e)
        {
            foreach (Student student in bll.AllStudents())
            {
                ListeStuderende.Items.Add(student.ToString());
            }
        }



        //private void VisCompanies_Click(object sender, RoutedEventArgs e)
        //{
        //    foreach (Company company in bll.AllCompanies())
        //    {
        //        CompanyListe.Items.Add(company.CompanyName);
        //    }
        //}




        //Kan ikke lige huske nedenstående

        //private void Add_Student(object sender, RoutedEventArgs e)
        //{
        //    Student stu = new Student(7, NameToChangeOrAdd.Text, int.Parse(Years.Text));
        //    bll.AddStudent(stu);
        //}

        //private void Edit_Student(object sender, RoutedEventArgs e)
        //{
        //    stu.YearStudent = int.Parse(Years.Text);
        //    stu.Name = NameToChangeOrAdd.Text;
        //    bll.EditStudent(stu);
        //}



    }
}
