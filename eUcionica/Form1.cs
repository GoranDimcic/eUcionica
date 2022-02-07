using eUcionica.RegistryLoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eUcionica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnProfessor_Click(object sender, EventArgs e)
        {
            BtnProfessor.Visible = false;
            BtnLoginProfessor.Visible = true;
            BtnRegistryProfessor.Visible = true;
            BtnX1.Visible = true;

            BtnStudent.Visible = true;
            BtnLoginStudent.Visible = false;
            BtnRegistryStudent.Visible = false;
            BtnX2.Visible = false;
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            BtnStudent.Visible = false;
            BtnLoginStudent.Visible = true;
            BtnRegistryStudent.Visible = true;
            BtnX2.Visible = true;

            BtnProfessor.Visible = true;
            BtnLoginProfessor.Visible = false;
            BtnRegistryProfessor.Visible = false;
            BtnX1.Visible = false;
        }

        private void BtnX1_Click(object sender, EventArgs e)
        {
            BtnProfessor.Visible = true;
            BtnLoginProfessor.Visible = false;
            BtnRegistryProfessor.Visible = false;
            BtnX1.Visible = false;
        }

        private void BtnX2_Click(object sender, EventArgs e)
        {
            BtnStudent.Visible = true;
            BtnLoginStudent.Visible = false;
            BtnRegistryStudent.Visible = false;
            BtnX2.Visible = false;
        }

        private void BtnLoginProfessor_Click(object sender, EventArgs e)
        {
            ProfessorLogin form = new ProfessorLogin();
            form.ShowDialog();
        }

        private void BtnRegistryProfessor_Click(object sender, EventArgs e)
        {
            ProfessorRegistry form = new ProfessorRegistry();
            form.ShowDialog();
        }

        private void BtnLoginStudent_Click(object sender, EventArgs e)
        {
            StudentLogin form = new StudentLogin();
            form.ShowDialog();
        }

        private void BtnRegistryStudent_Click(object sender, EventArgs e)
        {
            StudentRegistry form = new StudentRegistry();
            form.ShowDialog();
        }
    }
}
