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

namespace Quiz_app
{
    public partial class Nhapcauhoi : Form
    {
        DataTable dt = new DataTable();
        public Nhapcauhoi()
        {
            InitializeComponent();
        }
        FirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "PYI5Qluw9k3eFbArSMqczONfhSzBDcRqPUi4pMCV", // mat khau csdl
            BasePath = "https://quiz-app-6c6a3-default-rtdb.firebaseio.com/"

        };
        public int i = 0;

        private async void btnhap_Click(object sender, EventArgs e)
        {
            var dulieu = new Data_DapAn
            {
                cauhoi = richTextBox1.Text,
                DA1 = textBox1.Text,
                DA2 = textBox2.Text,
                DA3 = textBox3.Text,
                DA4 = textBox4.Text,
            };

            if (radioButton1.Checked == true)
            {
                dulieu.DADung = "DA1";
            }
            else
            if (radioButton2.Checked == true)
            {
                dulieu.DADung = "DA2";
            }
            else
            if (radioButton3.Checked == true)
            {
                dulieu.DADung = "DA3";
            }
            else
            if (radioButton4.Checked == true)
            {
                dulieu.DADung = "DA4";
            }
            IFirebaseClient client = new FirebaseClient(config);
            if (Int32.TryParse(tbx_stt.Text, out i))
            {

                string duongdan = $"Cauhoi_DapAn/{txtb_ma_de.Text}/{(i++).ToString()}";
                FirebaseResponse response = await client.UpdateAsync(duongdan, dulieu);
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

                string duongdan1 = $"Cauhoi_DapAn/{txtb_ma_de.Text}/{(i - 1).ToString()}";
                FirebaseResponse response1 = await client.GetAsync(duongdan1);
                Data_DapAn dulnhan = response1.ResultAs<Data_DapAn>();
                var dln = new Data_DapAn()
                {
                    cauhoi = dulieu.cauhoi,
                    DA1 = dulnhan.DA1,
                    DA2 = dulnhan.DA2,
                    DA3 = dulnhan.DA3,
                    DA4 = dulnhan.DA4,
                    DADung = dulnhan.DADung
                };
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

        private async void btxoa_Click(object sender, EventArgs e)
        {
            string duongdan = $"Cauhoi_DapAn/{ txtb_ma_de.Text}/{(--i).ToString()}";
            IFirebaseClient client = new FirebaseClient(config);
            FirebaseResponse response = await client.DeleteAsync(duongdan);
            // Lấy ra dòng hiện tại của DataGridView
            DataGridViewRow row = dg_cauhoi.CurrentRow;

            // Xóa dòng đó
            dg_cauhoi.Rows.Remove(row);

            // Lưu thay đổi
            dg_cauhoi.EndEdit();
            tbx_stt.Text = (i).ToString();
            MessageBox.Show("Xóa thành công");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            // quay ve Form chinh 
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





        //private void button2_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show((++i).ToString());
        //}

    }
}
