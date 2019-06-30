namespace Ecuacion.frmOpciones.frmSegundoGrado
{
    partial class frmSegundoGrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSegundoGrado));
            this.btnPrimeTermino = new System.Windows.Forms.Button();
            this.btnSegundoTermino = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrimeTermino
            // 
            this.btnPrimeTermino.Location = new System.Drawing.Point(83, 54);
            this.btnPrimeTermino.Name = "btnPrimeTermino";
            this.btnPrimeTermino.Size = new System.Drawing.Size(107, 38);
            this.btnPrimeTermino.TabIndex = 0;
            this.btnPrimeTermino.Text = "2 Termino";
            this.btnPrimeTermino.UseVisualStyleBackColor = true;
            this.btnPrimeTermino.Click += new System.EventHandler(this.btnPrimeTermino_Click);
            // 
            // btnSegundoTermino
            // 
            this.btnSegundoTermino.Location = new System.Drawing.Point(83, 123);
            this.btnSegundoTermino.Name = "btnSegundoTermino";
            this.btnSegundoTermino.Size = new System.Drawing.Size(107, 38);
            this.btnSegundoTermino.TabIndex = 1;
            this.btnSegundoTermino.Text = "3 Termino";
            this.btnSegundoTermino.UseVisualStyleBackColor = true;
            this.btnSegundoTermino.Click += new System.EventHandler(this.btnSegundoTermino_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(40, 23);
            this.btnAtras.TabIndex = 0;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmSegundoGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 209);
            this.Controls.Add(this.btnSegundoTermino);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnPrimeTermino);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSegundoGrado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de Terminos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrimeTermino;
        private System.Windows.Forms.Button btnSegundoTermino;
        private System.Windows.Forms.Button btnAtras;
    }
}