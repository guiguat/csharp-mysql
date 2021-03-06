﻿using csharp_mysql.Controllers;
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
    public partial class RegisterStudentForm : Form
    {
        public RegisterStudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(txbRA.Text == String.Empty || txbName.Text == String.Empty || cbClasses.SelectedItem == null))
            {
                string ra = txbRA.Text;
                string name = txbName.Text;
                string student_class = cbClasses.SelectedItem.ToString();
            
                try
                {
                    var student = new Student(int.Parse(ra), name, student_class);
                    var ctrl = new StudentController();
                    ctrl.Insert(student);
                    MessageBox.Show($"Student \"{student.Name}\" was succesfully registered!");
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Not able to insert into database\nError:\n{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please fill in the fields properly");
            }
        }

        private void ClearForm()
        {
            txbName.Text = "";
            txbRA.Text = "";
            cbClasses.SelectedItem = null;
        }
    }
}
