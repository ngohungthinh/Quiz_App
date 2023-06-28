﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_app.Forms
{
    public partial class Form_Chinh : Form
    {
        public Form_Chinh()
        {
            InitializeComponent();
        }
        public Point mouseLocation;
        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //--------------------------------------------------------------------------
        bool isChangetextBox_SearchQuiz = false;
        private void textBox_SearchQuiz_MouseClick(object sender, MouseEventArgs e)
        {
            if (isChangetextBox_SearchQuiz == false)
            {
                textBox_SearchQuiz.Text = "";
                isChangetextBox_SearchQuiz = true;
            }
        }

        private void textBox_SearchQuiz_Leave(object sender, EventArgs e)
        {
            if (textBox_SearchQuiz.Text == "")
            {
                textBox_SearchQuiz.Text = "Nhập tên.....";
                isChangetextBox_SearchQuiz = false;
            }
        }
        //---------------------------------------------------------------------------
        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login f = new Form_Login();
            f.ShowDialog();
            this.Close();
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Register f = new Form_Register();
            f.ShowDialog();
            this.Close();
        }
        private void button_TaoQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login f = new Form_Login();
            f.ShowDialog();
            this.Close();
        }
        //----------------------------------------------------------------------------
    }
}
