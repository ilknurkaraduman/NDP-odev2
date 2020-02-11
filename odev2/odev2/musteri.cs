using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    class musteri
    {
        public string isim;
        public string adres;
        public string mail;
        public string webadres;
        public int tel;
        public int fax;
        public int vergino;
        public int tarih;
        public int mesafe;
        public int urun;
        private string i;
        private string a;
        private string m;
        private string wa;
        private int t;
        private int vn;
        private int trh;
        private int msf;
        private int u;

        public musteri(string i, string a, string m, string wa, int t, int vn, int trh, int msf, int u)
        {
            this.i = i;
            this.a = a;
            this.m = m;
            this.wa = wa;
            this.t = t;
            this.vn = vn;
            this.trh = trh;
            this.msf = msf;
            this.u = u;
        }

        public musteri(string i, string a, string m, string wa, int t, int f, int vn, int trh, int msf, int u)
        {
            isim = i;
            adres = a;
            mail = m;
            webadres = wa;
            tel = t;
            fax = f;
            vergino = vn;
            tarih = trh;
            mesafe = msf;
            urun = u;
        }
        public virtual void bilgiVer()
        {
            Console.WriteLine("Musteri Adi:" + isim);
            Console.WriteLine("Adresi:" + adres);
            Console.WriteLine("Telefonu:" + tel);
            Console.WriteLine("Mail" + mail);
            Console.WriteLine("Web adresi" + webadres);
            Console.WriteLine("Vergi no" + vergino);
            Console.WriteLine("Siparis Tarihi" + tarih);
            Console.WriteLine("Tasinacak mesafe" + mesafe);
            Console.WriteLine("Tasinacak urun" + urun);

        }
    }
}