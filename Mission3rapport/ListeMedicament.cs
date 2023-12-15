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
        private gsbrapportsEntities mesDonnees;
        public ListeMedicament(gsbrapportsEntities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.dataGridView1.DataSource = mesDonnees.medicaments.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bdgMedicament.EndEdit();
            this.mesDonnees.SaveChanges();
        }
    }
}
