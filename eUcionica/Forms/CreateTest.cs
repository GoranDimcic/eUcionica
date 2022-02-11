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
    public partial class CreateTest : Form
    {
        public Professor loggedProfessor;

        public CreateTest(Professor professor)
        {
            InitializeComponent();
            loggedProfessor = professor;

            textBox1.Text = loggedProfessor.Subject;
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            DataProvider d = new DataProvider();

            d.AddTest(txtQuestions.Text, txtAnswers.Text, DateTime.Parse(date.Text), loggedProfessor);
        }
    }
}
