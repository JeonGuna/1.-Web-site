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
    public partial class test1 : Form
    {
        private login loginForm;
        private bool bt_login_click = false; // 로그인 버튼 클릭 여부를 나타내는 변수

        public test1()
        {
            InitializeComponent();

            // login 폼의 인스턴스를 생성
            loginForm = new login();
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            // 여기서 아이디가 변경될 때의 작업을 수행할 수 있습니다.
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {
            // 여기서 비밀번호가 변경될 때의 작업을 수행할 수 있습니다.
        }

        private void tb_install_Click(object sender, EventArgs e)
        {
            // login.cs에 만들어둔 인폼 불러와서 회원가입 진행하기.
            loginForm.ShowDialog();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            // "로그인" 버튼이 클릭되었을 때 아이디와 비밀번호 비교를 수행.
            // 사용자가 입력한 아이디와 비밀번호 가져오기
            string enteredId = tb_id.Text;
            string enteredPassword = tb_password.Text;

            // login.cs에서 저장된 아이디와 비밀번호 불러와서 비교
            string savedId = loginForm.GetSavedId();
            string savedPassword = loginForm.GetSavedPassword();

            // 아이디와 비밀번호가 일치하는지 확인
            if (enteredId == savedId && enteredPassword == savedPassword)
            {
                bt_login_click = true; // 로그인 버튼이 클릭되었음을 표시
                MessageBox.Show("로그인 성공!");
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bt_login_click) // 로그인 버튼이 클릭되었는지 확인
            {
                MessageBox.Show("G.s Shop에 접속 중입니다.");

                loding lodingForm = new loding();
                lodingForm.ShowDialog();

                website websiteForm = new website();


                websiteForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("로그인을 하세요.");
            }
        }

    }
}



