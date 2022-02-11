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
    public partial class UpdateTest : Form
    {
        public Professor loggedProfessor;

        public UpdateTest(Professor professor)
        {
            InitializeComponent();
            loggedProfessor = professor;
            FillTests();
        }

        public void FillTests()
        {
            DataProvider data = new DataProvider();
            List<Test> tests = new List<Test>();

            tests = data.GetTests(loggedProfessor);

            foreach (Test test in tests)
            {
                ComboBoxTests.Items.Add(test.Name);
            }
        }

        public void FillAnswers()
        {
            DataProvider data = new DataProvider();
            string answers;

            answers = data.GetAnswers(ComboBoxTests.SelectedItem.ToString());
            txtAnswers.Text = answers;
        }

        public void FillQuestions()
        {
            DataProvider data = new DataProvider();
            string questions;

            questions = data.GetQuestions(ComboBoxTests.SelectedItem.ToString());
            txtQuestions.Text = questions;
        }

        private void ComboBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAnswers();
            FillQuestions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            data.UpdateTest(ComboBoxTests.SelectedItem.ToString(), txtAnswers.Text, txtQuestions.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            data.DeleteTest(ComboBoxTests.SelectedItem.ToString());

            DialogResult = DialogResult.Cancel;
        }
    }
}
