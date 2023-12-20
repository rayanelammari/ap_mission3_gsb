using Mission3rapport;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class FrmGererMedoc : Form
    {
        private gsb2023Entities mesDonnees;

        public FrmGererMedoc(gsb2023Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            //  var query = from id in famille.id
            //            select id;
            this.bdgGereMedoc.DataSource = mesDonnees.familles.ToList();
        }

        // Supprimez le deuxième appel à InitializeComponent() dans le bouton2_Click
        private void button2_Click(object sender, EventArgs e)
        {
            ListeMedicament lstMedoc = new ListeMedicament(this.mesDonnees);
            lstMedoc.Show();

        }



        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmNouvelleFamille F2 = new FrmNouvelleFamille(this.mesDonnees);
            F2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            famille select = comboBox1.SelectedItem as famille;

            if (select != null)
            {
                var query = from medicament in mesDonnees.medicaments
                                         where medicament.famille.id == select.id
                                         select medicament;

                // Convertir les résultats en liste
                var listeMedicaments = query.ToList();

                ListeMedicament lstMedoc = Application.OpenForms["ListeMedicament"] as ListeMedicament;

                if (lstMedoc != null)
                {
                    // Mettre à jour directement la source de données du DataGridView
                    lstMedoc.MettreAJourMedicaments(listeMedicaments);
                }
                else
                {
                    lstMedoc = new ListeMedicament(mesDonnees);
                    lstMedoc.MettreAJourMedicaments(listeMedicaments);
                    lstMedoc.Show();
                }
            }

        }

    }


}