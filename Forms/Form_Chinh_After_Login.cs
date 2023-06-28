using Google.Cloud.Firestore;
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
    public partial class Form_Chinh_After_Login : Form
    {
        public static string username { get; set; }
        public Form_Chinh_After_Login()
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
        //-------------------------------------------------------------------------
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
        private void avatarPtb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Profile formProfile = new Form_Profile();
            formProfile.ShowDialog();
            this.Close();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Chinh form_Chinh = new Form_Chinh();
            form_Chinh.ShowDialog();
            this.Close();
        }
        //-----------------------------------------------------------------------------
        public async void Form_Chinh_After_Login_onLoad(object sender, EventArgs e)
        {
            var db = FirestoreHelper.Database;
            // Load User
            DocumentReference docRef = db.Collection("UserData").Document(username);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            UserData userData = null;
            if (snapshot.Exists)
            {
                userData = snapshot.ConvertTo<UserData>();
            }
            profileLb.Text = userData.Name;
            byte[] imageBytes = Convert.FromBase64String(userData.Avatar);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                avatarPtb.Image = image.GetThumbnailImage(60, 60, null, IntPtr.Zero);
            }
        }
    }
}
