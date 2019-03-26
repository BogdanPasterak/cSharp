using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentList
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
            // Add 5 unsorted Students 
            students.Add(new Student(5, "Bogdan", "Pasterak", "5/1/1999", "Software Develop"));
            students.Add(new Student(9, "John", "Doe", "31/12/2000", "Tourist guide"));
            students.Add(new Student(1, "Eva", "Mc'Donalds", "2/7/1997", "Cooking"));
            students.Add(new Student(7, "Ed", "Smith", "15/2/2004", "Tester"));
            students.Add(new Student(2, "Arnold", "Kenedy", "14/9/1998", "Software Develop"));

            PrintStudents();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int newID;

            lblMessage.ForeColor = Color.Red;

            if (txtID.Text == "")
            {
                lblMessage.Text = "         Required field";
                lblMessage.Visible = true;
                txtID.Focus();
            }
            else if (! int.TryParse(txtID.Text, out newID))
            {
                lblMessage.Text = "The value have to be a integer";
                lblMessage.Visible = true;
                txtID.Clear();
                txtID.Focus();
            }
            else if (IsAlready(newID))
            {
                lblMessage.Text = "This ID is already on the list";
                lblMessage.Visible = true;
                txtID.Clear();
                txtID.Focus();
            }
            else
            {
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "Student added to the list";
                lblMessage.Visible = true;
                students.Add(new Student(newID,txtFirstName.Text,txtSurname.Text,txtDOB.Text,txtCourse.Text));
                PrintStudents();
            }
        }

        private bool IsAlready(int newID)
        {
            foreach (Student s in students)
            {
                if (s.ID == newID)
                {
                    return true;
                }
            }
            return false;
        }

        private void PrintStudents()
        {
            lvStudents.Items.Clear();
            Console.WriteLine("Student List");
            foreach (Student s in students)
            {
                Console.WriteLine(s);
                // add s to list view

                ListViewItem item = new ListViewItem(s.ToListViewItem());
                lvStudents.Items.Add(item);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            SortStudents.QuickSort(students);
            PrintStudents();
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            SortStudents.BubbleSort(students);
            PrintStudents();
        }

        private void btnMix_Click(object sender, EventArgs e)
        {
            Student temp;
            Random rnd = new Random();
            int size = students.Count;
            int where = 0;

            for (int i = 0; i < size; i++)
            {
                where = rnd.Next(size);
                temp = students[i];
                students[i] = students[where];
                students[where] = temp;
            }

            PrintStudents();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path;
            
            SaveFileDialog file = new SaveFileDialog();
            file.DefaultExt = "csv";
            file.FileName = "Student List";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                Console.WriteLine(path.ToString());
                string toWrite = "";
                foreach (Student s in students)
                {
                    toWrite += s.ToCSV()  + Environment.NewLine;
                }
                File.WriteAllText(path, toWrite);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string path;

            OpenFileDialog file = new OpenFileDialog();
            file.DefaultExt = "csv";
            file.FileName = "Student List";
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                Console.WriteLine(path.ToString());
                string read = File.ReadAllText(path);
                string[] sts = read.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                students = new List<Student>();
                foreach (string s in sts)
                {
                    if (s != "")
                    {
                        string[] st = s.Split(',');
                        students.Add(new Student(int.Parse(st[0]),st[1],st[2],st[3],st[4]));
                    }
                }
                Console.WriteLine(sts.Length.ToString());
                PrintStudents();
            }
        }
    }
}
