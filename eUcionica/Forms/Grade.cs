using eUcionica.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eUcionica.Forms
{
    public partial class Grade : Form
    {
        public Professor loggedProfessor;
        public Test test;
        public Student student;

        public Grade(Professor professor)
        {
            InitializeComponent();
            loggedProfessor = professor;
            FillTest();
        }

        public void FillStudent(Test t)
        {
            DataProvider data = new DataProvider();
            List<Student> students = new List<Student>();

            students = data.GetStudents(t);

            foreach (Student s in students)
            {
                comboBox2.Items.Add(s.Name);
            }
        }

        public void FillAnswers()
        {
            DataProvider data = new DataProvider();
            string answers;

            answers = data.GetAnswers(comboBox1.SelectedItem.ToString());
            txtQuestions.Text = answers;
        }

        public void FillResults()
        {
            DataProvider data = new DataProvider();
            string results;

            results = data.GetResults(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
            txtResult.Text = results;
            student = data.GetStudent(comboBox2.SelectedItem.ToString());
        }

        public void FillTest()
        {
            DataProvider data = new DataProvider();
            List<Test> tests = new List<Test>();

            tests = data.GetTests(loggedProfessor);

            foreach (Test test in tests)
            {
                comboBox1.Items.Add(test.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            test = data.GetTest(comboBox1.SelectedItem.ToString());
            FillStudent(test);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            //StudentTest st = data.GetStudentTest(test, student);
            //st.Grade = Int32.Parse(comboBox3.SelectedItem.ToString());
            data.UpdateGrade(test, student, Int32.Parse(comboBox3.SelectedItem.ToString()));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAnswers();
            FillResults();
        }
    }
}
