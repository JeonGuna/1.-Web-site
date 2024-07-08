namespace P1
{
    partial class rd2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rd2));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            lb_name = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pc_1 = new System.Windows.Forms.PictureBox();
            button1 = new System.Windows.Forms.Button();
            lb_price = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pc_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1283, 560);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(486, 216);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(54, 23);
            numericUpDown1.TabIndex = 23;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.BackColor = System.Drawing.Color.Black;
            lb_name.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lb_name.Location = new System.Drawing.Point(191, 13);
            lb_name.Name = "lb_name";
            lb_name.Size = new System.Drawing.Size(395, 32);
            lb_name.TabIndex = 22;
            lb_name.Text = "[AMD R7-5700X/RX6800XT/16G]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Black;
            label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(17, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(168, 32);
            label1.TabIndex = 21;
            label1.Text = " Guns'S Shop";
            // 
            // pc_1
            // 
            pc_1.Image = (System.Drawing.Image)resources.GetObject("pc_1.Image");
            pc_1.Location = new System.Drawing.Point(19, 102);
            pc_1.Name = "pc_1";
            pc_1.Size = new System.Drawing.Size(338, 337);
            pc_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pc_1.TabIndex = 20;
            pc_1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(675, 481);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(207, 43);
            button1.TabIndex = 19;
            button1.Text = "구매하기";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            lb_price.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_price.ForeColor = System.Drawing.Color.Red;
            lb_price.Location = new System.Drawing.Point(534, 425);
            lb_price.Name = "lb_price";
            lb_price.Size = new System.Drawing.Size(0, 32);
            lb_price.TabIndex = 24;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(0, 559);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(1283, 711);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // rd2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(1285, 721);
            Controls.Add(pictureBox2);
            Controls.Add(lb_price);
            Controls.Add(numericUpDown1);
            Controls.Add(lb_name);
            Controls.Add(label1);
            Controls.Add(pc_1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "rd2";
            Text = "rd2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pc_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pc_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}