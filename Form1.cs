using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		void FELADAT()
		{
			Tollvastagság(3);


            using (new Frissítés(false))
            {
				Csik(50);
				Tulipan(50);
				vastagkor(3, 50);

			}


			kupaalakugrbe(2, 50);

			
			


		}
	}
}
