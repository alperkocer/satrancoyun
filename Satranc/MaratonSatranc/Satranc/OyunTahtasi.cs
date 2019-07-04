using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranc
{
    class OyunTahtasi
    {
        List<Tas> oyunTaslari = new List<Tas>();

        private Form1 form;

        public OyunTahtasi(Form1 form)
        {
            this.form = form;
            int sayac = 0, yatay = 0, dikey = 0;
            Color renk = Color.White;
            System.Windows.Forms.Panel pnlTahta;

            for (int i = 0; i < 64; i++)
            {
                Button btn = new Button();
                btn.BackColor = renk;
                btn.Location = new System.Drawing.Point(yatay, dikey);
                btn.Name = "btn" + (i + 1);
                btn.Size = new System.Drawing.Size(50, 50);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                form.pnlTahta.Controls.Add(btn);
                btn.Click += Btn_Click;

                sayac++;

                yatay += 50;
                if (yatay == form.pnlTahta.Size.Height)
                {
                    sayac++;

                    yatay = 0;
                    dikey += 50;
                }

                if (sayac % 2 == 0)
                {
                    renk = Color.White;
                }
                else
                {
                    renk = Color.Black;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((Button)sender).Name + " e tıkladın.");

        }

        public int BosYerBul(Form form)
        {
            int konum;
            bool kontrol = false;
            Random rnd = new Random();

            do
            {
                konum = rnd.Next(1, 65);
                Button OlusacakTas = form.Controls.Find(("btn" + konum), true).FirstOrDefault() as Button;

                if (OlusacakTas.Image == null)
                    kontrol = false;
                else
                    kontrol = true;
            }
            while (kontrol);
            return konum;
        }

        public void TasOlustur(Form1 form)
        {
            int konum = BosYerBul(form);

            Button OlusacakTas = form.Controls.Find(("btn" + konum.ToString()), true).FirstOrDefault() as Button;

            int newSize = 50;
            OlusacakTas.Font = new Font(OlusacakTas.Font.FontFamily, newSize);
            if (form.cmbTas.SelectedIndex == 0)
            {
                OlusacakTas.Image = global::Satranc.Properties.Resources.kale;
                Kale kale = new Kale();
                kale.Konum = konum;
                oyunTaslari.Add(kale);
            }
            //else if (form.cmbTas.SelectedIndex == 1)
            //{
            //    //OlusacakTas.Image = global::Satranc.Properties.Resources.piyon;
            //    //Piyon piyon = new Piyon();
            //    //piyon.Konum = konum;
            //    //oyunTaslari.Add(piyon);
            //}
            else if (form.cmbTas.SelectedIndex == 1)
            {
                OlusacakTas.Image = global::Satranc.Properties.Resources.fil;
                Fil fil = new Fil();
                fil.Konum = konum;
                oyunTaslari.Add(fil);
            }
            else if (form.cmbTas.SelectedIndex == 2)
            {
                OlusacakTas.Image = global::Satranc.Properties.Resources.at;
                At at = new At();
                at.Konum = konum;
                oyunTaslari.Add(at);
            }
        }

        public void TaslariHareketEttir()
        {
            foreach (var item in oyunTaslari)
            {
                item.HareketEt(form);
            }
        }
    }
}
