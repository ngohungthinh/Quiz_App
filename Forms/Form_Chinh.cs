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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_app.Forms
{
    public partial class Form_Chinh : Form
    {
        public static Dictionary<string, Data_DapAn[]> Question = new Dictionary<string, Data_DapAn[]>();
        public static Dictionary<string, int> SLCauHoi = new Dictionary<string, int>();

        public static QuizzData[] Quizzes = new QuizzData[100];
        public static int SoLuongQuizzes = 0;
        public static bool isLoadQuizData = false;
        public Form_Chinh()
        {
            InitializeComponent();    
        }
        public static async Task Update_QuizzData()
        {
            while (true)
            {
                await Task.Delay(10000);// 10 giây update 1 lần.
                
                int SoLuong = 0;
                
                var db = FirestoreHelper.Database;
                Query allQuizzQuery = db.Collection("Cauhoi_DAdung");
                
                QuerySnapshot allQuizzQuerySnapshot = await allQuizzQuery.GetSnapshotAsync();
                
                //QuizzData[] quizzes = new QuizzData[100];
                foreach (DocumentSnapshot documentSnapshot in allQuizzQuerySnapshot.Documents)
                {
                    Data_DapAn[] question = new Data_DapAn[100];
                    int i = 0;

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
                       
                        //---------
                        string str = JsonConvert.SerializeObject(r.Value);
                        Data_DapAn data_dapan = JsonConvert.DeserializeObject<Data_DapAn>(str);
                        //---------
                        question[i] = data_dapan;
                        i++;
                        //---------
                        
                        if (quizz.Image != "") continue;
                        // Lấy ảnh của câu hỏi đầu tiên làm ảnh thumbnail
                        quizz.Image = data_dapan.AnhMinhHoa;
                    }

                    Question[quizz.ID] = question;
                    SLCauHoi[quizz.ID] = i;

                    Quizzes[SoLuong] = quizz;
                    SoLuong++;
                    if (SoLuong == 100) break; // lay toi da 100 quizzes
                }
                //MessageBox.Show("So lương" + SoLuong.ToString());
                SoLuongQuizzes = SoLuong;
            }
            
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
            flowLayoutPanel1.Controls.Clear();
            if (isLoadQuizData == false)
            {
                var db = FirestoreHelper.Database;
                Query allQuizzQuery = db.Collection("Cauhoi_DAdung");
                QuerySnapshot allQuizzQuerySnapshot = await allQuizzQuery.GetSnapshotAsync();
                //QuizzData[] quizzes = new QuizzData[100];
                foreach (DocumentSnapshot documentSnapshot in allQuizzQuerySnapshot.Documents)
                {
                    Data_DapAn[] question = new Data_DapAn[100];
                    int i = 0;

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

                        //---------
                        string str = JsonConvert.SerializeObject(r.Value);
                        Data_DapAn data_dapan = JsonConvert.DeserializeObject<Data_DapAn>(str);

                        //---------
                        question[i] = data_dapan;
                        i++;
                        //---------

                        if (quizz.Image != "") continue;
                        // Lấy ảnh của câu hỏi đầu tiên làm ảnh thumbnail
                        quizz.Image = data_dapan.AnhMinhHoa;
                    }


                    Question[quizz.ID] = question;
                    SLCauHoi[quizz.ID] = i;


                    Quizzes[SoLuongQuizzes] = quizz;
                    SoLuongQuizzes++;
                    if (SoLuongQuizzes == 100) break; // lay toi da 100 quizzes
                }
                //--------------------------
                //Quan trọng
                isLoadQuizData = true;
                Update_QuizzData();
                //--------------------------
            }    
            LoadQuizzes(Quizzes, SoLuongQuizzes);
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
                string tenquizz = quizzes[i].TenQuiz;

                pictureBox.Click += (sender, e) => PictureBox_Click(sender, e, quizzid, tenquizz);

                flowLayoutPanel1.Controls.Add(pictureBox);
                
            }
        }

        private async void button_TimQuiz_Click(object sender, EventArgs e)
        {
            string searchStr = textBox_SearchQuiz.Text.Trim().ToLower();

            QuizzData[] quizzes_DeLoad = new QuizzData[100];
            int cnt = 0;

            for(int i = 0; i< Form_Chinh.SoLuongQuizzes; i++ )
            {
                if (Form_Chinh.Quizzes[i].TenQuiz.ToLower().IndexOf(searchStr) == -1) { continue; }
                quizzes_DeLoad[cnt] = Form_Chinh.Quizzes[i];
                cnt++;
                if (cnt == 100) break;

            }    
            LoadQuizzes(quizzes_DeLoad, cnt);
        }
        private void PictureBox_Click(object sender, EventArgs e, string quizzID,string tenquizz)
        {
            this.Hide();
            Form_Tra_Loi f = new Form_Tra_Loi(quizzID,tenquizz);
            f.ShowDialog();
            this.Close();
        }
    }
}
