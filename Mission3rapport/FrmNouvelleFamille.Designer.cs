namespace Mission3rapport
{
    partial class FrmNouvelleFamille
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
            this.components = new System.ComponentModel.Container();
            this.IdFamille = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNomFamille = new System.Windows.Forms.TextBox();
            this.nomFamille = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.bdgSFamille = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdgSFamille)).BeginInit();
            this.SuspendLayout();
            // 
            // IdFamille
            // 
            this.IdFamille.AutoSize = true;
            this.IdFamille.Location = new System.Drawing.Point(74, 102);
            this.IdFamille.Name = "IdFamille";
            this.IdFamille.Size = new System.Drawing.Size(63, 16);
            this.IdFamille.TabIndex = 0;
            this.IdFamille.Text = "Identifiant";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(162, 99);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(142, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtNomFamille
            // 
            this.txtNomFamille.Location = new System.Drawing.Point(191, 184);
            this.txtNomFamille.Name = "txtNomFamille";
            this.txtNomFamille.Size = new System.Drawing.Size(142, 22);
            this.txtNomFamille.TabIndex = 3;
            // 
            // nomFamille
            // 
            this.nomFamille.AutoSize = true;
            this.nomFamille.Location = new System.Drawing.Point(74, 184);
            this.nomFamille.Name = "nomFamille";
            this.nomFamille.Size = new System.Drawing.Size(111, 16);
            this.nomFamille.TabIndex = 2;
            this.nomFamille.Text = "Nom de la famille";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnEnregistrer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnregistrer.Location = new System.Drawing.Point(95, 356);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(198, 45);
            this.btnEnregistrer.TabIndex = 4;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // bdgSFamille
            // 
            this.bdgSFamille.DataSource = typeof(Mission3rapport.famille);
            // 
            // FrmNouvelleFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.txtNomFamille);
            this.Controls.Add(this.nomFamille);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.IdFamille);
            this.Name = "FrmNouvelleFamille";
            this.Text = "FrmNouvelleFamille";
            ((System.ComponentModel.ISupportInitialize)(this.bdgSFamille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdFamille;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNomFamille;
        private System.Windows.Forms.Label nomFamille;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.BindingSource bdgSFamille;
    }
}