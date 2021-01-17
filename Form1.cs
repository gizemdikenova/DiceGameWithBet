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
                labelKazanan.Text= $"{ kazanan.Ad}, { kazanan.OyuncununZari.Deger} atarak oyunu kazandı";
            }
            else
            {
                labelKazanan.Text = "Berabere";
            }

        }
    }
}
