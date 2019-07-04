using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranc
{
    public abstract class Tas
    {
        public int Konum { get; set; }

        public virtual void HareketEt(Form1 form)
        {

        }

        public virtual List<int> BuYondeGidilebilecekButonlar(Yon yon, Form1 form)
        {
            List<int> gidilebilecekButonlar = new List<int>();

            if (yon == Yon.Sag)
            {
                // Konum üzerinden işlem yapılacağı için geçici bir değişkene atandı.
                int geciciKonum = Konum;

                // Mod alındı. Moda göre işlem yapılacak.
                int mod = geciciKonum % 8;

                // Mod sıfır olana kadar ilerle. Sıfırsa en sağdadır demektir.
                while (mod != 0)
                {
                    //Bir sonraki konuma geç.
                    geciciKonum = geciciKonum + 1;

                    //Yeni konumdaki buton değişkene atanıyor.
                    Button yeniKonumdakiButon = form.Controls.Find(("btn" + (geciciKonum).ToString()), true).FirstOrDefault() as Button;

                    //Bu konumdaki butonda başka bir nesne var mı? Yoksa listeye ekle.
                    if (yeniKonumdakiButon.Image == null)
                    {
                        gidilebilecekButonlar.Add(geciciKonum);
                    }
                    mod = geciciKonum % 8;
                }
            }
            else if (yon == Yon.Sol)
            {
                // Konum üzerinden işlem yapılacağı için geçici bir değişkene atandı.
                int geciciKonum = Konum;

                // Mod alındı. Moda göre işlem yapılacak.
                int mod = geciciKonum % 8;

                // Mod sıfır olana kadar sola git. Sıfırsa en sağdadır demektir.
                while (mod != 1)
                {
                    //Bir sonraki konuma geç.
                    geciciKonum = geciciKonum - 1;

                    //Yeni konumdaki buton değişkene atanıyor.
                    Button yeniKonumdakiButon = form.Controls.Find(("btn" + (geciciKonum).ToString()), true).FirstOrDefault() as Button;

                    //Bu konumdaki butonda başka bir nesne var mı? Yoksa listeye ekle.
                    if (yeniKonumdakiButon.Image == null)
                    {
                        gidilebilecekButonlar.Add(geciciKonum);
                    }
                    mod = geciciKonum % 8;
                }
            }
            else if (yon == Yon.Yukari)
            {
                // Konum üzerinden işlem yapılacağı için geçici bir değişkene atandı.
                int geciciKonum = Konum;

                while (geciciKonum > 8)
                {
                    geciciKonum = geciciKonum - 8;
                    //Yeni konumdaki buton değişkene atanıyor.
                    Button yeniKonumdakiButon = form.Controls.Find(("btn" + (geciciKonum).ToString()), true).FirstOrDefault() as Button;

                    //Bu konumdaki butonda başka bir nesne var mı? Yoksa listeye ekle.
                    if (yeniKonumdakiButon.Image == null)
                    {
                        gidilebilecekButonlar.Add(geciciKonum);
                    }
                }
            }
            else
            {
                // Konum üzerinden işlem yapılacağı için geçici bir değişkene atandı.
                int geciciKonum = Konum;

                while (geciciKonum < 57)
                {
                    geciciKonum = geciciKonum + 8;
                    //Yeni konumdaki buton değişkene atanıyor.
                    Button yeniKonumdakiButon = form.Controls.Find(("btn" + (geciciKonum).ToString()), true).FirstOrDefault() as Button;

                    //Bu konumdaki butonda başka bir nesne var mı? Yoksa listeye ekle.
                    if (yeniKonumdakiButon.Image == null)
                    {
                        gidilebilecekButonlar.Add(geciciKonum);
                    }
                }
            }

            return gidilebilecekButonlar;
        }

        public void ResimGuncelle(Tas tas,Button button)
        {
            if (tas is Kale)
            {
                button.Image = global::Satranc.Properties.Resources.kale;
            }

            if (tas is At)
            {
                button.Image = global::Satranc.Properties.Resources.at;
            }

            if (tas is Fil)
            {
                button.Image = global::Satranc.Properties.Resources.fil;
            }
        }

        public Boolean UstSinirdaMi()
        {
            if (Konum > 0 && Konum < 9)
            {
                return true;
            }
            return false;
        }

        public Boolean SagSinirdaMi()
        {
            if (Konum % 8 == 0)
            {
                return true;
            }
            return false;
        }

        public Boolean SolSinirdaMi()
        {
            if (Konum % 8 == 1)
            {
                return true;
            }
            return false;
        }

        public Boolean AltSinirdaMi()
        {
            if (Konum > 56 && Konum < 65)
            {
                return true;
            }
            return false;
        }

        public Button ButonBul(Form1 form)
        {
            return form.Controls.Find(("btn" + (Konum).ToString()), true).FirstOrDefault() as Button;
        }

        public enum Yon
        {
            Sag = 0,
            Sol = 1,
            Yukari = 2,
            Asagi = 3
        }

        public List<Yon> GidilebilecekYonler()
        {
            List<Yon> gidilebilecekYonler = new List<Yon>();

            if (SagSinirdaMi() == false)
            {
                gidilebilecekYonler.Add(Yon.Sag);
            }

            if (SolSinirdaMi() == false)
            {
                gidilebilecekYonler.Add(Yon.Sol);
            }

            if (UstSinirdaMi() == false)
            {
                gidilebilecekYonler.Add(Yon.Yukari);
            }

            if (AltSinirdaMi() == false)
            {
                gidilebilecekYonler.Add(Yon.Asagi);
            }

            return gidilebilecekYonler;
        }

    }
}
