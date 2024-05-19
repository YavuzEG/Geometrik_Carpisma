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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float nx = 0, ny = 0, cx = 0, cy = 0, cyarıcap = 0;//Değişken Tanımlama yaptım
            nx = Convert.ToSingle(textBox1.Text);//Textboxdan aldığım değerleri atadım
            ny = Convert.ToSingle(textBox2.Text);
            
            cx = Convert.ToSingle(textBox3.Text);
            cy = Convert.ToSingle(textBox4.Text);
            cyarıcap= Convert.ToSingle(textBox5.Text);

            //Çarpışma Kontrolü

            if (cyarıcap >= Math.Sqrt(Math.Pow(cy - ny, 2) + Math.Pow(cx - nx, 2)))
                label9.Text = "Çarpışma Var";
            else
                label9.Text = "Çarpışma Yok";

            Graphics g = pictureBox1.CreateGraphics();


            //Şekilleri çizdridrdim
            g.FillEllipse(new SolidBrush(Color.Yellow), 150 + (cx-cyarıcap) * 4, 150 - (cy+cyarıcap) * 4, cyarıcap * 8, cyarıcap * 8);

            g.FillEllipse(new SolidBrush(Color.Red), 150 + nx * 4, 150 - ny * 4, 2, 2);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            //Silme butonu komutu
            pictureBox1.Image = null;
            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";

            }
            label9.Text = "";
        }
    }

}
