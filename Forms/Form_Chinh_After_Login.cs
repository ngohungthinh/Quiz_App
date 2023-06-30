using Google.Cloud.Firestore;
using Login_Signup.Classes;
using Newtonsoft.Json;
using Quiz_app.Classes;
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
        public static string username = "";
        public static UserData userData;
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
            Form_Chinh_After_Login.username = "";
            this.Hide();
            Form_Chinh form_Chinh = new Form_Chinh();
            form_Chinh.ShowDialog();
            this.Close();
        }

        private void button_TaoQuiz_Click(object sender, EventArgs e)
        {
            Form_Tao_Quiz f = new Form_Tao_Quiz();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Chinh_After_Login f = new Form_Chinh_After_Login();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        //-----------------------------------------------------------------------------
        public async void Form_Chinh_After_Login_onLoad(object sender, EventArgs e)
        {
            profileLb.Text = userData.Name;
            byte[] imageBytes = Convert.FromBase64String(userData.Avatar);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                avatarPtb.Image = image.GetThumbnailImage(60, 60, null, IntPtr.Zero);
            }

            //---------------------
            LoadQuizzes(Form_Chinh.Quizzes, Form_Chinh.SoLuongQuizzes);
            //---------------------
        }
        //----------------------------------------------------------------------------------
        private void LoadQuizzes(QuizzData[] quizzes, int n)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < n; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(170, 170);
                pictureBox.Margin = new Padding(20);
                pictureBox.Cursor = Cursors.Hand;

                try
                {
                    // Đọc tệp và gán nội dung vào PictureBox
                    byte[] imageBytes = Convert.FromBase64String(quizzes[i].Image);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBox.Image = image.GetThumbnailImage(170, 170, null, IntPtr.Zero);
                    }

                    Label quizzID = new Label();
                    quizzID.Text = "# Quiz: " + quizzes[i].TenQuiz.ToString();
                    quizzID.BackColor = System.Drawing.Color.AntiqueWhite;
                    quizzID.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y);
                    quizzID.Visible = true;
                    quizzID.Width = 170;
                    quizzID.ForeColor = System.Drawing.Color.Black;
                    quizzID.Font = new Font(quizzID.Font, FontStyle.Bold);
                    quizzID.Height = 20;
                    pictureBox.Controls.Add(quizzID);

                    Label dateTime = new Label();
                    dateTime.Text = quizzes[i].DateTime.ToString();
                    dateTime.BackColor = System.Drawing.Color.AntiqueWhite;
                    dateTime.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y + 20);
                    dateTime.Visible = true;
                    dateTime.Width = 170;
                    dateTime.ForeColor = System.Drawing.Color.Black;
                    dateTime.Font = new Font(dateTime.Font, FontStyle.Bold);
                    dateTime.Height = 20;
                    pictureBox.Controls.Add(dateTime);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
                string quizzid = quizzes[i].ID;

                string tenquizz = quizzes[i].TenQuiz;
                pictureBox.Click += (sender, e) => PictureBox_Click(sender, e, quizzid,tenquizz);

                flowLayoutPanel1.Controls.Add(pictureBox);

            }
        }
        private void PictureBox_Click(object sender, EventArgs e, string quizzID,string tenquizz)
        {
            this.Hide();
            Form_Tra_Loi f = new Form_Tra_Loi(quizzID,tenquizz);
            f.ShowDialog();
            this.Close();
        }
        //----------------------------------------------------------------------------------
        private async void button_TimQuiz_Click(object sender, EventArgs e)
        {
            string searchStr = textBox_SearchQuiz.Text.Trim().ToLower();

            QuizzData[] quizzes_DeLoad = new QuizzData[100];
            int cnt = 0;

            for (int i = 0; i < Form_Chinh.SoLuongQuizzes; i++)
            {
                if (Form_Chinh.Quizzes[i].TenQuiz.ToLower().IndexOf(searchStr) == -1) { continue; }
                quizzes_DeLoad[cnt] = Form_Chinh.Quizzes[i];
                cnt++;
                if (cnt == 100) break;

            }
            LoadQuizzes(quizzes_DeLoad, cnt);
        }  
        //----------------------------------------------------------------------------------
    }
}
