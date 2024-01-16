namespace Mission3rapport
{
    partial class ListeMedicament
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
            this.label1 = new System.Windows.Forms.Label();
            this.dListeMedicaments = new System.Windows.Forms.DataGridView();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.bdgMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFamilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sélectionner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dListeMedicaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste de médicament";
            // 
            // dListeMedicaments
            // 
            this.dListeMedicaments.AutoGenerateColumns = false;
            this.dListeMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dListeMedicaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomCommercialDataGridViewTextBoxColumn,
            this.idFamilleDataGridViewTextBoxColumn,
            this.compositionDataGridViewTextBoxColumn,
            this.effetsDataGridViewTextBoxColumn,
            this.contreIndicationsDataGridViewTextBoxColumn,
            this.Sélectionner});
            this.dListeMedicaments.DataSource = this.bdgMedicament;
            this.dListeMedicaments.Location = new System.Drawing.Point(12, 62);
            this.dListeMedicaments.Name = "dListeMedicaments";
            this.dListeMedicaments.RowHeadersWidth = 51;
            this.dListeMedicaments.RowTemplate.Height = 24;
            this.dListeMedicaments.Size = new System.Drawing.Size(1107, 412);
            this.dListeMedicaments.TabIndex = 1;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(12, 492);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(177, 45);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.Text = "Enregistrer les informations";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(502, 492);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(177, 45);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter un médicament";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // bdgMedicament
            // 
            this.bdgMedicament.DataSource = typeof(Mission3rapport.medicament);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomCommercialDataGridViewTextBoxColumn
            // 
            this.nomCommercialDataGridViewTextBoxColumn.DataPropertyName = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.HeaderText = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCommercialDataGridViewTextBoxColumn.Name = "nomCommercialDataGridViewTextBoxColumn";
            this.nomCommercialDataGridViewTextBoxColumn.Width = 125;
            // 
            // idFamilleDataGridViewTextBoxColumn
            // 
            this.idFamilleDataGridViewTextBoxColumn.DataPropertyName = "idFamille";
            this.idFamilleDataGridViewTextBoxColumn.HeaderText = "idFamille";
            this.idFamilleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idFamilleDataGridViewTextBoxColumn.Name = "idFamilleDataGridViewTextBoxColumn";
            this.idFamilleDataGridViewTextBoxColumn.Width = 125;
            // 
            // compositionDataGridViewTextBoxColumn
            // 
            this.compositionDataGridViewTextBoxColumn.DataPropertyName = "composition";
            this.compositionDataGridViewTextBoxColumn.HeaderText = "composition";
            this.compositionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.compositionDataGridViewTextBoxColumn.Name = "compositionDataGridViewTextBoxColumn";
            this.compositionDataGridViewTextBoxColumn.Width = 125;
            // 
            // effetsDataGridViewTextBoxColumn
            // 
            this.effetsDataGridViewTextBoxColumn.DataPropertyName = "effets";
            this.effetsDataGridViewTextBoxColumn.HeaderText = "effets";
            this.effetsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.effetsDataGridViewTextBoxColumn.Name = "effetsDataGridViewTextBoxColumn";
            this.effetsDataGridViewTextBoxColumn.Width = 125;
            // 
            // contreIndicationsDataGridViewTextBoxColumn
            // 
            this.contreIndicationsDataGridViewTextBoxColumn.DataPropertyName = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.HeaderText = "contreIndications";
            this.contreIndicationsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contreIndicationsDataGridViewTextBoxColumn.Name = "contreIndicationsDataGridViewTextBoxColumn";
            this.contreIndicationsDataGridViewTextBoxColumn.Width = 125;
            // 
            // Sélectionner
            // 
            this.Sélectionner.HeaderText = "Sélectionner";
            this.Sélectionner.MinimumWidth = 6;
            this.Sélectionner.Name = "Sélectionner";
            this.Sélectionner.Width = 125;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(942, 492);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(177, 45);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer ";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // ListeMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 549);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dListeMedicaments);
            this.Controls.Add(this.label1);
            this.Name = "ListeMedicament";
            this.Text = "ListeMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.dListeMedicaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dListeMedicaments;
        private System.Windows.Forms.BindingSource bdgMedicament;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sélectionner;
        private System.Windows.Forms.Button btnSupprimer;
    }
}