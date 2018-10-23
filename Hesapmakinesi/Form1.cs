using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        decimal sayi;

        bool rakam = true;

        string op;


        private void Form1_Load(object sender, EventArgs e)
        {
            txt_hesapalani.ReadOnly = true;
            txt_hesapalani.Text = "0";
        }

        private void butonrenk_mousehover(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.BackColor = Color.LightGray;
        }

        private void butonnr_mouseleft(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.BackColor = Color.White;
        }

        private void buttonnr_mousehover(object sender, EventArgs e)
        {

            Button btn = (sender as Button);
            btn.BackColor = System.Drawing.Color.FromArgb(0, 117, 214);
        }

        private void buttonnr_mouseleft(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            btn.BackColor = Color.LightGray;

        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            txt_gecmis.Text = "";
            
            switch (op)
            {
                case "+":
                  
                    sayi += decimal.Parse(txt_hesapalani.Text);
                    txt_hesapalani.Text = sayi.ToString();
                    break;
                case "/":
                    sayi /= decimal.Parse(txt_hesapalani.Text);
                    txt_hesapalani.Text = sayi.ToString();
                    break;
                case "x":
                    sayi *= decimal.Parse(txt_hesapalani.Text);
                    txt_hesapalani.Text = sayi.ToString();
                    break;
                case "-":
                    sayi -= decimal.Parse(txt_hesapalani.Text);
                    txt_hesapalani.Text = sayi.ToString();
                    break;
                default:
                    break;
            }

        }
        //btn_sil
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_hesapalani.Text.Length > 0)
            {
                txt_hesapalani.Text = txt_hesapalani.Text.Substring(0, txt_hesapalani.Text.Length - 1);
            }
        }
        //btn_cc
        private void button2_Click(object sender, EventArgs e)
        {
            txt_hesapalani.Clear();
            txt_gecmis.Clear();
            sayi = 0;
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_hesapalani.Clear();
        }

        private void btn_virgül_Click(object sender, EventArgs e)
        {
            if (txt_hesapalani.Text.IndexOf(",") <= 0)
            {
                if (txt_hesapalani.Text.Length == 0)
                {
                    txt_hesapalani.Text = "0,";
                }
                else
                {
                    txt_hesapalani.Text = txt_hesapalani.Text + ",";
                }
            }

        }

        private void Btn_carpim_Click(object sender, EventArgs e)
        {
            op = "x";
            if (sayi == 0)
            {
                sayi = decimal.Parse(txt_hesapalani.Text);
                txt_hesapalani.Text = sayi.ToString();
            }

            else
            {
                sayi *= decimal.Parse(txt_hesapalani.Text);
                txt_gecmis.Text += sayi.ToString() + "x";
                txt_hesapalani.Text = sayi.ToString();

            }
            rakam = true;
        }

        private void btn_negatif_Click(object sender, EventArgs e)
        {
            if (txt_hesapalani.Text.Length > 0)
            {
                if (txt_hesapalani.Text.Substring(0, 1) == "-")
                {
                    txt_hesapalani.Text = txt_hesapalani.Text.Substring(1);
                }
                else
                {
                    txt_hesapalani.Text = "-" + txt_hesapalani.Text.Substring(0);
                }
            }
        }

        private void rakamlar(object sender, EventArgs e)
        {
            if (rakam == true)
            {
                txt_hesapalani.Text = (sender as Button).Text;
            }
            else
            {
                txt_hesapalani.Text = txt_hesapalani.Text + (sender as Button).Text;

            }
            rakam = false;
        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {

            op = "+";
            if (txt_hesapalani.Text == "")
            {
                return;
            }

            sayi += decimal.Parse(txt_hesapalani.Text);
            txt_gecmis.Text += sayi.ToString() + "+";
            txt_hesapalani.Text = sayi.ToString();
            rakam = true;
        }

        private void btn_bölme_Click(object sender, EventArgs e)
        {
            op = "/";
            if (sayi == 0)
            {
                sayi = decimal.Parse(txt_hesapalani.Text);
                txt_hesapalani.Text = sayi.ToString();
            }
            else
            {
                sayi /= decimal.Parse(txt_hesapalani.Text);
                txt_hesapalani.Text = sayi.ToString();
            }
            rakam = true;

        }

        private void txt_gecmis_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cikarma_Click(object sender, EventArgs e)
        {
            op = "-";
            if (txt_hesapalani.Text == "")
            {
                return;

            }
            txt_gecmis.Text += sayi.ToString();
            sayi -= decimal.Parse(txt_hesapalani.Text);

            txt_hesapalani.Text = " ";
            txt_hesapalani.Text = sayi.ToString();
            rakam = true;
        }
    }
}
