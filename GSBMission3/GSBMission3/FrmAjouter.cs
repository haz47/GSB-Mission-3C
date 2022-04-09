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
    public partial class FrmAjouter : Form
    {
        private gsbrapports2021Entities mesDonnees;

        public FrmAjouter(gsbrapports2021Entities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
        }

        public static string RandomString()
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 4)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomString2()

        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private visiteur nouvellevisiteur()
        {
            string login = txtlogin.Text;
            login += $"{this.txtNom.Text}.{this.txtPrenom.Text}";
            string n = RandomString();
            string m = RandomString2();
            string Nom = txtNom.Text;
            string Prenom = txtPrenom.Text;
            string cp = txtCP.Text;
            string Adresse = txtAdresse.Text;
            string Ville = txtVille.Text;
            DateTime dateE = this.dtEmbauche.Value;
            visiteur v = new visiteur();
            v.id = n;
            v.mdp = m;
            v.prenom = Prenom;
            v.nom = Nom;
            v.cp = cp;
            v.adresse = Adresse;
            v.dateEmbauche = dateE;
            v.ville = Ville;
            v.login = login;

            return v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.mesDonnees.visiteur.Add(nouvellevisiteur());
            this.mesDonnees.SaveChanges();
            MessageBox.Show("Vos modifications ont été effectuées");
        }
    }
}
