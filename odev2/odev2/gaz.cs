using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    class gaz : musteri
    {
        public string gazAd;
        public int gazHacim;
        public int gazTipi;
        
        public gaz(string i, string a, string m, string wa, int t, int vn, int trh, int msf, int u, string gA, int gH, int gT) : base(i, a, m, wa, t, vn, trh, msf, u)
        {
            gazAd = gA;
            gazHacim = gH;
            gazTipi = gT;
        }

        public override void bilgiVer()
        {
            Console.WriteLine("gaz urunun adi: " + gazAd);
            Console.WriteLine("gaz urunun hacmi: " + gazHacim);
            Console.WriteLine("gaz urunun tipi: " + gazTipi);
        }
    }
}
