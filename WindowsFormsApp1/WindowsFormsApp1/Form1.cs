using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int startstar, purposestar;
        int have_memorypice;
        int Goddess_jewelry = 0;
        int memorypiece = 0;
        int max_memorypiece;
        int jewlrycost = 1;

        public Form1()
        {
            InitializeComponent();

            
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }        

        private void checkbutton_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (startstar > 4)
                {
                    MessageBox.Show("현재별이 4보다 클 수 없습니다.");
                    startstarlevel.Clear();
                    wantstarlevel.Clear();
                    break;
                }
                else if (purposestar > 5)
                {
                    MessageBox.Show("달성한 별이 5보다 클 수 없습니다.");
                    startstarlevel.Clear();
                    wantstarlevel.Clear();
                    break;
                }
                else
                {
                    break;
                }
            }

                if (startstar <= 4 || purposestar <= 5)
                {
                    switch (startstar)
                    {
                        case 1:
                            max_memorypiece = 30;
                            break;
                        case 2: // 2→3
                            max_memorypiece = 100;
                            break;
                        case 3: // 3→4
                            max_memorypiece = 120;
                            break;
                        case 4: //4→5
                            max_memorypiece = 150;
                            jewlrycost = 5;
                            break;
                    }
                }

                while (memorypiece < max_memorypiece)
                {
                    memorypiece++;
                    Goddess_jewelry++;
                    if (memorypiece > 20)
                    {
                        Goddess_jewelry++;
                        if (memorypiece > 40)
                        {
                            Goddess_jewelry++;
                            if (memorypiece > 60)
                            {
                                Goddess_jewelry++;
                                if (memorypiece > 80)
                                {
                                    Goddess_jewelry++;
                                }
                            }
                        }
                    }
                }
                
            
            textBox2.Text = "필요한 여신의보석 갯수 : " + Goddess_jewelry + Environment.NewLine + "필요한 메모리피스 : " + memorypiece;
            
        }

        private void startstarlevel_TextChanged(object sender, EventArgs e)
        {
            string text1 = startstarlevel.Text;
            startstar = Int32.Parse(text1);

        }

        private void wantstarlevel_TextChanged(object sender, EventArgs e)
        {
            string text2 = wantstarlevel.Text;
            purposestar = Int32.Parse(text2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (typeof(System.Windows.Forms.TextBox) == ctl.GetType())
                {
                    ctl.Text = string.Empty;
                    Goddess_jewelry = 0;
                    memorypiece = 0;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void startstarlevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
                MessageBox.Show("숫자만 입력해주세요.");
            }
        }
    }
}
