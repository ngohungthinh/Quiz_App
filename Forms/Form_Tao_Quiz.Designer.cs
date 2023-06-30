
namespace Quiz_app.Forms
{
    partial class Form_Tao_Quiz
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
            this.avatarPtb = new Quiz_app.CircularPictureBox();
            this.button_Logout = new System.Windows.Forms.Button();
            this.profileLb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.AnswerContent_D_tb = new System.Windows.Forms.TextBox();
            this.AnswerContent_C_tb = new System.Windows.Forms.TextBox();
            this.AnswerContent_B_tb = new System.Windows.Forms.TextBox();
            this.AnswerContent_A_tb = new System.Windows.Forms.TextBox();
            this.AnhMinhHoa_Ptb = new System.Windows.Forms.PictureBox();
            this.btn_XoaCauHoi = new System.Windows.Forms.Button();
            this.btn_ThemCauHoi = new System.Windows.Forms.Button();
            this.btn_TaiAnhMinhHoa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_QuestionContent = new System.Windows.Forms.TextBox();
            this.tb_SoThuTuCau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_QuizID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dg_cauhoi = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cauhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DA3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DA4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAdung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_TenQuiz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPtb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnhMinhHoa_Ptb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cauhoi)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1438, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(1383, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_Close
            // 
            this.label_Close.AutoSize = true;
            this.label_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_Close.Location = new System.Drawing.Point(1410, 3);
            this.label_Close.Name = "label_Close";
            this.label_Close.Size = new System.Drawing.Size(25, 24);
            this.label_Close.TabIndex = 3;
            this.label_Close.Text = "X";
            this.label_Close.Click += new System.EventHandler(this.label_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.avatarPtb);
            this.panel2.Controls.Add(this.button_Logout);
            this.panel2.Controls.Add(this.profileLb);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1438, 72);
            this.panel2.TabIndex = 1;
            // 
            // avatarPtb
            // 
            this.avatarPtb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarPtb.Image = global::Quiz_app.Properties.Resources.avata_2;
            this.avatarPtb.Location = new System.Drawing.Point(1014, 6);
            this.avatarPtb.Name = "avatarPtb";
            this.avatarPtb.Size = new System.Drawing.Size(60, 60);
            this.avatarPtb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPtb.TabIndex = 45;
            this.avatarPtb.TabStop = false;
            this.avatarPtb.Click += new System.EventHandler(this.avatarPtb_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Logout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Logout.FlatAppearance.BorderSize = 2;
            this.button_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Logout.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Logout.Location = new System.Drawing.Point(1333, 17);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(93, 35);
            this.button_Logout.TabIndex = 44;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // profileLb
            // 
            this.profileLb.AutoSize = true;
            this.profileLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.profileLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileLb.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.profileLb.Location = new System.Drawing.Point(1080, 21);
            this.profileLb.Name = "profileLb";
            this.profileLb.Size = new System.Drawing.Size(173, 28);
            this.profileLb.TabIndex = 43;
            this.profileLb.Text = "Ngô Hùng Thịnh";
            this.profileLb.Click += new System.EventHandler(this.avatarPtb_Click);
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
            this.label1.Size = new System.Drawing.Size(228, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oh My Quiz!";
            this.label1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1437, 1);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(1437, 29);
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
            this.panel6.Size = new System.Drawing.Size(1437, 1);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(0, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1438, 1);
            this.panel7.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel8.Controls.Add(this.radioButton4);
            this.panel8.Controls.Add(this.radioButton3);
            this.panel8.Controls.Add(this.radioButton2);
            this.panel8.Controls.Add(this.radioButton1);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Controls.Add(this.AnswerContent_D_tb);
            this.panel8.Controls.Add(this.AnswerContent_C_tb);
            this.panel8.Controls.Add(this.AnswerContent_B_tb);
            this.panel8.Controls.Add(this.AnswerContent_A_tb);
            this.panel8.Controls.Add(this.AnhMinhHoa_Ptb);
            this.panel8.Controls.Add(this.btn_XoaCauHoi);
            this.panel8.Controls.Add(this.btn_ThemCauHoi);
            this.panel8.Controls.Add(this.btn_TaiAnhMinhHoa);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.tb_QuestionContent);
            this.panel8.Controls.Add(this.tb_SoThuTuCau);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.tb_QuizID);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.dg_cauhoi);
            this.panel8.Controls.Add(this.tb_TenQuiz);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(15, 123);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1411, 597);
            this.panel8.TabIndex = 7;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(318, 508);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(14, 13);
            this.radioButton4.TabIndex = 57;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(10, 508);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 56;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(318, 446);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 55;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 446);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 54;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(1218, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 22);
            this.label6.TabIndex = 53;
            this.label6.Text = "Danh sách câu hỏi";
            // 
            // AnswerContent_D_tb
            // 
            this.AnswerContent_D_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerContent_D_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerContent_D_tb.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AnswerContent_D_tb.Location = new System.Drawing.Point(375, 492);
            this.AnswerContent_D_tb.Name = "AnswerContent_D_tb";
            this.AnswerContent_D_tb.Size = new System.Drawing.Size(222, 27);
            this.AnswerContent_D_tb.TabIndex = 52;
            this.AnswerContent_D_tb.Text = "Đáp án";
            this.AnswerContent_D_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AnswerContent_D_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnswerContent_D_tb_MouseClick);
            this.AnswerContent_D_tb.Validated += new System.EventHandler(this.AnswerContent_D_tb_Validated);
            // 
            // AnswerContent_C_tb
            // 
            this.AnswerContent_C_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerContent_C_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerContent_C_tb.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AnswerContent_C_tb.Location = new System.Drawing.Point(67, 492);
            this.AnswerContent_C_tb.Name = "AnswerContent_C_tb";
            this.AnswerContent_C_tb.Size = new System.Drawing.Size(222, 27);
            this.AnswerContent_C_tb.TabIndex = 51;
            this.AnswerContent_C_tb.Text = "Đáp án";
            this.AnswerContent_C_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AnswerContent_C_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnswerContent_C_tb_MouseClick);
            this.AnswerContent_C_tb.Validated += new System.EventHandler(this.AnswerContent_C_tb_Validated);
            // 
            // AnswerContent_B_tb
            // 
            this.AnswerContent_B_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerContent_B_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerContent_B_tb.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AnswerContent_B_tb.Location = new System.Drawing.Point(373, 430);
            this.AnswerContent_B_tb.Name = "AnswerContent_B_tb";
            this.AnswerContent_B_tb.Size = new System.Drawing.Size(222, 27);
            this.AnswerContent_B_tb.TabIndex = 50;
            this.AnswerContent_B_tb.Text = "Đáp án";
            this.AnswerContent_B_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AnswerContent_B_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnswerContent_B_tb_MouseClick);
            this.AnswerContent_B_tb.Validated += new System.EventHandler(this.AnswerContent_B_tb_Validated);
            // 
            // AnswerContent_A_tb
            // 
            this.AnswerContent_A_tb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AnswerContent_A_tb.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerContent_A_tb.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AnswerContent_A_tb.Location = new System.Drawing.Point(68, 430);
            this.AnswerContent_A_tb.Name = "AnswerContent_A_tb";
            this.AnswerContent_A_tb.Size = new System.Drawing.Size(222, 27);
            this.AnswerContent_A_tb.TabIndex = 49;
            this.AnswerContent_A_tb.Text = "Đáp án";
            this.AnswerContent_A_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AnswerContent_A_tb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AnswerContent_A_tb_MouseClick);
            this.AnswerContent_A_tb.Validated += new System.EventHandler(this.AnswerContent_A_tb_Validated);
            // 
            // AnhMinhHoa_Ptb
            // 
            this.AnhMinhHoa_Ptb.Image = global::Quiz_app.Properties.Resources.avata_2;
            this.AnhMinhHoa_Ptb.Location = new System.Drawing.Point(127, 227);
            this.AnhMinhHoa_Ptb.Name = "AnhMinhHoa_Ptb";
            this.AnhMinhHoa_Ptb.Size = new System.Drawing.Size(359, 160);
            this.AnhMinhHoa_Ptb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnhMinhHoa_Ptb.TabIndex = 48;
            this.AnhMinhHoa_Ptb.TabStop = false;
            // 
            // btn_XoaCauHoi
            // 
            this.btn_XoaCauHoi.BackColor = System.Drawing.Color.Brown;
            this.btn_XoaCauHoi.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaCauHoi.ForeColor = System.Drawing.Color.White;
            this.btn_XoaCauHoi.Location = new System.Drawing.Point(477, 540);
            this.btn_XoaCauHoi.Name = "btn_XoaCauHoi";
            this.btn_XoaCauHoi.Size = new System.Drawing.Size(144, 42);
            this.btn_XoaCauHoi.TabIndex = 47;
            this.btn_XoaCauHoi.Text = "Xóa";
            this.btn_XoaCauHoi.UseVisualStyleBackColor = false;
            this.btn_XoaCauHoi.Click += new System.EventHandler(this.btn_XoaCauHoi_Click);
            // 
            // btn_ThemCauHoi
            // 
            this.btn_ThemCauHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.btn_ThemCauHoi.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemCauHoi.ForeColor = System.Drawing.Color.White;
            this.btn_ThemCauHoi.Location = new System.Drawing.Point(188, 540);
            this.btn_ThemCauHoi.Name = "btn_ThemCauHoi";
            this.btn_ThemCauHoi.Size = new System.Drawing.Size(252, 42);
            this.btn_ThemCauHoi.TabIndex = 46;
            this.btn_ThemCauHoi.Text = "Thêm câu hỏi";
            this.btn_ThemCauHoi.UseVisualStyleBackColor = false;
            this.btn_ThemCauHoi.Click += new System.EventHandler(this.btn_ThemCauHoi_Click);
            // 
            // btn_TaiAnhMinhHoa
            // 
            this.btn_TaiAnhMinhHoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_TaiAnhMinhHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TaiAnhMinhHoa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TaiAnhMinhHoa.FlatAppearance.BorderSize = 2;
            this.btn_TaiAnhMinhHoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TaiAnhMinhHoa.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaiAnhMinhHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.btn_TaiAnhMinhHoa.Location = new System.Drawing.Point(220, 393);
            this.btn_TaiAnhMinhHoa.Name = "btn_TaiAnhMinhHoa";
            this.btn_TaiAnhMinhHoa.Size = new System.Drawing.Size(176, 28);
            this.btn_TaiAnhMinhHoa.TabIndex = 45;
            this.btn_TaiAnhMinhHoa.Text = "Tải ảnh minh họa";
            this.btn_TaiAnhMinhHoa.UseVisualStyleBackColor = false;
            this.btn_TaiAnhMinhHoa.Click += new System.EventHandler(this.btn_TaiAnhMinhHoa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(22, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 33);
            this.label10.TabIndex = 18;
            this.label10.Text = "C.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(328, 430);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 33);
            this.label9.TabIndex = 17;
            this.label9.Text = "B.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(328, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 33);
            this.label8.TabIndex = 16;
            this.label8.Text = "D.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(21, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "A.";
            // 
            // tb_QuestionContent
            // 
            this.tb_QuestionContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_QuestionContent.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_QuestionContent.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tb_QuestionContent.Location = new System.Drawing.Point(10, 150);
            this.tb_QuestionContent.Multiline = true;
            this.tb_QuestionContent.Name = "tb_QuestionContent";
            this.tb_QuestionContent.Size = new System.Drawing.Size(611, 71);
            this.tb_QuestionContent.TabIndex = 14;
            this.tb_QuestionContent.Text = "Nhập câu hỏi....";
            this.tb_QuestionContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_QuestionContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_QuestionContent_MouseClick);
            this.tb_QuestionContent.Validated += new System.EventHandler(this.tb_QuestionContent_Validated);
            // 
            // tb_SoThuTuCau
            // 
            this.tb_SoThuTuCau.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoThuTuCau.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tb_SoThuTuCau.Location = new System.Drawing.Point(334, 95);
            this.tb_SoThuTuCau.Name = "tb_SoThuTuCau";
            this.tb_SoThuTuCau.Size = new System.Drawing.Size(42, 37);
            this.tb_SoThuTuCau.TabIndex = 13;
            this.tb_SoThuTuCau.Text = "1";
            this.tb_SoThuTuCau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(253, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "#Câu:";
            // 
            // tb_QuizID
            // 
            this.tb_QuizID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_QuizID.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_QuizID.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tb_QuizID.Location = new System.Drawing.Point(508, 44);
            this.tb_QuizID.Name = "tb_QuizID";
            this.tb_QuizID.Size = new System.Drawing.Size(113, 27);
            this.tb_QuizID.TabIndex = 11;
            this.tb_QuizID.Text = ".....";
            this.tb_QuizID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_QuizID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_QuizID_MouseClick);
            this.tb_QuizID.Validated += new System.EventHandler(this.tb_QuizID_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(413, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quiz ID:";
            // 
            // dg_cauhoi
            // 
            this.dg_cauhoi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dg_cauhoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cauhoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.Cauhoi,
            this.DA1,
            this.DA2,
            this.DA3,
            this.DA4,
            this.DAdung});
            this.dg_cauhoi.Location = new System.Drawing.Point(637, 75);
            this.dg_cauhoi.Name = "dg_cauhoi";
            this.dg_cauhoi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dg_cauhoi.Size = new System.Drawing.Size(745, 507);
            this.dg_cauhoi.TabIndex = 8;
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.Width = 50;
            // 
            // Cauhoi
            // 
            this.Cauhoi.HeaderText = "Câu hỏi";
            this.Cauhoi.Name = "Cauhoi";
            this.Cauhoi.Width = 200;
            // 
            // DA1
            // 
            this.DA1.HeaderText = "DA1";
            this.DA1.Name = "DA1";
            // 
            // DA2
            // 
            this.DA2.HeaderText = "DA2";
            this.DA2.Name = "DA2";
            // 
            // DA3
            // 
            this.DA3.HeaderText = "DA3";
            this.DA3.Name = "DA3";
            // 
            // DA4
            // 
            this.DA4.HeaderText = "DA4";
            this.DA4.Name = "DA4";
            // 
            // DAdung
            // 
            this.DAdung.HeaderText = "DA";
            this.DAdung.Name = "DAdung";
            this.DAdung.Width = 50;
            // 
            // tb_TenQuiz
            // 
            this.tb_TenQuiz.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_TenQuiz.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenQuiz.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tb_TenQuiz.Location = new System.Drawing.Point(114, 44);
            this.tb_TenQuiz.Name = "tb_TenQuiz";
            this.tb_TenQuiz.Size = new System.Drawing.Size(194, 27);
            this.tb_TenQuiz.TabIndex = 1;
            this.tb_TenQuiz.Text = ".....";
            this.tb_TenQuiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_TenQuiz.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_TenQuiz_MouseClick);
            this.tb_TenQuiz.Validated += new System.EventHandler(this.tb_TenQuiz_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(5, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Quiz:";
            // 
            // Form_Tao_Quiz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1438, 732);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Tao_Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Tao_Quiz_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPtb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnhMinhHoa_Ptb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cauhoi)).EndInit();
            this.ResumeLayout(false);

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
        private CircularPictureBox avatarPtb;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Label profileLb;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tb_QuizID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dg_cauhoi;
        private System.Windows.Forms.TextBox tb_TenQuiz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_QuestionContent;
        private System.Windows.Forms.TextBox tb_SoThuTuCau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_TaiAnhMinhHoa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox AnhMinhHoa_Ptb;
        private System.Windows.Forms.Button btn_XoaCauHoi;
        private System.Windows.Forms.Button btn_ThemCauHoi;
        private System.Windows.Forms.TextBox AnswerContent_D_tb;
        private System.Windows.Forms.TextBox AnswerContent_C_tb;
        private System.Windows.Forms.TextBox AnswerContent_B_tb;
        private System.Windows.Forms.TextBox AnswerContent_A_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cauhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DA3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DA4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAdung;
    }
}