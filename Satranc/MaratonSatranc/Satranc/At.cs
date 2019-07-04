using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satranc
{
   public class At : Tas
    {        
        public bool DoluMu(Form1 frm)
        {
            Button atYeniKonum = ButonBul(frm);
            return true;
        }

        public override void HareketEt(Form1 form)
        {
            //Button atEskiKonum = ButonBul(frm);

            //while (0<Konum && Konum<65 )
            //{
            //    Konum++;
            //}

            //Button atYeniKonum = ButonBul(frm);

            //if (atYeniKonum.Image == null)
            //{
            //    atEskiKonum.Image = null;
            //    atYeniKonum.Image = global::Satranc.Properties.Resources.kale;
            //}

            Button atEskiKonum = ButonBul(form);

            List<Yon> gidilebilecekYonler = GidilebilecekYonler();

            Random rnd = new Random();
            bool atHamleYapabildiMi = false;
            int gidilecekYonIndex;
            Yon gidilecekYon;
            int geciciAtKonum = 0;
            Button geciciAt;

            do
            {
                if (gidilebilecekYonler.Count > 0)
                {
                    gidilecekYonIndex = rnd.Next(0, gidilebilecekYonler.Count);
                    gidilecekYon = gidilebilecekYonler[gidilecekYonIndex];
                    var gidilebilecekButonlar = BuYondeGidilebilecekButonlar(gidilecekYon, form);

                    // Atın sağa, sola, yukarı, ya da aşağı L harfi gibi
                    // ilerleyebilmesi için en az 2 hamle yapması gerekiyor.
                    if (gidilebilecekButonlar.Count > 1)
                    {

                        // L harfi şeklinde hareket edebilmesi için at sağa ya da sola
                        // 2 hamle yaparsa 1 hamle de yukarı ya da aşağı yapması gerekiyor. 
                        if (gidilecekYon == Yon.Sag || gidilecekYon == Yon.Sol)
                        {
                            // At hangi yöndeyse o yöne doğru 2 adım git

                            if (gidilecekYon == Yon.Sag)
                            {
                                geciciAtKonum = Konum + 2;
                            }

                            if (gidilecekYon == Yon.Sol)
                            {
                                geciciAtKonum = Konum - 2;
                            }


                            // 0 ile 1 arasında bir sayı üret
                            int rastgeleYonIndex = rnd.Next(0, 2);

                            // Yön index 0'sa yukarı 1'se aşağı gitmeye çalış.
                            if (rastgeleYonIndex == 0)
                            {
                                //Üst sınırda değilse ve o konumda başka taş yoksa o konuma yerleş
                                if (!UstSinirdaMi())
                                {
                                    geciciAtKonum = geciciAtKonum - 8;
                                    geciciAt = form.Controls.Find(("btn" + (geciciAtKonum).ToString()), true).FirstOrDefault() as Button;

                                    if (geciciAt.Image == null)
                                    {
                                        atEskiKonum.Image = null;
                                        Konum = geciciAtKonum;
                                        Button atYeniKonum = ButonBul(form);
                                        ResimGuncelle(this, atYeniKonum);
                                        atHamleYapabildiMi = true;
                                    }
                                }
                            }
                            else
                            {
                                //Üst sınırda değilse ve o konumda başka taş yoksa o konuma yerleş
                                if (!AltSinirdaMi())
                                {
                                    geciciAtKonum = geciciAtKonum + 8;
                                    geciciAt = form.Controls.Find(("btn" + (geciciAtKonum).ToString()), true).FirstOrDefault() as Button;

                                    if (geciciAt.Image == null)
                                    {
                                        atEskiKonum.Image = null;
                                        Konum = geciciAtKonum;
                                        Button atYeniKonum = ButonBul(form);
                                        ResimGuncelle(this, atYeniKonum);
                                        atHamleYapabildiMi = true;
                                    }
                                }
                            }

                        }
                        else
                        {
                            if (gidilecekYon == Yon.Yukari || gidilecekYon == Yon.Asagi)
                            {
                                // At hangi yöndeyse o yöne doğru 2 adım git

                                if (gidilecekYon == Yon.Yukari)
                                {
                                    geciciAtKonum = Konum - 16;
                                }

                                if (gidilecekYon == Yon.Asagi)
                                {
                                    geciciAtKonum = Konum + 16;
                                }

                                // 0 ile 1 arasında bir sayı üret
                                int rastgeleYonIndex = rnd.Next(0, 2);

                                // Yön index 0'sa saga 1'se sola gitmeye çalış.
                                if (rastgeleYonIndex == 0)
                                {
                                    //Üst sınırda değilse ve o konumda başka taş yoksa o konuma yerleş
                                    if (!SagSinirdaMi())
                                    {
                                        geciciAtKonum = geciciAtKonum + 1;
                                        geciciAt = form.Controls.Find(("btn" + (geciciAtKonum).ToString()), true).FirstOrDefault() as Button;

                                        if (geciciAt.Image == null)
                                        {
                                            atEskiKonum.Image = null;
                                            Konum = geciciAtKonum;
                                            Button atYeniKonum = ButonBul(form);
                                            ResimGuncelle(this, atYeniKonum);
                                            atHamleYapabildiMi = true;
                                        }
                                    }
                                }
                                else
                                {
                                    //Üst sınırda değilse ve o konumda başka taş yoksa o konuma yerleş
                                    if (!AltSinirdaMi())
                                    {
                                        geciciAtKonum = geciciAtKonum - 1;
                                        geciciAt = form.Controls.Find(("btn" + (geciciAtKonum).ToString()), true).FirstOrDefault() as Button;

                                        if (geciciAt.Image == null)
                                        {
                                            atEskiKonum.Image = null;
                                            Konum = geciciAtKonum;
                                            Button atYeniKonum = ButonBul(form);
                                            ResimGuncelle(this, atYeniKonum);
                                            atHamleYapabildiMi = true;
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
                        atHamleYapabildiMi = false;
                    }
                }
                else
                {
                    break;
                }

            } while (!atHamleYapabildiMi);

        }
    }
}
