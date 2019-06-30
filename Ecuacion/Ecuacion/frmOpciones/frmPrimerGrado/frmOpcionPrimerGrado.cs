using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ecuacion
{
    public partial class frmOpcionPrimerGrado : Form
    {
        public frmOpcionPrimerGrado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEcuacionNL1 frm = new frmEcuacionNL1();
            frm.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEcuacionNL2 frm = new frmEcuacionNL2();
            frm.Visible = true;
            this.Visible = false;
        }

        private void frmOpcionPrimerGrado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmEntrada n = new frmEntrada();
            n.Visible = true;
            this.Visible = false;

        }
    }
}
