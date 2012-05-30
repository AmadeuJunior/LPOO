namespace TWBalance
{
    partial class frmAutorizaAPP
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
            this.btnSolicitarPIN = new System.Windows.Forms.Button();
            this.txtInserePIN = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSolicitarPIN
            // 
            this.btnSolicitarPIN.Location = new System.Drawing.Point(12, 25);
            this.btnSolicitarPIN.Name = "btnSolicitarPIN";
            this.btnSolicitarPIN.Size = new System.Drawing.Size(244, 23);
            this.btnSolicitarPIN.TabIndex = 0;
            this.btnSolicitarPIN.Text = "Solicitar PIN";
            this.btnSolicitarPIN.UseVisualStyleBackColor = true;
            this.btnSolicitarPIN.Click += new System.EventHandler(this.btnSolicitarPIN_Click);
            // 
            // txtInserePIN
            // 
            this.txtInserePIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInserePIN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtInserePIN.Location = new System.Drawing.Point(50, 67);
            this.txtInserePIN.Name = "txtInserePIN";
            this.txtInserePIN.Size = new System.Drawing.Size(161, 22);
            this.txtInserePIN.TabIndex = 1;
            this.txtInserePIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInserePIN.TextChanged += new System.EventHandler(this.txtInserePIN_TextChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(12, 119);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(244, 23);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // frmAutorizaAPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 166);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtInserePIN);
            this.Controls.Add(this.btnSolicitarPIN);
            this.Name = "frmAutorizaAPP";
            this.Text = "Autorizando App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSolicitarPIN;
        private System.Windows.Forms.TextBox txtInserePIN;
        private System.Windows.Forms.Button btnEntrar;
    }
}

