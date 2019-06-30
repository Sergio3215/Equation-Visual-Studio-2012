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
    public partial class Distributiva : Form
    {
        private string signo;
        public double a, b, c, d,  result, result1, y=0;

        public Distributiva()
        {
            InitializeComponent();
        }

        private void Resolver()
        {
            if (this.Visible != false)
            {
                frmEcuacionNL1 v = new frmEcuacionNL1();
                if (chk3.Checked)
                {
                    if (txt1.TextLength > 0 && txt2.TextLength > 0 && txt3.TextLength > 0)
                    {
                        if (chk1.Checked || chk2.Checked)
                        {
                            if (cb1.Text == "+" || cb1.Text == "-")
                            {
                                if (txt4.Text == "")
                                    txt4.Text = "0";

                                a = double.Parse(txt1.Text);
                                b = double.Parse(txt2.Text);
                                c = double.Parse(txt3.Text);
                                d = double.Parse(txt4.Text);

                                result = (a * b);
                                result1 = (a * c);

                                signo = cb1.Text;

                                if (chk1.Checked)
                                    y = 1;
                                else if (chk2.Checked)
                                    y = 2;

                                v.Distri(result, result1, d, y, signo);
                                v.Visible = true;
                                this.Visible = false;

                                txt1.Text = "";
                                txt2.Text = "";
                                txt3.Text = "";
                                txt4.Text = "";
                            }
                            else
                                MessageBox.Show("Error, Seleccione + o - antes de continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Error, Seleccione una incognita", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Error, ingrese valores antes de continuar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Error, Seleccione los terminos de la distributiva", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Check()
        {
            if (chk3.Checked)
            {
                txt1.Enabled = true;
                txt2.Enabled = true;
                txt3.Enabled = true;
                chk1.Enabled = true;
                chk2.Enabled = true;
                cb1.Enabled = true;
                chk4.Enabled = true;
            }
            else
            {
                txt1.Enabled = false;
                txt2.Enabled = false;
                txt3.Enabled = false;
                chk1.Enabled = false;
                chk2.Enabled = false;
                cb1.Enabled = false;
                chk4.Enabled = false;
            }
        }

        private void Check1()
        {
            if (chk1.Checked)
                chk2.Enabled = false;
            else
                chk2.Enabled = true;
        }
        private void Check2()
        {
            if (chk2.Checked)
                chk1.Enabled = false;
            else
                chk1.Enabled = true;
        }

        private void Check3()
        {
            if (chk4.Checked)
                txt4.Enabled = true;
            else
            {
                txt4.Enabled = false;
                txt4.Text = "";
            }
                
        }

        private void Klous()
        {

            if (this.Visible != false)
            {
                frmEcuacionNL1 n = new frmEcuacionNL1();
                n.Visible = true;
                this.Visible = false;
            }
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            Resolver();
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            Check1();
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            Check2();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Klous();
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            Check3();
        }

        private void Distributiva_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible != false)
            {
                frmEntrada g = new frmEntrada();
                g.Visible = true;
                this.Visible = false;
            }
        }
    }
}
