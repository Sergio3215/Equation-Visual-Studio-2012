namespace Ecuacion
{
    partial class frmEcuacionNL2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEcuacionNL2));
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIncog2 = new System.Windows.Forms.CheckBox();
            this.chkIncog3 = new System.Windows.Forms.CheckBox();
            this.chkIncog4 = new System.Windows.Forms.CheckBox();
            this.cbOperation2 = new System.Windows.Forms.ComboBox();
            this.btnResolve = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.chkIncog1 = new System.Windows.Forms.CheckBox();
            this.cbOperation1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDistributiva = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(235, 52);
            this.txt2.MaxLength = 4;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(51, 29);
            this.txt2.TabIndex = 2;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // txt4
            // 
            this.txt4.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txt4.Location = new System.Drawing.Point(499, 52);
            this.txt4.MaxLength = 4;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(51, 29);
            this.txt4.TabIndex = 5;
            this.txt4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt3_KeyPress);
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txt3.Location = new System.Drawing.Point(400, 52);
            this.txt3.MaxLength = 4;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(51, 29);
            this.txt3.TabIndex = 4;
            this.txt3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt2_KeyPress);
            // 
            // txt5
            // 
            this.txt5.Enabled = false;
            this.txt5.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txt5.Location = new System.Drawing.Point(376, 141);
            this.txt5.MaxLength = 4;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(108, 29);
            this.txt5.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.Location = new System.Drawing.Point(335, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "x =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "=";
            // 
            // chkIncog2
            // 
            this.chkIncog2.AutoSize = true;
            this.chkIncog2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncog2.Location = new System.Drawing.Point(235, 87);
            this.chkIncog2.Name = "chkIncog2";
            this.chkIncog2.Size = new System.Drawing.Size(37, 21);
            this.chkIncog2.TabIndex = 9;
            this.chkIncog2.Text = "X";
            this.chkIncog2.UseVisualStyleBackColor = true;
            this.chkIncog2.CheckedChanged += new System.EventHandler(this.chkIncog2_CheckedChanged);
            // 
            // chkIncog3
            // 
            this.chkIncog3.AutoSize = true;
            this.chkIncog3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.chkIncog3.Location = new System.Drawing.Point(399, 87);
            this.chkIncog3.Name = "chkIncog3";
            this.chkIncog3.Size = new System.Drawing.Size(37, 21);
            this.chkIncog3.TabIndex = 10;
            this.chkIncog3.Text = "X";
            this.chkIncog3.UseVisualStyleBackColor = true;
            this.chkIncog3.CheckedChanged += new System.EventHandler(this.chkIncog3_CheckedChanged);
            // 
            // chkIncog4
            // 
            this.chkIncog4.AutoSize = true;
            this.chkIncog4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.chkIncog4.Location = new System.Drawing.Point(499, 87);
            this.chkIncog4.Name = "chkIncog4";
            this.chkIncog4.Size = new System.Drawing.Size(37, 21);
            this.chkIncog4.TabIndex = 11;
            this.chkIncog4.Text = "X";
            this.chkIncog4.UseVisualStyleBackColor = true;
            this.chkIncog4.CheckedChanged += new System.EventHandler(this.chkIncog4_CheckedChanged);
            // 
            // cbOperation2
            // 
            this.cbOperation2.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cbOperation2.FormattingEnabled = true;
            this.cbOperation2.Items.AddRange(new object[] {
            "",
            "+",
            "-"});
            this.cbOperation2.Location = new System.Drawing.Point(328, 52);
            this.cbOperation2.MaxLength = 1;
            this.cbOperation2.Name = "cbOperation2";
            this.cbOperation2.Size = new System.Drawing.Size(47, 29);
            this.cbOperation2.TabIndex = 3;
            // 
            // btnResolve
            // 
            this.btnResolve.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnResolve.Location = new System.Drawing.Point(192, 144);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(94, 26);
            this.btnResolve.TabIndex = 6;
            this.btnResolve.Text = "Resolver";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Operador";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(62, 52);
            this.txt1.MaxLength = 4;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(51, 29);
            this.txt1.TabIndex = 0;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1_KeyPress);
            // 
            // chkIncog1
            // 
            this.chkIncog1.AutoSize = true;
            this.chkIncog1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncog1.Location = new System.Drawing.Point(62, 87);
            this.chkIncog1.Name = "chkIncog1";
            this.chkIncog1.Size = new System.Drawing.Size(37, 21);
            this.chkIncog1.TabIndex = 8;
            this.chkIncog1.Text = "X";
            this.chkIncog1.UseVisualStyleBackColor = true;
            this.chkIncog1.CheckedChanged += new System.EventHandler(this.chkIncog1_CheckedChanged);
            // 
            // cbOperation1
            // 
            this.cbOperation1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cbOperation1.FormattingEnabled = true;
            this.cbOperation1.Items.AddRange(new object[] {
            "",
            "+",
            "-"});
            this.cbOperation1.Location = new System.Drawing.Point(155, 52);
            this.cbOperation1.MaxLength = 1;
            this.cbOperation1.Name = "cbOperation1";
            this.cbOperation1.Size = new System.Drawing.Size(47, 29);
            this.cbOperation1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Operador";
            // 
            // btnDistributiva
            // 
            this.btnDistributiva.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.btnDistributiva.Location = new System.Drawing.Point(33, 144);
            this.btnDistributiva.Name = "btnDistributiva";
            this.btnDistributiva.Size = new System.Drawing.Size(106, 29);
            this.btnDistributiva.TabIndex = 15;
            this.btnDistributiva.Text = "Distributiva";
            this.btnDistributiva.UseVisualStyleBackColor = true;
            this.btnDistributiva.Click += new System.EventHandler(this.btnDistributiva_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(51, 23);
            this.btnAtras.TabIndex = 16;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmEcuacionNL2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 193);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnDistributiva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.cbOperation1);
            this.Controls.Add(this.cbOperation2);
            this.Controls.Add(this.chkIncog4);
            this.Controls.Add(this.chkIncog3);
            this.Controls.Add(this.chkIncog1);
            this.Controls.Add(this.chkIncog2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEcuacionNL2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecuaciòn de primer grado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmEquacionNL1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIncog2;
        private System.Windows.Forms.CheckBox chkIncog3;
        private System.Windows.Forms.CheckBox chkIncog4;
        private System.Windows.Forms.ComboBox cbOperation2;
        private System.Windows.Forms.Button btnResolve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.CheckBox chkIncog1;
        private System.Windows.Forms.ComboBox cbOperation1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDistributiva;
        private System.Windows.Forms.Button btnAtras;
    }
}

