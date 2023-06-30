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
        private async void Form_Chinh_Load(object sender, EventArgs e)
        {
            var db = FirestoreHelper.Database;
            Query allQuizzQuery = db.Collection("Cauhoi_DAdung");
            QuerySnapshot allQuizzQuerySnapshot = await allQuizzQuery.GetSnapshotAsync();
            QuizzData[] quizzes = new QuizzData[100];
            int cnt = 0;
            foreach (DocumentSnapshot documentSnapshot in allQuizzQuerySnapshot.Documents)
            {
                QuizzData quizz = new QuizzData();
                quizz.ID = documentSnapshot.Id;

                Dictionary<string, object> Rows = documentSnapshot.ToDictionary();

                quizz.Image = "";
                foreach (KeyValuePair<string, object> r in Rows)
                {
                    if (r.Key == "creator")
                    {
                        quizz.Creator = r.Value as string;
                        continue;
                    }
                    if (r.Key == "DateTime")
                    {
                        quizz.DateTime = r.Value as string;
                        continue;
                    }
                    if (r.Key == "TenQuiz")
                    {
                        quizz.TenQuiz = r.Value as string;
                        continue;
                    }
                    if (quizz.Image != "") continue;
                    // Lấy ảnh của câu hỏi đầu tiên làm ảnh thumbnail
                    string str = JsonConvert.SerializeObject(r.Value);
                    Data_DapAn data_dapan = JsonConvert.DeserializeObject<Data_DapAn>(str);
                    quizz.Image = data_dapan.AnhMinhHoa;
                }
                quizzes[cnt] = quizz;
                cnt++;
                if (cnt == 100) break; // lay toi da 100 quizzes
            }
            // Lấy ra 1 loạt các tên_Quiz, Quiz_ID
            //MessageBox.Show(cnt.ToString());
            LoadQuizzes(quizzes, cnt);
        }

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

                pictureBox.Click += (sender, e) => PictureBox_Click(sender, e, quizzid);

                flowLayoutPanel1.Controls.Add(pictureBox);
                
            }
        }

        private async void button_TimQuiz_Click(object sender, EventArgs e)
        {
            string searchStr = textBox_SearchQuiz.Text.Trim().ToLower();
            var db = FirestoreHelper.Database;
            Query allQuizzQuery = db.Collection("Cauhoi_DAdung");
            QuerySnapshot allQuizzQuerySnapshot = await allQuizzQuery.GetSnapshotAsync();
            QuizzData[] quizzes = new QuizzData[100];
            int cnt = 0;
            foreach (DocumentSnapshot documentSnapshot in allQuizzQuerySnapshot.Documents)
            {
                QuizzData quizz = new QuizzData();
                quizz.ID = documentSnapshot.Id;
                Dictionary<string, object> Rows = documentSnapshot.ToDictionary();
                quizz.Image = "";
                foreach (KeyValuePair<string, object> r in Rows)
                {
                    if (r.Key == "creator")
                    {
                        quizz.Creator = r.Value as string;
                        continue;
                    }
                    if (r.Key == "DateTime")
                    {
                        quizz.DateTime = r.Value as string;
                        continue;
                    }
                    if (r.Key == "TenQuiz")
                    {
                        quizz.TenQuiz = r.Value as string;
                        continue;
                    }
                    if (quizz.Image != "") continue;
                    // Lấy ảnh của câu hỏi đầu tiên làm ảnh thumbnail
                    string str = JsonConvert.SerializeObject(r.Value);
                    Data_DapAn data_dapan = JsonConvert.DeserializeObject<Data_DapAn>(str);
                    quizz.Image = data_dapan.AnhMinhHoa;
                }
                if (quizz.TenQuiz.ToLower().IndexOf(searchStr) == -1) { continue; }
                quizzes[cnt] = quizz;
                cnt++;
                if (cnt == 100) break; // lay toi da 100 quizzes
            }
            LoadQuizzes(quizzes, cnt);
        }
        private void PictureBox_Click(object sender, EventArgs e, string quizzID)
        {
            this.Hide();
            Form_Tra_Loi f = new Form_Tra_Loi(quizzID);
            f.ShowDialog();
            this.Close();
        }
    }
}
