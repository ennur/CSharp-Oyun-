using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Oyun
{
    class AnaPencere:Form
    {
        private Oyuncu oyna;
        private Dusman saldir;
        private Lazer ates;
        private Timer ilerlet;
        private List<Dusman> dusmanlar = new List<Dusman>();
        private List<Lazer> lazerler = new List<Lazer>();
        private int sayac = 0;

        public AnaPencere(int yukseklik, int genislik)
        {
            DoubleBuffered = true;
            Height = yukseklik;
            Width = genislik;
            Text = "UCAKSAVAR";
            BackgroundImage = Image.FromFile("arkaplan.png");
            KeyDown += AnaPencere_KeyDown;
            Paint += AnaPencere_Paint;

            saldir = new Dusman();
            oyna = new Oyuncu();
            ates = new Lazer();

            ilerlet = new Timer();
            ilerlet.Interval = 30;
            ilerlet.Tick += İlerlet_Tick;
                   
        }

        private void İlerlet_Tick(object sender, EventArgs e)
        {
            foreach (var saldir in dusmanlar)
            {
                saldir.y++;
                if (saldir.y == 520)
                    ilerlet.Stop();
            }
                foreach (var ates in lazerler)
                ates.yukariGit();

            if (sayac == 50)
            {
                Dusman d = new Dusman();
                dusmanlar.Add(d);
                sayac = 0;
            }

            sayac++;     
            Invalidate();
         
            for (int i = 0; i < dusmanlar.Count; i++)
            {
                for (int j = 0; j < lazerler.Count; j++)
                {
                    if (dusmanlar[i].x <= (lazerler[j].x + lazerler[j].width) && dusmanlar[i].x + dusmanlar[i].width >= lazerler[j].x &&
                        dusmanlar[i].y <= (lazerler[j].y + lazerler[j].height) && dusmanlar[i].y + dusmanlar[i].height >= lazerler[j].y )
                    {
                        dusmanlar.RemoveAt(i);
                        lazerler.RemoveAt(j);
                    }

                }

            }

        }

        private void AnaPencere_Paint(object sender, PaintEventArgs e)
        {

            oyna.Ciz(e.Graphics);
            foreach(var saldir in dusmanlar)
                saldir.Ciz(e.Graphics);
            foreach (var ates in lazerler)
                ates.Ciz(e.Graphics);
        }

        private void AnaPencere_KeyDown(object sender, KeyEventArgs e)
        {
            
               
                if (e.KeyCode == Keys.Space )
                    {
                        ates= oyna.LazerOlustur();
                        lazerler.Add(ates);            
                    }

                    if (e.KeyCode == Keys.Right)
                    {   
                        oyna.oyuncuSagaGit();
                    }

                    if (e.KeyCode == Keys.Left)
                    {
                        oyna.oyuncuSolaGit();                
                    }
                    if (e.KeyCode == Keys.Enter)
                    {

                        ilerlet.Start();
                    }

            Invalidate();
        }
   
        private void InitializeComponent()
        {
        }      
    }
}
