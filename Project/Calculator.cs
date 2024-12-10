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
        public Calculator()
        {
            InitializeComponent();
        }
        //khai bao bien
        float data1, data2, ketqua;
        string pheptinh;
        bool isNegative = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e) //nut 0
        {
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
            if (isNegative && manhinhduoi.Text.Length == 0)
            {
                manhinhduoi.Text = "-9";
            }
            else
            {
                manhinhduoi.Text = manhinhduoi.Text + "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)//nut cong
        {
            if (manhinhduoi.Text.Length > 0)
            {
                pheptinh = "cong";
                data1 = float.Parse(manhinhduoi.Text);

                manhinhtren.Text = data1.ToString() + " +";
                manhinhduoi.Clear();
                isNegative = false;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(manhinhduoi.Text) || string.IsNullOrEmpty(pheptinh))
            {
                return;
            }

            switch (pheptinh)
            {
                case "cong":
                    data2 = data1 + float.Parse(manhinhduoi.Text);
                    //them vao listbox
                    lstHistory.Items.Add(data1.ToString() + " + " + (float.Parse(manhinhduoi.Text)) + " = " + data2.ToString());
                    //hien thi phep tinh o man hinh tren
                    manhinhtren.Text = data1.ToString() + " + " + float.Parse(manhinhduoi.Text) + " =";
                    manhinhduoi.Text = data2.ToString();


                    break;
                case "tru":
                    data2 = data1 - float.Parse(manhinhduoi.Text);
                    //them vao listbox
                    lstHistory.Items.Add(data1.ToString() + " - " + (float.Parse(manhinhduoi.Text)) + " = " + data2.ToString());
                    //hien thi phep tinh o man hinh tren
                    manhinhtren.Text = data1.ToString() + " - " + float.Parse(manhinhduoi.Text) + " =";
                    manhinhduoi.Text = data2.ToString();
                    break;
                case "nhan":
                    data2 = data1 * float.Parse(manhinhduoi.Text);
                    //them vao listbox
                    lstHistory.Items.Add(data1.ToString() + " * " + (float.Parse(manhinhduoi.Text)) + " = " + data2.ToString());
                    //hien thi phep tinh o man hinh tren
                    manhinhtren.Text = data1.ToString() + " x " + float.Parse(manhinhduoi.Text) + " =";
                    manhinhduoi.Text = data2.ToString();
                    break;
                case "chia":
                    if (float.Parse(manhinhduoi.Text) == 0)
                    {
                        manhinhloi.Text = "không chia được với số 0";
                        //hien thi phep tinh o man hinh tren
                        manhinhtren.Text = data1.ToString() + " / " + float.Parse(manhinhduoi.Text) + " =";
                    }
                    else
                    {
                        data2 = data1 / float.Parse(manhinhduoi.Text);
                        //them vao listbox
                        lstHistory.Items.Add(data1.ToString() + " / " + (float.Parse(manhinhduoi.Text)) + " = " + data2.ToString());
                        //hien thi phep tinh o man hinh tren
                        manhinhtren.Text = data1.ToString() + " / " + float.Parse(manhinhduoi.Text) + " =";
                        manhinhduoi.Text = data2.ToString();
                    }
                    break;
                case "x^y":
                    data2 = (float)Math.Pow(data1, float.Parse(manhinhduoi.Text));
                    //them vao listbox
                    lstHistory.Items.Add(data1.ToString() + " ^ " + (float.Parse(manhinhduoi.Text)) + " = " + data2.ToString());
                    //hien thi phep tinh o man hinh tren
                    manhinhtren.Text = data1.ToString() + " ^ " + float.Parse(manhinhduoi.Text) + " =";
                    manhinhduoi.Text = data2.ToString();
                    break;
                default:
                    // khong khop voi truong hop nao thi thoat 
                    break;
            }
            isNegative = false;
        }

        private void button15_Click(object sender, EventArgs e)//nut tru
        {
            if (manhinhduoi.Text.Length > 0)
            {
                pheptinh = "tru";
                data1 = float.Parse(manhinhduoi.Text);
                manhinhtren.Text = data1.ToString() + " -";
                manhinhduoi.Clear();
                isNegative = false;
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
                pheptinh = "nhan";
                data1 = float.Parse(manhinhduoi.Text);
                manhinhtren.Text = data1.ToString() + " x";
                manhinhduoi.Clear();
                isNegative = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)//nut chia
        {
            if (manhinhduoi.Text.Length > 0)
            {
                pheptinh = "chia";
                data1 = float.Parse(manhinhduoi.Text);
                manhinhtren.Text = data1.ToString() + " /";
                manhinhduoi.Clear();
                isNegative = false;
            }

        }

        private void button17_Click(object sender, EventArgs e)//nut x^y
        {
            if (manhinhduoi.Text.Length > 0)
            {
                pheptinh = "x^y";
                data1 = float.Parse(manhinhduoi.Text);
                manhinhtren.Text = data1.ToString() + " ^";
                manhinhduoi.Clear();
                isNegative = false;
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

                data1 = float.Parse(manhinhduoi.Text);
                data2 = (float)Math.Pow(data1, 2);
                //them vao listbox
                lstHistory.Items.Add(data1.ToString() + " ^2 " + " = " + data2.ToString());
                manhinhtren.Text = data1.ToString() + "^2 =";
                manhinhduoi.Text = data2.ToString();
            }
        }

        private void button23_Click(object sender, EventArgs e)//nut C
        {
            manhinhduoi.Clear();
            manhinhtren.Clear();
            manhinhloi.Clear();
            pheptinh = "";
            data1 = 0;
            data2 = 0;
            isNegative = false;
        }

        private void button19_Click(object sender, EventArgs e)//nut can bac 2
        {
            if (manhinhduoi.Text.Length > 0)
            {
                data1 = float.Parse(manhinhduoi.Text);
                if (data1 >= 0)
                {
                    data2 = (float)Math.Sqrt(data1);
                    //them vao listbox
                    lstHistory.Items.Add(" √" + data1.ToString() +" = "+ data2.ToString());
                    manhinhtren.Text = "√" + data1.ToString() + " =";
                    manhinhduoi.Text = data2.ToString();
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
                manhinhduoi.Text = manhinhduoi.Text.Remove(manhinhduoi.Text.Length - 1);
            }
        }

        private void button21_Click(object sender, EventArgs e)//nut %
        {
            if (manhinhduoi.Text.Length > 0)
            {
                // neu dang hien % thi chuyen ve decimal
                if (manhinhduoi.Text.EndsWith("%"))
                {
                    string numStr = manhinhduoi.Text.TrimEnd('%');
                    data1 = float.Parse(numStr) / 100;
                    manhinhtren.Text = numStr + "% to dec =";
                    manhinhduoi.Text = data1.ToString();
                }
                // chua hien % thi chuyen sang %
                else
                {
                    data1 = float.Parse(manhinhduoi.Text);
                    data2 = data1 * 100;
                    manhinhtren.Text = data1.ToString() + " to % =";
                    manhinhduoi.Text = data2.ToString() + "%";
                }
            }
        }





        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!manhinhduoi.Text.Contains("."))
            {
                manhinhduoi.Text = manhinhduoi.Text + ".";
            }
        }


        private void button22_Click(object sender, EventArgs e)
        {
            if (manhinhduoi.Text.Length > 0)
            {
                data1 = float.Parse(manhinhduoi.Text);
                if (data1 != 0)
                {
                    data2 = 1 / data1;
                    manhinhtren.Text = "1/" + data1.ToString() + " =";
                    manhinhduoi.Text = data2.ToString();
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
