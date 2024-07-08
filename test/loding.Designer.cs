namespace P1
{
    partial class loding
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
            progressBar1 = new System.Windows.Forms.ProgressBar();
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            progressBar1.ForeColor = System.Drawing.SystemColors.Desktop;
            progressBar1.Location = new System.Drawing.Point(25, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(487, 18);
            progressBar1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBox1.Enabled = false;
            textBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            textBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            textBox1.Location = new System.Drawing.Point(150, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(215, 29);
            textBox1.TabIndex = 1;
            // 
            // loding
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.탭사이트2;
            ClientSize = new System.Drawing.Size(531, 71);
            Controls.Add(textBox1);
            Controls.Add(progressBar1);
            Name = "loding";
            Text = "loding";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
    }
}