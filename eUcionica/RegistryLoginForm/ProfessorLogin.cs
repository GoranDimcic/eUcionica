using eUcionica.Entities;
using eUcionica.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eUcionica.RegistryLoginForm
{
    public partial class ProfessorLogin : Form
    {
        public Professor professor = new Professor();

        public ProfessorLogin()
        {
            InitializeComponent();
        }

        private void BtnLoginAsProfessor_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();

            if (TxtEmailLoginProfessor.Text == "")
            {
                MessageBox.Show("You didn't enter an email, try again!");
            }
            else if (TxtPasswordLoginProfessor.Text == "")
            {
                MessageBox.Show("You didn't enter a password, try again!");
            }
            else
            {
                professor = data.GetProfessor(TxtEmailLoginProfessor.Text, TxtPasswordLoginProfessor.Text);

                if (professor == null)
                {
                    MessageBox.Show("Incorrect login, try again!");
                    TxtEmailLoginProfessor.Text = "";
                    TxtPasswordLoginProfessor.Text = "";
                }
                else
                {
                    ProfessorView form = new ProfessorView(professor);
                    DialogResult = DialogResult.OK;
                    form.ShowDialog();
                }
            }
        }

        private void EnterPress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnLoginAsProfessor.PerformClick();
        }
    }
}
