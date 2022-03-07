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

        void negyedkor(double meret, bool felkorrel)
        {
            for (int i = 0; i < 45; i++)
            {
                Előre(meret / 200);
                Balra(1);
            }

            Jobbra(90);

            Előre(meret / 10);
            Hátra(meret / 10);

            Balra(90);


            for (int i = 0; i < 45; i++)
            {
                Előre(meret / 200);
                Balra(1);
            }


            if (felkorrel)
            {
                Jobbra(90);

                Előre(meret / 4);


                Jobbra(90);

                for (int i = 0; i < 90; i++)
                {
                    Előre(meret / 400);
                    Balra(1);
                }

                Előre(meret * 0.3);
                Hátra(meret * 0.3);

                for (int i = 0; i < 90; i++)
                {
                    Hátra(meret / 400);
                    Jobbra(1);
                }

                Balra(90);

                Balra(90);








                for (int i = 0; i < 90; i++)
                {
                    Előre(meret / 400);
                    Jobbra(1);
                }

                Előre(meret * 0.3);
                Hátra(meret * 0.3);

                for (int i = 0; i < 90; i++)
                {
                    Hátra(meret / 400);
                    Balra(1);
                }

                Jobbra(90);

                Hátra(meret / 4);

                Balra(90);
            }
            
        }

        void vastagkor(int vastagsag, double meret)
        {
            

            Előre(meret * 2.75);

            Tollvastagság(vastagsag + 1);

            Jobbra(90);


            negyedkor(meret, true);
            negyedkor(meret, false);
            negyedkor(meret, true);
            negyedkor(meret, false);

            Balra(90);

            Előre(meret * 0.58);
            Hátra(meret * 0.29);

            Jobbra(90);
            Előre(meret * 0.29);
            Hátra(meret * 0.58);

            Előre(meret * 0.29);

            Balra(90);

            Hátra(meret * 0.29);

            Tollvastagság(vastagsag);

            Hátra(meret * 2.75);
            
            

        }



        void kisfelkor(double meret)
        {
            
            Előre(meret * 2 + meret / 4);

            Jobbra(40);

            for (int i = 0; i < 30; i++)
            {
                Előre(meret / 150);
                Jobbra(1);
            }

            for (int i = 0; i < 45; i++)
            {
                Előre(meret / 200);
                Jobbra(3);
            }


            for (int i = 0; i < 45; i++)
            {
                Balra(3);
                Hátra(meret / 200);
            }

            for (int i = 0; i < 30; i++)
            {
                Balra(1);
                Hátra(meret / 150);
            }

            Balra(40);
        }


        void kisfelkor_vissza(double meret)
        {
            Hátra(meret * 2 + meret / 4);
        }

        void kozepsoresz(double meret)
        {
            Jobbra(30);

            Előre(meret / 3);
            
            for (int i = 0; i < 45; i++)
            {
                Előre(meret / 100);
                Jobbra(0.5);
            }

            for (int i = 0; i < 30; i++)
            {
                Előre(meret / 300);
                Balra(1);
            }

            for (int i = 0; i < 60; i++)
            {
                Előre(meret / 100);

                Balra(1);
            }
            

            
        }

        void kozepsoresz_vissza(double meret)
        {
            for (int i = 0; i < 60; i++)
            {
                Jobbra(1);
                Hátra(meret / 100);
            }

            for (int i = 0; i < 30; i++)
            {
                Jobbra(1);
                Hátra(meret / 300);
            }

            for (int i = 0; i < 45; i++)
            {
                Balra(0.5);
                Hátra(meret / 100);
            }

            Hátra(meret / 3);

            Balra(30);
        }

        void felsoresz(double meret)
        {
            

            for (int i = 0; i < 120; i++)
            {
                Előre(meret / 200);
                Balra(2);
            }

            Balra(30);
            Előre(meret * 0.5);

            for (int i = 0; i < 180; i++)
            {
                Előre(meret / 400);
                Jobbra(1);
            }
        }

        void felsoresz_vissza(double meret)
        {
            for (int i = 0; i < 180; i++)
            {
                Balra(1);
                Hátra(meret / 400);
            }

            Hátra(meret * 0.5);
            Jobbra(30);

            for (int i = 0; i < 120; i++)
            {
                Jobbra(2);
                Hátra(meret / 200);
            }
        }

        void kupaalakugorbe(int vastagsag, double meret)
        {
            Tollvastagság(vastagsag);

            kisfelkor(meret);

            kozepsoresz(meret);

            felsoresz(meret);

            felsoresz_vissza(meret);

            kozepsoresz_vissza(meret);

            kisfelkor_vissza(meret);
        }



        void kisfelkor_balra(double meret)
        {
            Hátra(meret * 2 + meret / 4);

            Balra(40);

            for (int i = 0; i < 30; i++)
            {
                Hátra(meret / 150);
                Balra(1);
            }

            for (int i = 0; i < 45; i++)
            {
                Hátra(meret / 200);
                Balra(3);
            }


            for (int i = 0; i < 45; i++)
            {
                Jobbra(3);
                Előre(meret / 200);
            }

            for (int i = 0; i < 30; i++)
            {
                Jobbra(1);
                Előre(meret / 150);
            }

            Jobbra(40);
        }


        void kozepsoresz_balra(double meret)
        {
            Balra(30);

            Hátra(meret / 3);

            for (int i = 0; i < 45; i++)
            {
                Hátra(meret / 100);
                Balra(0.5);
            }

            for (int i = 0; i < 30; i++)
            {
                Hátra(meret / 300);
                Jobbra(1);
            }

            for (int i = 0; i < 60; i++)
            {
                Hátra(meret / 100);

                Jobbra(1);
            }



        }

        void felsoresz_balra(double meret)
        {


            for (int i = 0; i < 120; i++)
            {
                Hátra(meret / 200);
                Jobbra(2);
            }

            Jobbra(30);
            Hátra(meret * 0.5);

            for (int i = 0; i < 180; i++)
            {
                Hátra(meret / 400);
                Balra(1);
            }
        }

        void kisfelkor_vissza_balra(double meret)
        {
            Előre(meret * 2 + meret / 4);
        }

        void kozepsoresz_vissza_balra(double meret)
        {
            for (int i = 0; i < 60; i++)
            {
                Balra(1);
                Előre(meret / 100);
            }

            for (int i = 0; i < 30; i++)
            {
                Balra(1);
                Előre(meret / 300);
            }

            for (int i = 0; i < 45; i++)
            {
                Jobbra(0.5);
                Előre(meret / 100);
            }

            Előre(meret / 3);

            Jobbra(30);
        }

        void felsoresz_vissza_balra(double meret)
        {
            for (int i = 0; i < 180; i++)
            {
                Jobbra(1);
                Előre(meret / 400);
            }

            Előre(meret * 0.5);
            Balra(30);

            for (int i = 0; i < 120; i++)
            {
                Balra(2);
                Előre(meret / 200);
            }
        }

        void kupaalakugorbe_balra(double meret)
        {
            kisfelkor_balra(meret);

            kozepsoresz_balra(meret);

            felsoresz_balra(meret);

            felsoresz_vissza_balra(meret);

            kozepsoresz_vissza_balra(meret);

            kisfelkor_vissza_balra(meret);
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

            

            vastagkor(vastagsag + 1, meret);
            Jobbra(180);
            vastagkor(vastagsag + 1, meret);

            kupaalakugorbe(vastagsag - 1, meret);

            kupaalakugorbe_balra(meret);

            Jobbra(180);

            kupaalakugorbe(vastagsag - 1, meret);

            kupaalakugorbe_balra(meret);

            Jobbra(180);

            Tollvastagság(vastagsag);
        }


        
    }
}
