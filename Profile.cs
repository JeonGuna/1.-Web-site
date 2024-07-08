using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Profile
    {
        private static Profile instance;

        // 프로필 정보
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int TotalPrice { get; set; } // 종합 가격
        public int BasePrice { get; set; }  // 기본 가격
        public int Quantity { get; set; }   // 수량
        public string intel1 { get; set; }
        public Image image1 { get; set; }

        private Profile() { }

        public static Profile Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Profile();
                }
                return instance;
            }
        }
    }
}




