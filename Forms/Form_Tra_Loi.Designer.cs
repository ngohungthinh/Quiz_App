
namespace Quiz_app.Forms
{
    partial class Form_Tra_Loi
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.lb_B = new System.Windows.Forms.Label();
            this.lb_C = new System.Windows.Forms.Label();
            this.lb_D = new System.Windows.Forms.Label();
            this.lb_A = new System.Windows.Forms.Label();
            this.Ansd_cb = new System.Windows.Forms.CheckBox();
            this.Ansc_cb = new System.Windows.Forms.CheckBox();
            this.Ansb_cb = new System.Windows.Forms.CheckBox();
            this.Ansa_cb = new System.Windows.Forms.CheckBox();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.btn_NextQuestion = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ptb_AnhMinhHoa = new System.Windows.Forms.PictureBox();
            this.lb_SoThuTuCau = new System.Windows.Forms.Label();
            this.lb_QuizID = new System.Windows.Forms.Label();
            this.lb_TenQuiz = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AnhMinhHoa)).BeginInit();
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
            this.label_Close.Location = new System.Drawing.Point(1129, 3);
            this.label_Close.Name = "label_Close";
            this.label_Close.Size = new System.Drawing.Size(25, 24);
            this.label_Close.TabIndex = 3;
            this.label_Close.Text = "X";
            this.label_Close.Click += new System.EventHandler(this.label_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(44)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.btn_thoat);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 72);
            this.panel2.TabIndex = 1;
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
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.lb_B);
            this.panel8.Controls.Add(this.lb_C);
            this.panel8.Controls.Add(this.lb_D);
            this.panel8.Controls.Add(this.lb_A);
            this.panel8.Controls.Add(this.Ansd_cb);
            this.panel8.Controls.Add(this.Ansc_cb);
            this.panel8.Controls.Add(this.Ansb_cb);
            this.panel8.Controls.Add(this.Ansa_cb);
            this.panel8.Controls.Add(this.tb_question);
            this.panel8.Controls.Add(this.btn_NextQuestion);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.ptb_AnhMinhHoa);
            this.panel8.Controls.Add(this.lb_SoThuTuCau);
            this.panel8.Controls.Add(this.lb_QuizID);
            this.panel8.Controls.Add(this.lb_TenQuiz);
            this.panel8.Location = new System.Drawing.Point(103, 145);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(948, 550);
            this.panel8.TabIndex = 7;
            // 
            // lb_B
            // 
            this.lb_B.AutoSize = true;
            this.lb_B.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_B.ForeColor = System.Drawing.Color.Brown;
            this.lb_B.Location = new System.Drawing.Point(601, 370);
            this.lb_B.Name = "lb_B";
            this.lb_B.Size = new System.Drawing.Size(82, 26);
            this.lb_B.TabIndex = 20;
            this.lb_B.Text = "Con cò";
            // 
            // lb_C
            // 
            this.lb_C.AutoSize = true;
            this.lb_C.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_C.ForeColor = System.Drawing.Color.Brown;
            this.lb_C.Location = new System.Drawing.Point(149, 441);
            this.lb_C.Name = "lb_C";
            this.lb_C.Size = new System.Drawing.Size(82, 26);
            this.lb_C.TabIndex = 19;
            this.lb_C.Text = "Con cò";
            // 
            // lb_D
            // 
            this.lb_D.AutoSize = true;
            this.lb_D.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_D.ForeColor = System.Drawing.Color.Brown;
            this.lb_D.Location = new System.Drawing.Point(601, 439);
            this.lb_D.Name = "lb_D";
            this.lb_D.Size = new System.Drawing.Size(82, 26);
            this.lb_D.TabIndex = 18;
            this.lb_D.Text = "Con cò";
            // 
            // lb_A
            // 
            this.lb_A.AutoSize = true;
            this.lb_A.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_A.ForeColor = System.Drawing.Color.Brown;
            this.lb_A.Location = new System.Drawing.Point(149, 372);
            this.lb_A.Name = "lb_A";
            this.lb_A.Size = new System.Drawing.Size(82, 26);
            this.lb_A.TabIndex = 17;
            this.lb_A.Text = "Con cò";
            // 
            // Ansd_cb
            // 
            this.Ansd_cb.AutoSize = true;
            this.Ansd_cb.Location = new System.Drawing.Point(541, 451);
            this.Ansd_cb.Name = "Ansd_cb";
            this.Ansd_cb.Size = new System.Drawing.Size(15, 14);
            this.Ansd_cb.TabIndex = 16;
            this.Ansd_cb.UseVisualStyleBackColor = true;
            // 
            // Ansc_cb
            // 
            this.Ansc_cb.AutoSize = true;
            this.Ansc_cb.Location = new System.Drawing.Point(87, 451);
            this.Ansc_cb.Name = "Ansc_cb";
            this.Ansc_cb.Size = new System.Drawing.Size(15, 14);
            this.Ansc_cb.TabIndex = 15;
            this.Ansc_cb.UseVisualStyleBackColor = true;
            // 
            // Ansb_cb
            // 
            this.Ansb_cb.AutoSize = true;
            this.Ansb_cb.Location = new System.Drawing.Point(541, 382);
            this.Ansb_cb.Name = "Ansb_cb";
            this.Ansb_cb.Size = new System.Drawing.Size(15, 14);
            this.Ansb_cb.TabIndex = 14;
            this.Ansb_cb.UseVisualStyleBackColor = true;
            // 
            // Ansa_cb
            // 
            this.Ansa_cb.AutoSize = true;
            this.Ansa_cb.Location = new System.Drawing.Point(87, 382);
            this.Ansa_cb.Name = "Ansa_cb";
            this.Ansa_cb.Size = new System.Drawing.Size(15, 14);
            this.Ansa_cb.TabIndex = 13;
            this.Ansa_cb.UseVisualStyleBackColor = true;
            // 
            // tb_question
            // 
            this.tb_question.BackColor = System.Drawing.Color.PeachPuff;
            this.tb_question.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_question.ForeColor = System.Drawing.Color.DarkRed;
            this.tb_question.Location = new System.Drawing.Point(39, 304);
            this.tb_question.Name = "tb_question";
            this.tb_question.ReadOnly = true;
            this.tb_question.Size = new System.Drawing.Size(855, 31);
            this.tb_question.TabIndex = 12;
            this.tb_question.Text = "Bức ảnh nói lên điều gì?";
            this.tb_question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_NextQuestion
            // 
            this.btn_NextQuestion.BackColor = System.Drawing.Color.Brown;
            this.btn_NextQuestion.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextQuestion.ForeColor = System.Drawing.Color.White;
            this.btn_NextQuestion.Location = new System.Drawing.Point(398, 492);
            this.btn_NextQuestion.Name = "btn_NextQuestion";
            this.btn_NextQuestion.Size = new System.Drawing.Size(172, 42);
            this.btn_NextQuestion.TabIndex = 10;
            this.btn_NextQuestion.Text = "Câu tiếp theo";
            this.btn_NextQuestion.UseVisualStyleBackColor = false;
            this.btn_NextQuestion.Click += new System.EventHandler(this.btn_NextQuestion_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(108, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 37);
            this.label10.TabIndex = 8;
            this.label10.Text = "C.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(562, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 37);
            this.label9.TabIndex = 7;
            this.label9.Text = "B.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(562, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 37);
            this.label8.TabIndex = 6;
            this.label8.Text = "D.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(108, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 37);
            this.label7.TabIndex = 5;
            this.label7.Text = "A.";
            // 
            // ptb_AnhMinhHoa
            // 
            this.ptb_AnhMinhHoa.Image = global::Quiz_app.Properties.Resources.mmh;
            this.ptb_AnhMinhHoa.Location = new System.Drawing.Point(267, 115);
            this.ptb_AnhMinhHoa.Name = "ptb_AnhMinhHoa";
            this.ptb_AnhMinhHoa.Size = new System.Drawing.Size(419, 183);
            this.ptb_AnhMinhHoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_AnhMinhHoa.TabIndex = 3;
            this.ptb_AnhMinhHoa.TabStop = false;
            // 
            // lb_SoThuTuCau
            // 
            this.lb_SoThuTuCau.AutoSize = true;
            this.lb_SoThuTuCau.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoThuTuCau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_SoThuTuCau.Location = new System.Drawing.Point(419, 65);
            this.lb_SoThuTuCau.Name = "lb_SoThuTuCau";
            this.lb_SoThuTuCau.Size = new System.Drawing.Size(107, 37);
            this.lb_SoThuTuCau.TabIndex = 2;
            this.lb_SoThuTuCau.Text = "#Câu 1";
            // 
            // lb_QuizID
            // 
            this.lb_QuizID.AutoSize = true;
            this.lb_QuizID.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_QuizID.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_QuizID.Location = new System.Drawing.Point(724, 37);
            this.lb_QuizID.Name = "lb_QuizID";
            this.lb_QuizID.Size = new System.Drawing.Size(140, 26);
            this.lb_QuizID.TabIndex = 1;
            this.lb_QuizID.Text = "Quiz ID: 1234";
            // 
            // lb_TenQuiz
            // 
            this.lb_TenQuiz.AutoSize = true;
            this.lb_TenQuiz.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenQuiz.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_TenQuiz.Location = new System.Drawing.Point(34, 37);
            this.lb_TenQuiz.Name = "lb_TenQuiz";
            this.lb_TenQuiz.Size = new System.Drawing.Size(233, 26);
            this.lb_TenQuiz.TabIndex = 0;
            this.lb_TenQuiz.Text = "Quiz: Kiến thức xã hội";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.DarkRed;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(1003, 23);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(120, 35);
            this.btn_thoat.TabIndex = 49;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_Tra_Loi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1157, 732);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Tra_Loi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Tra_Loi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_AnhMinhHoa)).EndInit();
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
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ptb_AnhMinhHoa;
        private System.Windows.Forms.Label lb_SoThuTuCau;
        private System.Windows.Forms.Label lb_QuizID;
        private System.Windows.Forms.Label lb_TenQuiz;
        private System.Windows.Forms.Button btn_NextQuestion;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.CheckBox Ansd_cb;
        private System.Windows.Forms.CheckBox Ansc_cb;
        private System.Windows.Forms.CheckBox Ansb_cb;
        private System.Windows.Forms.CheckBox Ansa_cb;
        private System.Windows.Forms.Label lb_B;
        private System.Windows.Forms.Label lb_C;
        private System.Windows.Forms.Label lb_D;
        private System.Windows.Forms.Label lb_A;
        private System.Windows.Forms.Button btn_thoat;
    }
}