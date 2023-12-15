using Mission3rapport;
using System;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class FrmMenu : Form
    {
        private gsbrapportsEntities mesDonnees;
        public FrmMenu()
        {
            this.InitializeComponent();
            this.mesDonnees = new gsbrapportsEntities();
            this.IsMdiContainer = true;
        }



        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGererMedoc F2 = new FrmGererMedoc(this.mesDonnees);
            F2.MdiParent = this;
            F2.Show();
        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
