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
    public partial class ProfessorRegistry : Form
    {
        public ProfessorRegistry()
        {
            InitializeComponent();
        }

        private void BtnRegistryProfessor_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                DataProvider data = new DataProvider();
                data.AddProfessor(txtNameProfessor.Text, txtEmailProfessor.Text, txtPasswordProfessor.Text, ComboBoxSubjects.Text);

                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("You must fill all fields!");
        }

        private bool Validation()
        {
            if (txtEmailProfessor.Text.Equals("") || txtNameProfessor.Text.Equals("") || txtPasswordProfessor.Text.Equals("") || ComboBoxSubjects.Text.Equals(""))
                return false;
            return true;
        }

        private void TxtEmailProfessor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnRegistryProfessor.PerformClick();
        }
    }
}
