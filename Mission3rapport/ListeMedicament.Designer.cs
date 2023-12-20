
namespace gsbRapports 
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nomCommercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFamille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.composition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contreIndications = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgMedicament = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dListeMedicaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // dListeMedicaments
            // 
            this.dListeMedicaments.AutoGenerateColumns = false;
            this.dListeMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dListeMedicaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nomCommercial,
            this.idFamille,
            this.composition,
            this.effets,
            this.contreIndications});
            this.dListeMedicaments.DataSource = this.bdgMedicament;
            this.dListeMedicaments.Location = new System.Drawing.Point(12, 48);
            this.dListeMedicaments.Name = "dListeMedicaments";
            this.dListeMedicaments.RowHeadersWidth = 51;
            this.dListeMedicaments.RowTemplate.Height = 24;
            this.dListeMedicaments.Size = new System.Drawing.Size(1104, 369);
            this.dListeMedicaments.TabIndex = 0;
            this.dListeMedicaments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste de Medicaments";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomCommercial
            // 
            this.nomCommercial.DataPropertyName = "nomCommercial";
            this.nomCommercial.HeaderText = "nomCommercial";
            this.nomCommercial.MinimumWidth = 6;
            this.nomCommercial.Name = "nomCommercial";
            this.nomCommercial.Width = 125;
            // 
            // idFamille
            // 
            this.idFamille.DataPropertyName = "idFamille";
            this.idFamille.HeaderText = "idFamille";
            this.idFamille.MinimumWidth = 6;
            this.idFamille.Name = "idFamille";
            this.idFamille.Width = 125;
            // 
            // composition
            // 
            this.composition.DataPropertyName = "composition";
            this.composition.HeaderText = "composition";
            this.composition.MinimumWidth = 6;
            this.composition.Name = "composition";
            this.composition.Width = 125;
            // 
            // effets
            // 
            this.effets.DataPropertyName = "effets";
            this.effets.HeaderText = "effets";
            this.effets.MinimumWidth = 6;
            this.effets.Name = "effets";
            this.effets.Width = 125;
            // 
            // contreIndications
            // 
            this.contreIndications.DataPropertyName = "contreIndications";
            this.contreIndications.HeaderText = "contreIndications";
            this.contreIndications.MinimumWidth = 6;
            this.contreIndications.Name = "contreIndications";
            this.contreIndications.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // bdgMedicament
            // 
            this.bdgMedicament.DataSource = typeof(Mission3rapport.medicament);
            this.bdgMedicament.CurrentChanged += new System.EventHandler(this.bdgMedicament_CurrentChanged);
            // 
            // ListeMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dListeMedicaments);
            this.Name = "ListeMedicament";
            this.Text = "ListeMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.dListeMedicaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dListeMedicaments;
        private System.Windows.Forms.BindingSource bdgMedicament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effetsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndicationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrirsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamille;
        private System.Windows.Forms.DataGridViewTextBoxColumn composition;
        private System.Windows.Forms.DataGridViewTextBoxColumn effets;
        private System.Windows.Forms.DataGridViewTextBoxColumn contreIndications;
    }
}