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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sx, sy, sz, syarıcap, suzun, yd;//Değişkenleri tanımladım
            char yuzey;

            sx = Convert.ToSingle(textBox1.Text);//Textboxdaki değerleri değişkenlere atadım
            sy = Convert.ToSingle(textBox2.Text);
            sz = Convert.ToSingle(textBox3.Text);
            syarıcap = Convert.ToSingle(textBox4.Text);
            suzun = Convert.ToSingle(textBox7.Text)/2;

            yuzey = Convert.ToChar(textBox5.Text);
            yd = Convert.ToSingle(textBox6.Text);


            Graphics g = pictureBox1.CreateGraphics();


            //Çarpışma Kontrolü

            if (yuzey == 'x' || yuzey == 'X')
            {
                if (sx < yd)
                {
                    if (sx >= yd - syarıcap)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }
                else
                {
                    if (sx <= yd + syarıcap)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }


                //Silindir Çizdirme

                g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun) * 4, syarıcap * 8, suzun * 8);
                g.DrawRectangle(new Pen(Color.Black), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun) * 4, syarıcap * 8, suzun * 8);


                g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun + syarıcap / 4) * 4, syarıcap * 8, suzun * 2);
                g.DrawEllipse(new Pen(Color.Black), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun + syarıcap / 4) * 4, syarıcap * 8, suzun * 2);

                g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (sx - syarıcap) * 4, 150 - (sy - suzun / 2 - syarıcap / 4) * 4, syarıcap * 8, suzun * 2);
                g.DrawEllipse(new Pen(Color.Black), 150 + (sx - syarıcap) * 4, 150 - (sy - suzun / 2 - syarıcap / 4) * 4, syarıcap * 8, suzun * 2);

                //Çİzigi çizdirme
                g.DrawLine(new Pen(Color.Purple), new PointF(150 + yd * 4, 0), new PointF(150 + yd * 4, 500));

            }
            else if (yuzey == 'Y' || yuzey == 'y')
            {
                if (sy < yd)
                {
                    if (sy >= yd - suzun)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }
                else
                {
                    if (sy <= yd + suzun)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }

                //Silindir Çizdirme

                g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun) * 4, syarıcap * 8, suzun * 8);
                g.DrawRectangle(new Pen(Color.Black), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun) * 4, syarıcap * 8, suzun * 8);


                g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun + syarıcap / 4) * 4, syarıcap * 8, suzun * 2);
                g.DrawEllipse(new Pen(Color.Black), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun + syarıcap / 4) * 4, syarıcap * 8, suzun * 2);

                g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (sx - syarıcap) * 4, 150 - (sy - suzun / 2 - syarıcap / 4) * 4, syarıcap * 8, suzun * 2);
                g.DrawEllipse(new Pen(Color.Black), 150 + (sx - syarıcap) * 4, 150 - (sy - suzun / 2 - syarıcap / 4) * 4, syarıcap * 8, suzun * 2);

                g.DrawLine(new Pen(Color.Purple), new PointF(0, 150 - yd * 4), new PointF(500, 150 - yd * 4));
            }
            else
            {
                if (sz < yd)
                {
                    if (sz >= yd - syarıcap)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }
                else
                {
                    if (sz <= yd + syarıcap)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }


                //Silindir Çizdirme

                g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (sz - syarıcap) * 4, 150 - (sy + suzun) * 4, syarıcap * 8, suzun * 8);
                g.DrawRectangle(new Pen(Color.Black), 150 + (sz - syarıcap) * 4, 150 - (sy + suzun) * 4, syarıcap * 8, suzun * 8);


                g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (sz - syarıcap) * 4, 150 - (sy + suzun + syarıcap / 4) * 4, syarıcap * 8, suzun * 2);
                g.DrawEllipse(new Pen(Color.Black), 150 + (sz - syarıcap) * 4, 150 - (sy + suzun + syarıcap / 4) * 4, syarıcap * 8, suzun * 2);

                g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (sz - syarıcap) * 4, 150 - (sy - suzun / 2 - syarıcap / 4) * 4, syarıcap * 8, suzun * 2);
                g.DrawEllipse(new Pen(Color.Black), 150 + (sz - syarıcap) * 4, 150 - (sy - suzun / 2 - syarıcap / 4) * 4, syarıcap * 8, suzun * 2);


                g.DrawLine(new Pen(Color.Purple), new PointF(150 + yd * 4, 0), new PointF(150 + yd * 4, 500));
            }
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
