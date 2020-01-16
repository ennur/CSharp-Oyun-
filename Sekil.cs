using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    abstract class Sekil
    {
        private int X;
        private int Y;
        private int Width;
        private int Height;
        public void solaGit()
        {
           
                x -= 10;
        }
        public void sagaGit()
        {  
             
                x += 10;
        }
        public void yukariGit()
        {
            y -= 10;
        }
        public void asagiGit()
        {
            y += 10;
        }

        public int x
        {
            get
            {
                return X;
            }

            set
            {
                X = value;
            }
        }

        public int y
        {
            get
            {
                return Y;
            }

            set
            {
                Y = value;
            }
        }

        public int width
        {
            get
            {
                return Width;
            }

            set
            {
                Width = value;
            }
        }

        public int height
        {
            get
            {
                return Height;
            }

            set
            {
                Height = value;
            }
        }

        public void oyuncuSagaGit()
        {
            sagaGit();
            if (x >= 745)
                solaGit();

        }
        public void oyuncuSolaGit()
        {
            solaGit();
            if (x <= -1)
                sagaGit();
        }

    }
}
