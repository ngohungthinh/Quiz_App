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
    public partial class Form_Tra_Loi : Form
    {
        private string quizz_id,ten_quizz;
        private Data_DapAn[] questions;
        private int SoCauHoi = 0;
        private int Stt_Current = 0;
        private int numOfCorrectness = 0;
        public Form_Tra_Loi(string quiz_id,string tenquizz)
        {
            InitializeComponent();
            quizz_id = quiz_id;
            ten_quizz = tenquizz;
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
        //---------------------------------------------------------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(Form_Chinh_After_Login.username == "")
            {
                Form_Chinh f = new Form_Chinh();
                f.ShowDialog();
            }    
            else
            {
                Form_Chinh_After_Login f = new Form_Chinh_After_Login();
                f.ShowDialog();
            }    
            this.Close();
        }
        //-----------------------------------------------------------------------------
        
        private async void Form_Tra_Loi_Load(object sender, EventArgs e)
        {
            lb_QuizID.Text ="Quiz ID: " + quizz_id;
            lb_TenQuiz.Text = "Quiz: " + ten_quizz;

            questions = Form_Chinh.Question[quizz_id];
            SoCauHoi = Form_Chinh.SLCauHoi[quizz_id];

            showQuestion(0);
        }
        private void btn_NextQuestion_Click(object sender, EventArgs e)
        {
            if (checkAns(questions[Stt_Current].DADung))
            {
                numOfCorrectness++;
                MessageBox.Show("Chính xác!");
            }
            else
            {
                MessageBox.Show("Sai rồi! Đáp án là " + convertToABCD(questions[Stt_Current].DADung));
            }


            Stt_Current += 1;
            if (Stt_Current == SoCauHoi)
            {
                MessageBox.Show("Bạn đã hoàn thành bài thi!\nSố câu đúng: " + numOfCorrectness.ToString() + "/" + SoCauHoi.ToString() + "\nĐiểm: " + (10 * ((float)numOfCorrectness / (float)SoCauHoi)).ToString());
                return;
            }

            lb_SoThuTuCau.Text = $"#Câu {Stt_Current + 1}";
            Ansa_cb.Checked = false; Ansb_cb.Checked = false; Ansc_cb.Checked = false; Ansd_cb.Checked = false;
            showQuestion(Stt_Current);
        }
        private void showQuestion(int id)
        {
            tb_question.Text = questions[id].Cauhoi;
            lb_A.Text = questions[id].DA1;
            lb_B.Text = questions[id].DA2;
            lb_C.Text = questions[id].DA3;
            lb_D.Text = questions[id].DA4;
            byte[] imageBytes = Convert.FromBase64String(questions[id].AnhMinhHoa);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                ptb_AnhMinhHoa.Image = image.GetThumbnailImage(187, 148, null, IntPtr.Zero);
            }
        }

        private bool checkAns(string dapAn)
        {
            if ( (dapAn == "DA1" && Ansa_cb.Checked) && ((!Ansb_cb.Checked && !Ansc_cb.Checked) && !Ansd_cb.Checked)) { return true; }
            if ( (dapAn == "DA2" && !Ansa_cb.Checked) && ((Ansb_cb.Checked && !Ansc_cb.Checked) && !Ansd_cb.Checked)) { return true; }
            if ( (dapAn == "DA3" && !Ansa_cb.Checked) && ((!Ansb_cb.Checked && Ansc_cb.Checked) && !Ansd_cb.Checked)) { return true; }
            if ( (dapAn == "DA4" && !Ansa_cb.Checked) && ((!Ansb_cb.Checked && !Ansc_cb.Checked) && Ansd_cb.Checked)) { return true; }
            return false;
        }
        private string convertToABCD(string ans)
        {
            if (ans == "DA1") return "A";
            if (ans == "DA2") return "B";
            if (ans == "DA3") return "C";
            if (ans == "DA4") return "D";
            return "";
        }
    }
}
