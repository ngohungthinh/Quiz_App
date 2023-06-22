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
using System.IO;

namespace Quiz_app.Forms
{
    public partial class Form_Register : Form
    {
        public Form_Register()
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

        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login f = new Form_Login();
            f.ShowDialog();
            this.Close();
        }
        private UserData GetWriteData()
        {

            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            password = Security.Encrypt(password);
            string name = textBoxName.Text.Trim();

            // Profile picture
            byte[] imageBytes = File.ReadAllBytes(avatarFilenameLb.Text);
            string base64String = Convert.ToBase64String(imageBytes);

            return new UserData()
            {
                Email = email,
                Password = password,
                Name = name,
                Avatar = base64String
            };
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPassword.Text == "" || textBoxName.Text == "" || avatarFilenameLb.Text == "") throw new Exception();
                label_Nhap_sai.Text = "";
                if (CheckIfUserAlreadyExist())
                {
                    MessageBox.Show("User Already Exist");
                    return;
                }

                var db = FirestoreHelper.Database;
                var data = GetWriteData();

                DocumentReference docRef = db.Collection("UserData").Document(data.Email);
                docRef.SetAsync(data);
                MessageBox.Show("Success");
            }
            catch(Exception exc)
            {
                label_Nhap_sai.Text = "Vui lòng kiểm tra lại thông tin!";
            }
        }

        private bool CheckIfUserAlreadyExist()
        {
            string email = textBoxEmail.Text.Trim();
            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(email);

            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();//class trong Classes

            if (data != null)
            {
                return true;
            }
            else
                return false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Chinh f = new Form_Chinh();
            f.ShowDialog();
            this.Close();
        }

        private void loadAvatarBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog avatar = new OpenFileDialog();
            avatar.Title = "Select image";
            avatar.Filter = "Image Files(*.jpg) | *.jpg";

            if (avatar.ShowDialog() == DialogResult.OK)
            {
                avatarFilenameLb.Text = avatar.FileName;
            }
        }
    }
}
