using Google.Cloud.Firestore;
using Login_Signup.Classes;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading.Tasks;
namespace Quiz_app.Forms
{

    
    public partial class Form_QuenMatKhau : Form
    {
        public Form_QuenMatKhau()
        {
            InitializeComponent();
        }
        public void CloseForm()
        {
            this.Close();
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
        //-----------------------------------------------------------------------------------
        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login f = new Form_Login();
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
        //----------------------------------------------------------


        private async void button_LayLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            bool isEmailValid = Regex.IsMatch(email, @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");

            if (!isEmailValid)
            {
                lb_thongbao.Text = "Sai định dạng email. Vui lòng nhập lại địa chỉ email!";
            }
            else
            {
                // Kiểm tra sự tồn tại của tài khoản trong một luồng riêng biệt
                bool accountExists = await Task.Run(() => CheckAccountExists(email));

                if (accountExists)
                {
                   
                    button_LayLaiMatKhau.Visible = false;
                    btn_quaylai.Visible = true;
                    lb_thongbao.Text = "";
                    btn_xacnhan.Visible = true;
                    lb_quaylai.Visible = true;
                    txt_nhapOTP.Visible = true;
                    lb_thongbao.Text = "VUI LONG NHAP OTP";
                    MessageBox.Show("Đã gửi OTP");
                    lb_demnguoc.Visible = true;
                    TaoVaGuiOTP();
                    timer1.Start();
                   
                    
                }
                else
                {
                    lb_thongbao.Text = "Tài khoản không tồn tại!";
                }
            }
        }

        private bool CheckAccountExists(string email)
        {
            DocumentReference doc = FirestoreHelper.Database.Collection("UserData").Document(email);
            DocumentSnapshot snap = doc.GetSnapshotAsync().GetAwaiter().GetResult();
            return snap.Exists;
        }
        int randomNumber;
        private void TaoVaGuiOTP()
        {
            Random random = new Random();
            randomNumber = random.Next(100000, 999999);
            var server = new SmtpClient();
            server.Connect("smtp.gmail.com", 465, true); // ket noi den smtp mail
            server.Authenticate("OhMyQuizApp@gmail.com", "yoyczshxtbpjejfh");
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("OhMyQuizApp", "OhMyQuizApp@gmail.com"));
            message.To.Add(new MailboxAddress("", textBoxEmail.Text.Trim()));
            message.Subject = "Ma OTP lay lai mat khau";
            message.Body = new TextPart("plain")
            {
                Text = $"Mã xác thực OTP của bạn là: {randomNumber}. \n Vui lòng không cung cấp mã này cho bất kì ai !"
            };

            server.Send(message);
        }

        private void Form_QuenMatKhau_Load(object sender, EventArgs e)
        {
            quaylaibandau();
        }
        int i = 60;

        private void timer1_Tick(object sender, EventArgs e)
        {

            i--;
            if (i >= 0)
            {
                int minutes = i / 60;
                int seconds = i % 60;
                lb_demnguoc.Text = $"{minutes}:{seconds:D2}"; // D2 dinh dang so dang xx
            }
            else
            {
                // Đếm ngược đã kết thúc
                lb_demnguoc.Text = "0:00";
                timer1.Stop();
                lb_thongbao.Text = "Het thoi gian nhap OTP";
                lb_demnguoc.Visible = false;
                txt_nhapOTP.Visible = false;
                btn_xacnhan.Visible = false;
                button_LayLaiMatKhau.Visible = true;
                i = 60;
            }

        }

        private async void btn_xacnhan_Click(object sender, EventArgs e)
        {
            
            if (KiemtraOTP(txt_nhapOTP.Text))
            {
                DocumentReference doc = FirestoreHelper.Database.Collection("UserData").Document(textBoxEmail.Text);
                DocumentSnapshot snap = await doc.GetSnapshotAsync();
                UserData data = snap.ConvertTo<UserData>();
                //// Form_Newpass f = new Form_Newpass(textBoxEmail.Text.Trim());
                // f.Show();
                // this.Hide();
                
                newpass();
                


            }
            else
            {
                lb_thongbao.Text = "Sai ma OTP. Vui long xem lai !";
            }

        }
        private bool KiemtraOTP(string OTP)
        {
            if (OTP == (randomNumber).ToString())
                return true;
            return false;

        }
        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            quaylaibandau();
        }
        private void quaylaibandau()
        {
            lb_quaylai.Visible = false;
            lb_thongbao.Text = "";
            txt_nhapOTP.Visible = false;
            textBoxEmail.Text = "";
            lb_demnguoc.Visible = false;
            btn_quaylai.Visible = false;
            btn_xacnhan.Visible = false;
            button_LayLaiMatKhau.Visible = true;
            panelcha.Visible = false;
        }
        private Form formchild;
        private void newpass()
        {
            Form_Newpass f1 = new Form_Newpass(textBoxEmail.Text);

            if (formchild != null)
            {
                formchild.Close();
            }
            formchild = f1;
            formchild.TopLevel = false;
            f1.FormBorderStyle = FormBorderStyle.None;
            f1.Dock = DockStyle.Fill;
            panelcha.Visible = true;
            panelcha.Controls.Add(f1);
            panelcha.Tag = f1;
            f1.BringToFront();
            f1.Show();
            lb_quaylai.Visible = false;
            btn_quaylai.Visible = false;
        }
        
        
    }        
}
