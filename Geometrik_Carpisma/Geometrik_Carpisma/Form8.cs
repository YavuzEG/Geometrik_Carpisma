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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float nx = 0, ny = 0, nz = 0, dx = 0, dy = 0, dz = 0, dxuzun = 0, dyuzun = 0, dzuzun = 0;//Değişken oluşturdum 

            nx = Convert.ToSingle(textBox4.Text);//Textboxdaki değerleri değişkenlere atadım
            ny = Convert.ToSingle(textBox3.Text);
            nz = Convert.ToSingle(textBox6.Text);

            dx = Convert.ToSingle(textBox8.Text);
            dy = Convert.ToSingle(textBox7.Text);
            dz = Convert.ToSingle(textBox5.Text);
            dxuzun = Convert.ToSingle(textBox2.Text)/2;
            dyuzun = Convert.ToSingle(textBox1.Text)/2;
            dzuzun = Convert.ToSingle(textBox9.Text)/2;

            //Çarpışma Kontrolü

            if(dy<ny)
            {
                if(dz<nz)
                {
                    if(ny<=dy+dyuzun)
                    {
                        if (nz <= dz + dzuzun)
                        {
                            if (Math.Abs(nx - dx) <= dxuzun)
                                label9.Text = "Çarpışma Var";
                            else
                                label9.Text="Çarpışma Yok";
                        }
                        else
                            label9.Text = "Çarpışma Yok";
                    }
                    else
                    label9.Text = "Çarpışma Yok";
                }
                else
                {
                    if (ny <= dy + dyuzun)
                    {
                        if (nz >= dz - dzuzun)
                        {
                            if (Math.Abs(nx - dx) <= dxuzun)
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
                if (dz < nz)
                {
                    if (ny >= dy - dyuzun)
                    {
                        if (nz <= dz + dzuzun)
                        {
                            if (Math.Abs(nx - dx) <= dxuzun)
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
                    if (ny >= dy - dyuzun)
                    {
                        if (nz >= dz - dzuzun)
                        {
                            if (Math.Abs(nx - dx) <= dxuzun)
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


            Graphics g = pictureBox1.CreateGraphics();

            //Şekilleri çizdridrdim
            g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (dx - dxuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun*2 , dxuzun * 8, dyuzun * 8);
            g.DrawRectangle(new Pen(Color.Black), 150 + (dx - dxuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun *2, dxuzun * 8, dyuzun * 8);


            g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (dx -dxuzun) * 4, 150 - (dy + dyuzun) * 4, dxuzun * 8, dyuzun * 8);
            g.DrawRectangle(new Pen(Color.Black), 150 + (dx - dxuzun) * 4 , 150 - (dy + dyuzun) * 4 , dxuzun * 8, dyuzun * 8);

            g.DrawLine(new Pen(Color.Black), new PointF(150 + (dx - dxuzun) * 4, 150 - (dy + dyuzun) * 4), new PointF(150 + (dx - dxuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2));
            g.DrawLine(new Pen(Color.Black), new PointF(150 + (dx + dxuzun) * 4, 150 - (dy + dyuzun) * 4), new PointF(150 + (dx + dxuzun) * 4 + dzuzun * 4, 150 - (dy + dyuzun) * 4 - dzuzun * 2));
            g.DrawLine(new Pen(Color.Black), new PointF(150 + (dx + dxuzun) * 4, 150 - (dy - dyuzun) * 4), new PointF(150 + (dx + dxuzun) * 4 + dzuzun * 4, 150 - (dy - dyuzun) * 4 - dzuzun * 2));


            //Şekilleri çizdridrdim
            g.FillEllipse(new SolidBrush(Color.Red), 150 + nx * 4, 150 - ny * 4, 2, 2);

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            //Silme Komutu
            pictureBox1.Image = null;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";

            }
            label9.Text = "";
        }


        private void label14_Click(object sender, EventArgs e)
        {

        }

    }
}
