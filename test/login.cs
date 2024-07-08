using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class login : Form
    {
        private List<User> users = new List<User>();
        private string savedId;
        private string savedPassword;
        private string savedName;
        private string savedEmail;
        private string savedPhone;

        public login()
        {
            InitializeComponent();
        }

        private void bt_enter_Click(object sender, EventArgs e)
        {
            if (rd_agreed.Checked)
            {
                string id = tb_Id1.Text;
                string name = tb_name1.Text;
                string password = tb_Id2.Text;
                string email = tb_mail1.Text + comboBox1.Text;
                string phone = tb_phone.Text;

                Profile.Instance.Name = name;
                Profile.Instance.Email = email;
                Profile.Instance.Phone = phone;

                if (IsInput(id, name, password, email, phone))
                {
                    users.Add(new User(id, name, password, email, phone));
                    savedId = id; // 입력된 아이디를 저장합니다.
                    savedPassword = password; // 입력된 비밀번호를 저장합니다.
                    savedName = name;
                    savedEmail = email;
                    savedPhone = phone;
                    MessageBox.Show("회원가입에 성공하셨습니다.");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("입력된 정보가 유효하지 않거나 빠진 항목이 있습니다.");
                }
            }
            else
            {
                MessageBox.Show("회원가입에 동의하지 않으셨습니다.");
                MessageBox.Show("응모해주세요.");
            }
        }

        private bool IsInput(string id, string name, string password, string email, string phone)
        {
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("모든 항목을 입력해주세요.");
                return false;
            }

            if (id.Length < 2 || id.Length > 8)
                return false;
            if (name.Length < 2)
                return false;
            if (password.Length < 4 || password.Length > 12)
                return false;

            // 이메일에 특수 기호가 있는지 확인
            foreach (char c in email)
            {
                if (!char.IsLetterOrDigit(c) && c != '@' && c != '.')
                {
                    MessageBox.Show("이메일에 특수 기호를 사용할 수 없습니다.");
                    return false;
                }
            }

            // 이메일 콤보박스 선택 확인
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("이메일 도메인을 선택해주세요.");
                return false;
            }

            return true;
        }

        public string GetSavedId()
        {
            // 저장된 아이디를 반환합니다.
            return savedId;
        }

        public string GetSavedPassword()
        {
            // 저장된 비밀번호를 반환합니다.
            return savedPassword;
        }
        public string GetSavedName()
        {
            return savedName;
        }

        public string GetSavedEmail()
        {
            return savedEmail;
        }
        public string GetSavedPhone()
        {
            return savedPhone;
        }

        private class User
        {
            public string Id { get; }
            public string Name { get; }
            public string Password { get; }
            public string Email { get; }
            public string Phone { get; }

            public User(string id, string name, string password, string email, string phone)
            {
                Id = id;
                Name = name;
                Password = password;
                Email = email;
                Phone = phone;
            }
        }

        private void bt_enter2_Click(object sender, EventArgs e)
        {
            if (rd_agreed2.Checked)
            {
                MessageBox.Show("응모에 동의하셨습니다.");
            }
            else if (rd_noagreed2.Checked)
            {
                MessageBox.Show("응모에 동의하지 않으셨습니다.");
            }
            else
            {
                MessageBox.Show("응모 동의 여부를 선택해주세요.");
            }
        }
    }
}

