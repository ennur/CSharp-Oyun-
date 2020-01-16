using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Oyun
{
    class Oyuncu:Sekil
    {  
        
        private Image resim; 

        public Lazer LazerOlustur()
        {
            Lazer laz = new Lazer();

            laz.x = x+width/2 - laz.width / 2;

            laz.y = y - 15;

            return laz;
        }

        public Oyuncu()
        {          
            resim = ResimYonetim.OyuncuResimGetir();
            x = 200;
            y = 520;
            width = 40;
        }

        public void Ciz(Graphics savarciz)
            
        { 
            savarciz.DrawImage(resim, x, y, width, width);

        }

    }

}
