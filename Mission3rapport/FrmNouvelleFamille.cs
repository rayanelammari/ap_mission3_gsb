using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3rapport
{
    public partial class FrmNouvelleFamille : Form
    {
        private gsbrapportsEntities mesDonnees;
        public FrmNouvelleFamille (gsbrapportsEntities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgSFamille.DataSource= mesDonnees.familles.ToList();
  
        }

        private famille newFamille()
        {
            famille newFamille = new famille();
            newFamille.id = txtId.Text;
            newFamille.libelle = txtNomFamille.Text;
            return newFamille;
        }
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.mesDonnees.familles.Add(newFamille());
            this.mesDonnees.SaveChanges();
            MessageBox.Show("Enregistrement validé");
        }
    }
}
