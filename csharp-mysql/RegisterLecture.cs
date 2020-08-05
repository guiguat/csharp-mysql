using csharp_mysql.Controllers;
using csharp_mysql.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace csharp_mysql
{
    public partial class RegisterLecture : Form
    {
        public RegisterLecture()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           txbDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(
                txbSpeaker.Text == String.Empty
                || txbTitle.Text == String.Empty
                || txbDate.Text == String.Empty
                || cbHour.SelectedItem == null
               ))
            {
                string title = txbTitle.Text;
                string day = txbDate.Text;
                string hour = cbHour.SelectedItem.ToString();
                string speaker = txbSpeaker.Text;
                try
                {
                    var lect = new Lecture(title, speaker, day, hour);
                    var ctrl = new LectureController();
                    ctrl.Insert(lect);
                    MessageBox.Show($"Lecture \"{lect.Title}\" was succesfully registered!");
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to insert in table Lecture\n Error:\n{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please fill in the fields properly");
            }
        }

        private void ClearForm()
        {
            txbTitle.Text = "";
            txbSpeaker.Text = "";
            txbDate.Text = "";
            cbHour.SelectedItem = null;
        }
    }
}
