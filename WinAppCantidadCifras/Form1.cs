using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppCantidadCifras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (textBoxNumero.Text.Length == 0)
            {
                MessageBox.Show("Ingrese un número", "Número no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNumero.Focus();
            }
            else {
                Calcular c = new Calcular(int.Parse(textBoxNumero.Text));
                labelRespuesta.Text = c.cifras().ToString();
                labelRespuesta.Visible = true;
            }
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonCalcular.Focus();
            }
            Validar.validar(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxNumero.Focus();
            labelRespuesta.Visible= false;
        }

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
