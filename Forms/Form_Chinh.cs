using Google.Cloud.Firestore;
using Google.Type;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            var db = FirestoreHelper.Database;
            if (username != "")
            {
                button_login.Visible = false;
                button_signup.Visible = false;
                profileLb.Text = username;

                // Load profile picture
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
                btn_taodethi.Visible = false;
                avatarPtb.Visible = false;
                showMyQuizBtn.Visible = false;
            }
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
                foreach (KeyValuePair<string, object> r in Rows) {
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
            LoadQuizzes(quizzes, cnt);

        }
        private TableLayoutPanel tableLayoutPanelOuter;
        private TableLayoutPanel tableLayoutPanel1;
        private VScrollBar scrollBar;
        public Form_Chinh()
        {
            InitializeComponent();
            tableLayoutPanelOuter = new TableLayoutPanel();
            tableLayoutPanelOuter.Width = 730;
            tableLayoutPanelOuter.Height = 340;
            tableLayoutPanelOuter.Location = new Point(107, 250);
            Controls.Add(tableLayoutPanelOuter);

            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.Width = 720;
            tableLayoutPanelOuter.Controls.Add(tableLayoutPanel1, 0, 0);

            scrollBar = new VScrollBar();
            scrollBar.Dock = DockStyle.Right;
            scrollBar.Scroll += ScrollBar_Scroll;
            tableLayoutPanelOuter.Controls.Add(scrollBar, 1, 0);

            pictureBoxes = new List<PictureBox>();
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

        private List<PictureBox> pictureBoxes;

        private void LoadQuizzes(QuizzData[] quizzes, int n)
        {
            // Xóa các PictureBox cũ (nếu có)
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                tableLayoutPanel1.Controls.Remove(pictureBox);
                pictureBox.Dispose();
            }
            pictureBoxes.Clear();
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.RowCount = (int)Math.Ceiling((double)n / 4);

            // Tải và hiển thị các hình ảnh
            int columnCount = 4;
            int rowIndex = 0;
            int columnIndex = 0;

            for (int i = 0; i < n; i++)
            {
                if (columnIndex >= columnCount)
                {
                    rowIndex++;
                    columnIndex = 0;
                }

                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Size = new Size(170, 170);
                pictureBox.Margin = new Padding(5);

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
                    quizzID.Text = "#Quiz: " + quizzes[i].TenQuiz.ToString();
                    quizzID.BackColor = System.Drawing.Color.White;
                    quizzID.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y);
                    quizzID.Visible = true;
                    quizzID.Width = 170;
                    quizzID.ForeColor = System.Drawing.Color.Black;
                    quizzID.Font = new Font(quizzID.Font, FontStyle.Bold);
                    quizzID.Height = 30;
                    pictureBox.Controls.Add(quizzID);
                    
                    Label dateTime = new Label();
                    dateTime.Text = "Thời gian tạo: \n" + quizzes[i].DateTime.ToString();
                    dateTime.BackColor = System.Drawing.Color.White;
                    dateTime.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y+30);
                    dateTime.Visible = true;
                    dateTime.Width = 170;
                    dateTime.ForeColor = System.Drawing.Color.Black;
                    dateTime.Font = new Font(dateTime.Font, FontStyle.Bold);
                    dateTime.Height = 30;
                    pictureBox.Controls.Add(dateTime);

                    Label creator = new Label();
                    creator.Text = "Người tạo: \n" + quizzes[i].Creator.ToString();
                    creator.BackColor = System.Drawing.Color.White;
                    creator.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y + 60);
                    creator.Visible = true;
                    creator.Width = 170;
                    creator.Height = 30;
                    creator.ForeColor = System.Drawing.Color.Black;
                    creator.Font = new Font(creator.Font, FontStyle.Bold);
                    pictureBox.Controls.Add(creator);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
                string quizzid = quizzes[i].ID;
                pictureBox.Click += (sender, e) => PictureBox_Click(sender, e, quizzid);
                tableLayoutPanel1.Controls.Add(pictureBox, columnIndex, rowIndex);
                pictureBoxes.Add(pictureBox);

                columnIndex++;
            }
            tableLayoutPanel1.Height = 170 * tableLayoutPanel1.RowCount;
            AdjustScrollBar();
        }
        private void PictureBox_Click(object sender, EventArgs e, string quizzID)
        {
            this.Hide();
            Form_Quest form_Quest = new Form_Quest(int.Parse(quizzID));
            form_Quest.ShowDialog();
            this.Close();
        }
        private void AdjustScrollBar()
        {
            int[] rowHeights = tableLayoutPanel1.GetRowHeights();
            int totalHeight = rowHeights.Sum();
            int visibleHeight = tableLayoutPanelOuter.Height;

            scrollBar.Minimum = 0;
            scrollBar.Maximum = totalHeight - visibleHeight;
            scrollBar.LargeChange = visibleHeight;
            scrollBar.SmallChange = 50;

            tableLayoutPanelOuter.AutoScroll = false;
            tableLayoutPanelOuter.VerticalScroll.Visible = false;

            if (totalHeight > visibleHeight)
            {
                tableLayoutPanelOuter.AutoScroll = true;
                tableLayoutPanelOuter.VerticalScroll.Visible = true;
            }
        }

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            tableLayoutPanelOuter.VerticalScroll.Value = e.NewValue;
        }

        private async void showMyQuizBtn_Click(object sender, EventArgs e)
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
                if (quizz.Creator != username) { continue; }
                quizzes[cnt] = quizz;
                cnt++;
                if (cnt == 100) break; // lay toi da 100 quizzes
            }
            LoadQuizzes(quizzes, cnt);
        }

        private async void search_btn_Click(object sender, EventArgs e)
        {
            string searchStr = search_tb.Text.Trim().ToLower();
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
    }
}
