using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCantidadCifras
{
    class Validar
    {
        public static void validar(KeyPressEventArgs n)
        {
            if (Char.IsDigit(n.KeyChar))
            {
                n.Handled = false;
            }
            else if (Char.IsSeparator(n.KeyChar))
            {
                n.Handled = false;
            }
            else if (Char.IsControl(n.KeyChar))
            {
                n.Handled = false;
            }
            else if (n.KeyChar.ToString().Equals("-"))
            {
                n.Handled = false;
            }
            else
            {
                n.Handled = true;
            }
        }
    }
}
