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
            this.dListeMedicaments = new System.Windows.Forms.DataGridView();
            this.Sélectionner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnXml = new System.Windows.Forms.Button();
            this.dMedicamentsOfferts = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idMedicamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgMedocOfferts = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFamilleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effetsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndicationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgMedicament = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dListeMedicaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMedicamentsOfferts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedocOfferts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // dListeMedicaments
            // 
            this.dListeMedicaments.AutoGenerateColumns = false;
            this.dListeMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dListeMedicaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sélectionner,
            this.idDataGridViewTextBoxColumn,
            this.nomCommercialDataGridViewTextBoxColumn,
            this.idFamilleDataGridViewTextBoxColumn,
            this.compositionDataGridViewTextBoxColumn,
            this.effetsDataGridViewTextBoxColumn,
            this.contreIndicationsDataGridViewTextBoxColumn});
            this.dListeMedicaments.DataSource = this.bdgMedicament;
            this.dListeMedicaments.Location = new System.Drawing.Point(6, 29);
            this.dListeMedicaments.Name = "dListeMedicaments";
            this.dListeMedicaments.RowHeadersWidth = 51;
            this.dListeMedicaments.RowTemplate.Height = 24;
            this.dListeMedicaments.Size = new System.Drawing.Size(715, 276);
            this.dListeMedicaments.TabIndex = 1;
            // 
            // Sélectionner
            // 
            this.Sélectionner.HeaderText = "Sélectionner";
            this.Sélectionner.MinimumWidth = 6;
            this.Sélectionner.Name = "Sélectionner";
            this.Sélectionner.Width = 125;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(13, 342);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(208, 67);
            this.btnEnregistrer.TabIndex = 2;
            this.btnEnregistrer.Text = "Enregistrer les informations";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(276, 342);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(177, 67);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter un médicament";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(530, 342);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(177, 67);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer ";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(444, 371);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(177, 63);
            this.btnXml.TabIndex = 5;
            this.btnXml.Text = "Générer fichier XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // dMedicamentsOfferts
            // 
            this.dMedicamentsOfferts.AutoGenerateColumns = false;
            this.dMedicamentsOfferts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dMedicamentsOfferts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicamentDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn});
            this.dMedicamentsOfferts.DataSource = this.bdgMedocOfferts;
            this.dMedicamentsOfferts.Location = new System.Drawing.Point(32, 54);
            this.dMedicamentsOfferts.Name = "dMedicamentsOfferts";
            this.dMedicamentsOfferts.RowHeadersWidth = 51;
            this.dMedicamentsOfferts.RowTemplate.Height = 24;
            this.dMedicamentsOfferts.Size = new System.Drawing.Size(589, 284);
            this.dMedicamentsOfferts.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEnregistrer);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.dListeMedicaments);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 440);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste Médicament";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dMedicamentsOfferts);
            this.groupBox2.Controls.Add(this.btnXml);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(777, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 440);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste de médicament concernés par des dons";
            // 
            // idMedicamentDataGridViewTextBoxColumn
            // 
            this.idMedicamentDataGridViewTextBoxColumn.DataPropertyName = "idMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.HeaderText = "idMedicament";
            this.idMedicamentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMedicamentDataGridViewTextBoxColumn.Name = "idMedicamentDataGridViewTextBoxColumn";
            this.idMedicamentDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "quantite";
            this.quantiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            this.quantiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdgMedocOfferts
            // 
            this.bdgMedocOfferts.DataSource = typeof(Mission3rapport.offrir);
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
            // bdgMedicament
            // 
            this.bdgMedicament.DataSource = typeof(Mission3rapport.medicament);
            // 
            // ListeMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 594);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListeMedicament";
            this.Text = "ListeMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.dListeMedicaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMedicamentsOfferts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedocOfferts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dListeMedicaments;
        private System.Windows.Forms.BindingSource bdgMedicament;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.BindingSource bdgMedocOfferts;
        private System.Windows.Forms.DataGridView dMedicamentsOfferts;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sélectionner;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}