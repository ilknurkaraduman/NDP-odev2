using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    class degerliUrun : musteri
    {
        public string degUrunAd;
        public int degUrunHacim;
        public int degUrunTonaj;
        public int degUrunAdet;
        public int adetAgirligi;


        public degerliUrun(string i, string a, string m, string wa, int t, int vn, int trh, int msf, int u, string duA, int duT, int duH, int duAdet, int duAgirlik) : base(i, a, m, wa, t, vn, trh, msf, u)
        {
            degUrunAd = duA;
            degUrunHacim = duH;
            degUrunTonaj = duT;
            degUrunAdet = duAdet;
            adetAgirligi = duAgirlik;
        }

        public override void bilgiVer()
        {
            Console.WriteLine("degUrun urunun adi: " + degUrunAd);
            Console.WriteLine("degUrun urunun hacmi: " + degUrunHacim);
            Console.WriteLine("degUrun urunun tonaji: " + degUrunTonaj);
            Console.WriteLine("degUrun urunun adeti: " + degUrunAdet);
            Console.WriteLine("degUrun urunun adet agirligi: " + adetAgirligi);

        }
    }
}
