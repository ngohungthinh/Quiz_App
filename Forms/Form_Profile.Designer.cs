
namespace Quiz_app.Forms
{
    partial class Form_Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_Nhap_sai = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.hoTenLb = new System.Windows.Forms.Label();
            this.emailLb = new System.Windows.Forms.Label();
            this.avatarLb = new System.Windows.Forms.Label();
            this.hoTenValueLb = new System.Windows.Forms.Label();
            this.emailValueLb = new System.Windows.Forms.Label();
            this.avatarValuePtb = new System.Windows.Forms.PictureBox();
            this.button_signup = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.profileLb = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.avatarPtb = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarValuePtb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPtb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_Close);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1157, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1102, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "_";
            // 
            // label_Close
            // 
            this.label_Close.AutoSize = true;
            this.label_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Close.Location = new System.Drawing.Point(1129, 3);
            this.label_Close.Name = "label_Close";
            this.label_Close.Size = new System.Drawing.Size(31, 29);
            this.label_Close.TabIndex = 3;
            this.label_Close.Text = "X";
            this.label_Close.Click += new System.EventHandler(this.label_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Quiz_app.Properties.Resources.Q2;
            this.pictureBox1.Location = new System.Drawing.Point(15, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(77, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oh My Quiz!";
            this.label1.Click += new System.EventHandler(this.pictureBox1_Click);
            //
            // panel2
            //
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.avatarPtb);
            this.panel2.Controls.Add(this.profileLb);
            this.panel2.Controls.Add(this.button_logout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button_signup);
            this.panel2.Controls.Add(this.button_login);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 72);
            this.panel2.TabIndex = 1;

            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1157, 1);
            this.panel3.TabIndex = 2;
            // 
            // profileLb
            // 
            this.profileLb.AutoSize = true;
            this.profileLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLb.ForeColor = System.Drawing.Color.White;
            this.profileLb.Location = new System.Drawing.Point(835, 17);
            this.profileLb.Name = "profileLb";
            this.profileLb.Size = new System.Drawing.Size(61, 22);
            this.profileLb.TabIndex = 8;
            this.profileLb.Text = "Profile";
            this.profileLb.Click += new System.EventHandler(this.profileLb_Click);
            // 
            // avatarPtb
            // 
            this.avatarPtb.Location = new System.Drawing.Point(760, 6);
            this.avatarPtb.Name = "avatarPtb";
            this.avatarPtb.Size = new System.Drawing.Size(60, 60);
            this.avatarPtb.TabIndex = 9;
            this.avatarPtb.TabStop = false;
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(1054, 17);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 35);
            this.button_logout.TabIndex = 7;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(1156, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 703);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 703);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 731);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1157, 1);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(0, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1157, 1);
            this.panel7.TabIndex = 6;
            // 
            // label_Nhap_sai
            // 
            this.label_Nhap_sai.AutoSize = true;
            this.label_Nhap_sai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Nhap_sai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nhap_sai.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Nhap_sai.Location = new System.Drawing.Point(404, 638);
            this.label_Nhap_sai.Name = "label_Nhap_sai";
            this.label_Nhap_sai.Size = new System.Drawing.Size(0, 36);
            this.label_Nhap_sai.TabIndex = 39;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel8.Controls.Add(this.avatarValuePtb);
            this.panel8.Controls.Add(this.emailValueLb);
            this.panel8.Controls.Add(this.hoTenValueLb);
            this.panel8.Controls.Add(this.avatarLb);
            this.panel8.Controls.Add(this.emailLb);
            this.panel8.Controls.Add(this.hoTenLb);
            this.panel8.Location = new System.Drawing.Point(237, 197);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(623, 341);
            this.panel8.TabIndex = 40;
            // 
            // hoTenLb
            // 
            this.hoTenLb.AutoSize = true;
            this.hoTenLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenLb.Location = new System.Drawing.Point(49, 61);
            this.hoTenLb.Name = "hoTenLb";
            this.hoTenLb.Size = new System.Drawing.Size(69, 20);
            this.hoTenLb.TabIndex = 0;
            this.hoTenLb.Text = "Họ tên: ";
            this.hoTenLb.Click += new System.EventHandler(this.label3_Click);
            // 
            // emailLb
            // 
            this.emailLb.AutoSize = true;
            this.emailLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLb.Location = new System.Drawing.Point(49, 136);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(56, 20);
            this.emailLb.TabIndex = 1;
            this.emailLb.Text = "Email:";
            // 
            // avatarLb
            // 
            this.avatarLb.AutoSize = true;
            this.avatarLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avatarLb.Location = new System.Drawing.Point(47, 219);
            this.avatarLb.Name = "avatarLb";
            this.avatarLb.Size = new System.Drawing.Size(106, 20);
            this.avatarLb.TabIndex = 2;
            this.avatarLb.Text = "Ảnh đại diện:";
            // 
            // hoTenValueLb
            // 
            this.hoTenValueLb.AutoSize = true;
            this.hoTenValueLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenValueLb.Location = new System.Drawing.Point(189, 61);
            this.hoTenValueLb.Name = "hoTenValueLb";
            this.hoTenValueLb.Size = new System.Drawing.Size(0, 20);
            this.hoTenValueLb.TabIndex = 3;
            // 
            // emailValueLb
            // 
            this.emailValueLb.AutoSize = true;
            this.emailValueLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValueLb.Location = new System.Drawing.Point(193, 139);
            this.emailValueLb.Name = "emailValueLb";
            this.emailValueLb.Size = new System.Drawing.Size(0, 20);
            this.emailValueLb.TabIndex = 4;
            // 
            // avatarValuePtb
            // 
            this.avatarValuePtb.Location = new System.Drawing.Point(274, 187);
            this.avatarValuePtb.Name = "avatarValuePtb";
            this.avatarValuePtb.Size = new System.Drawing.Size(100, 100);
            this.avatarValuePtb.TabIndex = 5;
            this.avatarValuePtb.TabStop = false;
            // 
            // button_signup
            // 
            this.button_signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_signup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_signup.FlatAppearance.BorderSize = 2;
            this.button_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_signup.Location = new System.Drawing.Point(1013, 17);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(105, 35);
            this.button_signup.TabIndex = 4;
            this.button_signup.Text = "Đăng kí";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // button_login
            // 
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatAppearance.BorderSize = 2;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_login.Location = new System.Drawing.Point(885, 17);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(105, 35);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Đăng nhập";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Form_Profile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1157, 732);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label_Nhap_sai);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarValuePtb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPtb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_Nhap_sai;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label hoTenLb;
        private System.Windows.Forms.PictureBox avatarValuePtb;
        private System.Windows.Forms.Label emailValueLb;
        private System.Windows.Forms.Label hoTenValueLb;
        private System.Windows.Forms.Label avatarLb;
        private System.Windows.Forms.Label emailLb;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Label profileLb;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.PictureBox avatarPtb;
    }
}