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
    public partial class frmEcuacionNL1 : Form
    {
        public frmEcuacionNL1()
        {
            InitializeComponent();
        }


        // Comienzo del codigo-----------------------------------------------------------------------------------
        public void Distri(double result, double result1, double d, double y, string signo)
        {
            double result2 = 0, result3 = 0, txt3D;

            result2 = result;
            result3 = result1;
            txt3D = d;

            txt1.Text = result2.ToString();
            txt2.Text = result3.ToString();
            txt3.Text = txt3D.ToString();
            cbOperation.Text = signo;

            double x = y;

            if (x == 1)
                chkIncog1.Checked = true;
            else if (x == 2)
                chkIncog2.Checked = true;

        }


        //Seleccionas la incognita de la ecuación y los demas se bloquean
        private void Check1()
        {
            if (chkIncog1.Checked)
            {
                chkIncog2.Enabled = false;
                chkIncog3.Enabled = false;
            }
            else
            {
                chkIncog2.Enabled = true;
                chkIncog3.Enabled = true;
            }

        }

        //Seleccionas la incognita de la ecuación y los demas se bloquean
        private void Check2()
        {
            if (chkIncog2.Checked)
            {
                chkIncog1.Enabled = false;
                chkIncog3.Enabled = false;
            }
            else
            {
                chkIncog1.Enabled = true;
                chkIncog3.Enabled = true;
            }

        }

        //Seleccionas la incognita de la ecuación y los demas se bloquean
        private void Check3()
        {
            if (chkIncog3.Checked)
            {
                chkIncog2.Enabled = false;
                chkIncog1.Enabled = false;
            }
            else
            {
                chkIncog2.Enabled = true;
                chkIncog1.Enabled = true;
            }

        }

        private void Resolv()
        {
            double x = 0, a = 0, b = 0, c = 0;//declaramos segun los chk cual sera la "X" y cual sera la variable a utilizar
            if (txt1.TextLength > 0 && txt2.TextLength > 0 && txt3.TextLength > 0)
            {
                a = double.Parse(txt1.Text);
                b = double.Parse(txt2.Text);
                c = double.Parse(txt3.Text);
                if (cbOperation.Text == "+" || cbOperation.Text == "-")
                {
                    if (chkIncog1.Checked)
                    {
                        x = a;
                        if (cbOperation.Text.Equals("+"))
                        {
                            if (a >= 0)
                                c = (b - a) / x;
                            else
                                c = (b + a) / x;
                        }
                        else if (cbOperation.Text.Equals("-"))
                        {
                            if (a >= 0)
                                c = (b + a) / x;
                            else
                                c = (b + a) / x;

                        }

                        txt4.Text = c.ToString();

                    }
                    //declaramos segun los chk cual sera la "X" y cual sera la variable a utilizar
                    else if (chkIncog2.Checked)
                    {
                        a = double.Parse(txt1.Text);
                        x = double.Parse(txt2.Text);
                        b = double.Parse(txt3.Text);

                        if (cbOperation.Text.Equals("+"))
                        {
                            if (a >= 0)
                                c = (b - a) / -x;
                            else
                                c = (b + a) / -x;
                        }
                        else if (cbOperation.Text.Equals("-"))
                        {
                            if (a >= 0)
                                c = (b - a) / x;
                            else
                                c = (b + a) / x;
                        }

                        txt4.Text = c.ToString();

                    }

                    //declaramos segun los chk cual sera la "X" y cual sera la variable a utilizar
                    else if (chkIncog3.Checked)
                    {
                        a = double.Parse(txt1.Text);
                        b = double.Parse(txt2.Text);
                        x = double.Parse(txt3.Text);

                        if (cbOperation.Text.Equals("+"))
                        {
                            c = (a + b) / x;
                            c = c / -1;
                        }
                        else if (cbOperation.Text.Equals("-"))
                        {
                            c = (a - b) / x;
                            c = c / -1;
                        }

                        txt4.Text = c.ToString();

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
            frmOpcionPrimerGrado g = new frmOpcionPrimerGrado();
            g.Visible = true;
            this.Visible = false;
        }
    }
}
