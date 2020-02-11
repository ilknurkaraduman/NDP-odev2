/***********************************************************************************************************
**                                         SAKARYA ÜNİVERSİTESİ                                           **
**                                BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                               **
**                                 BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ                                 **
**                                    NESNEYE DAYALI PROGRAMLAMA DERSİ                                    **
**                                         2016-2017 BAHAR DÖNEMİ                                         **
**                                                                                                        **
**                                ÖDEV NUMARASI..........: 2                                              **
**                                ÖĞRENCİ ADI............: İLKNUR KARADUMAN                               **
**                                ÖĞRENCİ NUMARASI.......: b161200040                                     **
***********************************************************************************************************/
using System;

namespace odev2
{
    class b161200040
    {
        public static int menu()
        {
            int secim = 0;
            Console.Clear();
            Console.WriteLine("\n....::MENU::....\n");
            Console.WriteLine("1-Kayit Al");
            Console.WriteLine("2-Kayit Listele");
            Console.WriteLine("3-Cıkıs");
            Console.Write("Seciminiz: ");
            secim = Convert.ToInt32(Console.ReadLine());
            return secim;
        }

        static void Main(string[] args)
        {
            musteri[] kayit = new musteri[10000];
            int sayac = 0;
            int secim = 0;
            string i, a, m, wa;
            int t,f, vn, trh, msf, u;


            do
            {
                secim = menu();
                Console.Clear();

                if (secim == 1)
                {
                    secim = menu();
                    Console.Clear();
                        Console.Write("Musteri Adi: ");
                        i = Convert.ToString(Console.ReadLine());
                        Console.Write("Adresi: ");
                        a = Convert.ToString(Console.ReadLine());
                        Console.Write("Telefonu: ");
                        t = int.Parse(Console.ReadLine());
                        Console.Write("Fax: ");
                        f= int.Parse(Console.ReadLine());
                        Console.Write("Mail: ");
                        m= Convert.ToString(Console.ReadLine());
                        Console.Write("Web Adresi: ");
                        wa= Convert.ToString(Console.ReadLine());
                        Console.Write("Vergi No: ");
                        vn= int.Parse(Console.ReadLine());
                        Console.Write("Siparis Tarihi: ");
                        trh= int.Parse(Console.ReadLine());
                        Console.Write("Tasınacak Mesafe: ");
                        msf= int.Parse(Console.ReadLine());
                        Console.Write("Tasınacak Urun (0:sıvı, 1:katı, 2:gaz, 3:degerli urun) : ");
                        u = int.Parse(Console.ReadLine());

                        string sA,kA,gA,duA;
                        int sT, sOA, kT, pHacmi, gH, gT, duT, duH,duAdet, duAgirlik;

                        if(u==0)
                        {
                            Console.WriteLine("Sivi urunun adi: ");
                            sA = Console.ReadLine();
                            Console.WriteLine("Sivi urunun tonaji: ");
                            sT = int.Parse(Console.ReadLine());
                            Console.WriteLine("Sivi urunun ozgul agirligi: ");
                            sOA = int.Parse(Console.ReadLine());
                            Double sivitutari = 1.25 *msf*sT;
                        kayit[sayac++] = new sivi(i, a, m, wa, t, vn, trh, msf, u, sA, sT, sOA);
                    }
                    if (u==1)
                        {
                            Console.WriteLine("kati urunun adi: ");
                            kA = Console.ReadLine();
                            Console.WriteLine("kati urunun tonaji: ");
                            kT = int.Parse(Console.ReadLine());
                            Console.WriteLine("kati urunun paket hacmi: ");
                            pHacmi = int.Parse(Console.ReadLine());
                            int katitutari = kT * 1 * (msf + 1000);
                        kayit[sayac++] = new kati(i, a, m, wa, t, vn, trh, msf, u, kA, kT, pHacmi);
                        }
                        if(u==2)
                        {                        
                        Console.WriteLine("gaz urunun adi: ");
                        gA = Console.ReadLine();
                        Console.WriteLine("gaz urunun hacmi: ");
                        gH = int.Parse(Console.ReadLine());
                        Console.WriteLine("gaz urunun tipi: ");
                        gT = int.Parse(Console.ReadLine());
                        Double gaztutari = gH * 1.1 * (msf + 4000);
                        kayit[sayac++] = new gaz(i, a, m, wa, t, vn, trh, msf, u, gA, gH, gT);
                        }
                    if (u==3)
                        {
                        Console.WriteLine("degUrun urunun adi: ");
                        duA = Console.ReadLine();
                        Console.WriteLine("degUrun urunun hacmi: ");
                        duT = int.Parse(Console.ReadLine());
                        Console.WriteLine("degUrun urunun tonaji: ");
                        duH = int.Parse(Console.ReadLine());
                        Console.WriteLine("degUrun urunun adeti: ");
                        duAdet = int.Parse(Console.ReadLine());
                        Console.WriteLine("degUrun urunun adet agirligi: ");
                        duAgirlik = int.Parse(Console.ReadLine());
                        kayit[sayac++] = new degerliUrun(i, a, m, wa, t, vn, trh, msf, u, duA, duT, duH, duAdet, duAgirlik);
                        }

                    Console.WriteLine("Devam etmek için Tıklayınız");
                    Console.ReadKey();
                }
                
                if (secim == 2)
                {
                    for (int x = 0; x < sayac; x++)
                    {
                        kayit[x].bilgiVer();
                        Console.WriteLine("...................");
                    }

                    Console.WriteLine("Devam etmek için Tıklayınız");
                    Console.ReadKey();
                }

                if (secim != 1 && secim != 2 && secim != 3)
                {
                    Console.WriteLine("Hatali Secim");
                    Console.WriteLine("Devam Etmek İcin Tıklayınız");
                    Console.ReadKey();
                }

            } while (secim != 3);
        }
    }
}
      
