using Mission3rapport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class ListeMedicament : Form
    {
        private gsb2023Entities mesDonnees;
        public ListeMedicament(gsb2023Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.dListeMedicaments.DataSource = mesDonnees.medicaments.ToList();
        }
        public DataGridView DListeMedicaments
        {
            get { return this.dListeMedicaments; }
            set { this.dListeMedicaments = value; }
        }
        public void MettreAJourMedicaments(List<medicament> medicaments)
        {
            this.dListeMedicaments.DataSource = medicaments;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.bdgMedicament.EndEdit();
            this.mesDonnees.SaveChanges();
        }

        private void bdgMedicament_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
