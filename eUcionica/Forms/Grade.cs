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
        public Professor LoggedProfessor;
        public Test test;
        public Student student;

        public Grade(Professor professor)
        {
            InitializeComponent();
            LoggedProfessor = professor;
            FillTest();
        }

        public void FillTest()
        {
            DataProvider data = new DataProvider();
            _ = new List<Test>();

            List<Test> tests = data.GetTests(LoggedProfessor);

            foreach (Test test in tests)
            {
                ComboBoxTests.Items.Add(test.Name);
            }
        }

        public void FillStudent(Test test)
        {
            DataProvider data = new DataProvider();
            _ = new List<Student>();

            List<Student> students = data.GetStudents(test);

            foreach (Student student in students)
            {
                ComboBoxStudents.Items.Add(student.Name);
            }
        }

        public void FillAnswers()
        {
            DataProvider data = new DataProvider();
            string answers;

            answers = data.GetAnswers(ComboBoxTests.SelectedItem.ToString());
            TxtAnswers.Text = answers;
        }

        public void FillResults()
        {
            DataProvider data = new DataProvider();
            string results;

            results = data.GetResults(ComboBoxTests.SelectedItem.ToString(), ComboBoxStudents.SelectedItem.ToString());
            TxtResult.Text = results;
            student = data.GetStudent(ComboBoxStudents.SelectedItem.ToString());
        }

        private void ComboBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            test = data.GetTest(ComboBoxTests.SelectedItem.ToString());
            FillStudent(test);
        }

        private void ComboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAnswers();
            FillResults();
        }

        private void BtnSubmitGrade_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();

            data.UpdateGrade(test, student, Int32.Parse(ComboBoxGrade.SelectedItem.ToString()));

            DialogResult = DialogResult.OK;
        }
    }
}
