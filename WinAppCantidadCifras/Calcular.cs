using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCantidadCifras
{
    class Calcular
    {
        int num, cc;
        double r;

        public Calcular(int Num) {
            this.num = Num;
        }

        public int cifras() {
            if (num < 0) {
                num = num * -1;
            }
            r = (Math.Log(num) / Math.Log(10)) + 1;
            cc = Convert.ToInt32 (Math.Round(r));
            return cc;
        }
    }
}
