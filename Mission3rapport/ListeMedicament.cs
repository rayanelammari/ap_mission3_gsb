using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3rapport
{
    public partial class ListeMedicament : Form
    {
        private gsb2023Entities mesDonnees;
        private string familleSelectionnee;
        public ListeMedicament(gsb2023Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgMedicament.DataSource = mesDonnees.medicaments.ToList();
            this.familleSelectionnee = "";
        }
        public void MettreAJourMedicaments(List<medicament> medicaments)
        {   

            this.dListeMedicaments.DataSource = medicaments;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        { 
                this.bdgMedicament.EndEdit();
                this.mesDonnees.SaveChanges();
                MessageBox.Show("Enregistrement validé");
         
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmAjouterMedicament F2 = new FrmAjouterMedicament(this.mesDonnees);
            F2.Show();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Stockez la famille sélectionnée avant la suppression
            string familleAvantSuppression = familleSelectionnee;

            // Récupérez les lignes sélectionnées
            List<DataGridViewRow> lignesASupprimer = new List<DataGridViewRow>();

            foreach (DataGridViewRow ligne in dListeMedicaments.Rows)
            {
                DataGridViewCheckBoxCell celluleCheckBox = ligne.Cells["Sélectionner"] as DataGridViewCheckBoxCell;

                if (celluleCheckBox != null && Convert.ToBoolean(celluleCheckBox.Value))
                {
                    lignesASupprimer.Add(ligne);
                }
            }

            // Supprimez les médicaments correspondants dans votre source de données
            foreach (DataGridViewRow ligne in lignesASupprimer)
            {
                medicament medicamentASupprimer = ligne.DataBoundItem as medicament;

                if (medicamentASupprimer != null)
                {
                    mesDonnees.medicaments.Remove(medicamentASupprimer);
                }
            }

            // Enregistrez les modifications
            mesDonnees.SaveChanges();

            // Demandez au DataGridView de se rafraîchir
            dListeMedicaments.Refresh();
            dListeMedicaments.Update();

            MessageBox.Show("Médicaments supprimés avec succès.");
        }
    }
}
