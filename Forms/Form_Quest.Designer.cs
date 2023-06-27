namespace Quiz_app
{
    partial class Form_Quest
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
            this.label1 = new System.Windows.Forms.Label();
            this.question_value_lb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quizz_id_tb = new System.Windows.Forms.TextBox();
            this.Image_ptb = new System.Windows.Forms.PictureBox();
            this.next_btn = new System.Windows.Forms.Button();
            this.question_lb = new System.Windows.Forms.Label();
            this.Ansa_cb = new System.Windows.Forms.CheckBox();
            this.Ansb_cb = new System.Windows.Forms.CheckBox();
            this.Ansc_cb = new System.Windows.Forms.CheckBox();
            this.Ansd_cb = new System.Windows.Forms.CheckBox();
            this.quit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Image_ptb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Câu: ";
            // 
            // question_value_lb
            // 
            this.question_value_lb.Enabled = false;
            this.question_value_lb.Location = new System.Drawing.Point(575, 24);
            this.question_value_lb.Name = "question_value_lb";
            this.question_value_lb.Size = new System.Drawing.Size(70, 22);
            this.question_value_lb.TabIndex = 2;
            this.question_value_lb.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(828, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quizz ID:";
            // 
            // quizz_id_tb
            // 
            this.quizz_id_tb.Enabled = false;
            this.quizz_id_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizz_id_tb.Location = new System.Drawing.Point(914, 19);
            this.quizz_id_tb.Name = "quizz_id_tb";
            this.quizz_id_tb.Size = new System.Drawing.Size(154, 27);
            this.quizz_id_tb.TabIndex = 4;
            // 
            // Image_ptb
            // 
            this.Image_ptb.BackColor = System.Drawing.Color.Transparent;
            this.Image_ptb.Location = new System.Drawing.Point(382, 380);
            this.Image_ptb.Name = "Image_ptb";
            this.Image_ptb.Size = new System.Drawing.Size(287, 148);
            this.Image_ptb.TabIndex = 5;
            this.Image_ptb.TabStop = false;
            // 
            // next_btn
            // 
            this.next_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.next_btn.Location = new System.Drawing.Point(704, 425);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(120, 42);
            this.next_btn.TabIndex = 6;
            this.next_btn.Text = "Câu tiếp theo";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // question_lb
            // 
            this.question_lb.AutoSize = true;
            this.question_lb.Location = new System.Drawing.Point(74, 76);
            this.question_lb.Name = "question_lb";
            this.question_lb.Size = new System.Drawing.Size(52, 16);
            this.question_lb.TabIndex = 7;
            this.question_lb.Text = "Câu hỏi";
            // 
            // Ansa_cb
            // 
            this.Ansa_cb.AutoSize = true;
            this.Ansa_cb.Location = new System.Drawing.Point(142, 230);
            this.Ansa_cb.Name = "Ansa_cb";
            this.Ansa_cb.Size = new System.Drawing.Size(95, 20);
            this.Ansa_cb.TabIndex = 8;
            this.Ansa_cb.Text = "checkBox1";
            this.Ansa_cb.UseVisualStyleBackColor = true;
            // 
            // Ansb_cb
            // 
            this.Ansb_cb.AutoSize = true;
            this.Ansb_cb.Location = new System.Drawing.Point(616, 230);
            this.Ansb_cb.Name = "Ansb_cb";
            this.Ansb_cb.Size = new System.Drawing.Size(95, 20);
            this.Ansb_cb.TabIndex = 9;
            this.Ansb_cb.Text = "checkBox1";
            this.Ansb_cb.UseVisualStyleBackColor = true;
            // 
            // Ansc_cb
            // 
            this.Ansc_cb.AutoSize = true;
            this.Ansc_cb.Location = new System.Drawing.Point(142, 316);
            this.Ansc_cb.Name = "Ansc_cb";
            this.Ansc_cb.Size = new System.Drawing.Size(95, 20);
            this.Ansc_cb.TabIndex = 10;
            this.Ansc_cb.Text = "checkBox2";
            this.Ansc_cb.UseVisualStyleBackColor = true;
            // 
            // Ansd_cb
            // 
            this.Ansd_cb.AutoSize = true;
            this.Ansd_cb.Location = new System.Drawing.Point(616, 316);
            this.Ansd_cb.Name = "Ansd_cb";
            this.Ansd_cb.Size = new System.Drawing.Size(95, 20);
            this.Ansd_cb.TabIndex = 11;
            this.Ansd_cb.Text = "checkBox3";
            this.Ansd_cb.UseVisualStyleBackColor = true;
            // 
            // quit_btn
            // 
            this.quit_btn.Location = new System.Drawing.Point(155, 426);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(123, 41);
            this.quit_btn.TabIndex = 12;
            this.quit_btn.Text = "Thoát";
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // Form_Quest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_app.Properties.Resources.vong_quay_may_man_tren_powerpoint_23;
            this.ClientSize = new System.Drawing.Size(1140, 562);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.Ansd_cb);
            this.Controls.Add(this.Ansc_cb);
            this.Controls.Add(this.Ansb_cb);
            this.Controls.Add(this.Ansa_cb);
            this.Controls.Add(this.question_lb);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.Image_ptb);
            this.Controls.Add(this.quizz_id_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.question_value_lb);
            this.Controls.Add(this.label1);
            this.Name = "Form_Quest";
            this.Text = "Form_Quest";
            ((System.ComponentModel.ISupportInitialize)(this.Image_ptb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox question_value_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quizz_id_tb;
        private System.Windows.Forms.PictureBox Image_ptb;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Label question_lb;
        private System.Windows.Forms.CheckBox Ansa_cb;
        private System.Windows.Forms.CheckBox Ansb_cb;
        private System.Windows.Forms.CheckBox Ansc_cb;
        private System.Windows.Forms.CheckBox Ansd_cb;
        private System.Windows.Forms.Button quit_btn;
    }
}