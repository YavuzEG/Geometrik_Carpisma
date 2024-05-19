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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Değişkenleri tanımladım
        {
            float kx, ky, kz, kyarıcap, yd;
            char yuzey;

            kx = Convert.ToSingle(textBox1.Text);//textbozdaki değerleri değişkenlere atadım
            ky = Convert.ToSingle(textBox2.Text);
            kz = Convert.ToSingle(textBox3.Text);
            kyarıcap = Convert.ToSingle(textBox4.Text);

            yuzey = Convert.ToChar(textBox5.Text);
            yd = Convert.ToSingle(textBox6.Text);

            Graphics g = pictureBox1.CreateGraphics();

            //Çarpışma KOntrolü

            if (yuzey=='x' || yuzey=='X')
            {
                if(kx<yd)
                {
                    if (kx >= yd - kyarıcap)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }
                else
                {
                    if (kx <= yd + kyarıcap)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }

                //Şekilleri çizdridrdim
                g.FillEllipse(new SolidBrush(Color.Red), 150 + (kx - kyarıcap) * 4, 150 - (ky + kyarıcap) * 4, kyarıcap * 8, kyarıcap * 8);
                g.DrawEllipse(new Pen(Color.Black), 150 + (kx - kyarıcap) * 4, 150 - (ky + kyarıcap) * 4, kyarıcap * 8, kyarıcap * 8);
                g.DrawEllipse(new Pen(Color.Black), 150 + (kx - kyarıcap) * 4, 150 - (ky + kyarıcap / 2) * 4, kyarıcap * 8, kyarıcap * 4);

                g.DrawLine(new Pen(Color.Purple),new PointF(150+yd*4,0),new PointF(150 +yd * 4, 500));

            }
          else if(yuzey == 'Y'|| yuzey =='y')
            {
                if (ky < yd)
                {
                    if (ky >= yd - kyarıcap)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }
                else
                {
                    if (ky <= yd + kyarıcap)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }

                //Şekilleri çizdridrdim

                g.FillEllipse(new SolidBrush(Color.Red), 150 + (kx - kyarıcap) * 4, 150 - (ky + kyarıcap) * 4, kyarıcap * 8, kyarıcap * 8);
                g.DrawEllipse(new Pen(Color.Black), 150 + (kx - kyarıcap) * 4, 150 - (ky + kyarıcap) * 4, kyarıcap * 8, kyarıcap * 8);
                g.DrawEllipse(new Pen(Color.Black), 150 + (kx - kyarıcap) * 4, 150 - (ky + kyarıcap / 2) * 4, kyarıcap * 8, kyarıcap * 4);

                g.DrawLine(new Pen(Color.Purple), new PointF(0,150 - yd * 4), new PointF(500,150 - yd * 4));
            }
            else
            {
                if (kz < yd)
                {
                    if (kz >= yd - kyarıcap)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }
                else
                {
                    if (kz <= yd + kyarıcap)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }

                //Şekilleri çizdridrdim
                g.FillEllipse(new SolidBrush(Color.Red), 150 + (kz - kyarıcap) * 4, 150 - (ky + kyarıcap) * 4, kyarıcap * 8, kyarıcap * 8);
                g.DrawEllipse(new Pen(Color.Black), 150 + (kz - kyarıcap) * 4, 150 - (ky + kyarıcap) * 4, kyarıcap * 8, kyarıcap * 8);
                g.DrawEllipse(new Pen(Color.Black), 150 + (kz - kyarıcap) * 4, 150 - (ky + kyarıcap / 2) * 4, kyarıcap * 8, kyarıcap * 4);

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

