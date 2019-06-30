namespace Ecuacion
{
    partial class frmSabias5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSabias5));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lbl_Img1 = new System.Windows.Forms.Label();
            this.btnAdelante = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAceptar.Location = new System.Drawing.Point(201, 170);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(179, 9);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(277, 77);
            this.lblTexto.TabIndex = 4;
            this.lblTexto.Text = "En el menu secundario veremos  opcion de 2 o mas termino. ";
            // 
            // lbl_Img1
            // 
            this.lbl_Img1.Image = global::Ecuacion.Properties.Resources._9;
            this.lbl_Img1.Location = new System.Drawing.Point(12, 9);
            this.lbl_Img1.Name = "lbl_Img1";
            this.lbl_Img1.Size = new System.Drawing.Size(161, 142);
            this.lbl_Img1.TabIndex = 3;
            // 
            // btnAdelante
            // 
            this.btnAdelante.Image = global::Ecuacion.Properties.Resources.adelante;
            this.btnAdelante.Location = new System.Drawing.Point(404, 158);
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(48, 46);
            this.btnAdelante.TabIndex = 2;
            this.btnAdelante.UseVisualStyleBackColor = true;
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAtras.Image = global::Ecuacion.Properties.Resources.atras;
            this.btnAtras.Location = new System.Drawing.Point(15, 158);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(50, 46);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmSabias5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(464, 222);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lbl_Img1);
            this.Controls.Add(this.btnAdelante);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAceptar);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSabias5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sabias que...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnAdelante;
        private System.Windows.Forms.Label lbl_Img1;
        private System.Windows.Forms.Label lblTexto;
    }
}