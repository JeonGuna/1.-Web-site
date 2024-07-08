using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace P1
{
    public partial class loding : Form
    {
        public loding()
        {
            InitializeComponent();
            Shown += loding_Shown; // 폼이 보여질 때 이벤트 핸들러 등록
        }

        private async void loding_Shown(object sender, EventArgs e)
        {
            await UpdateProgressBarAndTextAsync();
        }

        private async Task UpdateProgressBarAndTextAsync()
        {
            int totalTime = 15; // 총 시간 (초)
            int dnsCheckTime = 7; // DNS 변조 검사 시간 (초)

            for (int i = 0; i <= totalTime; i++)
            {
                // 텍스트 업데이트
                if (i <= dnsCheckTime)
                {
                    textBox1.Text = "DNS 변조 검사중...";
                }
                else
                {
                    textBox1.Text = "웹사이트로 이동중...";
                }

                // 진행 막대 업데이트
                progressBar1.Value = (int)((double)i / totalTime * 100);

                await Task.Delay(500); // 1초 대기
            }

            // 작업 완료 후 폼 종료
            this.Close();
        }
    }
}



