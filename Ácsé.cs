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
            Ív(180, méret / 2);
            Tollat(fel);
            Ív(180, méret / 2);
            Tollat(le);
            Hátra(méret);
        }
        void virág(double méret)
        {
            using (new Átmenetileg(Balra, 90))
            {
                Előre(méret / 10);
                for (int i = 0; i < 15; i++)
                {
                    Jobbra(4);
                    Előre(méret / 12);
                }
                for (int i = 0; i < 10; i++)
                {
                    Balra(2);
                    Előre(méret / 12);
                }
            }
            using (new Átmenetileg(Jobbra, 90))
            {
                Előre(méret / 10);
                for (int i = 0; i < 15; i++)
                {
                    Balra(3);
                    Előre(méret / 12);
                }
                for (int i = 0; i < 7; i++)
                {
                    Balra(20);
                    Előre(méret / 12);
                }
                for (int i = 0; i < 19; i++)
                {
                    Jobbra(6);
                    Előre(méret / 12);
                }
                for (int i = 0; i < 5; i++)
                {
                    Balra(2);
                    Előre(méret / 12);
                }
                Balra(49);

                Tollat(fel);
                Hátra(méret * 2.884);
                Tollat(le);

                Balra(90);
                Előre(méret / 10);
                Hátra(méret / 10);
                Jobbra(90);

            using (new Átmenetileg(Jobbra, 90))
                {
                    Előre(méret / 10);
                    for (int i = 0; i < 15; i++)
                    {
                        Balra(4);
                        Előre(méret / 12);
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        Jobbra(2);
                        Előre(méret / 12);
                    }
                }
                using (new Átmenetileg(Balra, 90))
                {
                    Előre(méret / 10);
                    for (int i = 0; i < 15; i++)
                    {
                        Jobbra(3);
                        Előre(méret / 12);
                    }
                    for (int i = 0; i < 7; i++)
                    {
                        Jobbra(20);
                        Előre(méret / 12);
                    }
                    for (int i = 0; i < 19; i++)
                    {
                        Balra(6);
                        Előre(méret / 12);
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Jobbra(2);
                        Előre(méret / 12);
                    }
                }
                Balra(41);

                Tollat(fel);
                Hátra(méret * 2.884);
                Tollat(le);
            } 
        }
        void kezdés1(double méret)
        {
            Tollvastagság(2);
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


            Előre(méret / 2.1);
            for (int i = 0; i < 5; i++)
            {
                Balra(14);
                Előre(méret / 36);
            }
            virág(méret / 21);
            Jobbra(90);
            Tollat(fel);
            Előre(méret / 40);
            Tölt(Color.Black);
            Hátra(méret / 40);

            Jobbra(160);
            Előre(méret / 11.38);
            Jobbra(90);
            Előre(méret / 1.74378);

            Jobbra(90);
            Tollat(le);
            Előre(méret / 2.1);
            for (int i = 0; i < 5; i++)
            {
                Jobbra(14);
                Előre(méret / 36);
            }
            virág(méret / 21);
            Jobbra(90);
            Tollat(fel);
            Előre(méret / 40);
            Tölt(Color.Black);
            Hátra(méret / 40);


            Balra(160);
            Előre(méret / 11.38);
            Balra(90);
            Előre(méret / 1.74378);
            Tollat(le);

            /*
            Jobbra(180);
            Előre(méret / 3);
            Jobbra(90);
            Ív(35, méret / 3);
            Balra(80);
            görbevégűtestbalra((méret / 3) / 3);
            Előre((méret / 3) / 3);
            Ív(90, ((méret / 3) / 3) / 2);
            Jobbra(90);
            Előre((méret / 3) / 1.8333333333);
            Tollat(fel);
            Hátra(méret / 3 + ((méret / 3) * 1.1) - (méret / 3));
            Pihi(4000);
            Jobbra(135);
            Előre((méret / 3) / 17.0542);
            Balra(90);
            Előre((méret / 3) / 17.13288);
            Tollat(le);
            Jobbra(90);
            /*/
            


        }
        void kezdés2(double méret)
        {
            Tollvastagság(2);
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

            Előre(méret / 2.1);
            for (int i = 0; i < 5; i++)
            {
                Balra(14);
                Előre(méret / 36);
            }
            virág(méret / 21);
            Jobbra(90);
            Tollat(fel);
            Előre(méret / 40);
            Tölt(Color.Black);
            Hátra(méret / 40);

            Jobbra(160);
            Előre(méret / 11.38);
            Jobbra(90);
            Előre(méret / 1.74378);

            Jobbra(90);
            Tollat(le);
            Előre(méret / 2.1);
            for (int i = 0; i < 5; i++)
            {
                Jobbra(14);
                Előre(méret / 36);
            }
            virág(méret / 21);
            Jobbra(90);
            Tollat(fel);
            Előre(méret / 40);
            Tölt(Color.Black);
            Hátra(méret / 40);

            Balra(160);
            Előre(méret / 11.38);
            Balra(90);
            Előre(méret / 1.74378);
            Tollat(le);
        }


        void egészalap(double méret)
        {
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
