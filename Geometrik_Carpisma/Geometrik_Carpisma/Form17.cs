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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float d1x = 0, d2x = 0, d1y = 0, d2y = 0, d1z = 0, d2z = 0, d1xuzun, d2xuzun, d1yuzun, d2yuzun, d1zuzun, d2zuzun;//Değişken Tanımladım

            d1x = Convert.ToSingle(textBox5.Text);//Textboxdaki değerleri değişkenlre atadım.
            d1y = Convert.ToSingle(textBox12.Text);
            d1z = Convert.ToSingle(textBox4.Text);
            d1xuzun = Convert.ToSingle(textBox11.Text);
            d1yuzun = Convert.ToSingle(textBox6.Text);
            d1zuzun = Convert.ToSingle(textBox3.Text);

            d2x = Convert.ToSingle(textBox8.Text);
            d2y = Convert.ToSingle(textBox10.Text);
            d2z = Convert.ToSingle(textBox1.Text);
            d2xuzun = Convert.ToSingle(textBox7.Text);
            d2yuzun = Convert.ToSingle(textBox2.Text);
            d2zuzun = Convert.ToSingle(textBox9.Text);


            //Çarpışma Kontrolü

            if (d1y < d2y)
            {
                if (d1z < d2z)
                {
                    if (d2y - d2yuzun<= d1y + d1yuzun)
                    {
                        if (d2z - d2zuzun <= d1z + d1zuzun)
                        {
                            if (Math.Abs(d2x - d1x) <= d1xuzun+ d2xuzun)
                                label19.Text = "Çarpışma Var";
                            else
                                label19.Text = "Çarpışma Yok";
                        }
                        else
                            label19.Text = "Çarpışma Yok";
                    }
                    else
                        label19.Text = "Çarpışma Yok";
                }
                else
                {
                    if (d2y- d2yuzun <= d1y + d1yuzun)
                    {
                        if (d2z +  d2zuzun >= d1z - d1zuzun)
                        {
                            if (Math.Abs(d2x - d1x) <= d1xuzun + d2xuzun)
                                label19.Text = "Çarpışma Var";
                            else
                                label19.Text = "Çarpışma Yok";
                        }
                        else
                            label19.Text = "Çarpışma Yok";
                    }
                    else
                        label19.Text = "Çarpışma Yok";
                }
            }
            else
            {
                if (d1z  < d2z)
                {
                    if (d2y +d2yuzun >= d1y - d1yuzun)
                    {
                        if (d2z- d2zuzun <= d1z + d1zuzun)
                        {
                            if (Math.Abs(d2x - d1x) <= d1xuzun + d2xuzun)
                                label19.Text = "Çarpışma Var";
                            else
                                label19.Text = "Çarpışma Yok";
                        }
                        else
                            label19.Text = "Çarpışma Yok";
                    }
                    else
                        label19.Text = "Çarpışma Yok";
                }
                else
                {
                    if (d2y  +d2yuzun >= d1y - d1yuzun)
                    {
                        if (d2z +d2zuzun >= d1z - d1zuzun)
                        {
                            if (Math.Abs(d2x - d1x) <= d1xuzun+ d2xuzun)
                                label19.Text = "Çarpışma Var";
                            else
                                label19.Text = "Çarpışma Yok";
                        }
                        else
                            label19.Text = "Çarpışma Yok";
                    }
                    else
                        label19.Text = "Çarpışma Yok";
                }
            }

            Graphics g = pictureBox1.CreateGraphics();

            //Dikdörtgen Prizma Çizimleri

            g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (d1x - d1xuzun) * 4 + d1zuzun * 4, 150 - (d1y + d1yuzun) * 4 - d1zuzun * 2, d1xuzun * 8, d1yuzun * 8);
            g.DrawRectangle(new Pen(Color.Black), 150 + (d1x - d1xuzun) * 4 + d1zuzun * 4, 150 - (d1y + d1yuzun) * 4 - d1zuzun * 2, d1xuzun * 8, d1yuzun * 8);


            g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (d1x - d1xuzun) * 4, 150 - (d1y + d1yuzun) * 4, d1xuzun * 8, d1yuzun * 8);
            g.DrawRectangle(new Pen(Color.Black), 150 + (d1x - d1xuzun) * 4, 150 - (d1y + d1yuzun) * 4, d1xuzun * 8, d1yuzun * 8);

            g.DrawLine(new Pen(Color.Black), new PointF(150 + (d1x - d1xuzun) * 4, 150 - (d1y + d1yuzun) * 4), new PointF(150 + (d1x - d1xuzun) * 4 + d1zuzun * 4, 150 - (d1y + d1yuzun) * 4 - d1zuzun * 2));
            g.DrawLine(new Pen(Color.Black), new PointF(150 + (d1x + d1xuzun) * 4, 150 - (d1y + d1yuzun) * 4), new PointF(150 + (d1x + d1xuzun) * 4 + d1zuzun * 4, 150 - (d1y + d1yuzun) * 4 - d1zuzun * 2));
            g.DrawLine(new Pen(Color.Black), new PointF(150 + (d1x + d1xuzun) * 4, 150 - (d1y - d1yuzun) * 4), new PointF(150 + (d1x + d1xuzun) * 4 + d1zuzun * 4, 150 - (d1y - d1yuzun) * 4 - d1zuzun * 2));



            g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (d2x - d2xuzun) * 4 + d2zuzun * 4, 150 - (d2y + d2yuzun) * 4 - d2zuzun * 2, d2xuzun * 8, d2yuzun * 8);
            g.DrawRectangle(new Pen(Color.Black), 150 + (d2x - d2xuzun) * 4 + d2zuzun * 4, 150 - (d2y + d2yuzun) * 4 - d2zuzun * 2, d2xuzun * 8, d2yuzun * 8);


            g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (d2x - d2xuzun) * 4, 150 - (d2y + d2yuzun) * 4, d2xuzun * 8, d2yuzun * 8);
            g.DrawRectangle(new Pen(Color.Black), 150 + (d2x - d2xuzun) * 4, 150 - (d2y + d2yuzun) * 4, d2xuzun * 8, d2yuzun * 8);

            g.DrawLine(new Pen(Color.Black), new PointF(150 + (d2x - d2xuzun) * 4, 150 - (d2y + d2yuzun) * 4), new PointF(150 + (d2x - d2xuzun) * 4 + d2zuzun * 4, 150 - (d2y + d2yuzun) * 4 - d2zuzun * 2));
            g.DrawLine(new Pen(Color.Black), new PointF(150 + (d2x + d2xuzun) * 4, 150 - (d2y + d2yuzun) * 4), new PointF(150 + (d2x + d2xuzun) * 4 + d2zuzun * 4, 150 - (d2y + d2yuzun) * 4 - d2zuzun * 2));
            g.DrawLine(new Pen(Color.Black), new PointF(150 + (d2x + d2xuzun) * 4, 150 - (d2y - d2yuzun) * 4), new PointF(150 + (d2x + d2xuzun) * 4 + d2zuzun * 4, 150 - (d2y - d2yuzun) * 4 - d2zuzun * 2));
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Sildirme BUTONNU

            pictureBox1.Image = null;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";

            }
            label19.Text = "";
        }
    }
}
