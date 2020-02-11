using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    class sivi : musteri
    {
        public int siviTonaj { get; set; }
        public int ozgulagırlık { get; set; }
        public string siviAd
        {
            get { return siviAd; }
            set
            {
                if (value == null)
                    Console.WriteLine("Deger Null Olamaz");
                else siviAd = value;
            }
        }
        public static int sayi = 0;
        public sivi(string i, string a, string m, string wa, int t, int vn, int trh, int msf, int u, string sA,int sT,int sOA) : base (i,a,m,wa,t,vn,trh,msf,u)
        {
            siviAd = sA;
            siviTonaj = sT;
            ozgulagırlık = sOA;
            sayi++;
        }

        public override void bilgiVer()
        {
            Console.WriteLine("Sivi urunun adi: "+siviAd);
            Console.WriteLine("Sivi urunun tonaji: "+siviTonaj);
            Console.WriteLine("Sivi urunun ozgul agirligi: "+ozgulagırlık);
        }
    }
}
