using Google.Cloud.Firestore;
using Google.Type;
using Login_Signup.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_app.Forms
{
    public partial class Form_Chinh : Form
    {
        public static string username { get; set; }

        static Form_Chinh()
        {

            username = "";
        }

        public async void Form_Chinh_onLoad(object sender, EventArgs e)
        {
            if (username != "")
            {
                button_login.Visible = false;
                button_signup.Visible = false;
                profileLb.Text = username;

                // Load profile picture
                var db = FirestoreHelper.Database;
                DocumentReference docRef = db.Collection("UserData").Document(username);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
                UserData userData = null;
                if (snapshot.Exists)
                {
                    userData = snapshot.ConvertTo<UserData>();
                }
                else
                {
                    MessageBox.Show("Khong ton tai!");
                }
                byte[] imageBytes = Convert.FromBase64String(userData.Avatar);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    Image image = Image.FromStream(ms);
                    avatarPtb.Image = image.GetThumbnailImage(60, 60, null, IntPtr.Zero);
                }
            } else
            {
                button_logout.Visible = false;
                profileLb.Visible = false;
                avatarPtb.Visible = false;
            }
        }

        public Form_Chinh()
        {
            InitializeComponent();
            this.Load += Form_Chinh_onLoad;
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

        private void button_logout_Click(object sender, EventArgs e)
        {
            Form_Chinh.username = "";
            this.Hide();
            Form_Chinh form_Chinh = new Form_Chinh();
            form_Chinh.ShowDialog();
            this.Close();
        }

        private void profileLb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Profile formProfile = new Form_Profile();
            formProfile.ShowDialog();
            this.Close();
        }

        private void btn_taodethi_Click(object sender, EventArgs e)
        {
            Nhapcauhoi f = new Nhapcauhoi();
            Hide();
            f.ShowDialog();
        }
    }
}
