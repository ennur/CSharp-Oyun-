using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    class Dusman:Sekil
    {  
       
       private  Image resim1;

        public Dusman()
        {
            resim1 = ResimYonetim.DusmanResimGetir();
            x = RastgeleSayi.SayiUret(0, 745);
            y = RastgeleSayi.SayiUret(-70, 0);
            width = 40;
            height = 40;

        }


        public void Ciz(Graphics dusmanciz)

        {
            dusmanciz.DrawImage(resim1,x,y, width, height);

        }

        
    }
}
