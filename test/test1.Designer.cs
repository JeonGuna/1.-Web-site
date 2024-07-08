namespace P1
{
    partial class test1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test1));
            label1 = new System.Windows.Forms.Label();
            tb_id = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tb_password = new System.Windows.Forms.TextBox();
            tb_install = new System.Windows.Forms.Button();
            bt_login = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(304, 418);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "아이디    :";
            // 
            // tb_id
            // 
            tb_id.Location = new System.Drawing.Point(375, 415);
            tb_id.Name = "tb_id";
            tb_id.Size = new System.Drawing.Size(133, 23);
            tb_id.TabIndex = 1;
            tb_id.TextChanged += tb_id_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(304, 447);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "비밀번호 :";
            // 
            // tb_password
            // 
            tb_password.Location = new System.Drawing.Point(375, 444);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new System.Drawing.Size(133, 23);
            tb_password.TabIndex = 3;
            tb_password.TextChanged += tb_password_TextChanged;
            // 
            // tb_install
            // 
            tb_install.BackColor = System.Drawing.SystemColors.ControlLightLight;
            tb_install.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            tb_install.Location = new System.Drawing.Point(304, 488);
            tb_install.Name = "tb_install";
            tb_install.Size = new System.Drawing.Size(75, 23);
            tb_install.TabIndex = 4;
            tb_install.Text = "회원가입";
            tb_install.UseVisualStyleBackColor = false;
            tb_install.Click += tb_install_Click;
            // 
            // bt_login
            // 
            bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bt_login.Location = new System.Drawing.Point(395, 488);
            bt_login.Name = "bt_login";
            bt_login.Size = new System.Drawing.Size(75, 23);
            bt_login.TabIndex = 5;
            bt_login.Text = "로그인";
            bt_login.UseVisualStyleBackColor = true;
            bt_login.Click += bt_login_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(537, 412);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(77, 78);
            button1.TabIndex = 6;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // test1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.b8ea3e5c047ac1;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(842, 605);
            Controls.Add(button1);
            Controls.Add(bt_login);
            Controls.Add(tb_install);
            Controls.Add(tb_password);
            Controls.Add(label2);
            Controls.Add(tb_id);
            Controls.Add(label1);
            Name = "test1";
            Text = "test1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button tb_install;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button button1;
    }
}