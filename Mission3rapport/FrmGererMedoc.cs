using Mission3rapport;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class FrmGererMedoc : Form
    {
        private gsbrapportsEntities mesDonnees;

        public FrmGererMedoc(gsbrapportsEntities mesDonnees)
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
            // Vous n'avez pas besoin d'appeler InitializeComponent() à nouveau ici
            // cela a déjà été fait dans le constructeur.
            ListeMedicament lstMedoc = new ListeMedicament(this.mesDonnees);
            lstMedoc.Show();
            // Si vous souhaitez rafraîchir les données du contrôle de liaison,
            // vous pouvez simplement mettre à jour la source de données.
        }



        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FrmNouvelleFamille F2 = new FrmNouvelleFamille(this.mesDonnees);
            F2.Show();
        }
    }
}
