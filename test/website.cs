using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class website : Form
    {
        public website()
        {
            InitializeComponent();
            pictureBox2.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\loginbt1.png");
            pictureBox3.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\intel1.png");
            pc_intel1.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\in_pc1.png");
            pc_intel2.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\in_pc2.png");
            pc_intel3.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\in_pc3.png");
            GTX_pc.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\gtx1.png");
            gtx_pc1.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\gtx_pc1.png");
            gtx_pc2.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\gtx_pc2.png");
            gtx_pc3.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\gtx_pc3.png");
            rd_pc.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\rd1.png");
            rd_pc1.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\rd_pc1.png");
            rd_pc2.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\rd_pc2.png");
            rd_pc3.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\rd_pc3.png");
            amd_pc.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\amd1.png");
            amd_pc1.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\amd_pc1.png");
            amd_pc2.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\amd_pc2.png");
            amd_pc3.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\amd_pc3.png");
            danawa.Image = Image.FromFile(@"C:\C#\web_jeon_guna\P1\pic\danawa1.png");

        }
        private void danawa_Click(object sender, EventArgs e)
        {

            string danawaURL = "https://www.danawa.com/";
            //danawURL에 주소값을 넣어 Process.strat를 이용하여 홈페이 열기
            Process.Start(new ProcessStartInfo
            {
                FileName = danawaURL,
                UseShellExecute = true
            });

        }

        private void pc_intel1_Click(object sender, EventArgs e)
        {
            intel1 formIntel1 = new intel1();

            formIntel1.Show();
        }

        private void pc_intel2_Click(object sender, EventArgs e)
        {
            intel2 formIntel1 = new intel2();

            formIntel1.Show();
        }

        private void pc_intel3_Click(object sender, EventArgs e)
        {
            intel3 formIntel1 = new intel3();

            formIntel1.Show();
        }

        private void gtx_pc1_Click(object sender, EventArgs e)
        {
            gtx1 formIntel1 = new gtx1();

            formIntel1.Show();
        }

        private void gtx_pc2_Click(object sender, EventArgs e)
        {
            gtx2 formIntel1 = new gtx2();

            formIntel1.Show();
        }

        private void gtx_pc3_Click(object sender, EventArgs e)
        {
            gtx3 formIntel1 = new gtx3();

            formIntel1.Show();
        }

        private void rd_pc1_Click(object sender, EventArgs e)
        {
            rd1 formIntel1 = new rd1();

            formIntel1.Show();
        }

        private void rd_pc2_Click(object sender, EventArgs e)
        {
            rd2 formIntel1 = new rd2();

            formIntel1.Show();
        }

        private void rd_pc3_Click(object sender, EventArgs e)
        {
            rd3 formIntel1 = new rd3();

            formIntel1.Show();
        }

        private void amd_pc1_Click(object sender, EventArgs e)
        {
            amd1 formIntel1 = new amd1();

            formIntel1.Show();
        }

        private void amd_pc2_Click(object sender, EventArgs e)
        {
            amd2 formIntel1 = new amd2();

            formIntel1.Show();
        }

        private void amd_pc3_Click(object sender, EventArgs e)
        {
            amd3 formIntel1 = new amd3();

            formIntel1.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           
            if (e.Node.Text == "Intel")
            {
                // inteltem 폼의 인스턴스를 생성합니다.
                inteltem formInteltem = new inteltem();

                // inteltem 폼을 보여줍니다.
                formInteltem.Show();
            }
        }

    }
}



