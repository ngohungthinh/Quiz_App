using Google.Cloud.Firestore;
using Login_Signup.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_app.Forms
{
    public partial class Quenmatkhau : Form
    {
        public Quenmatkhau()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login f = new Form_Login();
            f.ShowDialog();
            this.Close();
        }

        private void btn_LayPass_Click(object sender, EventArgs e)
        {
            var db = FirestoreHelper.Database;
            string email = textBox1.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng kí!"); 
            }
            else
            {
                //truy vấn dữ liệu từ firestore
                if(/*nếu pass đúng*/)
                {
                    label3.ForeColor = Color.Blue;
                    label3.Text = "Mật khẩu: ";
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Email này chưa được đăng ký!";
                }    
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
