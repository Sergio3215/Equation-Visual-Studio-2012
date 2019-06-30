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
    public partial class frmEntrada : Form
    {
        public frmEntrada()
        {
            InitializeComponent();
            LoadCheck();
        }

        private void SaveCheck()
        {
            string letra = "";
            byte[] encriptar;

            if (chkMostrarAyuda.Checked)
            {
                letra = "Falso";
                encriptar = System.Text.Encoding.Unicode.GetBytes(letra);
                letra = Convert.ToBase64String(encriptar);

                StreamWriter sw = new StreamWriter("File01");
                sw.Write(letra);
                sw.Close();
            }
            else
            {
                letra = "Verdadero";
                encriptar = System.Text.Encoding.Unicode.GetBytes(letra);
                letra = Convert.ToBase64String(encriptar);

                StreamWriter sw = new StreamWriter("File01");
                sw.Write(letra);
                sw.Close();
            }
        }

        private void LoadCheck()
        {
            string letra = "";
            byte[] nocrypt;
            if (System.IO.File.Exists("File01"))
            {
                StreamReader sr = new StreamReader("File01");

                letra = sr.ReadLine();
                sr.Close();

                nocrypt = Convert.FromBase64String(letra);
                letra = System.Text.Encoding.Unicode.GetString(nocrypt);

                if (letra == "Falso")
                {
                    chkMostrarAyuda.Checked = true;
                }
                else
                {
                    chkMostrarAyuda.Checked = false;
                }
            }
            else
                SaveCheck();
        }

        private void InvocarCheck()
        {
            frmSabias1 s = new frmSabias1();
            if (this.Visible == true)
            {
                if (chkMostrarAyuda.Checked)
                    s.Visible = true;
            }
        }

        private void Check()
        {
            if (chkMostrarAyuda.Checked)
            {
                InvocarCheck();
                SaveCheck();
            }
            else
            {
                SaveCheck();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOpcionPrimerGrado frm = new frmOpcionPrimerGrado();
            frm.Visible = true;
            this.Visible = false;
        }

        private void frmEntrada_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmOpciones.frmSegundoGrado.frmSegundoGrado g = new frmOpciones.frmSegundoGrado.frmSegundoGrado();
            g.Visible = true;
            this.Visible = false;
        }

        private void chkMostrarAyuda_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
