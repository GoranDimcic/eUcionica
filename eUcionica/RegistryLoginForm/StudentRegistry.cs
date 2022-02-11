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
    public partial class StudentRegistry : Form
    {
        public StudentRegistry()
        {
            InitializeComponent();
        }

        private void BtnRegistryStudent_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                DataProvider data = new DataProvider();
                data.AddStudent(txtEmailStudent.Text, txtPasswordStudent.Text, txtNameStudent.Text);

                DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("You must fill all fields!");
        }

        private bool Validation()
        {
            if (txtNameStudent.Text.Equals("") || txtEmailStudent.Text.Equals("") || txtPasswordStudent.Text.Equals(""))
                return false;
            return true;
        }

        private void EnterPress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnRegistryStudent.PerformClick();
        }
    }
}
