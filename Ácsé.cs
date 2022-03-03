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
        void kezdés(double méret)
        {
            Tollvastagság(2);
            using (new Átmenetileg(Előre, méret)){}
            using (new Átmenetileg(Előre, méret / 3))
            {
                using (new Átmenetileg(Jobbra, 90))
                {
                    Ív(90, méret / 3);
                }
            }
            using (new Átmenetileg(Balra, 45))
            {
                Előre((méret / 3));
            }
        }

    }
}
