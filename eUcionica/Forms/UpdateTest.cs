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
        public Professor LoggedProfessor;

        public UpdateTest(Professor professor)
        {
            InitializeComponent();
            LoggedProfessor = professor;
            FillTests();
        }

        public void FillTests()
        {
            DataProvider data = new DataProvider();
            _ = new List<Test>();

            List<Test> tests = data.GetTests(LoggedProfessor);

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
        }

        public void FillAnswers()
        {
            DataProvider data = new DataProvider();
            string answers;

            answers = data.GetAnswers(ComboBoxTests.SelectedItem.ToString());
            TxtAnswers.Text = answers;
        }

        private void ComboBoxTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAnswers();
            FillQuestions();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            data.UpdateTest(ComboBoxTests.SelectedItem.ToString(), TxtAnswers.Text, TxtQuestions.Text);

            DialogResult = DialogResult.OK;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();
            data.DeleteTest(ComboBoxTests.SelectedItem.ToString());

            DialogResult = DialogResult.Cancel;
        }
    }
}
