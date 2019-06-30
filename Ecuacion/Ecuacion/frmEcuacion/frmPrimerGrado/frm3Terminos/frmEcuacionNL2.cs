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
    public partial class frmEcuacionNL2 : Form
    {
        public frmEcuacionNL2()
        {
            InitializeComponent();
        }


        // Comienzo del codigo-----------------------------------------------------------------------------------
        private void Check1()
        {
            if (chkIncog1.Checked)
            {
                chkIncog2.Enabled = false;
                chkIncog3.Enabled = false;
                chkIncog4.Enabled = false;
            }
            else
            {
                chkIncog2.Enabled = true;
                chkIncog3.Enabled = true;
                chkIncog4.Enabled = true;
            }

        }
        private void Check2()
        {
            if (chkIncog2.Checked)
            {
                chkIncog1.Enabled = false;
                chkIncog3.Enabled = false;
                chkIncog4.Enabled = false;
            }
            else
            {
                chkIncog1.Enabled = true;
                chkIncog3.Enabled = true;
                chkIncog4.Enabled = true;
            }

        }
        private void Check3()
        {
            if (chkIncog3.Checked)
            {
                chkIncog1.Enabled = false;
                chkIncog2.Enabled = false;
                chkIncog4.Enabled = false;
            }
            else
            {
                chkIncog1.Enabled = true;
                chkIncog2.Enabled = true;
                chkIncog4.Enabled = true;
            }

        }
        private void Check4()
        {
            if (chkIncog4.Checked)
            {
                chkIncog1.Enabled = false;
                chkIncog3.Enabled = false;
                chkIncog2.Enabled = false;
            }
            else
            {
                chkIncog1.Enabled = true;
                chkIncog3.Enabled = true;
                chkIncog2.Enabled = true;
            }

        }

        private void Resolv()
        {
            double x = 0, a = 0, b = 0, c = 0, d = 0, e = 0;

            if (txt1.TextLength > 0 && txt2.TextLength > 0 && txt3.TextLength > 0 && txt4.TextLength > 0)
            {
                a = Double.Parse(txt1.Text);
                b = Double.Parse(txt2.Text);
                c = Double.Parse(txt3.Text);
                d = Double.Parse(txt4.Text);
                if (cbOperation1.Text == "+" || cbOperation1.Text == "-" || cbOperation2.Text == "-+" || cbOperation2.Text == "-")
                {

                    if (chkIncog1.Checked)
                    {
                        x = a;
                        if (cbOperation1.Text.Equals("+") && cbOperation2.Text.Equals("+"))
                        {
                            e = (d - (b + c)) / x;
                        }

                        else if (cbOperation1.Text.Equals("-") && cbOperation2.Text.Equals("-"))
                        {
                            e = (d - (-b - c)) / x;
                        }

                        else if (cbOperation1.Text.Equals("-") && cbOperation2.Text.Equals("+"))
                        {
                            e = (d - (-b + c)) / x;

                        }

                        else if (cbOperation1.Text.Equals("+") && cbOperation2.Text.Equals("-"))
                        {
                            e = (d - (b - c)) / x;

                        }

                        txt5.Text = e.ToString();
                    }

                    else if (chkIncog2.Checked)
                    {
                        x = b;

                        if (cbOperation1.Text.Equals("+") && cbOperation2.Text.Equals("+"))
                        {
                            if (a >= 0)
                                e = ((d - a) - c) / -x;
                            else
                                e = ((d + a) - c) / -x;
                        }

                        else if (cbOperation1.Text.Equals("-") && cbOperation2.Text.Equals("-"))
                        {
                            if (a >= 0)
                                e = ((d - a) + c) / x;
                            else
                                e = (d + a + c) / x;
                        }

                        else if (cbOperation1.Text.Equals("-") && cbOperation2.Text.Equals("+"))
                        {
                            if (a >= 0)
                                e = ((d - a) - c) / x;
                            else
                                e = ((d + a) - c) / x;

                        }

                        else if (cbOperation1.Text.Equals("+") && cbOperation2.Text.Equals("-"))
                        {
                            if (a >= 0)
                                e = ((d - a) + c) / -x;
                            else
                                e = (d + a + c) / -x;

                        }

                        txt5.Text = e.ToString();

                    }

                    else if (chkIncog3.Checked)
                    {
                        x = c;

                        if (cbOperation1.Text.Equals("+") && cbOperation2.Text.Equals("+"))
                        {
                            e = (d - (a + b)) / x;
                        }

                        else if (cbOperation1.Text.Equals("-") && cbOperation2.Text.Equals("-"))
                        {
                            e = (d - (a - b)) / x;
                        }

                        else if (cbOperation1.Text.Equals("-") && cbOperation2.Text.Equals("+"))
                        {
                            e = (d - (-a + b)) / x;

                        }

                        else if (cbOperation1.Text.Equals("+") && cbOperation2.Text.Equals("-"))
                        {
                            e = (d - (a + b)) / x;

                        }

                        txt5.Text = e.ToString();

                    }

                    else if (chkIncog4.Checked)
                    {
                        x = d;

                        if (cbOperation1.Text.Equals("+") && cbOperation2.Text.Equals("+"))
                        {
                            e = ((a + b + c) / x) / -1;
                        }

                        else if (cbOperation1.Text.Equals("-") && cbOperation2.Text.Equals("-"))
                        {
                            e = ((a - b - c) / x) / -1;
                        }

                        else if (cbOperation1.Text.Equals("-") && cbOperation2.Text.Equals("+"))
                        {
                            e = ((a - b + c) / x) / -1;

                        }

                        else if (cbOperation1.Text.Equals("+") && cbOperation2.Text.Equals("-"))
                        {
                            e = ((a + b - c) / x) / -1;

                        }

                        txt5.Text = e.ToString();

                    }
                    else if (!chkIncog1.Checked || !chkIncog2.Checked || !chkIncog3.Checked || !chkIncog4.Checked)
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

        private void chkIncog4_CheckedChanged(object sender, EventArgs e)
        {
            Check4();

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

        private void frmEquacionNL1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDistributiva_Click(object sender, EventArgs e)
        {
            Distributiva d = new Distributiva();
            d.Visible = true;
            this.Visible = false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            frmOpcionPrimerGrado g = new frmOpcionPrimerGrado();
            g.Visible = true;
            this.Visible = false;
        }
    }
}
