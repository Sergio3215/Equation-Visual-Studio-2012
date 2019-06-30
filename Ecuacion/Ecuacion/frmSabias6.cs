using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Ecuacion
{
    public partial class frmSabias6 : Form
    {
        public frmSabias6()
        {
            InitializeComponent();
        }

        private void Aceptar()
        {
            this.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmSabias5 s = new frmSabias5();
            s.Visible = true;
            this.Visible = false;
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            frmSabias7 s = new frmSabias7();
            s.Visible = true;
            this.Visible = false;
        }

        private void frmSabias1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
