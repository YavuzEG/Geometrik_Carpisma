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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float dx, dy, dz, dxuzun,dyuzun,dzuzun, yd;//Değişkenleri tanımladım    
            char yuzey;

            dx = Convert.ToSingle(textBox1.Text);//textboxdaki değerleri değişknenlere atadım
            dy = Convert.ToSingle(textBox2.Text);
            dz = Convert.ToSingle(textBox3.Text);
            dxuzun= Convert.ToSingle(textBox4.Text)/2;
            dyuzun= Convert.ToSingle(textBox7.Text)/2;
            dzuzun= Convert.ToSingle(textBox8.Text)/2;

            yuzey = Convert.ToChar(textBox5.Text);
            yd = Convert.ToSingle(textBox6.Text);

            Graphics g = pictureBox1.CreateGraphics();

            //Çarpışma Kontrolü

            if (yuzey == 'x' || yuzey == 'X')
            {
                if (dx < yd)
                {
                    if (dx >= yd - dxuzun)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }
                else
                {
                    if (dx <= yd + dxuzun)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }


                //Dikdörtgen Prizma Çizdirme
                g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (dx - dxuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2, dxuzun * 8, dyuzun * 8);
                g.DrawRectangle(new Pen(Color.Black), 150 + (dx - dxuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2, dxuzun * 8, dyuzun * 8);


                g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (dx - dxuzun) * 4, 150 - (dy + dyuzun) * 4, dxuzun * 8, dyuzun * 8);
                g.DrawRectangle(new Pen(Color.Black), 150 + (dx - dxuzun) * 4, 150 - (dy + dyuzun) * 4, dxuzun * 8, dyuzun * 8);

                g.DrawLine(new Pen(Color.Black), new PointF(150 + (dx - dxuzun) * 4, 150 - (dy + dyuzun) * 4), new PointF(150 + (dx - dxuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2));
                g.DrawLine(new Pen(Color.Black), new PointF(150 + (dx + dxuzun) * 4, 150 - (dy + dyuzun) * 4), new PointF(150 + (dx + dxuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2));
                g.DrawLine(new Pen(Color.Black), new PointF(150 + (dx + dxuzun) * 4, 150 - (dy - dyuzun) * 4), new PointF(150 + (dx + dxuzun) * 4 + dzuzun * 4, 150 - (dy - dyuzun) * 4 - dzuzun * 2));

                //Çİzigi çizdirme
                g.DrawLine(new Pen(Color.Purple), new PointF(150 + yd * 4, 0), new PointF(150 + yd * 4, 500));

            }
            else if (yuzey == 'Y' || yuzey == 'y')
            {
                if (dy < yd)
                {
                    if (dy >= yd - dyuzun)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }
                else
                {
                    if (dy <= yd + dyuzun)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }

                //Şekilleri çizdridrdim
                g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (dx - dxuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2, dxuzun * 8, dyuzun * 8);
                g.DrawRectangle(new Pen(Color.Black), 150 + (dx - dxuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2, dxuzun * 8, dyuzun * 8);


                g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (dx - dxuzun) * 4, 150 - (dy + dyuzun) * 4, dxuzun * 8, dyuzun * 8);
                g.DrawRectangle(new Pen(Color.Black), 150 + (dx - dxuzun) * 4, 150 - (dy + dyuzun) * 4, dxuzun * 8, dyuzun * 8);

                g.DrawLine(new Pen(Color.Black), new PointF(150 + (dx - dxuzun) * 4, 150 - (dy + dyuzun) * 4), new PointF(150 + (dx - dxuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2));
                g.DrawLine(new Pen(Color.Black), new PointF(150 + (dx + dxuzun) * 4, 150 - (dy + dyuzun) * 4), new PointF(150 + (dx + dxuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2));
                g.DrawLine(new Pen(Color.Black), new PointF(150 + (dx + dxuzun) * 4, 150 - (dy - dyuzun) * 4), new PointF(150 + (dx + dxuzun) * 4 + dzuzun * 4, 150 - (dy - dyuzun) * 4 - dzuzun * 2));

                g.DrawLine(new Pen(Color.Purple), new PointF(0, 150 - yd * 4), new PointF(500, 150 - yd * 4));
            }
            else
            {
                if (dz < yd)
                {
                    if (dz >= yd - dzuzun)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }
                else
                {
                    if (dz <= yd + dzuzun)
                        label19.Text = "Çarpışma Var";
                    else
                        label19.Text = "Çarpışma Yok";
                }


                //Şekilleri çizdridrdim
                g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (dz - dzuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2, dzuzun * 8, dyuzun * 8);
                g.DrawRectangle(new Pen(Color.Black), 150 + (dz - dzuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2, dzuzun * 8, dyuzun * 8);


                g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (dz - dzuzun) * 4, 150 - (dy + dyuzun) * 4, dzuzun * 8, dyuzun * 8);
                g.DrawRectangle(new Pen(Color.Black), 150 + (dz - dzuzun) * 4, 150 - (dy + dyuzun) * 4, dzuzun * 8, dyuzun * 8);

                g.DrawLine(new Pen(Color.Black), new PointF(150 + (dz - dzuzun) * 4, 150 - (dy + dyuzun) * 4), new PointF(150 + (dz - dzuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2));
                g.DrawLine(new Pen(Color.Black), new PointF(150 + (dz + dzuzun) * 4, 150 - (dy + dyuzun) * 4), new PointF(150 + (dz + dzuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2));
                g.DrawLine(new Pen(Color.Black), new PointF(150 + (dz + dzuzun) * 4, 150 - (dy - dyuzun) * 4), new PointF(150 + (dz + dzuzun) * 4 + dzuzun * 4, 150 - (dy - dyuzun) * 4 - dzuzun * 2));


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
