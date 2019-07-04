using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranc
{
    public class Kale : Tas
    {
        public override void HareketEt(Form1 frm)
        {
            Button kaleEskiKonum = ButonBul(frm);

            List<Yon> gidilebilecekYonler = GidilebilecekYonler();

            Random rnd = new Random();

            int gidilecekYonIndex = rnd.Next(0, gidilebilecekYonler.Count);
            Yon gidilecekYon = gidilebilecekYonler[gidilecekYonIndex];

            var gidilebilecekButonlar = BuYondeGidilebilecekButonlar(gidilecekYon, frm);
            if (gidilebilecekButonlar.Count > 0)
            {
                kaleEskiKonum.Image = null;
                int deneme = gidilebilecekButonlar.Count;
                Konum = gidilebilecekButonlar[rnd.Next(0, deneme)];
                Button kaleYeniKonum = ButonBul(frm);

                ResimGuncelle(this, kaleYeniKonum);
            }
        }

    }
}
