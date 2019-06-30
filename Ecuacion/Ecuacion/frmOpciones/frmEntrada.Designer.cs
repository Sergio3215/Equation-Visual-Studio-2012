namespace Ecuacion
{
    partial class frmEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntrada));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkMostrarAyuda = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ecuación de primer grado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ecuación de segundo grado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkMostrarAyuda
            // 
            this.chkMostrarAyuda.AutoSize = true;
            this.chkMostrarAyuda.Location = new System.Drawing.Point(221, 189);
            this.chkMostrarAyuda.Name = "chkMostrarAyuda";
            this.chkMostrarAyuda.Size = new System.Drawing.Size(94, 17);
            this.chkMostrarAyuda.TabIndex = 2;
            this.chkMostrarAyuda.Text = "Mostrar Ayuda";
            this.chkMostrarAyuda.UseVisualStyleBackColor = true;
            this.chkMostrarAyuda.CheckedChanged += new System.EventHandler(this.chkMostrarAyuda_CheckedChanged);
            // 
            // frmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 218);
            this.Controls.Add(this.chkMostrarAyuda);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elija el grado de ecuación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEntrada_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkMostrarAyuda;
    }
}