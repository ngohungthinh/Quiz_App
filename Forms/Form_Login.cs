using Google.Cloud.Firestore;
using Login_Signup.Classes;
using System;
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
    public partial class Form_Login : Form
    {
        public Form_Login()
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
        //-----------------------------------------------------------------

        private void button_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Register f = new Form_Register();
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

        private void label_QuenMatKhau_Click(object sender, EventArgs e)
        {
            Form_QuenMatKhau f = new Form_QuenMatKhau();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = textBoxEmail.Text.Trim();
                string password = textBoxPassword.Text;

                if (password == "") throw new Exception();
                

                var db = FirestoreHelper.Database;
                DocumentReference docRef = db.Collection("UserData").Document(email);

                UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();//class trong Classes

                if (data != null)
                {
                    if (password == Security.Decrypt(data.Password))
                    {
                        //MessageBox.Show("Login Success");

                        Form_Chinh_After_Login.username = email;
                        Form_Chinh_After_Login.userData = data;

                        this.Hide();
                        Form_Chinh_After_Login formChinh = new Form_Chinh_After_Login();
                        formChinh.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Login Failed");
                }
                else
                    MessageBox.Show("Login Failed");
            }
            catch (Exception exc)
            {
                label_Nhap_sai.Text = "Vui lòng kiểm tra lại thông tin!";
            }
        }
    }
}
