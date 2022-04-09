
namespace GSBMission3
{
    partial class FrmModifier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.txtAddresse = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.dtEmbauche = new System.Windows.Forms.DateTimePicker();
            this.btModifier = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSentence = new System.Windows.Forms.Label();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modifier les informations d’un visiteur";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(463, 73);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 17);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id: ";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(463, 109);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(41, 17);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(463, 149);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(61, 17);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prénom:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(463, 186);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 17);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Login:";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.Location = new System.Drawing.Point(463, 225);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(42, 17);
            this.lblMDP.TabIndex = 7;
            this.lblMDP.Text = "MDP:";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(463, 259);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(64, 17);
            this.lblAdresse.TabIndex = 8;
            this.lblAdresse.Text = "Adresse:";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(463, 295);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(34, 17);
            this.lblCP.TabIndex = 9;
            this.lblCP.Text = "CP: ";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(463, 329);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(42, 17);
            this.lblVille.TabIndex = 10;
            this.lblVille.Text = "Ville: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(463, 363);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(127, 17);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date d\'embauche: ";
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteurs, "id", true));
            this.txtId.Location = new System.Drawing.Point(648, 73);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(180, 22);
            this.txtId.TabIndex = 12;
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteurs, "nom", true));
            this.txtNom.Location = new System.Drawing.Point(648, 109);
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(180, 22);
            this.txtNom.TabIndex = 13;
            // 
            // txtPrenom
            // 
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteurs, "prenom", true));
            this.txtPrenom.Location = new System.Drawing.Point(648, 149);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.ReadOnly = true;
            this.txtPrenom.Size = new System.Drawing.Size(180, 22);
            this.txtPrenom.TabIndex = 14;
            // 
            // txtLogin
            // 
            this.txtLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteurs, "login", true));
            this.txtLogin.Location = new System.Drawing.Point(648, 186);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(180, 22);
            this.txtLogin.TabIndex = 15;
            // 
            // txtMDP
            // 
            this.txtMDP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteurs, "mdp", true));
            this.txtMDP.Location = new System.Drawing.Point(648, 225);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.ReadOnly = true;
            this.txtMDP.Size = new System.Drawing.Size(180, 22);
            this.txtMDP.TabIndex = 16;
            // 
            // txtAddresse
            // 
            this.txtAddresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteurs, "adresse", true));
            this.txtAddresse.Location = new System.Drawing.Point(648, 259);
            this.txtAddresse.Name = "txtAddresse";
            this.txtAddresse.Size = new System.Drawing.Size(180, 22);
            this.txtAddresse.TabIndex = 17;
            // 
            // txtCP
            // 
            this.txtCP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteurs, "cp", true));
            this.txtCP.Location = new System.Drawing.Point(648, 295);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(180, 22);
            this.txtCP.TabIndex = 18;
            // 
            // txtVille
            // 
            this.txtVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteurs, "ville", true));
            this.txtVille.Location = new System.Drawing.Point(648, 329);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(180, 22);
            this.txtVille.TabIndex = 19;
            // 
            // dtEmbauche
            // 
            this.dtEmbauche.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteurs, "dateEmbauche", true));
            this.dtEmbauche.Location = new System.Drawing.Point(648, 363);
            this.dtEmbauche.Name = "dtEmbauche";
            this.dtEmbauche.Size = new System.Drawing.Size(180, 22);
            this.dtEmbauche.TabIndex = 20;
            this.dtEmbauche.ValueChanged += new System.EventHandler(this.dtEmbauche_ValueChanged);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(687, 427);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(75, 30);
            this.btModifier.TabIndex = 21;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(768, 427);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 30);
            this.btAnnuler.TabIndex = 22;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdgVisiteurs;
            this.dataGridView1.Location = new System.Drawing.Point(13, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 307);
            this.dataGridView1.TabIndex = 23;
            // 
            // lblSentence
            // 
            this.lblSentence.AutoSize = true;
            this.lblSentence.Location = new System.Drawing.Point(13, 73);
            this.lblSentence.Name = "lblSentence";
            this.lblSentence.Size = new System.Drawing.Size(166, 17);
            this.lblSentence.TabIndex = 24;
            this.lblSentence.Text = "Selectionnez un visiteur: ";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdgVisiteurs
            // 
            this.bdgVisiteurs.DataSource = typeof(GSBMission3.visiteur);
            this.bdgVisiteurs.CurrentChanged += new System.EventHandler(this.bdgVisiteurs_CurrentChanged);
            // 
            // FrmModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 469);
            this.Controls.Add(this.lblSentence);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.dtEmbauche);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtAddresse);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblMDP);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifier";
            this.Text = "Modifier";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdgVisiteurs;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.TextBox txtAddresse;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.DateTimePicker dtEmbauche;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblSentence;
    }
}