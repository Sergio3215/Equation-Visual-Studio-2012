using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ecuacion.frmOpciones.frmSegundoGrado
{
    public partial class frmSegundoGrado : Form
    {
        public frmSegundoGrado()
        {
            InitializeComponent();
        }

        private void btnPrimeTermino_Click(object sender, EventArgs e)
        {
            frmEcuacionG2NL1 g = new frmEcuacionG2NL1();
            g.Visible = true;
            this.Visible = false;
        }

        private void btnSegundoTermino_Click(object sender, EventArgs e)
        {
            frmEcuacionG2NL2 g = new frmEcuacionG2NL2();
            g.Visible = true;
            this.Visible = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmEntrada n = new frmEntrada();
            n.Visible = true;
            this.Visible = false;
        }
    }
}
