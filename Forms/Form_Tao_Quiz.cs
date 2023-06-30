﻿using Google.Cloud.Firestore;
using Login_Signup.Classes;
using Newtonsoft.Json;
using Quiz_app.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_app.Forms
{
    public partial class Form_Tao_Quiz : Form
    {
        string Quiz_ID_current = "";
        int i = 0;
        public Form_Tao_Quiz()
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
        //---------------------------------------------------------------------------
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

        private void avatarPtb_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Profile formProfile = new Form_Profile();
            formProfile.ShowDialog();
            this.Close();
        }
        //------------------------------------------------------------------------------
        private void Form_Tao_Quiz_Load(object sender, EventArgs e)
        {
            //Load User
            UserData userData = Form_Chinh_After_Login.userData;
            profileLb.Text = userData.Name;
            byte[] imageBytes = Convert.FromBase64String(userData.Avatar);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms);
                avatarPtb.Image = image.GetThumbnailImage(60, 60, null, IntPtr.Zero);
            }
        }

        private async void btn_ThemCauHoi_Click(object sender, EventArgs e)
        {
            if ((image_label.Text == ""||(tb_TenQuiz.Text == "" || tb_QuizID.Text == "") || (tb_SoThuTuCau.Text == "" || tb_QuestionContent.Text == "") )  ||  
                ( (radioButton1.Checked == false && radioButton2.Checked == false) && (radioButton3.Checked == false && radioButton4.Checked == false) ) )
            {
                MessageBox.Show("Vui lòng xem lại dữ liệu!!!"); 
            }
            else
            {
                if (Int32.TryParse(tb_SoThuTuCau.Text, out i))
                {
                    string stt = $"Câu {i}";
                    var db = FirestoreHelper.Database;
                    DocumentReference doRef = db.Collection("Cauhoi_DAdung").Document(tb_QuizID.Text);

                    // Lay anh minh hoa va convert ve base64
                    Image image = AnhMinhHoa_Ptb.Image;
                    byte[] imageBytes = File.ReadAllBytes(image_label.Text);
                    string base64String = Convert.ToBase64String(imageBytes);

                    var dulieu = new Dictionary<string, object>
                      {
                        { "Cauhoi", tb_QuestionContent.Text },
                        { "DA1", AnswerContent_A_tb.Text },
                        { "DA2", AnswerContent_B_tb.Text },
                        { "DA3", AnswerContent_C_tb.Text },
                        { "DA4", AnswerContent_D_tb.Text },
                        {"DAdung",  Checkdapan()},
                        {"AnhMinhHoa", base64String }
                          // Các trường khác tùy ý
                      };

                    var datagui = new Dictionary<string, object>
                     {
                             { stt, dulieu },
                            { "creator", Form_Chinh_After_Login.username },
                        { "DateTime", DateTime.Now.ToString() },
                        {"TenQuiz", tb_TenQuiz.Text },

                     };

                    // Nếu table rỗng hoặc 2 Quiz_ID khác nhau thì sẽ update câu hỏi và load table.
                    if(dg_cauhoi.Rows.Count == 0 || Quiz_ID_current != tb_QuizID.Text)
                    {
                        //Kiểm tra xem Quiz_ID phải của mình không?
                        DocumentSnapshot snapshot = await doRef.GetSnapshotAsync();
                        if (snapshot.Exists)
                        {
                            Dictionary<string, object> data = snapshot.ToDictionary();
                            string usernameO = Form_Chinh_After_Login.username;

                            // Nếu "creator" không mang giá trị username
                            if (data["creator"].ToString() !=  usernameO)
                            {
                                MessageBox.Show("Quiz ID đã tồn tại và không thuộc sơ hữu của bạn. Vui lòng chọn lại Quiz ID");
                                return;
                            }    
                        }
                        else
                        {
                            Quiz_ID_current = tb_QuizID.Text;
                            AddRowTable(stt, tb_QuestionContent.Text, AnswerContent_A_tb.Text, AnswerContent_B_tb.Text,
                                    AnswerContent_C_tb.Text, AnswerContent_D_tb.Text, Checkdapan());
                            GonNhe();
                            await doRef.SetAsync(datagui);
                            return;
                        }    

                        Quiz_ID_current = tb_QuizID.Text;
                        await doRef.UpdateAsync(datagui);
                        UpdateTable();
                        GonNhe();
                        return;
                    }

                    // Xuống được dòng dưới thì Quiz_ID đã giống nhau nên ta chỉ còn thêm, update câu hỏi

                    if (CheckCauHoiTrongTable() == -1)
                    {
                        AddRowTable(stt, tb_QuestionContent.Text, AnswerContent_A_tb.Text, AnswerContent_B_tb.Text,
                                    AnswerContent_C_tb.Text, AnswerContent_D_tb.Text, Checkdapan());
                    }
                    else
                    {
                        
                        int index = CheckCauHoiTrongTable();
                        
                        dg_cauhoi.Rows.RemoveAt(index);
                        AddRowTable(stt, tb_QuestionContent.Text, AnswerContent_A_tb.Text, AnswerContent_B_tb.Text,
                                    AnswerContent_C_tb.Text, AnswerContent_D_tb.Text, Checkdapan());
                    }

                    GonNhe();

                    await doRef.UpdateAsync(datagui);

                    MessageBox.Show("Thanh cong");
                }
            }
        }
        async void UpdateTable()
        {
            DocumentReference doRef = FirestoreHelper.Database.Collection("Cauhoi_DAdung").Document(tb_QuizID.Text);
            DocumentSnapshot snapshot = await doRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                dg_cauhoi.Rows.Clear();
                Dictionary<string, object> data = snapshot.ToDictionary();
                foreach (KeyValuePair<string, object> r in data)
                {
                    if (r.Key == "creator" || r.Key == "DateTime" || r.Key == "TenQuiz") continue;

                    string str = JsonConvert.SerializeObject(r.Value);// Chuyển Value sang string byte .Net
                    Data_DapAn data_dapan = JsonConvert.DeserializeObject<Data_DapAn>(str);

                    AddRowTable(r.Key, data_dapan.Cauhoi, data_dapan.DA1, data_dapan.DA2, data_dapan.DA3, data_dapan.DA4, data_dapan.DADung);
                }
            }
        }

        void AddRowTable(string sttCau,string Cauhoi,string DA1,string DA2,string DA3,string DA4,string DADung)
        {
            dg_cauhoi.Rows.Add(sttCau, Cauhoi, DA1, DA2, DA3, DA4,DADung);
        }

        public string Checkdapan()
        {
            if (radioButton1.Checked == true)
            {
                return "DA1";
            }
            else
                if (radioButton2.Checked == true)
            {
                return "DA2";
            }
            else
                if (radioButton3.Checked == true)
            {
                return "DA3";
            }
            else
                if (radioButton4.Checked == true)
            {
                return "DA4";
            }
            return "0";
        }
        int CheckCauHoiTrongTable()
        {
            foreach (DataGridViewRow row in dg_cauhoi.Rows)
            {
                if(row.Cells[0].Value != null && row.Cells[0].Value.ToString() == $"Câu {tb_SoThuTuCau.Text}")
                {
                    return row.Index;
                }    
            }
            return -1;
        }
        void GonNhe()
        {
            tb_QuestionContent.Text = "";

            AnswerContent_A_tb.Text = "";
            AnswerContent_B_tb.Text = "";
            AnswerContent_C_tb.Text = "";
            AnswerContent_D_tb.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            tb_SoThuTuCau.Text = (i + 1).ToString();
        }
        //------------------------------------------------------------------------------------
        private async void btn_XoaCauHoi_Click(object sender, EventArgs e)
        {
            if(dg_cauhoi.SelectedRows !=  null )
            {
                string SoThuTuCau = dg_cauhoi.SelectedRows[0].Cells[0].Value.ToString();

                DocumentReference doRef = FirestoreHelper.Database.Collection("Cauhoi_DAdung").Document(tb_QuizID.Text);
                Dictionary<string, object> data = new Dictionary<string, object>()
                {
                    {SoThuTuCau,FieldValue.Delete }
                };
                dg_cauhoi.Rows.RemoveAt(this.dg_cauhoi.SelectedRows[0].Index);
                await doRef.UpdateAsync(data);
            }
        }

        private void btn_TaiAnhMinhHoa_Click(object sender, EventArgs e)
        {
            OpenFileDialog avatar = new OpenFileDialog();
            avatar.Title = "Select image";
            avatar.Filter = "Image Files(*.jpg) | *.jpg";

            if (avatar.ShowDialog() == DialogResult.OK)
            {
                image_label.Text = avatar.FileName;
            }
            if (System.IO.File.Exists(image_label.Text))
            {
                Image image = Image.FromFile(image_label.Text);
                Image thumbnail = image.GetThumbnailImage(187, 148, null, IntPtr.Zero);

                AnhMinhHoa_Ptb.Image = thumbnail;

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Hide();
            Form_Chinh_After_Login f = new Form_Chinh_After_Login();
            f.ShowDialog();
            this.Close();
        }
    }
}
