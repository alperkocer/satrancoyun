using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Kale> kaleler = new List<Kale>();
        List<Fil> filler = new List<Fil>();
        List<At> atlar = new List<At>();
        OyunTahtasi oyunTahtasi;

        private void Form1_Load(object sender, EventArgs e)
        {
            oyunTahtasi = new OyunTahtasi(this);
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            oyunTahtasi.TasOlustur(this);
        }

        private void btnHareket_Click(object sender, EventArgs e)
        {
            oyunTahtasi.TaslariHareketEttir();
        }

        private void cmbTas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //
        }

    }
}