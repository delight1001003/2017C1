using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            //也可以寫成 var x = int.Parse(textBox1.Text); 知道嗎?
            //google一下var關鍵字吧!
            int y = int.Parse(textBox2.Text);
            //如果欄位填入9000000000000000這樣的數字會出錯，
            //可以怎麼避免?
            label1.Text = (x + y).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);            
            //練習一下使用int.TryParse
            //如果想parse成長整數，該怎麼改呢?
            int y = int.Parse(textBox2.Text);
            label1.Text = (x - y).ToString();
        }
    }
}
