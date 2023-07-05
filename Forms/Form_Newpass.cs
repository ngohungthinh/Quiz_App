using Google.Cloud.Firestore;
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
    public partial class Form_Newpass : Form
    {
        string mail;

        public Form_Newpass()
        {
            InitializeComponent();
        }
        public Form_Newpass(string mail)
        {
            InitializeComponent();
            this.mail = mail;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private Form_QuenMatKhau formQuenMatKhau;

        public void SetFormQuenMatKhau(Form_QuenMatKhau form)
        {
            formQuenMatKhau = form;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            DocumentReference docRef = FirestoreHelper.Database.Collection("UserData").Document(mail);
            var data = new Dictionary<string, object>()
            {
                { "Password",Security.Encrypt(textBox1.Text.Trim()) }
            };
            await docRef.UpdateAsync(data);
            MessageBox.Show("Thanh cong");
            Form_QuenMatKhau f = new Form_QuenMatKhau();
            f.CloseForm();
            Form_Login f1 = new  Form_Login();
            f1.Show();
        }
    }
}
