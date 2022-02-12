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
        public Professor LoggedProfessor;

        public CreateTest(Professor professor)
        {
            InitializeComponent();
            LoggedProfessor = professor;

            TxtProfessorSubject.Text = LoggedProfessor.Subject;
        }

        private void BtnAddTest_Click_1(object sender, EventArgs e)
        {
            DataProvider d = new DataProvider();

            d.AddTest(TxtQuestions.Text, TxtAnswers.Text, System.DateTime.Parse(DateTime.Text), TxtTestName.Text, LoggedProfessor);
        }
    }
}
