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


            }
            
            
        }
        void kezdés(double méret)
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
            using (new Átmenetileg(Balra, 45))
            {
                Előre((méret / 3) / 2);
                using (new Átmenetileg(Előre, (méret / 3) / 2)){}
                Balra(90);
                Ív(90, ((méret / 3) / 2) - 3);
            }
        }

    }
}
