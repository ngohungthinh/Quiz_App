using Google.Cloud.Firestore;
using Login_Signup.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_app.Forms
{
    public partial class Form_QuenMatKhau : Form
    {
        public Form_QuenMatKhau()
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
        //-----------------------------------------------------------------------------------
        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login f = new Form_Login();
            f.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Chinh f = new Form_Chinh();
            f.ShowDialog();
            this.Close();
        }
        //----------------------------------------------------------
        private async void button_LayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;

            if (email.Trim() == "")
            {
                textBox_Result.Visible = true;
                return;
            }

            DocumentReference doc = FirestoreHelper.Database.Collection("UserData").Document(textBoxEmail.Text);
            DocumentSnapshot snap = await doc.GetSnapshotAsync();
            
            if(snap.Exists)
            {
                UserData data = snap.ConvertTo<UserData>();
                textBox_Result.Text = "Mật khẩu của bạn: " + Security.Decrypt(data.Password);
            }
            textBox_Result.Visible = true;
        }
    }
}
