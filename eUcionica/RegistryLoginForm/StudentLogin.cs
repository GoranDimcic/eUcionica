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
    public partial class StudentLogin : Form
    {
        public Student student = new Student();

        public StudentLogin()
        {
            InitializeComponent();
        }

        private void BtnLoginAsStudent_Click(object sender, EventArgs e)
        {
            DataProvider data = new DataProvider();

            if (txtEmailLoginStudent.Text == "")
            {
                MessageBox.Show("You didn't enter an email, try again!");
            }
            else if (txtPasswordLoginStudent.Text == "")
            {
                MessageBox.Show("You didn't enter a password, try again!");
            }
            else
            {
                student = data.GetStudent(txtEmailLoginStudent.Text, txtPasswordLoginStudent.Text);

                if (student == null)
                {
                    MessageBox.Show("Incorrect login, try again!");
                    txtEmailLoginStudent.Text = "";
                    txtPasswordLoginStudent.Text = "";
                }
                else
                {
                    Work form = new Work(student);
                    form.ShowDialog();
                }
            }
        }

        private void EnterPress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnLoginAsStudent.PerformClick();
        }
    }
}
