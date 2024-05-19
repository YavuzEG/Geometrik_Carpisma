/****************************************************************************
**                          SAKARYA ÜNİVERSİTESİ
**              BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                  BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                   PROGRAMLAMAYA GİRİŞİ DERSİ
**
**                       ÖDEV NUMARASI : 1
**                       ÖĞRENCİ ADI : Yavuz Emre Gündüz
**                       ÖĞRENCİ NUMARASI : B221210071
**                       DERS GRUBU :  A
**                       YOUTUBE LİNKİ : https://youtu.be/ZyMNOZTj1So
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ÖDEV_FORM
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float d1x = 0, d1y = 0, d2x = 0, d1en = 0, d1boy = 0, d2y = 0, d2boy = 0, d2en = 0;//Değişken tanımladım

            d1x = Convert.ToSingle(textBox3.Text);//Textboxdaki değeleri değişkenlere atadım.
            d1y = Convert.ToSingle(textBox4.Text);
            d1en = Convert.ToSingle(textBox5.Text) / 2;
            d1boy = Convert.ToSingle(textBox6.Text) / 2;

            d2x = Convert.ToSingle(textBox8.Text);
            d2y = Convert.ToSingle(textBox7.Text);
            d2boy = Convert.ToSingle(textBox1.Text) / 2;
            d2en = Convert.ToSingle(textBox2.Text) / 2;

            //Çrpışma Kontrolü

            if(d1y< d2y)
            {
                if(d1y+d1boy>=d2y-d2boy)
                {
                    if (Math.Abs(d1x - d2x) <= d1en + d2en)
                        label13.Text = "Çarpışma Var";
                    else
                        label13.Text = "Çarpışma Yok";

                }
                else
                    label13.Text = "Çarpışma Yok";
            }
            else
            {
                if (d1y - d1boy <= d2y + d2boy)
                {
                    if (Math.Abs(d1x - d2x) <= d1en + d2en)
                        label13.Text = "Çarpışma Var";
                    else
                        label13.Text = "Çarpışma Yok";

                }
                else
                    label13.Text = "Çarpışma Yok";
            }

            Graphics g = pictureBox1.CreateGraphics();


            //Şekilleri çizdridrdim
            g.FillRectangle(new SolidBrush(Color.Red), 150 + (d1x - d1en) * 4, 150 - (d1y + d1boy) * 4, d1en * 8, d1boy * 8);
            g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (d2x - d2en) * 4, 150 - (d2y + d2boy) * 4, d2en * 8, d2boy * 8);
        }


        private void button2_Click_1(object sender, EventArgs e)
        {           

            //Sildirme butonu komutu
            pictureBox1.Image = null;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";

            }
            label13.Text = "";
        

        }
    } 
}

        
