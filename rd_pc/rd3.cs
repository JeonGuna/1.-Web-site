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
    public partial class rd3 : Form
    {
        private const int UnitPrice = 2125000;

        public rd3()
        {
            InitializeComponent();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDown1.Value;
            int totalPrice = quantity * UnitPrice;

            Profile.Instance.TotalPrice = totalPrice;
            Profile.Instance.BasePrice = UnitPrice;
            Profile.Instance.Quantity = quantity;
            Profile.Instance.intel1 = lb_name.Text;
            Profile.Instance.image1 = pc_1.Image;

            lb_price.Text = totalPrice.ToString("C0") + "원";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Profile.Instance.TotalPrice == 0)
            {
                MessageBox.Show("구매 수량을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Buy formIntel1 = new Buy();
                formIntel1.Show();
            }
        }
    }
}
