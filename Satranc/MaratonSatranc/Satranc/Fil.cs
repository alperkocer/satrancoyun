using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranc
{
    public class Fil: Tas
    {

        //public override void HareketEt(Form1 frm)
        //{
        //    Button filEskiKonum = ButonBul(frm);

        //    List<Yon> gidilebilecekYonler = GidilebilecekYonler();

        //    Random rnd = new Random();

        //    int gidilecekYonIndex = rnd.Next(0, gidilebilecekYonler.Count);
        //    Yon gidilecekYon = gidilebilecekYonler[gidilecekYonIndex];

        //    var gidilebilecekButonlar = BuYondeGidilebilecekButonlar(gidilecekYon, frm);
        //    if (gidilebilecekButonlar.Count > 0)
        //    {
        //        filEskiKonum.Image = null;
        //        int deneme = gidilebilecekButonlar.Count;
        //        Konum = gidilebilecekButonlar[rnd.Next(0, deneme)];
        //        Button kaleYeniKonum = ButonBul(frm);

        //        ResimGuncelle(this, kaleYeniKonum);
        //    }


        //}

        public bool DoluMu(Form1 frm)
        {
            Button atYeniKonum = ButonBul(frm);
            return true;
        }

        public override void HareketEt(Form1 form)
        {
            

            Button filEskiKonum = ButonBul(form);

            List<Yon> gidilebilecekYonler = GidilebilecekYonler();

            Random rnd = new Random();
            bool filHamleYapabildiMi = false;
            int gidilecekYonIndex;
            Yon gidilecekYon;
            int geciciFilKonum = 0;
            Button geciciFil;

            do
            {
                if (gidilebilecekYonler.Count > 0)
                {
                    gidilecekYonIndex = rnd.Next(0, gidilebilecekYonler.Count);
                    gidilecekYon = gidilebilecekYonler[gidilecekYonIndex];
                    var gidilebilecekButonlar = BuYondeGidilebilecekButonlar(gidilecekYon, form);

                    // filinn sağa, sola, yukarı, ya da aşağı küçük L harfi gibi
                    // ilerleyebilmesi için en az 2 hamle yapması gerekiyor.
                    if (gidilebilecekButonlar.Count > 1)
                    {

                        // L harfi şeklinde hareket edebilmesi için fil sağa ya da sola
                        // 2 hamle yaparsa 1 hamle de yukarı ya da aşağı yapması gerekiyor. 
                        if (gidilecekYon == Yon.Sag || gidilecekYon == Yon.Sol)
                        {
                            // fil hangi yöndeyse o yöne doğru 1 adım git

                            if (gidilecekYon == Yon.Sag)
                            {
                                geciciFilKonum = Konum + 1;
                            }

                            if (gidilecekYon == Yon.Sol)
                            {
                                geciciFilKonum = Konum - 1;
                            }


                            // 0 ile 1 arasında bir sayı üret
                            int rastgeleYonIndex = rnd.Next(0, 1);

                            // Yön index 0'sa yukarı 1'se aşağı gitmeye çalış.
                            if (rastgeleYonIndex == 0)
                            {
                                //Üst sınırda değilse ve o konumda başka taş yoksa o konuma yerleş
                                if (!UstSinirdaMi())
                                {
                                    geciciFilKonum = geciciFilKonum - 8;
                                    geciciFil = form.Controls.Find(("btn" + (geciciFilKonum).ToString()), true).FirstOrDefault() as Button;

                                    if (geciciFil.Image == null)
                                    {
                                        filEskiKonum.Image = null;
                                        Konum = geciciFilKonum;
                                        Button filYeniKonum = ButonBul(form);
                                        ResimGuncelle(this, filYeniKonum);
                                        filHamleYapabildiMi = true;
                                    }
                                }
                            }
                            else
                            {
                                //Üst sınırda değilse ve o konumda başka taş yoksa o konuma yerleş
                                if (!AltSinirdaMi())
                                {
                                    geciciFilKonum = geciciFilKonum + 8;
                                    geciciFil = form.Controls.Find(("btn" + (geciciFilKonum).ToString()), true).FirstOrDefault() as Button;

                                    if (geciciFil.Image == null)
                                    {
                                        filEskiKonum.Image = null;
                                        Konum = geciciFilKonum;
                                        Button filYeniKonum = ButonBul(form);
                                        ResimGuncelle(this, filYeniKonum);
                                        filHamleYapabildiMi = true;
                                    }
                                }
                            }

                        }
                        else
                        {
                            if (gidilecekYon == Yon.Yukari || gidilecekYon == Yon.Asagi)
                            {
                                // fil hangi yöndeyse o yöne doğru 2 adım git

                                if (gidilecekYon == Yon.Yukari)
                                {
                                    geciciFilKonum = Konum - 8;
                                }

                                if (gidilecekYon == Yon.Asagi)
                                {
                                    geciciFilKonum = Konum + 8;
                                }

                                // 0 ile 1 arasında bir sayı üret
                                int rastgeleYonIndex = rnd.Next(0, 1);

                                // Yön index 0'sa saga 1'se sola gitmeye çalış.
                                if (rastgeleYonIndex == 0)
                                {
                                    //Üst sınırda değilse ve o konumda başka taş yoksa o konuma yerleş
                                    if (!SagSinirdaMi())
                                    {
                                        geciciFilKonum = geciciFilKonum + 1;
                                        geciciFil = form.Controls.Find(("btn" + (geciciFilKonum).ToString()), true).FirstOrDefault() as Button;

                                        if (geciciFil.Image == null)
                                        {
                                            filEskiKonum.Image = null;
                                            Konum = geciciFilKonum;
                                            Button filYeniKonum = ButonBul(form);
                                            ResimGuncelle(this, filYeniKonum);
                                            filHamleYapabildiMi = true;
                                        }
                                    }
                                }
                                else
                                {
                                    //Üst sınırda değilse ve o konumda başka taş yoksa o konuma yerleş
                                    if (!AltSinirdaMi())
                                    {
                                        geciciFilKonum = geciciFilKonum - 1;
                                        geciciFil = form.Controls.Find(("btn" + (geciciFilKonum).ToString()), true).FirstOrDefault() as Button;

                                        if (geciciFil.Image == null)
                                        {
                                            filEskiKonum.Image = null;
                                            Konum = geciciFilKonum;
                                            Button filYeniKonum = ButonBul(form);
                                            ResimGuncelle(this, filYeniKonum);
                                            filHamleYapabildiMi = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // Bu yöne gidilemediği için bu yönü sil
                        gidilebilecekYonler.Remove(gidilecekYon);
                        filHamleYapabildiMi = false;
                    }
                }
                else
                {
                    break;
                }

            } while (!filHamleYapabildiMi);

        }
    }
}
