using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev7
{
    internal class veriler
    {
        public static String oda, cinsiyet, isim,soyisim;
        public int sayac;

        public static String odabilgi
        {
            get { return oda; }
            set { oda = value; }
        }
        public static String cinsiyetbilgi
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }

        public static String isimbilgi
        {
            get { return isim; }
            set { isim = value; }
        }
        public static String soyisimbilgi
        {
            get { return soyisim; }
            set { soyisim = value; }
        }
    }
}
