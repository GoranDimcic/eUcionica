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
        public Professor loggedProfessor;

        public ProfessorView(Professor professor)
        {
            InitializeComponent();
            loggedProfessor = professor;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateTest form = new CreateTest(loggedProfessor);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grade form = new Grade(loggedProfessor);
            form.ShowDialog();
        }
    }
}
