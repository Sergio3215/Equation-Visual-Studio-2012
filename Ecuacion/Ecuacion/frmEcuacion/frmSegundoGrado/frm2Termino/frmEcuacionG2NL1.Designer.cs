namespace Ecuacion
{
    partial class frmEcuacionG2NL1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEcuacionG2NL1));
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIncog1 = new System.Windows.Forms.CheckBox();
            this.chkIncog2 = new System.Windows.Forms.CheckBox();
            this.chkIncog3 = new System.Windows.Forms.CheckBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.btnResolve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDistributiva = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(12, 53);
            this.txt1.MaxLength = 4;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(51, 29);
            this.txt1.TabIndex = 0;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txt3.Location = new System.Drawing.Point(276, 53);
            this.txt3.MaxLength = 4;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(51, 29);
            this.txt3.TabIndex = 3;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3_KeyPress);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txt2.Location = new System.Drawing.Point(177, 53);
            this.txt2.MaxLength = 4;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(51, 29);
            this.txt2.TabIndex = 2;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // txt4
            // 
            this.txt4.Enabled = false;
            this.txt4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txt4.Location = new System.Drawing.Point(219, 142);
            this.txt4.MaxLength = 4;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(108, 29);
            this.txt4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.Location = new System.Drawing.Point(178, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "x =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "=";
            // 
            // chkIncog1
            // 
            this.chkIncog1.AutoSize = true;
            this.chkIncog1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncog1.Location = new System.Drawing.Point(12, 88);
            this.chkIncog1.Name = "chkIncog1";
            this.chkIncog1.Size = new System.Drawing.Size(37, 21);
            this.chkIncog1.TabIndex = 4;
            this.chkIncog1.Text = "X";
            this.chkIncog1.UseVisualStyleBackColor = true;
            this.chkIncog1.CheckedChanged += new System.EventHandler(this.chkIncog1_CheckedChanged);
            // 
            // chkIncog2
            // 
            this.chkIncog2.AutoSize = true;
            this.chkIncog2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.chkIncog2.Location = new System.Drawing.Point(176, 88);
            this.chkIncog2.Name = "chkIncog2";
            this.chkIncog2.Size = new System.Drawing.Size(37, 21);
            this.chkIncog2.TabIndex = 5;
            this.chkIncog2.Text = "X";
            this.chkIncog2.UseVisualStyleBackColor = true;
            this.chkIncog2.CheckedChanged += new System.EventHandler(this.chkIncog2_CheckedChanged);
            // 
            // chkIncog3
            // 
            this.chkIncog3.AutoSize = true;
            this.chkIncog3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.chkIncog3.Location = new System.Drawing.Point(276, 88);
            this.chkIncog3.Name = "chkIncog3";
            this.chkIncog3.Size = new System.Drawing.Size(37, 21);
            this.chkIncog3.TabIndex = 6;
            this.chkIncog3.Text = "X";
            this.chkIncog3.UseVisualStyleBackColor = true;
            this.chkIncog3.CheckedChanged += new System.EventHandler(this.chkIncog3_CheckedChanged);
            // 
            // cbOperation
            // 
            this.cbOperation.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Items.AddRange(new object[] {
            "",
            "+",
            "-"});
            this.cbOperation.Location = new System.Drawing.Point(105, 53);
            this.cbOperation.MaxLength = 1;
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(47, 29);
            this.cbOperation.TabIndex = 1;
            // 
            // btnResolve
            // 
            this.btnResolve.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnResolve.Location = new System.Drawing.Point(58, 145);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(94, 26);
            this.btnResolve.TabIndex = 10;
            this.btnResolve.Text = "Resolver";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Operador";
            // 
            // btnDistributiva
            // 
            this.btnDistributiva.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnDistributiva.Location = new System.Drawing.Point(106, 193);
            this.btnDistributiva.Name = "btnDistributiva";
            this.btnDistributiva.Size = new System.Drawing.Size(122, 34);
            this.btnDistributiva.TabIndex = 12;
            this.btnDistributiva.Text = "Distributiva";
            this.btnDistributiva.UseVisualStyleBackColor = true;
            this.btnDistributiva.Click += new System.EventHandler(this.btnDistributiva_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(51, 23);
            this.btnAtras.TabIndex = 14;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmEcuacionG2NL1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 239);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnDistributiva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.chkIncog3);
            this.Controls.Add(this.chkIncog2);
            this.Controls.Add(this.chkIncog1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEcuacionG2NL1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecuaciòn de segundo grado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEquacionNL1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIncog1;
        private System.Windows.Forms.CheckBox chkIncog2;
        private System.Windows.Forms.CheckBox chkIncog3;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDistributiva;
        private System.Windows.Forms.Button btnAtras;
    }
}

