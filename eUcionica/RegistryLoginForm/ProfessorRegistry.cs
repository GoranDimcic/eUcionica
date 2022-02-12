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
                data.AddProfessor(TxtNameProfessor.Text, TxtEmailProfessor.Text, TxtPasswordProfessor.Text, ComboBoxSubjects.Text);

                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("You must fill all fields!");
        }

        private bool Validation()
        {
            if (TxtEmailProfessor.Text.Equals("") || TxtNameProfessor.Text.Equals("") || TxtPasswordProfessor.Text.Equals("") || ComboBoxSubjects.Text.Equals(""))
                return false;
            return true;
        }

        private void EnterPress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnRegistryProfessor.PerformClick();
        }
    }
}
