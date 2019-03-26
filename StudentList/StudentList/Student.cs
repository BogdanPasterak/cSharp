using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string DOB { get; set; }
        public string Course { get; set; }

        public Student(int iD, string firstName, string surname, string dOB, string course)
        {
            ID = iD;
            FirstName = firstName;
            Surname = surname;
            DOB = dOB;
            Course = course;
        }

        public string ToCSV()
        {
            return ID + "," + FirstName + "," + Surname + "," + DOB + "," + Course;
        }

        public string[] ToListViewItem()
        {
            string[] row = new string[5];
            row[0] = ID.ToString();
            row[1] = FirstName;
            row[2] = Surname;
            row[3] = DOB;
            row[4] = Course;

            return row;
        }

        public override string ToString()
        {
            return string.Format("Student=>  ID: {0,-3:N0}  First Name: {1,-10}  Surname: {2,-12}  DOB: {3,-10}  Cours: {4}", ID, FirstName, Surname, DOB, Course);
        }
    }
}
