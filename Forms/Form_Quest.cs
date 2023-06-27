using Google.Cloud.Firestore;
using Login_Signup.Classes;
using Newtonsoft.Json;
using Quiz_app.Classes;
using Quiz_app.Forms;
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

namespace Quiz_app
{
    public partial class Form_Quest : Form
    {
        private int quizz_id;
        private Data_DapAn[] questions = new Data_DapAn[100];
        private int cnt = 0;
        private int numOfCorrectness = 0;
        private bool checkAns(string dapAn)
        {
            if (dapAn == "DA1" && Ansa_cb.Checked && !Ansb_cb.Checked && !Ansc_cb.Checked && !Ansd_cb.Checked) { return true; }
            if (dapAn == "DA2" && !Ansa_cb.Checked && Ansb_cb.Checked && !Ansc_cb.Checked && !Ansd_cb.Checked) { return true; }
            if (dapAn == "DA3" && !Ansa_cb.Checked && !Ansb_cb.Checked && Ansc_cb.Checked && !Ansd_cb.Checked) { return true; }
            if (dapAn == "DA4" && !Ansa_cb.Checked && !Ansb_cb.Checked && !Ansc_cb.Checked && Ansd_cb.Checked) { return true; }
            return false;
        }
        private void showQuestion(int id)
        {

            question_lb.Text = questions[id].Cauhoi;
            Ansa_cb.Text = questions[id].DA1;
            Ansb_cb.Text = questions[id].DA2;
            Ansc_cb.Text = questions[id].DA3;
            Ansd_cb.Text = questions[id].DA4;
            byte[] imageBytes = Convert.FromBase64String(questions[id].AnhMinhHoa);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                Image_ptb.Image = image.GetThumbnailImage(187, 148, null, IntPtr.Zero);
            }
        }
        private async void Form_Quest_onLoad(object sender, EventArgs e)
        {
            quizz_id_tb.Text = quizz_id.ToString();
            var db = FirestoreHelper.Database;
            DocumentReference doRef = db.Collection("Cauhoi_DAdung").Document(quizz_id.ToString());
            DocumentSnapshot snapshot = await doRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                Dictionary<string, object> data = snapshot.ToDictionary();
                foreach (KeyValuePair<string, object> r in data)
                {
                    if (r.Key == "creator" || r.Key == "DateTime") continue;
                    string str = JsonConvert.SerializeObject(r.Value);
                    Data_DapAn data_dapan = JsonConvert.DeserializeObject<Data_DapAn>(str);
                    questions[cnt] = data_dapan;
                    cnt++;
                }
            }
            else
            {
                MessageBox.Show("Khong ton tai!");
            }

            showQuestion(0);
        }
        public Form_Quest(int quiz_id)
        {
            InitializeComponent();
            quizz_id = quiz_id;
            this.Load += Form_Quest_onLoad;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private string convertToABCD(string ans)
        {
            if (ans == "DA1") return "A";
            if (ans == "DA2") return "B";
            if (ans == "DA3") return "C";
            if (ans == "DA4") return "D";
            return "";
        }
        private void next_btn_Click(object sender, EventArgs e)
        {
            int quesID = int.Parse(question_value_lb.Text.ToString().Trim()) - 1;
            if (quesID + 1 == cnt)
            {
                MessageBox.Show("Bạn đã hoàn thành bài thi!\nSố câu đúng: " + numOfCorrectness.ToString() + "/" + cnt.ToString() + "\nĐiểm: " + (10 * ((float) numOfCorrectness / (float) cnt)).ToString());
                return;
            }
            if (checkAns(questions[quesID].DADung))
            {
                numOfCorrectness++;
                MessageBox.Show("Chính xác!");
            } else
            {
                MessageBox.Show("Sai rồi! Đáp án là " + convertToABCD(questions[quesID].DADung));
            }
            question_value_lb.Text = (quesID + 2).ToString();
            Ansa_cb.Checked = false; Ansb_cb.Checked = false; Ansc_cb.Checked = false; Ansd_cb.Checked = false;
            showQuestion(quesID + 1);
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Chinh form_Chinh = new Form_Chinh();
            form_Chinh.ShowDialog();
            this.Close();
        }
    }
}
