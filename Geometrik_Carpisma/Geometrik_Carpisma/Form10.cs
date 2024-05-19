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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDP_ÖDEV_FORM
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float s1x, s1y, s1z, s2x, s2y, s2z, s1yarıcap, s2yarıcap, s1uzun, s2uzun;//Değişkenleri Tnaımladım
            
            s1x= Convert.ToSingle(textBox4.Text);//Textboxdaki değerleri değişkenlere atadım.
            s1y= Convert.ToSingle(textBox6.Text);
            s1z= Convert.ToSingle(textBox5.Text);
            s1yarıcap= Convert.ToSingle(textBox7.Text);
            s1uzun= Convert.ToSingle(textBox10.Text) / 2;


            s2x= Convert.ToSingle(textBox2.Text);
            s2y= Convert.ToSingle(textBox3.Text);
            s2z= Convert.ToSingle(textBox1.Text);
            s2yarıcap= Convert.ToSingle(textBox8.Text);
            s2uzun= Convert.ToSingle(textBox9.Text) / 2;


            //Çarpışma Kontrolü

            if (s1y < s2y)
            {
                if (s1z < s2z)
                {
                    if (s2y - s2uzun <= s1y + s1uzun)
                    {
                        if (s2z - s2yarıcap <= s1z + s1yarıcap)
                        {
                            if (Math.Abs(s2x - s1x) <= s1yarıcap+s2yarıcap)
                                label9.Text = "Çarpışma Var";
                            else
                                label9.Text = "Çarpışma Yok";
                        }
                        else
                            label9.Text = "Çarpışma Yok";
                    }
                    else
                        label9.Text = "Çarpışma Yok";
                }
                else
                {
                    if (s2y - s2uzun <= s1y + s1uzun)
                    {
                        if (s2z +s2yarıcap >= s1z - s1yarıcap)
                        {
                            if (Math.Abs(s1x - s1x) <= s1yarıcap+s2yarıcap)
                                label9.Text = "Çarpışma Var";
                            else
                                label9.Text = "Çarpışma Yok";
                        }
                        else
                            label9.Text = "Çarpışma Yok";
                    }
                    else
                        label9.Text = "Çarpışma Yok";
                }
            }
            else
            {
                if (s1z < s2z)
                {
                    if (s2y + s2uzun >= s1y - s1uzun)
                    {
                        if (s2z - s2yarıcap <= s1z + s1yarıcap)
                        {
                            if (Math.Abs(s1x - s1x) <= s1yarıcap + s2yarıcap)
                                label9.Text = "Çarpışma Var";
                            else
                                label9.Text = "Çarpışma Yok";
                        }
                        else
                            label9.Text = "Çarpışma Yok";
                    }
                    else
                        label9.Text = "Çarpışma Yok";
                }
                else
                {
                    if (s2y + s2uzun >= s1y - s1uzun)
                    {
                        if (s2z + s2yarıcap >= s1z - s1yarıcap)
                        {
                            if (Math.Abs(s1x - s1x) <= s1yarıcap + s2yarıcap)
                                label9.Text = "Çarpışma Var";
                            else
                                label9.Text = "Çarpışma Yok";
                        }
                        else
                            label9.Text = "Çarpışma Yok";
                    }
                    else
                        label9.Text = "Çarpışma Yok";
                }
            }
            //Çarpışma Kontrolü

            //Silindir 1
            Graphics g = pictureBox1.CreateGraphics();

            g.FillRectangle(new SolidBrush(Color.Red), 150 + (s1x - s1yarıcap) * 4, 150 - (s1y + s1uzun) * 4, s1yarıcap * 8, s1uzun * 8);
            g.DrawRectangle(new Pen(Color.Black), 150 + (s1x - s1yarıcap) * 4, 150 - (s1y + s1uzun) * 4, s1yarıcap * 8, s1uzun * 8);


            g.FillEllipse(new SolidBrush(Color.Red), 150 + (s1x - s1yarıcap) * 4, 150 - (s1y + s1uzun + s1yarıcap / 4) * 4, s1yarıcap * 8, s1uzun * 2);
            g.DrawEllipse(new Pen(Color.Black), 150 + (s1x - s1yarıcap) * 4, 150 - (s1y + s1uzun + s1yarıcap / 4) * 4, s1yarıcap * 8, s1uzun * 2);

            g.FillEllipse(new SolidBrush(Color.Red), 150 + (s1x - s1yarıcap) * 4, 150 - (s1y - s1uzun / 2 - s1yarıcap / 4) * 4, s1yarıcap * 8, s1uzun * 2);
            g.DrawEllipse(new Pen(Color.Black), 150 + (s1x - s1yarıcap) * 4, 150 - (s1y - s1uzun / 2 - s1yarıcap / 4) * 4, s1yarıcap * 8, s1uzun * 2);

            //Silindir 2
            g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (s2x - s2yarıcap) * 4, 150 - (s2y + s2uzun) * 4, s2yarıcap * 8, s2uzun * 8);
            g.DrawRectangle(new Pen(Color.Black), 150 + (s2x - s2yarıcap) * 4, 150 - (s2y + s2uzun) * 4, s2yarıcap * 8, s2uzun * 8);


            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (s2x - s2yarıcap) * 4, 150 - (s2y + s2uzun + s2yarıcap / 4) * 4, s2yarıcap * 8, s2uzun * 2);
            g.DrawEllipse(new Pen(Color.Black), 150 + (s2x - s2yarıcap) * 4, 150 - (s2y + s2uzun + s2yarıcap / 4) * 4, s2yarıcap * 8, s2uzun * 2);

            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (s2x - s2yarıcap) * 4, 150 - (s2y - s2uzun / 2 - s2yarıcap / 4) * 4, s2yarıcap * 8, s2uzun * 2);
            g.DrawEllipse(new Pen(Color.Black), 150 + (s2x - s2yarıcap) * 4, 150 - (s2y - s2uzun / 2 - s2yarıcap / 4) * 4, s2yarıcap * 8, s2uzun * 2);
        }


        private void button2_Click_1(object sender, EventArgs e)
        {

            //Sildirme BUTONNU

            pictureBox1.Image = null;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "Syste.Windows.Forms.TextBox") item.Text = "";

            }
            label9.Text = "";
        }
    }
}
