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
    public partial class ProfessorView : Form
    {
        public Professor LoggedProfessor;

        public ProfessorView(Professor professor)
        {
            InitializeComponent();
            LoggedProfessor = professor;
        }

        private void BtnCreateTest_Click(object sender, EventArgs e)
        {
            CreateTest form = new CreateTest(LoggedProfessor);
            form.ShowDialog();
        }

        private void BtnGradeTest_Click(object sender, EventArgs e)
        {
            Grade form = new Grade(LoggedProfessor);
            form.ShowDialog();
        }

        private void BtnUpdateTest_Click(object sender, EventArgs e)
        {
            UpdateTest form = new UpdateTest(LoggedProfessor);
            form.ShowDialog();
        }
    }
}
