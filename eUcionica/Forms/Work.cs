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

        public void FillComboBox()
        {
            DataProvider data = new DataProvider();
            List<Test> tests = new List<Test>();

            tests = data.GetTests(ComboBoxSubjects.SelectedItem.ToString());

            foreach (Test test in tests)
            {
                ComboBoxTests.Items.Add(test.Name);
            }
        }

        public void FillQuestions()
        {
            DataProvider data = new DataProvider();
            string questions;

            questions = data.GetQuestions(ComboBoxTests.SelectedItem.ToString());
            TxtQuestions.Text = questions;

            test = data.GetTest(ComboBoxTests.SelectedItem.ToString());
        }

        private void ComboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void ComboBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillQuestions();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            data.AddStudentTest(LoggedStudent, test, TxtAnswers.Text);
        }
    }
}
