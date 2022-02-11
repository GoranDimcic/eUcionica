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

            if (txtEmailLoginProfessor.Text == "")
            {
                MessageBox.Show("You didn't enter an email, try again!");
            }
            else if (txtPasswordLoginProfessor.Text == "")
            {
                MessageBox.Show("You didn't enter a password, try again!");
            }
            else
            {
                professor = data.GetProfessor(txtEmailLoginProfessor.Text, txtPasswordLoginProfessor.Text);

                if (professor == null)
                {
                    MessageBox.Show("Incorrect login, try again!");
                    txtEmailLoginProfessor.Text = "";
                    txtPasswordLoginProfessor.Text = "";
                }
                else
                {
                    ProfessorView form = new ProfessorView(professor);
                    form.ShowDialog();
                }
            }
        }

        private void TxtEmailLoginProfessor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnLoginAsProfessor.PerformClick();
        }
    }
}
