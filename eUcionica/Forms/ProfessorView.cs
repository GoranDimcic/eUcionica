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
            CreateTest form = new CreateTest();
            form.ShowDialog();
        }
    }
}
