
namespace Quiz_app.Forms
{
    partial class Form_Chinh
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
            this.avatarPtb = new System.Windows.Forms.PictureBox();
            this.profileLb = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_signup = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_taodethi = new System.Windows.Forms.Button();
            this.btn_join = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPtb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // avatarPtb
            // 
            this.avatarPtb.Location = new System.Drawing.Point(760, 6);
            this.avatarPtb.Name = "avatarPtb";
            this.avatarPtb.Size = new System.Drawing.Size(60, 60);
            this.avatarPtb.TabIndex = 9;
            this.avatarPtb.TabStop = false;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1157, 1);
            this.panel3.TabIndex = 2;
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
            // btn_taodethi
            // 
            this.btn_taodethi.ForeColor = System.Drawing.Color.Black;
            this.btn_taodethi.Image = global::Quiz_app.Properties.Resources.Background_xanh_duong_basic;
            this.btn_taodethi.Location = new System.Drawing.Point(1028, 161);
            this.btn_taodethi.Name = "btn_taodethi";
            this.btn_taodethi.Size = new System.Drawing.Size(90, 44);
            this.btn_taodethi.TabIndex = 7;
            this.btn_taodethi.Text = "Quản lý quizz";
            this.btn_taodethi.UseVisualStyleBackColor = true;
            this.btn_taodethi.Click += new System.EventHandler(this.btn_taodethi_Click);
            // 
            // btn_join
            // 
            this.btn_join.BackColor = System.Drawing.Color.Black;
            this.btn_join.ForeColor = System.Drawing.Color.Black;
            this.btn_join.Image = global::Quiz_app.Properties.Resources.Background_xanh_duong_basic;
            this.btn_join.Location = new System.Drawing.Point(107, 161);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(90, 44);
            this.btn_join.TabIndex = 9;
            this.btn_join.Text = "Tham gia quiz";
            this.btn_join.UseVisualStyleBackColor = false;
            this.btn_join.Click += new System.EventHandler(this.btn_choi_Click);
            // 
            // Form_Chinh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1157, 732);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.btn_taodethi);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Chinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPtb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label profileLb;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.PictureBox avatarPtb;
        private System.Windows.Forms.Button btn_taodethi;
        private System.Windows.Forms.Button btn_join;
    }
}