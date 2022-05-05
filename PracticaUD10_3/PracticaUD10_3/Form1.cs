using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaUD10_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            string text = "", nombre, apellido, tlf;

            tlf = tMovil.Text;
            nombre = tNombre.Text;
            apellido = tApellidos.Text;

            text = text + ("Nombre Completo: " + nombre + " " + apellido + "             Nº Teléfono: " + tlf);

            lSocios.Text = lSocios.Text + text + "\n\n";
        }
    }
}
