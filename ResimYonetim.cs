using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    class ResimYonetim
    {

        private static Image DusmanResim;
        private static Image OyuncuResim;
        private static Image LazerResim;
       
        public static Image DusmanResimGetir()
        {
            if (DusmanResim == null)
                DusmanResim = Image.FromFile("dusman.png");

            return DusmanResim;
        }

        public static Image OyuncuResimGetir()
        {
            if (OyuncuResim == null)
                OyuncuResim = Image.FromFile("oyuncu.png");

            return OyuncuResim;
        }

        public static Image LazerResimGetir()
        {
            if (LazerResim == null)
                LazerResim = Image.FromFile("lazer.png");

            return LazerResim;
        }

    }
}
