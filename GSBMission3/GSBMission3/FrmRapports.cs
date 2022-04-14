using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

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
            var rapports = from v in this.mesDonnees.visiteur
                       join r in this.mesDonnees.rapport on v.id equals r.idVisiteur
                       where v.nom == nom
                       where v.prenom == prenom
                       select r;
            this.dataGridView1.DataSource = rapports.ToList();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            visiteur v = new visiteur();
            v.nom = GetAllRapports();
            v.prenom = GetAllRapports();
        }

        private void XMLbtn_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDataTableFromDGV(dataGridView1);
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlTextWriter xmlSave = new XmlTextWriter(saveFileDialog1.OpenFile(), Encoding.UTF8);
                xmlSave.Formatting = Formatting.Indented;
                ds.WriteXml(xmlSave);
                xmlSave.Close();
                MessageBox.Show("Le fichier XML contenant tous les rapports a été créé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("L'export du rapport a été annulé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }
            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            return dt;
        }
    }
}
