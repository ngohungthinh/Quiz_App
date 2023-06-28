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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quiz_app.Forms
{
    public partial class Form_Profile : Form
    {
        public Form_Profile()
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
        private void label_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //--------------------------------------------------------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Chinh_After_Login f = new Form_Chinh_After_Login();
            f.ShowDialog();
            this.Close();
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Chinh form_Chinh = new Form_Chinh();
            form_Chinh.ShowDialog();
            this.Close();
        }
        //---------------------------------------------------------------------------
        public async void Form_Profile_onLoad(object sender, EventArgs e)
        {
            // Load User
            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(Form_Chinh_After_Login.username);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            UserData userData = null;
            if (snapshot.Exists)
            {
                userData = snapshot.ConvertTo<UserData>();
            }
            
            byte[] imageBytes = Convert.FromBase64String(userData.Avatar);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                avatarPtb.Image = image.GetThumbnailImage(60, 60, null, IntPtr.Zero);
                avatarValuePtb.Image = image.GetThumbnailImage(100, 100, null, IntPtr.Zero);
            }
            hoTenValueLb.Text = userData.Name;
            emailValueLb.Text = userData.Email;

            profileLb.Text = userData.Name;

        }
    }
}
