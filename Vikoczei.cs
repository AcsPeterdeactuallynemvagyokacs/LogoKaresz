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


        void Tulipan(double meret)
        {



            Előre(meret * 2);

            Tollat(fel);

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


            Előre(meret / 6);
            Ív(90, meret / 12);


            Tollat(le);

            Balra(90);

            Előre(meret - meret * 0.3);

            Ív(90, meret / 6);




            Jobbra(90);

            Hátra(meret * 1.133333);






            Előre(meret);

            Jobbra(90);

            Tollat(fel);

            Ív(90, meret / 3);


            Hátra(meret / 3 + meret / 3);

            Tollat(le);

            Ív(90, meret / 3);


            Jobbra(90);

            Előre(meret / 3);

            Tollat(fel);

            Jobbra(90);
            Előre(meret / 3);
            Balra(90);

            Tollat(le);

            Előre(meret);




            Bezier(meret / 2, 90, 0, 60, meret * 0.6);



            spiral(meret);



            Tollat(fel);

            Balra(30);

            Hátra(meret * 0.6);





            Tollat(le);

            Balra(60);

            Hátra(meret);

            Jobbra(180);

            Ív(90, meret / 3);

            Jobbra(90);

            Hátra(meret);

        }


        void Tulipanbalra(double meret)
        {
            Hátra(meret * 2);

            Tollat(fel);

            Balra(90);

            for (int i = 0; i < 2; i++)
            {
                Hátra(meret);

                Jobbra(90);

                Hátra(meret / 4);

                Jobbra(90);
            }


            Jobbra(90);

            Hátra(meret / 4);

            Balra(90);

            Hátra(meret / 4);

            Balra(90);



            Hátra(meret / 6);

            Ív(270, meret / 12);


            Tollat(le);

            Jobbra(90);

            Hátra(meret - meret * 0.3);

            Tollat(fel);

            Ív(270, meret / 6);

            Tollat(le);

            Ív(90, meret / 6);

            Tollat(fel);
            Ív(270, meret / 6);
            Tollat(le);

            Jobbra(90);



            Hátra(meret * 1.133333);






            Előre(meret);

            Balra(90);



            Ív(90, meret / 3);





            Előre(meret / 3 + meret / 3 + meret / 3);






            Bezier(meret / 2, 90, 0, -60, meret * 0.6);


            spiralbalra(meret);



            Tollat(fel);

            Jobbra(30);

            Előre(meret * 0.6);





            Tollat(le);

            Jobbra(60);

            Előre(meret);

            Balra(180);
            Tollat(fel);
            Ív(270, meret / 3);
            Tollat(le);




            Jobbra(90);

            Hátra(meret);


            Jobbra(180);

        }


        void Csikbalra(double meret)
        {

            Hátra(meret * 2);

            Balra(90);

            for (int i = 0; i < 2; i++)
            {
                Hátra(meret);

                Jobbra(90);

                Hátra(meret / 4);

                Jobbra(90);
            }

            Jobbra(90);

            Hátra(meret / 4);

            Balra(90);

            Hátra(meret / 4);

            Balra(90);


            gorbevegutestbalra(meret / 6);


            Balra(90);

            Hátra(meret / 6);

            Hátra(meret * 0.4);

            Balra(90);

            gorbevegutestbalra(meret / 6);

            Balra(90);

            Hátra(meret / 6);

            Hátra(meret / 4);

            Balra(90);

            gorbevegutestbalra(meret / 6);


            Balra(90);

            Előre(meret * 0.733333333333333333);

            Jobbra(90);

            Előre(meret * 2);
            Előre(meret / 4);

        }


        void gorbevegutestbalra(double meret)
        {

            Hátra(meret);

            Tollat(fel);

            Ív(180, meret / 2);

            Tollat(le);

            Ív(180, meret / 2);

            Tollat(fel);

            Ív(180, meret / 2);

            Tollat(le);

            Hátra(meret);
        }


        void spiral(double meret)
        {
            Jobbra(40);

            for (int i = 0; i < 180; i++)
            {
                Előre(meret / 300);
                Jobbra(1);
            }


            Jobbra(30);

            for (int i = 0; i < 60; i++)
            {
                Előre(meret / 300);
                Jobbra(1);
            }

            Jobbra(30);

            for (int i = 0; i < 60; i++)
            {
                Előre(meret / 300);
                Jobbra(2);
            }








            for (int i = 0; i < 60; i++)
            {
                Balra(2);
                Hátra(meret / 300);
            }

            Balra(30);

            for (int i = 0; i < 60; i++)
            {
                Balra(1);
                Hátra(meret / 300);
            }

            Balra(30);

            for (int i = 0; i < 180; i++)
            {
                Balra(1);
                Hátra(meret / 300);
            }

            Balra(40);
        }


        void spiralbalra(double meret)
        {
            Balra(40);

            for (int i = 0; i < 180; i++)
            {
                Hátra(meret / 300);
                Balra(1);
            }


            Balra(30);

            for (int i = 0; i < 60; i++)
            {
                Hátra(meret / 300);
                Balra(1);
            }

            Balra(30);

            for (int i = 0; i < 60; i++)
            {
                Hátra(meret / 300);
                Balra(2);
            }








            for (int i = 0; i < 60; i++)
            {
                Jobbra(2);
                Előre(meret / 300);
            }

            Jobbra(30);

            for (int i = 0; i < 60; i++)
            {
                Jobbra(1);
                Előre(meret / 300);
            }

            Jobbra(30);

            for (int i = 0; i < 180; i++)
            {
                Jobbra(1);
                Előre(meret / 300);
            }

            Jobbra(40);
        }



        void vastagkor(int vastagsag, double meret)
        {
            

            Előre(meret * 2.75);

            Tollvastagság(vastagsag + 1);

            Jobbra(90);

        }



        void Ajto(int vastagsag, double meret)
        {
            Tollvastagság(vastagsag);

            Csik(meret);
            Tulipan(meret);

            

            Csikbalra(meret);
            Tulipanbalra(meret);


            Jobbra(180);

            Csik(meret);
            Tulipan(meret);


            

            Csikbalra(meret);
            Tulipanbalra(meret);

            Jobbra(180);
        }
    }
}
