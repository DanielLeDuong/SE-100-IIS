using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Calculator : Form
    {
        // Hàm khởi tạo - Khởi tạo các thành phần của form
        public Calculator()
        {
            InitializeComponent();
        }
        //khai bao bien
        float data1, data2, ketqua; // Biến lưu trữ các số và kết quả
        string pheptinh; // Biến lưu loại phép tính (+,-,*,/,...)
        bool isNegative = false; // Cờ đánh dấu số âm
        bool isNewCalculation = true; // Cờ đánh dấu phép tính mới
        bool isFirstCalculation = true; // Cờ đánh dấu phép tính đầu tiên
        bool hasDecimalPoint = false; // Cờ đánh dấu đã có dấu thập phân

        // Hàm xử lý sự kiện khi form được tải
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Hàm xử lý sự kiện khi nhấn các nút số (0-9)
        // Thuật toán: 
        // - Nếu là phép tính mới thì xóa màn hình
        // - Nếu là số âm và màn hình trống thì thêm dấu trừ
        // - Thêm số vào cuối chuỗi hiển thị
        private void button8_Click(object sender, EventArgs e) //nut 0
        {
            if (isNewCalculation)
            {
                manhinhduoi.Clear();
                isNewCalculation = false;
            }
            if (isNegative && manhinhduoi.Text.Length == 0)
            {
                manhinhduoi.Text = "-0";
            }
            else
            {
                manhinhduoi.Text = manhinhduoi.Text + "0";
            }
        }

        private void button3_Click(object sender, EventArgs e) //nut 1
        {
            if (isNewCalculation)
            {
                manhinhduoi.Clear();
                isNewCalculation = false;
            }
            if (isNegative && manhinhduoi.Text.Length == 0)
            {
                manhinhduoi.Text = "-1";
            }
            else
            {
                manhinhduoi.Text = manhinhduoi.Text + "1";
            }
        }

        private void button7_Click(object sender, EventArgs e)//nut2
        {
            if (isNewCalculation)
            {
                manhinhduoi.Clear();
                isNewCalculation = false;
            }
            if (isNegative && manhinhduoi.Text.Length == 0)
            {
                manhinhduoi.Text = "-2";
            }
            else
            {
                manhinhduoi.Text = manhinhduoi.Text + "2";
            }
        }

        private void button11_Click(object sender, EventArgs e)//nut 3
        {
            if (isNewCalculation)
            {
                manhinhduoi.Clear();
                isNewCalculation = false;
            }
            if (isNegative && manhinhduoi.Text.Length == 0)
            {
                manhinhduoi.Text = "-3";
            }
            else
            {
                manhinhduoi.Text = manhinhduoi.Text + "3";
            }
        }

        private void button2_Click(object sender, EventArgs e) //nut 4
        {
            if (isNewCalculation)
            {
                manhinhduoi.Clear();
                isNewCalculation = false;
            }
            if (isNegative && manhinhduoi.Text.Length == 0)
            {
                manhinhduoi.Text = "-4";
            }
            else
            {
                manhinhduoi.Text = manhinhduoi.Text + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)//nut 5
        {
            if (isNewCalculation)
            {
                manhinhduoi.Clear();
                isNewCalculation = false;
            }
            if (isNegative && manhinhduoi.Text.Length == 0)
            {
                manhinhduoi.Text = "-5";
            }
            else
            {
                manhinhduoi.Text = manhinhduoi.Text + "5";
            }
        }

        private void button10_Click(object sender, EventArgs e)//nut 6
        {
            if (isNewCalculation)
            {
                manhinhduoi.Clear();
                isNewCalculation = false;
            }
            if (isNegative && manhinhduoi.Text.Length == 0)
            {
                manhinhduoi.Text = "-6";
            }
            else
            {
                manhinhduoi.Text = manhinhduoi.Text + "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)//nut7
        {
            if (isNewCalculation)
            {
                manhinhduoi.Clear();
                isNewCalculation = false;
            }
            if (isNegative && manhinhduoi.Text.Length == 0)
            {
                manhinhduoi.Text = "-7";
            }
            else
            {
                manhinhduoi.Text = manhinhduoi.Text + "7";
            }
        }

        private void button5_Click(object sender, EventArgs e)//nut 8
        {
            if (isNewCalculation)
            {
                manhinhduoi.Clear();
                isNewCalculation = false;
            }
            if (isNegative && manhinhduoi.Text.Length == 0)
            {
                manhinhduoi.Text = "-8";
            }
            else
            {
                manhinhduoi.Text = manhinhduoi.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)//nut 9
        {
            if (isNewCalculation)
            {
                manhinhduoi.Clear();
                isNewCalculation = false;
            }
            if (isNegative && manhinhduoi.Text.Length == 0)
            {
                manhinhduoi.Text = "-9";
            }
            else
            {
                manhinhduoi.Text = manhinhduoi.Text + "9";
            }
        }

        // Hàm xử lý các phép toán (+,-,*,/)
        // Thuật toán:
        // - Lưu số đầu tiên vào data1
        // - Lưu loại phép tính
        // - Hiển thị lên màn hình trên
        // - Reset các cờ
        private void button14_Click(object sender, EventArgs e)//nut cong
        {
            if (manhinhduoi.Text.Length > 0)
            {
                if (!isFirstCalculation)
                {
                    CalculateResult();
                }
                pheptinh = "cong";
                data1 = float.Parse(manhinhduoi.Text.TrimEnd('%'));
                manhinhtren.Text = data1.ToString() + " +";
                manhinhduoi.Clear();
                isNegative = false;
                isNewCalculation = false;
                isFirstCalculation = false;
                hasDecimalPoint = false;
            }
        }

        // Hàm tính toán kết quả
        // Thuật toán:
        // - Kiểm tra phép tính
        // - Thực hiện phép tính tương ứng giữa data1 và số trên màn hình
        // - Hiển thị kết quả
        private void CalculateResult()
        {
            if (string.IsNullOrEmpty(manhinhduoi.Text) || string.IsNullOrEmpty(pheptinh))
            {
                return;
            }

            float secondNumber = float.Parse(manhinhduoi.Text.TrimEnd('%'));
            bool isPercent = manhinhduoi.Text.EndsWith("%");

            switch (pheptinh)
            {
                case "cong":
                    if (isPercent)
                    {
                        data1 = data1 + (data1 * secondNumber / 100);
                    }
                    else
                    {
                        data1 = data1 + secondNumber;
                    }
                    break;
                case "tru":
                    if (isPercent)
                    {
                        data1 = data1 - (data1 * secondNumber / 100);
                    }
                    else
                    {
                        data1 = data1 - secondNumber;
                    }
                    break;
                case "nhan":
                    if (isPercent)
                    {
                        data1 = data1 * (secondNumber / 100);
                    }
                    else
                    {
                        data1 = data1 * secondNumber;
                    }
                    break;
                case "chia":
                    if (secondNumber == 0)
                    {
                        manhinhloi.Text = "không chia được với số 0";
                        return;
                    }
                    if (isPercent)
                    {
                        data1 = data1 / (secondNumber / 100);
                    }
                    else
                    {
                        data1 = data1 / secondNumber;
                    }
                    break;
                case "x^y":
                    data1 = (float)Math.Pow(data1, secondNumber);
                    break;
                case "phantram":
                    data1 = data1 * secondNumber / 100;
                    break;
            }
            manhinhduoi.Text = data1.ToString();
        }

        // Hàm xử lý nút bằng
        // Thuật toán:
        // - Tính kết quả cuối cùng
        // - Thêm phép tính vào lịch sử
        // - Reset các cờ
        private void button16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(manhinhduoi.Text) || string.IsNullOrEmpty(pheptinh))
            {
                return;
            }

            float lastNumber = float.Parse(manhinhduoi.Text.TrimEnd('%'));
            bool isPercent = manhinhduoi.Text.EndsWith("%");
            data2 = data1;
            CalculateResult();

            // Add final calculation to history
            switch (pheptinh)
            {
                case "cong":
                    if (isPercent)
                    {
                        lstHistory.Items.Add(data2.ToString() + " + " + lastNumber + "% = " + data1.ToString());
                        manhinhtren.Text = data2.ToString() + " + " + lastNumber + "% =";
                    }
                    else
                    {
                        lstHistory.Items.Add(data2.ToString() + " + " + lastNumber + " = " + data1.ToString());
                        manhinhtren.Text = data2.ToString() + " + " + lastNumber + " =";
                    }
                    break;
                case "tru":
                    if (isPercent)
                    {
                        lstHistory.Items.Add(data2.ToString() + " - " + lastNumber + "% = " + data1.ToString());
                        manhinhtren.Text = data2.ToString() + " - " + lastNumber + "% =";
                    }
                    else
                    {
                        lstHistory.Items.Add(data2.ToString() + " - " + lastNumber + " = " + data1.ToString());
                        manhinhtren.Text = data2.ToString() + " - " + lastNumber + " =";
                    }
                    break;
                case "nhan":
                    if (isPercent)
                    {
                        lstHistory.Items.Add(data2.ToString() + " * " + lastNumber + "% = " + data1.ToString());
                        manhinhtren.Text = data2.ToString() + " x " + lastNumber + "% =";
                    }
                    else
                    {
                        lstHistory.Items.Add(data2.ToString() + " * " + lastNumber + " = " + data1.ToString());
                        manhinhtren.Text = data2.ToString() + " x " + lastNumber + " =";
                    }
                    break;
                case "chia":
                    if (lastNumber != 0)
                    {
                        if (isPercent)
                        {
                            lstHistory.Items.Add(data2.ToString() + " / " + lastNumber + "% = " + data1.ToString());
                            manhinhtren.Text = data2.ToString() + " / " + lastNumber + "% =";
                        }
                        else
                        {
                            lstHistory.Items.Add(data2.ToString() + " / " + lastNumber + " = " + data1.ToString());
                            manhinhtren.Text = data2.ToString() + " / " + lastNumber + " =";
                        }
                    }
                    break;
                case "x^y":
                    lstHistory.Items.Add(data2.ToString() + " ^ " + lastNumber + " = " + data1.ToString());
                    manhinhtren.Text = data2.ToString() + " ^ " + lastNumber + " =";
                    break;
                case "phantram":
                    lstHistory.Items.Add(data2.ToString() + " % of " + lastNumber + " = " + data1.ToString());
                    manhinhtren.Text = data2.ToString() + " % of " + lastNumber + " =";
                    break;
            }

            isNegative = false;
            isNewCalculation = true;
            isFirstCalculation = true;
            hasDecimalPoint = false;
        }

        private void button15_Click(object sender, EventArgs e)//nut tru
        {
            if (manhinhduoi.Text.Length > 0)
            {
                if (!isFirstCalculation)
                {
                    CalculateResult();
                }
                pheptinh = "tru";
                data1 = float.Parse(manhinhduoi.Text.TrimEnd('%'));
                manhinhtren.Text = data1.ToString() + " -";
                manhinhduoi.Clear();
                isNegative = false;
                isNewCalculation = false;
                isFirstCalculation = false;
                hasDecimalPoint = false;
            }
            else
            {
                isNegative = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)//nut nhan
        {
            if (manhinhduoi.Text.Length > 0)
            {
                if (!isFirstCalculation)
                {
                    CalculateResult();
                }
                pheptinh = "nhan";
                data1 = float.Parse(manhinhduoi.Text.TrimEnd('%'));
                manhinhtren.Text = data1.ToString() + " x";
                manhinhduoi.Clear();
                isNegative = false;
                isNewCalculation = false;
                isFirstCalculation = false;
                hasDecimalPoint = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)//nut chia
        {
            if (manhinhduoi.Text.Length > 0)
            {
                if (!isFirstCalculation)
                {
                    CalculateResult();
                }
                pheptinh = "chia";
                data1 = float.Parse(manhinhduoi.Text.TrimEnd('%'));
                manhinhtren.Text = data1.ToString() + " /";
                manhinhduoi.Clear();
                isNegative = false;
                isNewCalculation = false;
                isFirstCalculation = false;
                hasDecimalPoint = false;
            }
        }

        // Hàm xử lý các phép toán đặc biệt (x^y, x^2, √x, 1/x)
        // Thuật toán:
        // - Lấy số từ màn hình
        // - Thực hiện phép tính
        // - Hiển thị kết quả và thêm vào lịch sử
        private void button17_Click(object sender, EventArgs e)//nut x^y
        {
            if (manhinhduoi.Text.Length > 0)
            {
                if (!isFirstCalculation)
                {
                    CalculateResult();
                }
                pheptinh = "x^y";
                data1 = float.Parse(manhinhduoi.Text.TrimEnd('%'));
                manhinhtren.Text = data1.ToString() + " ^";
                manhinhduoi.Clear();
                isNegative = false;
                isNewCalculation = false;
                isFirstCalculation = false;
                hasDecimalPoint = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)//nut +/- de doi dau ketqua
        {
            if (data2 == 0)
            {
                manhinhloi.Text = "thuc hien phep tinh truoc";
            }
            else
            {
                data2 = -data2;
                ketqua = data2;
                manhinhduoi.Text = ketqua.ToString();
            }

        }

        private void button18_Click(object sender, EventArgs e)//nut x^2
        {
            if (manhinhduoi.Text.Length > 0)
            {

                data1 = float.Parse(manhinhduoi.Text.TrimEnd('%'));
                data2 = (float)Math.Pow(data1, 2);
                //them vao listbox
                lstHistory.Items.Add(data1.ToString() + " ^2 " + " = " + data2.ToString());
                manhinhtren.Text = data1.ToString() + "^2 =";
                manhinhduoi.Text = data2.ToString();
                isNewCalculation = true;
                hasDecimalPoint = false;
            }
        }

        // Hàm xử lý các nút điều khiển (C, CE, ←)
        // Thuật toán:
        // - C: Xóa tất cả và reset về ban đầu
        // - ←: Xóa ký tự cuối cùng
        private void button23_Click(object sender, EventArgs e)//nut C
        {
            manhinhduoi.Clear();
            manhinhtren.Clear();
            manhinhloi.Clear();
            pheptinh = "";
            data1 = 0;
            data2 = 0;
            isNegative = false;
            isNewCalculation = false;
            isFirstCalculation = true;
            hasDecimalPoint = false;
        }

        private void button19_Click(object sender, EventArgs e)//nut can bac 2
        {
            if (manhinhduoi.Text.Length > 0)
            {
                data1 = float.Parse(manhinhduoi.Text.TrimEnd('%'));
                if (data1 >= 0)
                {
                    data2 = (float)Math.Sqrt(data1);
                    //them vao listbox
                    lstHistory.Items.Add(" √" + data1.ToString() +" = "+ data2.ToString());
                    manhinhtren.Text = "√" + data1.ToString() + " =";
                    manhinhduoi.Text = data2.ToString();
                    isNewCalculation = true;
                    hasDecimalPoint = false;
                }
                else
                {
                    manhinhloi.Text = "khong can bac hai voi so nho hon 0";
                    manhinhduoi.Clear();
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)// nut xoa 1 gia tri
        {
            if (manhinhduoi.Text.Length > 0)
            {
                if (manhinhduoi.Text[manhinhduoi.Text.Length - 1] == '.')
                {
                    hasDecimalPoint = false;
                }
                manhinhduoi.Text = manhinhduoi.Text.Remove(manhinhduoi.Text.Length - 1);
            }
        }

        // Hàm xử lý nút phần trăm
        // Thuật toán:
        // - Nếu là phép tính mới thì xóa màn hình
        // - Chuyển số hiện tại thành dạng phần trăm
        private void button21_Click(object sender, EventArgs e)//nut %
        {
            if (manhinhduoi.Text.Length > 0 && !manhinhduoi.Text.EndsWith("%"))
            {
                float currentNumber = float.Parse(manhinhduoi.Text);
                currentNumber = currentNumber / 100;
                manhinhduoi.Text = currentNumber.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Hàm xử lý nút xóa lịch sử
        private void button25_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
        }

        // Hàm xử lý nút thập phân
        // Thuật toán: Thêm dấu thập phân nếu chưa có
        private void button12_Click(object sender, EventArgs e)
        {
            if (!hasDecimalPoint && !manhinhduoi.Text.Contains("."))
            {
                if (manhinhduoi.Text.Length == 0)
                {
                    manhinhduoi.Text = "0.";
                }
                else
                {
                    manhinhduoi.Text = manhinhduoi.Text + ".";
                }
                hasDecimalPoint = true;
            }
        }

        // Hàm xử lý nút nghịch đảo (1/x)
        // Thuật toán:
        // - Kiểm tra số khác 0
        // - Tính nghịch đảo và hiển thị
        private void button22_Click(object sender, EventArgs e)
        {
            if (manhinhduoi.Text.Length > 0)
            {
                data1 = float.Parse(manhinhduoi.Text.TrimEnd('%'));
                if (data1 != 0)
                {
                    data2 = 1 / data1;
                    manhinhtren.Text = "1/" + data1.ToString() + " =";
                    manhinhduoi.Text = data2.ToString();
                    isNewCalculation = true;
                    hasDecimalPoint = false;
                }
                else
                {
                    manhinhloi.Text = "khong chia duoc cho so 0";
                    manhinhduoi.Clear();
                }
            }
        }

    }
}
