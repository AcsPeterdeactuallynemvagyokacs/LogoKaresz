using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LogoKaresz
{
	public partial class Form1 : Form
	{
		// Ez az én branchom //

		void FELADAT()
		{
			Tollat(fel);
			Előre(180);
			Tollat(le);

			//kezdés1(300);
			//kezdés2(300);
			//virág(100);

			//
			using (new Frissítés(false))
			{
				egészalap(200, 2);
			}
			Jobbra(90);
			/**/
		}
	}
}
