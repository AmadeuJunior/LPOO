namespace TWBalance
{
    partial class frmPrincipal
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.btnPostar = new System.Windows.Forms.Button();
            this.btnMentions = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(29, 45);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(911, 426);
            this.dg.TabIndex = 0;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(12, 488);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(280, 20);
            this.txtPost.TabIndex = 2;
            this.txtPost.TextChanged += new System.EventHandler(this.txtPost_TextChanged);
            // 
            // btnPostar
            // 
            this.btnPostar.Location = new System.Drawing.Point(398, 488);
            this.btnPostar.Name = "btnPostar";
            this.btnPostar.Size = new System.Drawing.Size(75, 23);
            this.btnPostar.TabIndex = 3;
            this.btnPostar.Text = "Postar";
            this.btnPostar.UseVisualStyleBackColor = true;
            this.btnPostar.Click += new System.EventHandler(this.btnPostar_Click);
            // 
            // btnMentions
            // 
            this.btnMentions.Location = new System.Drawing.Point(511, 488);
            this.btnMentions.Name = "btnMentions";
            this.btnMentions.Size = new System.Drawing.Size(75, 23);
            this.btnMentions.TabIndex = 4;
            this.btnMentions.Text = "Mentions";
            this.btnMentions.UseVisualStyleBackColor = true;
            this.btnMentions.Click += new System.EventHandler(this.btnMentions_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(1111, 45);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 530);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnMentions);
            this.Controls.Add(this.btnPostar);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.dg);
            this.Name = "frmPrincipal";
            this.Text = "TWbalance";
            this.Load += new System.EventHandler(this.frmTeste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Button btnPostar;
        private System.Windows.Forms.Button btnMentions;
        private System.Windows.Forms.Button btnAtualizar;
    }
}