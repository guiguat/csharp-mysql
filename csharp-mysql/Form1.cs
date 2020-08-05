using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_mysql
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //Register Student click
            if (Application.OpenForms.OfType<RegisterStudentForm>().Count() == 0)
            {
                RegisterStudentForm rf = new RegisterStudentForm();
                rf.MdiParent = this;
                rf.Show();
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            //Register Lectures click
            if (Application.OpenForms.OfType<RegisterLecture>().Count() == 0)
            {
                RegisterLecture rl = new RegisterLecture();
                rl.MdiParent = this;
                rl.Show();
            }
        }
    }
}
