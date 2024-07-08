using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace P1
{
    public partial class Buy : Form
    {


        public Buy()
        {
            InitializeComponent();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            //인텔 상품 1 불러오기
            tb_name.Text = Profile.Instance.Name;
            tb_name2.Text = Profile.Instance.Name;
            tb_mail.Text = Profile.Instance.Email;
            tb_phone.Text = Profile.Instance.Phone;
            tb_phone1.Text = Profile.Instance.Phone;
            tb_2.Text = Profile.Instance.BasePrice.ToString("C0") + "원"; ;
            tb_3.Text = Profile.Instance.Quantity.ToString();
            tb_4.Text = Profile.Instance.TotalPrice.ToString("C0") + "원";
            tb_6.Text = Profile.Instance.TotalPrice.ToString("C0");
            tb_7.Text = Profile.Instance.TotalPrice.ToString("C0") + "원";
            tb_9.Text = Profile.Instance.Quantity.ToString();
            tb_1.Text = Profile.Instance.intel1;
            pc_1.Image = Profile.Instance.image1;
        }
        //rd_2은 라디오버튼 무통장입금
        //rd_2이 선택 되면 cb_1박스에 신한은행, 국민은행,농협은행, 새마을금고, 우체국, 기업은행 추가해줘
        //bt_pay 버튼 이 클릭되면 메시지 박스로 무슨 카드로 TotalPrice가 결제 되었습니다.

        private void rd_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_1.Checked)
            {

                cb_1.Items.Clear();
                cb_1.Items.Add("신한카드");
                cb_1.Items.Add("국민카드");
                cb_1.Items.Add("BC카드");
                cb_1.Items.Add("네이버 페이");
                cb_1.Items.Add("PAYCO");
                cb_1.Items.Add("Toss");
            }
        }
        private void rd_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_2.Checked)
            {
                
                cb_1.Items.Clear(); 
                cb_1.Items.Add("신한은행");
                cb_1.Items.Add("국민은행");
                cb_1.Items.Add("농협은행");
                cb_1.Items.Add("새마을금고");
                cb_1.Items.Add("우체국");
                cb_1.Items.Add("기업은행");
                
            }
        }

        private void bt_pay_Click(object sender, EventArgs e)
        {
            if (rd_1.Checked)
            {

                string selectedCard = cb_1.SelectedItem.ToString();
                MessageBox.Show(selectedCard + "로 " + Profile.Instance.TotalPrice.ToString("C0") + "가 결제되었습니다.");
            }
            else if (rd_2.Checked)
            {
                // rd_2가 선택된 경우 선택된 은행 메시지 박스로 출력
                string selectedBank = cb_1.SelectedItem.ToString();
                MessageBox.Show(selectedBank + "로 " + Profile.Instance.TotalPrice.ToString("C0") + "가 입금되었습니다.");
            }
            MessageBox.Show("주문이 완료되었습니다.");
            this.Close();

        }


    }
}
