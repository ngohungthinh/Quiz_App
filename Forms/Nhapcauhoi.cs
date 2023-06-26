using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Quiz_app.Classes;
using Login_Signup.Classes;
using Quiz_app.Forms;
using Google.Cloud.Firestore;
namespace Quiz_app
{
    public partial class Nhapcauhoi : Form
    {
        DataTable dt = new DataTable();
        public Nhapcauhoi()
        {
            InitializeComponent();
        }
        public int i = 0;

        private async void btnhap_Click(object sender, EventArgs e)
        {
           
            if ((richTextBox1.Text == null || textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null) &&
                (!(radioButton1.Checked) && !(radioButton2.Checked) && !(radioButton3.Checked) && !(radioButton4.Checked)))
            { MessageBox.Show("Vui long nhap du lieu"); }
            else
            {
              
           //     DocumentReference doRef = db.Collection("Cauhoi_DAdung").Document(txtb_ma_de.Text);
                //string stt = $"Cau {i}";
                //CreateCollection(txtb_ma_de.Text, stt)

                
             
           //     IFirebaseClient client = new FirebaseClient(config);
                if (Int32.TryParse(tbx_stt.Text, out i))
                {
                    string stt = $"Câu {i}";
                    var db = FirestoreHelper.Database;
                    DocumentReference doRef = db.Collection("Cauhoi_DAdung").Document(txtb_ma_de.Text);
                    //       string duongdan = $"Cauhoi_DapAn/{txtb_ma_de.Text}/{(i++).ToString()}";
                    //       FirebaseResponse response = await client.UpdateAsync(duongdan, dulieu);
                    var dulieu = new Dictionary<string, object>
                      {
                        { "Cauhoi", richTextBox1.Text },
                        { "DA1", textBox1.Text },
                        { "DA2", textBox2.Text },
                        { "DA3", textBox3.Text },
                        { "DA4", textBox4.Text },
                        {"DAdung",  Checkdapan()}
                          // Các trường khác tùy ý
                      };

                    var datagui = new Dictionary<string, object>
                     {
                             { stt, dulieu },
                     };

                    doRef.SetAsync(datagui);
                    MessageBox.Show("Thanh cong");
                    richTextBox1.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    // Lấy tất cả các nút radio trong nhóm lựa chọn
                    RadioButton[] radioButtons = groupBox1.Controls.OfType<RadioButton>().ToArray();

                    // Duyệt qua tất cả các nút radio và đặt giá trị Checked của mỗi nút radio bằng false
                    foreach (RadioButton radioButton in radioButtons)
                    {
                        radioButton.Checked = false;
                    }


                    var dln = new Data_DapAn();
                    DocumentSnapshot snapshot = await doRef.GetSnapshotAsync();
                 
                    //UserData dulnhan = doRef.GetSnapshotAsync().Result.ConvertTo<UserData>();//class trong Classes


                    DataRow row = dt.NewRow();
                    row["stt"] = i - 1;
                    row["cauhoi"] = dln.cauhoi;
                    row["DA1"] = dln.DA1;
                    row["DA2"] = dln.DA2;
                    row["DA3"] = dln.DA3;
                    row["DA4"] = dln.DA4;
                    row["DAdung"] = dln.DADung;
                    dt.Rows.Add(row);
                    tbx_stt.Text = (i).ToString();
                }
            }
        }

        //private async void btxoa_Click(object sender, EventArgs e)
        //{
        //    //string duongdan = $"Cauhoi_DapAn/{ txtb_ma_de.Text}/{(--i).ToString()}";
        //    //IFirebaseClient client = new FirebaseClient(config);
        //    //FirebaseResponse response = await client.DeleteAsync(duongdan);
        //    // Lấy ra dòng hiện tại của DataGridView
        //    FirestoreDb db = FirestoreDb.Create("member-a1176");
        //    CollectionReference collectionRef = db.Collection("Cauhoi_DAdung").Document(txtb_ma_de.Text);
        //    QuerySnapshot snapshot = collectionRef.GetSnapshotAsync().Result;

        //    foreach (DocumentSnapshot document in snapshot.Documents)
        //    {
        //        document.Reference.DeleteAsync();
        //    }

        //    DataGridViewRow row = dg_cauhoi.CurrentRow;

        //    // Xóa dòng đó
        //    dg_cauhoi.Rows.Remove(row);

        //    // Lưu thay đổi
        //    dg_cauhoi.EndEdit();
        //    tbx_stt.Text = (i).ToString();
        //    MessageBox.Show("Xóa thành công");
        //}

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Form_Chinh f = new Form_Chinh();
            this.Close();
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("stt");
            dt.Columns.Add("cauhoi");
            dt.Columns.Add("DA1");
            dt.Columns.Add("DA2");
            dt.Columns.Add("DA3");
            dt.Columns.Add("DA4");
            dt.Columns.Add("Dadung");


            dg_cauhoi.DataSource = dt;

            dg_cauhoi.Columns[0].HeaderText = "Stt";
            dg_cauhoi.Columns[1].HeaderText = "Câu hỏi";
            dg_cauhoi.Columns[6].HeaderText = "Đáp án đúng";

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

        private void dg_cauhoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show((++i).ToString());
        //}

    }
}
