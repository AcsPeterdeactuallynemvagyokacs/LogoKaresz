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
    partial class Form1
    {
       


        void gorbevegutest(double meret)
        {
            
            Előre(meret);
            Ív(180, meret / 2);
            Előre(meret);
        }



        void Csik(double meret)
        {
            Tollvastagság(2);

            Előre(meret * 2);

            Jobbra(90);

            for (int i = 0; i < 2; i++)
            {
                Előre(meret);

                Balra(90);

                Előre(meret / 4);

                Balra(90);
            }

            Balra(90);

            Előre(meret / 4);

            Jobbra(90);

            Előre(meret / 4);

            Jobbra(90);
            

            gorbevegutest(meret / 6);


            Jobbra(90);

            Előre(meret / 6);

            Előre(meret * 0.4);

            Jobbra(90);

            gorbevegutest(meret / 6);

            Jobbra(90);

            Előre(meret / 6);

            Előre(meret / 4);

            Jobbra(90);

            gorbevegutest(meret / 6);


            Jobbra(90);

            Hátra(meret * 0.733333333333333333);

            Balra(90);

            Hátra(meret * 2);
            Hátra(meret / 4);
            


            





           


        }



        



        
    }
}
