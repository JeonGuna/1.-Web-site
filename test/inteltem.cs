using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P1
{
    public partial class inteltem : Form
    {
        private decimal totalPrice = 0;

        public inteltem()
        {
            InitializeComponent();
        }

        private void buy_1_Click(object sender, EventArgs e)
        {
            HandleBuyButton(ck_1, lb_1, lb_price1);
        }

        private void buy_2_Click(object sender, EventArgs e)
        {
            HandleBuyButton(ck_2, lb_2, lb_price2);
        }

        private void buy_3_Click(object sender, EventArgs e)
        {
            HandleBuyButton(ck_3, lb_3, lb_price3);
        }

        private void buy_4_Click(object sender, EventArgs e)
        {
            HandleBuyButton(ck_4, lb_4, lb_price4);
        }

        private void buy_5_Click(object sender, EventArgs e)
        {
            HandleBuyButton(ck_5, lb_5, lb_price5);
        }

        private void buy_6_Click(object sender, EventArgs e)
        {
            HandleBuyButton(ck_6, lb_6, lb_price6);
        }

        private void buy_7_Click(object sender, EventArgs e)
        {
            HandleBuyButton(ck_7, lb_7, lb_price7);
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"저장된 카드 정보로 총 {totalPrice:C} 원이 결제되었습니다.");
        }

        private void HandleBuyButton(CheckBox checkBox, Label label, Label priceLabel)
        {
            if (!checkBox.Checked)
            {
                MessageBox.Show("항목을 체크하세요.");
                return;
            }

            string item = label.Text;
            lb_item.Text = item;
            lb_item2.Text = item;

            AddPrice(priceLabel);
        }

        private void AddPrice(Label priceLabel)
        {
            string priceText = priceLabel.Text;

            if (decimal.TryParse(priceText, out decimal price))
            {
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("가격을 파싱할 수 없습니다.");
            }
        }

        private void UpdateTotalPrice()
        {
            lb_price.Text = totalPrice.ToString("C");
        }
    }
}




