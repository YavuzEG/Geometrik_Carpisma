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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float kx, ky, kz, kyarıcap, sx, sz, sy, suzun, syarıcap;//Değişkenleri Tnımladım

            kx = Convert.ToSingle(textBox4.Text);//TextBox dan aldığım değerleri deişkenlere atadım
            ky = Convert.ToSingle(textBox6.Text);
            kz = Convert.ToSingle(textBox7.Text);
            kyarıcap = Convert.ToSingle(textBox5.Text);

            sx = Convert.ToSingle(textBox2.Text);
            sy = Convert.ToSingle(textBox3.Text);
            sz = Convert.ToSingle(textBox1.Text);
            suzun = Convert.ToSingle(textBox9.Text)/2;
            syarıcap = Convert.ToSingle(textBox8.Text);

            //Çarpışma Kontrolü

            if(sx+suzun<ky||sx-suzun>ky)
            {
                if(Math.Sqrt(Math.Pow(sy-ky,2)+Math.Pow(sx-kx,2)+Math.Pow(sz-kz,2))<=kyarıcap + Math.Sqrt(syarıcap*syarıcap + syarıcap*syarıcap +suzun*suzun))
                    label9.Text = "Çarpışma Var";
                else
                    label9.Text = "Çarpışma Yok";
            }    
            else
            {
                if (Math.Abs(sz - kz) <= kyarıcap + syarıcap)
                {
                    if (Math.Abs(sx - kx) <= kyarıcap + syarıcap)
                        label9.Text = "Çarpışma Var";
                    else
                        label9.Text = "Çarpışma Yok";
                }
                else
                    label9.Text = "Çarpışma Yok";
            }

            //Şekil Çizdirme

            //Silindir Çizdirme
            Graphics g = pictureBox1.CreateGraphics();

            g.FillRectangle(new SolidBrush(Color.Yellow), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun) * 4, syarıcap * 8, suzun * 8);
            g.DrawRectangle(new Pen(Color.Black), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun) * 4, syarıcap * 8, suzun * 8);


            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun + syarıcap / 4) * 4, syarıcap * 8, suzun * 2);
            g.DrawEllipse(new Pen(Color.Black), 150 + (sx - syarıcap) * 4, 150 - (sy + suzun + syarıcap / 4) * 4, syarıcap * 8, suzun * 2);

            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (sx - syarıcap) * 4, 150 - (sy - suzun / 2 - syarıcap / 4) * 4, syarıcap * 8, suzun * 2);
            g.DrawEllipse(new Pen(Color.Black), 150 + (sx - syarıcap) * 4, 150 - (sy - suzun / 2 - syarıcap / 4) * 4, syarıcap * 8, suzun * 2);


            //Küre Çizdirme
            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (kx - kyarıcap) * 4, 150 - (ky + kyarıcap) * 4, kyarıcap * 8, kyarıcap * 8);
            g.DrawEllipse(new Pen(Color.Black), 150 + (kx - kyarıcap) * 4, 150 - (ky + kyarıcap) * 4, kyarıcap * 8, kyarıcap * 8);
            g.DrawEllipse(new Pen(Color.Black), 150 + (kx - kyarıcap) * 4, 150 - (ky + kyarıcap / 2) * 4, kyarıcap * 8, kyarıcap * 4);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Sildirme BUTONNU

            pictureBox1.Image = null;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";

            }
            label9.Text = "";
        }
    }
}
