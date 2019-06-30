using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ecuacion
{
    public partial class frmEcuacionG2NL1 : Form
    {
        public frmEcuacionG2NL1()
        {
            InitializeComponent();
        }


        // Comienzo del codigo-----------------------------------------------------------------------------------



        //Seleccionas la incognita de la ecuación y los demas se bloquean
        private void Check1()
        {
                if (chkIncog2.Checked  && chkIncog1.Checked)
                    chkIncog3.Enabled = false;
                else
                    chkIncog3.Enabled = true;

                if (chkIncog3.Checked && chkIncog1.Checked)
                    chkIncog2.Enabled = false;
                else
                    chkIncog2.Enabled = true;

                if (chkIncog2.Checked && !chkIncog1.Checked)
                    chkIncog3.Enabled = true;

                if (chkIncog3.Checked && !chkIncog1.Checked)
                    chkIncog2.Enabled = true;

        }

        //Seleccionas la incognita de la ecuación y los demas se bloquean
        private void Check2()
        {
            if (chkIncog3.Checked && chkIncog2.Checked)
                    chkIncog1.Enabled = false;
                else
                    chkIncog1.Enabled = true;

            if (chkIncog1.Checked && chkIncog2.Checked)
                    chkIncog3.Enabled = false;
                else
                    chkIncog3.Enabled = true;

            if (chkIncog3.Checked && !chkIncog2.Checked)
                    chkIncog1.Enabled = true;

            if (chkIncog2.Checked && !chkIncog2.Checked)
                    chkIncog3.Enabled = true;

        }

        //Seleccionas la incognita de la ecuación y los demas se bloquean
        private void Check3()
        {
            if (chkIncog1.Checked && chkIncog3.Checked)
                    chkIncog2.Enabled = false;
                else
                    chkIncog2.Enabled = true;

            if (chkIncog2.Checked && chkIncog3.Checked)
                    chkIncog1.Enabled = false;
                else
                    chkIncog1.Enabled = true;

            if (chkIncog1.Checked && !chkIncog3.Checked)
                    chkIncog2.Enabled = true;

            if (chkIncog2.Checked && !chkIncog3.Checked)
                    chkIncog1.Enabled = true;

        }

        private void Resolv()
        {
            double x = 0, y = 0, a = 0, b = 0, c = 0;
            
            //declaramos segun los chk cual sera la "X" y cual sera la variable a utilizar
            if (txt1.TextLength > 0 && txt2.TextLength > 0 && txt3.TextLength > 0)
            {
                a = double.Parse(txt1.Text);
                b = double.Parse(txt2.Text);
                c = double.Parse(txt3.Text);
                if (cbOperation.Text == "+" || cbOperation.Text == "-")
                {

                    if (chkIncog1.Checked && chkIncog2.Checked)
                    {
                        x = a;
                        y = b;

                        if (cbOperation.Text.Equals("+"))
                        {
                            a = c / ((x + y) / -1);
                        }
                        else if (cbOperation.Text.Equals("-"))
                        {
                            a = c / ((x - y) / -1);
                        }

                        txt4.Text = a.ToString();

                    }

                    //declaramos segun los chk cual sera la "X" y cual sera la variable a utilizar
                    else if (chkIncog1.Checked && chkIncog3.Checked)
                    {
                        x = a;
                        y = c;

                        if (cbOperation.Text.Equals("+"))
                        {
                            c = (x - y) / -1;
                            a = -b / c;
                        }
                        else if (cbOperation.Text.Equals("-"))
                        {
                            c = (x - y) / -1;
                            a = b / c;
                        }

                        txt4.Text = a.ToString();

                    }

                    //declaramos segun los chk cual sera la "X" y cual sera la variable a utilizar
                    else if (chkIncog2.Checked && chkIncog3.Checked)
                    {
                        x = b;
                        y = c;

                        if (cbOperation.Text.Equals("+"))
                        {
                            c = (x - y) / -1;
                            b = -a / c;
                        }
                        else if (cbOperation.Text.Equals("-"))
                        {
                            c = (-x - y) / -1;
                            b = -a / c;
                        }

                        txt4.Text = b.ToString();

                    }
                    else if (!chkIncog1.Checked || !chkIncog2.Checked || !chkIncog3.Checked)
                        MessageBox.Show("Seleccione check para seleccionar la(s) incognita(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Ingrese un valor de suma o resta antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Ingrese un valor antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Fin del codigo------------------------------------------------------------------------------------------
        //Parte de objetos en Design-------------------------------------------------------------------------------

        private void chkIncog1_CheckedChanged(object sender, EventArgs e)
        {
            Check1();
        }

        private void chkIncog2_CheckedChanged(object sender, EventArgs e)
        {
            Check2();
        }

        private void chkIncog3_CheckedChanged(object sender, EventArgs e)
        {
            Check3();

        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar.ToString() == cc.NumberFormat.NegativeSign)
                e.Handled = false;

            else
                e.Handled = true; 
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar.ToString() == cc.NumberFormat.NegativeSign)
                e.Handled = false;

            else
                e.Handled = true; 

        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || e.KeyChar.ToString() == cc.NumberFormat.NegativeSign)
                e.Handled = false;

            else
                e.Handled = true;

        }

        private void btnResolve_Click(object sender, EventArgs e)
        {
            Resolv();
        }

        private void btnDistributiva_Click(object sender, EventArgs e)
        {
            Distributiva dis = new Distributiva();
            dis.Visible = true;
            this.Visible = false;
        }

        private void frmEquacionNL1_FormClosed(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmOpciones.frmSegundoGrado.frmSegundoGrado g = new frmOpciones.frmSegundoGrado.frmSegundoGrado();
            g.Visible = true;
            this.Visible = false;
        }
    }
}
