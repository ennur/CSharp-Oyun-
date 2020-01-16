using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    class Lazer:Sekil
    {
       private Image resim2;

        public Lazer()
        {
            resim2 = ResimYonetim.LazerResimGetir();
            width = 10;
        }

        public void Ciz(Graphics lazerciz)
        {
           lazerciz.DrawImage(resim2,x, y, width, width);          
        }
        
    }
}
