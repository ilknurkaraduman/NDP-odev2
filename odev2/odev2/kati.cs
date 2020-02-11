using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    class kati : musteri
    {
        public string katiAd;
        public int katiTonaj;
        public int paketHacmi;


        public kati(string i, string a, string m, string wa, int t, int vn, int trh, int msf, int u, string kA, int kT, int pHacmi) : base(i, a, m, wa, t, vn, trh, msf, u)
        {
            katiAd = kA;
            katiTonaj = kT;
            paketHacmi = pHacmi;
        }

        public override void bilgiVer()
        {
            Console.WriteLine("kati urunun adi: " + katiAd);
            Console.WriteLine("kati urunun tonaji: " + katiTonaj);
            Console.WriteLine("kati urunun paket hacmi: " + paketHacmi);
        }
    }
}
