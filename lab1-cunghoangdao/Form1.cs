using System;
using System.Windows.Forms;

namespace lab1_cunghoangdao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            submit.Click += submit_click;

        }

        private void submit_click(object sender, EventArgs e)
        {
            DateTime date;

            // Kiểm tra xem có nhập ngày hợp lệ không
            if (!DateTime.TryParse(textBox1.Text, out date))
            {
                MessageBox.Show("Vui lòng nhập ngày hợp lệ!","Error");
                return;
            }

            string zodiacSign = GetZodiacSign(date);
            MessageBox.Show(zodiacSign,"Cung hoàng đạo của bạn");
        }

        private string GetZodiacSign(DateTime date)
        {
            int day = date.Day;
            int month = date.Month;

            // Kiểm tra cung hoàng đạo dựa theo tháng và ngày
            if ((month == 3 && day >= 21) || (month == 4 && day <= 19))
                return "Bạch Dương";
            else if ((month == 4 && day >= 20) || (month == 5 && day <= 20))
                return "Kim Ngưu";
            else if ((month == 5 && day >= 21) || (month == 6 && day <= 20))
                return "Song Tử";
            else if ((month == 6 && day >= 21) || (month == 7 && day <= 22))
                return "Cự Giải";
            else if ((month == 7 && day >= 23) || (month == 8 && day <= 22))
                return "Sư Tử";
            else if ((month == 8 && day >= 23) || (month == 9 && day <= 22))
                return "Xử Nữ";
            else if ((month == 9 && day >= 23) || (month == 10 && day <= 22))
                return "Thiên Bình";
            else if ((month == 10 && day >= 23) || (month == 11 && day <= 21))
                return "Bọ Cạp";
            else if ((month == 11 && day >= 22) || (month == 12 && day <= 21))
                return "Nhân Mã";
            else if ((month == 12 && day >= 22) || (month == 1 && day <= 19))
                return "Ma Kết";
            else if ((month == 1 && day >= 20) || (month == 2 && day <= 18))
                return "Bảo Bình";
            else if ((month == 2 && day >= 19) || (month == 3 && day <= 20))
                return "Song Ngư";
            else
                return "Không xác định";
        }

    }
}
