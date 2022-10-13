using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captchachar
{
    public partial class Form1 : Form
    {

        private Random random = new Random();
        private string captcha = "";
        internal void UpdateCaptcha()
        {
            string captcha = "";
            for (int i = 0; i < random.Next(6, 10); i++)
            {
                if (random.Next(2) % 2 == 0)
                {
                    captcha += char.ConvertFromUtf32(random.Next(65, 91));
                    continue;
                }
                captcha += random.Next(0, 10).ToString();
            }
            this.captcha = captcha;
            LblCaptcha.Text = captcha;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateCaptcha();
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void Txt_Cptch(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == captcha)
            {
                MessageBox.Show("Captcha is correct!", "Entering", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Captcha is not correct!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            UpdateCaptcha();
            textBox1.Text = "";
            textBox1.Focus();
        }

        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            UpdateCaptcha();
        }
    }
}
