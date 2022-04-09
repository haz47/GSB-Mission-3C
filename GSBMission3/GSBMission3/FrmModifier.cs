using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSBMission3
{
    public partial class FrmModifier : Form
    {
        private gsbrapports2021Entities mesDonnees;

        public FrmModifier(gsbrapports2021Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgVisiteurs.DataSource = this.mesDonnees.visiteur.ToList();
        }

        private void gridModifier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            try
            {
                this.bdgVisiteurs.EndEdit();
                this.mesDonnees.SaveChanges();
                MessageBox.Show("Vos modifications ont été effectuées");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void bdgVisiteurs_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtEmbauche_ValueChanged(object sender, EventArgs e)
        {
            this.dtEmbauche.Enabled = false;
        }
    }
}
