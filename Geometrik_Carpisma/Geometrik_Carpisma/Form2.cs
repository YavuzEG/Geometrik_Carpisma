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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ÖDEV_FORM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            float nx = 0, ny = 0, dx = 0, dy = 0, dboy = 0, den = 0;//Değişkenler tanımladım.
            nx = Convert.ToSingle(textBox1.Text);//Textboxdaki değerleri değişkenleri atadım.
            ny = Convert.ToSingle(textBox2.Text);

            dx = Convert.ToSingle(textBox3.Text);
            dy = Convert.ToSingle(textBox4.Text);
            dboy = Convert.ToSingle(textBox6.Text) / 2;
            den = Convert.ToSingle(textBox5.Text) / 2;

            //Çarpışma Kontrolü

            if(ny>dy)
            {
                if(ny<=dy+dboy)
                {
                    if (Math.Abs(nx - dx) >= den)
                        label10.Text = "Çarpışma Var";
                    else
                        label10.Text = "Çarpışma Yok";
                }
                else
                    label10.Text = "Çarpışma Yok";
            }
            else
            {
                if (ny >= dy - dboy)
                {
                    if (Math.Abs(nx - dx) >= den)
                        label10.Text = "Çarpışma Var";
                    else
                        label10.Text = "Çarpışma Yok";
                }
                else
                    label10.Text = "Çarpışma Yok";
            }

            Graphics g =pictureBox1.CreateGraphics();


            //Şekilleri çizdridrdim

            g.FillRectangle(new SolidBrush(Color.Yellow),150+(dx-den)*4,150-(dy+dboy)*4,den*8,dboy*8);
            g.FillEllipse(new SolidBrush(Color.Red), 150+ nx*4, 150 - ny*4,2,2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sildirme butonu komutu
            pictureBox1.Image = null;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";

            }
            label10.Text = "";
        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
