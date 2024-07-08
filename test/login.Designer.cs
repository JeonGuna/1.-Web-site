namespace P1
{
    partial class login
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            tb_phone = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            tb_mail1 = new System.Windows.Forms.TextBox();
            tb_name1 = new System.Windows.Forms.TextBox();
            tb_Id2 = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            tb_Id1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            rd_agreed = new System.Windows.Forms.RadioButton();
            rd_noagreed = new System.Windows.Forms.RadioButton();
            bt_enter = new System.Windows.Forms.Button();
            groupBox4 = new System.Windows.Forms.GroupBox();
            bt_enter2 = new System.Windows.Forms.Button();
            rd_agreed2 = new System.Windows.Forms.RadioButton();
            rd_noagreed2 = new System.Windows.Forms.RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = System.Drawing.SystemColors.ControlText;
            groupBox1.Controls.Add(tb_phone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(tb_mail1);
            groupBox1.Controls.Add(tb_name1);
            groupBox1.Controls.Add(tb_Id2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tb_Id1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            groupBox1.Location = new System.Drawing.Point(12, 204);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(333, 206);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "회원가입";
            // 
            // tb_phone
            // 
            tb_phone.BackColor = System.Drawing.SystemColors.ScrollBar;
            tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tb_phone.Location = new System.Drawing.Point(81, 138);
            tb_phone.Name = "tb_phone";
            tb_phone.Size = new System.Drawing.Size(100, 16);
            tb_phone.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(15, 138);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(62, 15);
            label5.TabIndex = 6;
            label5.Text = "전화번호 :";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "@naver.com", "@gmail.com", "@hotmail.com" });
            comboBox1.Location = new System.Drawing.Point(191, 168);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 10;
            // 
            // tb_mail1
            // 
            tb_mail1.BackColor = System.Drawing.SystemColors.ScrollBar;
            tb_mail1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tb_mail1.Location = new System.Drawing.Point(81, 171);
            tb_mail1.Name = "tb_mail1";
            tb_mail1.Size = new System.Drawing.Size(100, 16);
            tb_mail1.TabIndex = 9;
            // 
            // tb_name1
            // 
            tb_name1.BackColor = System.Drawing.SystemColors.ScrollBar;
            tb_name1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tb_name1.Location = new System.Drawing.Point(81, 104);
            tb_name1.Name = "tb_name1";
            tb_name1.Size = new System.Drawing.Size(100, 16);
            tb_name1.TabIndex = 5;
            // 
            // tb_Id2
            // 
            tb_Id2.BackColor = System.Drawing.SystemColors.ScrollBar;
            tb_Id2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tb_Id2.Location = new System.Drawing.Point(81, 69);
            tb_Id2.Name = "tb_Id2";
            tb_Id2.PasswordChar = '*';
            tb_Id2.Size = new System.Drawing.Size(100, 16);
            tb_Id2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(15, 104);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 15);
            label4.TabIndex = 4;
            label4.Text = "이름       :";
            // 
            // tb_Id1
            // 
            tb_Id1.BackColor = System.Drawing.SystemColors.ScrollBar;
            tb_Id1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tb_Id1.Location = new System.Drawing.Point(81, 35);
            tb_Id1.Name = "tb_Id1";
            tb_Id1.Size = new System.Drawing.Size(100, 16);
            tb_Id1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 171);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 15);
            label3.TabIndex = 8;
            label3.Text = "이메일    :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 69);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "비밀번호 : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 35);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "아이디    : ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = System.Drawing.SystemColors.ControlText;
            groupBox2.Controls.Add(rd_agreed);
            groupBox2.Controls.Add(rd_noagreed);
            groupBox2.Controls.Add(bt_enter);
            groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            groupBox2.Location = new System.Drawing.Point(351, 204);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(272, 82);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "개인정보 동의서";
            // 
            // rd_agreed
            // 
            rd_agreed.AutoSize = true;
            rd_agreed.Location = new System.Drawing.Point(22, 33);
            rd_agreed.Name = "rd_agreed";
            rd_agreed.Size = new System.Drawing.Size(49, 19);
            rd_agreed.TabIndex = 0;
            rd_agreed.Text = "동의";
            rd_agreed.UseVisualStyleBackColor = true;
            // 
            // rd_noagreed
            // 
            rd_noagreed.AutoSize = true;
            rd_noagreed.Location = new System.Drawing.Point(100, 33);
            rd_noagreed.Name = "rd_noagreed";
            rd_noagreed.Size = new System.Drawing.Size(73, 19);
            rd_noagreed.TabIndex = 1;
            rd_noagreed.Text = "동의안함";
            rd_noagreed.UseVisualStyleBackColor = true;
            // 
            // bt_enter
            // 
            bt_enter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            bt_enter.ForeColor = System.Drawing.Color.Black;
            bt_enter.Location = new System.Drawing.Point(191, 33);
            bt_enter.Name = "bt_enter";
            bt_enter.Size = new System.Drawing.Size(75, 23);
            bt_enter.TabIndex = 2;
            bt_enter.Text = "가입하기";
            bt_enter.UseVisualStyleBackColor = false;
            bt_enter.Click += bt_enter_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            groupBox4.Controls.Add(bt_enter2);
            groupBox4.Controls.Add(rd_agreed2);
            groupBox4.Controls.Add(rd_noagreed2);
            groupBox4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            groupBox4.Location = new System.Drawing.Point(351, 323);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(272, 83);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "이벤트에 응모";
            // 
            // bt_enter2
            // 
            bt_enter2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            bt_enter2.ForeColor = System.Drawing.Color.Black;
            bt_enter2.Location = new System.Drawing.Point(188, 37);
            bt_enter2.Name = "bt_enter2";
            bt_enter2.Size = new System.Drawing.Size(75, 23);
            bt_enter2.TabIndex = 2;
            bt_enter2.Text = "응모";
            bt_enter2.UseVisualStyleBackColor = false;
            bt_enter2.Click += bt_enter2_Click;
            // 
            // rd_agreed2
            // 
            rd_agreed2.AutoSize = true;
            rd_agreed2.Location = new System.Drawing.Point(19, 37);
            rd_agreed2.Name = "rd_agreed2";
            rd_agreed2.Size = new System.Drawing.Size(52, 21);
            rd_agreed2.TabIndex = 0;
            rd_agreed2.Text = "동의";
            rd_agreed2.UseVisualStyleBackColor = true;
            // 
            // rd_noagreed2
            // 
            rd_noagreed2.AutoSize = true;
            rd_noagreed2.Location = new System.Drawing.Point(97, 37);
            rd_noagreed2.Name = "rd_noagreed2";
            rd_noagreed2.Size = new System.Drawing.Size(78, 21);
            rd_noagreed2.TabIndex = 1;
            rd_noagreed2.Text = "동의안함";
            rd_noagreed2.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.로그인창;
            ClientSize = new System.Drawing.Size(635, 422);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "login";
            Text = "회원가입";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Id1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mail1;
        private System.Windows.Forms.TextBox tb_name1;
        private System.Windows.Forms.TextBox tb_Id2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rd_agreed;
        private System.Windows.Forms.RadioButton rd_noagreed;
        private System.Windows.Forms.Button bt_enter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_enter2;
        private System.Windows.Forms.RadioButton rd_agreed2;
        private System.Windows.Forms.RadioButton rd_noagreed2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_phone;
    }
}