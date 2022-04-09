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
    public partial class FrmRapports : Form
    {
        private gsbrapports2021Entities mesDonnees;

        public FrmRapports(gsbrapports2021Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgVisiteurs.DataSource = this.mesDonnees.visiteur.ToList();
            this.bdgRapport.DataSource = this.mesDonnees.rapport.ToList();
        }
        private void FrmRapports_Load(object sender, EventArgs e)
        {
            var n = (from v in this.mesDonnees.visiteur
                     select new { v.nom, v.prenom });

            foreach (visiteur vis in this.mesDonnees.visiteur)
            {
                this.comboBox1.Items.Add(vis.nom + " " + vis.prenom);
            }
        }

        public string GetAllRapports()
        {
            var allRapports = (from v in this.mesDonnees.visiteur
                               join r in this.mesDonnees.rapport
                               on v.id equals r.idVisiteur
                               select new { v.nom, v.prenom, r.id, r.date, r.motif, r.bilan, r.idVisiteur, r.idMedecin });
            return allRapports.ToString();
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;
            string[] subs = selectedItem.ToString().Split(' ');
            string nom = subs[0];
            string prenom = subs[1];
            var test = from v in this.mesDonnees.visiteur
                       join r in this.mesDonnees.rapport on v.id equals r.idVisiteur
                       where v.nom == nom
                       where v.prenom == prenom
                       select r;
            this.dataGridView1.DataSource = test.ToList();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            visiteur v = new visiteur();

            v.nom = GetAllRapports();
            v.prenom = GetAllRapports();
        }
    }
}
