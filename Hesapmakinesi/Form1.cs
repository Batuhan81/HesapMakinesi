using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesapmakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private char islem;
        bool ekrantemizle;
        int sayi;
        int sayi1;
        bool durum = true;
        private void button1_Click(object sender, EventArgs e)
        {
            EkranıTemizle();
            Sonuç.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EkranıTemizle();
            Sonuç.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EkranıTemizle();
            Sonuç.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EkranıTemizle();
            Sonuç.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EkranıTemizle();
            Sonuç.Text += button5.Text;
        }
        public void dolumu()
        {
            if(Sonuç.Text ==" ") 
            { 
                durum= true;
            }
            else if(Sonuç.Text == "")
            {
                durum = true;
            }
            else
            {
                durum=false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EkranıTemizle();
            Sonuç.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EkranıTemizle();
            Sonuç.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EkranıTemizle();
            Sonuç.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EkranıTemizle();
            Sonuç.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            EkranıTemizle();
            Sonuç.Text += button10.Text;
        }

        private void btntopla_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Sonuç.Text))
            {
              
                islem = '+';
                ekrantemizle = true;
                sayi = Convert.ToInt32(Sonuç.Text);
                Sonuç.Text += btntopla.Text;
            }
            else
            {
                MessageBox.Show("Hesaplanacak veri bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void EkranıTemizle()
        {
            if(ekrantemizle)
            {
                Sonuç.Text = "";
            }
            ekrantemizle = false;
        }

        private void btnçıkar_Click(object sender, EventArgs e)
        {
            dolumu();
            if (durum == true)
            {
                MessageBox.Show("Çıkartabilecek veri Girin");
            }
            else
            {
                
                islem = '-';
                ekrantemizle = true;
                sayi = Convert.ToInt32(Sonuç.Text);
                Sonuç.Text += btnçıkar.Text;
                ekrantemizle = true;
            }
        }

        private void btnçarp_Click(object sender, EventArgs e)
        {
            dolumu();
            if (durum == true)
            {
                MessageBox.Show("Çarpılacak veri Girin");
            }
            else
            {
               
                islem = '*';
                ekrantemizle = true;
                sayi = Convert.ToInt32(Sonuç.Text);
                Sonuç.Text += btnçarp.Text;
                ekrantemizle = true;
            }
        }

        private void btnböl_Click(object sender, EventArgs e)
        {
            dolumu();
            if (durum == true)
            {
                MessageBox.Show("Bölünebilecek veri girin");
            }
            else
            {
                
                islem = '/';
                ekrantemizle = true;
             
                sayi = Convert.ToInt32(Sonuç.Text);
                Sonuç.Text += btnböl.Text;
                ekrantemizle = true;
            }
        }

        private void btnsil_Click_1(object sender, EventArgs e)
        { 
            if (Sonuç.Text == " ")
            {
                MessageBox.Show("Silinecek Veri Bulunamadı", "Uyarı !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Sonuç.Text = " ";
            sayi = 0;
        }

        private void eşittir_Click(object sender, EventArgs e)
        {
            Eşitlik();
            
        }
        int sayi2 = 1;
      
       
        private void Eşitlik()
        {
            if (!string.IsNullOrWhiteSpace(Sonuç.Text))
            {
                sayi2 = Convert.ToInt32(Sonuç.Text);
                int sonuç;
                switch (islem)
                {
                    case '+':
                        sonuç = sayi + sayi2;
                        Sonuç.Text = sonuç.ToString();
                        break;
                    case '-':
                        sonuç = sayi - sayi2;
                        Sonuç.Text = sonuç.ToString();
                        break;
                    case '*':
                        sonuç = sayi * sayi2;
                        Sonuç.Text = sonuç.ToString();
                        break;
                    case '/':
                        if (sayi2 != 0)
                        {
                            sonuç = sayi / sayi2;
                            Sonuç.Text = sonuç.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Sıfıra bölme hatası!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Hesaplanacak veri mi bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
