using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
    public partial class Form1
    {
        void görbevégűtestjobbra(double méret)
        {

            Előre(méret);
            Ív(180, méret / 2);
            Előre(méret);
        }
        void görbevégűtestbalra(double méret)
        {

            Hátra(méret);
            Tollat(fel);
            Ív(180, méret / 2);
            Tollat(le);
            Ív(90, méret / 2);
            Jobbra(90);
            Előre(méret * 1.6);

            Balra(90);
            for (int i = 0; i < 50; i++)
            {
                Jobbra(2);
                Előre(méret / 80);
            }
            Előre(méret / 10);
            Balra(90);
            Előre(méret / 5);
            Hátra(méret / 5);
            Jobbra(90);
            Hátra(méret / 10);
            for (int i = 0; i < 50; i++)
            {
                Hátra(méret / 80);
                Balra(2);
            }
            Jobbra(180);
            for (int i = 0; i < 50; i++)
            {
                Balra(2);
                Előre(méret / 80);
            }
            Előre(méret / 10);
            Jobbra(90);
            Előre(méret / 5);
            Hátra(méret / 5);
            Balra(90);
            Hátra(méret / 10);
            for (int i = 0; i < 50; i++)
            {
                Hátra(méret / 80);
                Jobbra(2);
            }
            Balra(90);

            Hátra(méret * 1.6);
            Balra(90);
            Ív(90, méret / 2);
            Tollat(fel);
            Ív(180, méret / 2);
            Tollat(le);
            Hátra(méret);
        }
        void virág(double méret)
        {
            Balra(90);
            Előre(méret / 5);


            for (int i = 0; i < 15; i++)
            {
                Jobbra(4);
                Előre(méret / 12);
            }
            Jobbra(130);

            //
            for (int i = 0; i < 10; i++)
            {
                Balra(2);
                Előre(méret / 12);
            }

            for (int i = 0; i < 10; i++)
            {
                Balra(12);
                Előre(méret / 24);
            }

            for (int i = 0; i < 15; i++)
            {
                Jobbra(4);
                Előre(méret / 24);
            }

            for (int i = 0; i < 10; i++)
            {
                Jobbra(5);
                Előre(méret / 24);
            }
            for (int i = 0; i < 4; i++)
            {
                Balra(2);
                Előre(méret / 24);
            }

            ////

            for (int i = 0; i < 4; i++)
            {
                Hátra(méret / 24);
                Jobbra(2);
            }

            for (int i = 0; i < 10; i++)
            {
                Hátra(méret / 24);
                Balra(5);
            }

            for (int i = 0; i < 15; i++)
            {
                Hátra(méret / 24);
                Balra(4);
            }

            for (int i = 0; i < 10; i++)
            {
                Hátra(méret / 24);
                Jobbra(12);
            }

            for (int i = 0; i < 10; i++)
            {
                Hátra(méret / 12);
                Jobbra(2);
            }

            Balra(130);
            for (int i = 0; i < 15; i++)
            {
                Hátra(méret / 12);
                Balra(4);
            }

            Hátra(méret / 5);

            /////
            
            Jobbra(180);

            Előre(méret / 5);


            for (int i = 0; i < 15; i++)
            {
                Balra(4);
                Előre(méret / 12);
            }
            Balra(130);

            //
            for (int i = 0; i < 10; i++)
            {
                Jobbra(2);
                Előre(méret / 12);
            }

            for (int i = 0; i < 10; i++)
            {
                Jobbra(12);
                Előre(méret / 24);
            }

            for (int i = 0; i < 15; i++)
            {
                Balra(4);
                Előre(méret / 24);
            }

            for (int i = 0; i < 10; i++)
            {
                Balra(5);
                Előre(méret / 24);
            }
            for (int i = 0; i < 4; i++)
            {
                Jobbra(2);
                Előre(méret / 24);
            }

            ////

            for (int i = 0; i < 4; i++)
            {
                Hátra(méret / 24);
                Balra(2);
            }

            for (int i = 0; i < 10; i++)
            {
                Hátra(méret / 24);
                Jobbra(5);
            }

            for (int i = 0; i < 15; i++)
            {
                Hátra(méret / 24);
                Jobbra(4);
            }

            for (int i = 0; i < 10; i++)
            {
                Hátra(méret / 24);
                Balra(12);
            }

            for (int i = 0; i < 10; i++)
            {
                Hátra(méret / 12);
                Balra(2);
            }

            Jobbra(130);
            for (int i = 0; i < 15; i++)
            {
                Hátra(méret / 12);
                Jobbra(4);
            }

            Hátra(méret / 5);

            Balra(90);

            Tollat(fel);
            Előre(méret / 3);
            Tölt(Color.Black, false);
            Hátra(méret / 3);
            Tollat(le);
            /**/
        }
        void kezdés1(double méret)
        {
            using (new Átmenetileg(Előre, méret)){}
            using (new Átmenetileg(Előre, (méret / 1.5)))
            {
                using (new Átmenetileg(Jobbra, 90))
                {
                    Ív(90, méret / 1.5);
                }
            }
            using (new Átmenetileg(Előre, méret)){}
            Balra(90);
            using (new Átmenetileg(Előre, méret / 3))
            {
                using (new Átmenetileg(Jobbra, 90))
                {
                    Ív(90, méret / 3);
                }
            }

            // VIRÁG 1
            // BEJÖN

            Előre(méret / 2);
            for (int i = 0; i < 12; i++)
            {
                Balra(6);
                Előre(méret / 100);
            }

            virág(méret / 18);

            for (int i = 0; i < 12; i++)
            {
                Hátra(méret / 100);
                Jobbra(6);
            }

            // KIMEGY
            Hátra(méret / 2);

            // VIRÁG 2
            // BEJÖN

            Balra(90);
            Előre(méret / 2);

            for (int i = 0; i < 12; i++)
            {
                Jobbra(6);
                Előre(méret / 100);
            }

            virág(méret / 18);

            for (int i = 0; i < 12; i++)
            {
                Hátra(méret / 100);
                Balra(6);
            }

            // KIMEGY
            Hátra(méret / 2);

            // POSZEIDON STUFF
            Előre(méret / 3);
            Jobbra(90);

            Ív(35, méret / 3);
            Balra(80);
            görbevégűtestbalra((méret / 3) / 3);
            görbevégűtestjobbra((méret / 3) / 3);
            Jobbra(80);
            Ív(55, méret / 3);
            Jobbra(90);
            Előre(méret / 3);
            Jobbra(90);

            Előre(méret / 10);
            Jobbra(90);
            Ív(90, méret / 10);
            Jobbra(90);
            Előre(méret / 10);
            Jobbra(135);
            Tollat(fel);
            Előre(méret / 20);
            Tölt(Color.Black, false);
            Hátra(méret / 20);
            Tollat(le);
            Balra(45);
        }
        void kezdés2(double méret)
        {
            using (new Átmenetileg(Előre, méret)) { }
            Balra(90);
            using (new Átmenetileg(Előre, méret)) { }
            using (new Átmenetileg(Előre, (méret / 1.5)))
            {
                using (new Átmenetileg(Jobbra, 90))
                {
                    Ív(90, méret / 1.5);
                }
            }
            Balra(90);
            using (new Átmenetileg(Előre, méret / 3))
            {
                using (new Átmenetileg(Jobbra, 90))
                {
                    Ív(90, méret / 3);
                }
            }

            // VIRÁG 1
            // BEJÖN

            Előre(méret / 2);
            for (int i = 0; i < 12; i++)
            {
                Balra(6);
                Előre(méret / 100);
            }

            virág(méret / 18);

            for (int i = 0; i < 12; i++)
            {
                Hátra(méret / 100);
                Jobbra(6);
            }

            // KIMEGY
            Hátra(méret / 2);

            // VIRÁG 2
            // BEJÖN

            Balra(90);
            Előre(méret / 2);

            for (int i = 0; i < 12; i++)
            {
                Jobbra(6);
                Előre(méret / 100);
            }

            virág(méret / 18);

            for (int i = 0; i < 12; i++)
            {
                Hátra(méret / 100);
                Balra(6);
            }

            // KIMEGY
            Hátra(méret / 2);
            // POSZEIDON STUFF
            Előre(méret / 3);
            Jobbra(90);

            Ív(35, méret / 3);
            Balra(80);
            görbevégűtestbalra((méret / 3) / 3);
            görbevégűtestjobbra((méret / 3) / 3);
            Jobbra(80);
            Ív(55, méret / 3);
            Jobbra(90);
            Előre(méret / 3);
            Jobbra(90);

            Előre(méret / 10);
            Jobbra(90);
            Ív(90, méret / 10);
            Jobbra(90);
            Előre(méret / 10);
            Jobbra(135);
            Tollat(fel);
            Előre(méret / 20);
            Tölt(Color.Black, false);
            Hátra(méret / 20);
            Tollat(le);
            Balra(45);
        }


        public void egészalap(double méret, int tollvastagi)
        {
            Tollvastagság(tollvastagi);
            kezdés1(méret);
            Jobbra(180);
            kezdés2(méret);
            Jobbra(90);
            Pihi(1000);
            kezdés1(méret);
            Jobbra(180);
            kezdés2(méret);
        }
    }
}
