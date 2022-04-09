using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GSBMission3
{
    public partial class FrmMenu : Form
    {
        private gsbrapports2021Entities mesDonnees;

        public FrmMenu()
        {
            this.InitializeComponent();
            this.mesDonnees = new gsbrapports2021Entities();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void idToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModifier form2 = new FrmModifier(this.mesDonnees);
            form2.MdiParent = this;
            form2.Show();
        }

        private void ajouterToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmAjouter form3 = new FrmAjouter(this.mesDonnees);
            form3.MdiParent = this;
            form3.Show();
        }

        private void ajouterToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSupprimer form4 = new FrmSupprimer();
            form4.MdiParent = this;
            form4.Show();
        }

        private void majToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRapports form5 = new FrmRapports(this.mesDonnees);
            form5.MdiParent = this;
            form5.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
