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
    public partial class Work : Form
    {
        public Student LoggedStudent;
        public Test test;

        public Work(Student student)
        {
            InitializeComponent();
            LoggedStudent = student;
        }

        public void Clear()
        {
            ComboBoxTests.Items.Clear();
        }

        public void FillComboBox()
        {
            DataProvider data = new DataProvider();
            _ = new List<Test>();

            Professor professor = data.GetProfessor(ComboBoxSubjects.SelectedItem.ToString());

            if (professor.Tests.Count == 0)
            {
                MessageBox.Show("No available tests!");
                ComboBoxTests.Text = "";
            }
            else
            {
                List<Test> tests = data.GetTests(ComboBoxSubjects.SelectedItem.ToString());

                foreach (Test test in tests)
                {
                    ComboBoxTests.Items.Add(test.Name);
                }
            }
        }

        public void FillQuestions()
        {
            DataProvider data = new DataProvider();
            string questions;

            questions = data.GetQuestions(ComboBoxTests.SelectedItem.ToString());
            TxtQuestions.Text = questions;
        }

        private void ComboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            FillComboBox();
        }

        private void ComboBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            test = data.GetTest(ComboBoxTests.SelectedItem.ToString());

            StudentTest studentTest = data.GetStudentTest(test, LoggedStudent);
            if (studentTest != null)
            {
                MessageBox.Show("You have already completed this test!");
            }
            else
            {
                FillQuestions();
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            data.AddStudentTest(LoggedStudent, test, TxtAnswers.Text);

            DialogResult = DialogResult.OK;
        }
    }
}
