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
        public Student loggedStudent;

        public Work(Student student)
        {
            InitializeComponent();
            loggedStudent = student;
        }

        public void FillComboBox()
        {
            DataProvider data = new DataProvider();
            List<Test> tests = new List<Test>();

            tests = data.GetTests(ComboBoxSubjects.SelectedItem.ToString());

            foreach (Test test in tests)
            {
                comboBox1.Items.Add(test.Name);
            }
        }

        public void FillQuestions()
        {
            DataProvider data = new DataProvider();
            string questions;

            questions = data.GetQuestions(comboBox1.SelectedItem.ToString());
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            txtQuestions.Text = questions;
        }

        private void ComboBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillQuestions();
        }
    }
}
