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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           float nx, ny, nz, sx, sy, sz, syarıcap, suzun;//Değişkenleri tanımladım

            nx = Convert.ToSingle(textBox5.Text);//Textboxdaki değeleri değişkenlere atadm
            ny = Convert.ToSingle(textBox4.Text);
            nz = Convert.ToSingle(textBox6.Text);

            sx = Convert.ToSingle(textBox2.Text);
            sy = Convert.ToSingle(textBox3.Text);
            sz = Convert.ToSingle(textBox1.Text);
            syarıcap = Convert.ToSingle(textBox8.Text);
            suzun = Convert.ToSingle(textBox9.Text) / 2;

            //Çarpışma Kontrolü

            if (sy < ny)
            {
                if (sz < nz)
                {
                    if (ny <= sy + suzun)
                    {
                        if (nz <= sz + syarıcap)
                        {
                            if (Math.Abs(nx - sx) <= syarıcap)
                                label10.Text = "Çarpışma Var";
                            else
                                label10.Text = "Çarpışma Yok";
                        }
                        else
                            label10.Text = "Çarpışma Yok";
                    }
                    else
                        label10.Text = "Çarpışma Yok";
                }
                else
                {
                    if (ny <= sy + suzun)
                    {
                        if (nz >= sz - syarıcap)
                        {
                            if (Math.Abs(nx - sx) <= syarıcap)
                                label10.Text = "Çarpışma Var";
                            else
                                label10.Text = "Çarpışma Yok";
                        }
                        else
                            label10.Text = "Çarpışma Yok";
                    }
                    else
                        label10.Text = "Çarpışma Yok";
                }
            }
            else
            {
                if (sz < nz)
                {
                    if (ny >= sy - suzun)
                    {
                        if (nz <= sz + syarıcap)
                        {
                            if (Math.Abs(nx - sx) <= syarıcap)
                                label10.Text = "Çarpışma Var";
                            else
                                label10.Text = "Çarpışma Yok";
                        }
                        else
                            label10.Text = "Çarpışma Yok";
                    }
                    else
                        label10.Text = "Çarpışma Yok";
                }
                else
                {
                    if (ny >= sy - suzun)
                    {
                        if (nz >= sz - syarıcap)
                        {
                            if (Math.Abs(nx - sx) <= syarıcap)
                                label10.Text = "Çarpışma Var";
                            else
                                label10.Text = "Çarpışma Yok";
                        }
                        else
                            label10.Text = "Çarpışma Yok";
                    }
                    else
                        label10.Text = "Çarpışma Yok";
                }
            }


            Graphics g = pictureBox1.CreateGraphics();

            //Şekilleri çizdridrdim

            g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun) * 4, syarıcap * 8, suzun * 8);
            g.DrawRectangle(new Pen(Color.Black), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun) * 4, syarıcap * 8, suzun * 8);


            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun + syarıcap/4) * 4, syarıcap * 8, suzun * 2);
            g.DrawEllipse(new Pen(Color.Black), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun + syarıcap/4) * 4, syarıcap * 8, suzun * 2);

            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (sx - syarıcap) * 4, 150 - (sy - suzun/2 - syarıcap / 4) * 4, syarıcap * 8, suzun * 2);
            g.DrawEllipse(new Pen(Color.Black), 150 + (sx - syarıcap) * 4, 150 - (sy - suzun/2 - syarıcap / 4) * 4, syarıcap * 8, suzun * 2);


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
            label10.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void Form9_Load(object sender, EventArgs e)
        {

        }

    }
}
