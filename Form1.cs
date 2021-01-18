using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Bu oyunda 2 oyuncu vardır.
             * Her oyuncunun 1 zarı vardır.
             * Oyuncular zar atar.
             * Zarlar karşılaştırılır.
             * Büyük atan kazanır.
             * 
             * Nesneler:
             * Oyun
             * Oyuncu
             * Zar
             */
        }

        Oyun zarOyunu = new Oyun();
        private void buttonAd1_Click(object sender, EventArgs e)
        {
            string oyuncuAdi = textBoxOyuncu1Ad.Text;
            zarOyunu.BirinciOyuncu = new Oyuncu(oyuncuAdi);
            zarOyunu.BirinciOyuncu.OyuncununZari = new Zar();
            labelOyuncu1Ad.Text = zarOyunu.BirinciOyuncu.Ad;

        }
        private void buttonAd2_Click(object sender, EventArgs e)
        {
            string oyuncuAdi = textBoxOyuncu2Ad.Text;
            zarOyunu.IkinciOyuncu = new Oyuncu(oyuncuAdi);
            zarOyunu.IkinciOyuncu.OyuncununZari = new Zar();
            labelOyuncu2Ad.Text = zarOyunu.IkinciOyuncu.Ad;
            BahisEkle1.Enabled = true;

        }

        private void textBoxOyuncu1Ad_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBoxOyuncu2Ad_TextChanged(object sender, EventArgs e)
        {
            string oyuncuAdi = textBoxOyuncu2Ad.Text;
            zarOyunu.IkinciOyuncu = new Oyuncu(oyuncuAdi);
            zarOyunu.IkinciOyuncu.OyuncununZari = new Zar();
        }

        private void buttonOyuncu1_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuZarAt();
            labelOyuncu1Zar.Text = zarOyunu.BirinciOyuncu.OyuncununZari.Deger.ToString();
        }

        private void buttonOyuncu2_Click(object sender, EventArgs e)
        {
            zarOyunu.IkıncıOyuncuZarAt();
            labelOyuncu2Zar.Text = zarOyunu.IkinciOyuncu.OyuncununZari.Deger.ToString();

            Oyuncu kazanan = zarOyunu.Karsilastir();
            if (kazanan != null)
            {
                labelKazanan.Text = $"{ kazanan.Ad}, { kazanan.OyuncununZari.Deger} atarak oyunu kazandı";

            }
            else
            {
                labelKazanan.Text = "Berabere";
            }
            if (zarOyunu.BirinciOyuncu.OyuncuBakiye.Tutar == 0)
            {
                MessageBox.Show($"{zarOyunu.BirinciOyuncu.Ad} bakiyesi bitti");
                BahisEkle1.Enabled = false;
            }
            else if (zarOyunu.IkinciOyuncu.OyuncuBakiye.Tutar == 0)
            {
                MessageBox.Show($"{zarOyunu.IkinciOyuncu.Ad} bakiyesi bitti.");
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ToplamBakiyeİkinciOyuncu = Convert.ToInt32(bakiye2sonuc.Text);
            int Oyuncu2Bahis = Convert.ToInt32(button2.Text);
            if (Oyuncu2Bahis>ToplamBakiyeİkinciOyuncu)
            {
                MessageBox.Show("Bakiye 100!!!!");
                textBox2.Text = "";
            }
            else
            {
                zarOyunu.IkinciOyuncu.OyuncuBakiye = new BakiyeDurumu(ToplamBakiyeİkinciOyuncu);
                zarOyunu.IkinciOyuncu.OyuncuBakiye.AzalanBakiye(Oyuncu2Bahis);

            }


        }

        private void bakiye2sonuc_Click(object sender, EventArgs e)
        {

        }

        private void BahisEkle1_Click(object sender, EventArgs e)
        {
            int ToplamBakiyeBirinciOyuncu = Convert.ToInt32(bakiye1sonuc.Text);
            int Oyuncu1Bahis = Convert.ToInt32(textBox1.Text);
            if (Oyuncu1Bahis > ToplamBakiyeBirinciOyuncu)
            {
                MessageBox.Show("Bakiye 100!!!!");
                textBox1.Text = "";

            }
            else
            {
                BahisEkle1.Enabled = true;
                zarOyunu.BirinciOyuncu.OyuncuBakiye = new BakiyeDurumu(ToplamBakiyeBirinciOyuncu);
                zarOyunu.BirinciOyuncu.OyuncuBakiye.AzalanBakiye(Oyuncu1Bahis);
                bakiye1sonuc.Text = zarOyunu.BirinciOyuncu.OyuncuBakiye.Tutar.ToString();
            }
        }

    }
}
