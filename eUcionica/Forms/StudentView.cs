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
    public partial class StudentView : Form
    {
        public Student loggedStudent;

        public StudentView(Student student)
        {
            InitializeComponent();
            loggedStudent = student;
        }
    }
}
