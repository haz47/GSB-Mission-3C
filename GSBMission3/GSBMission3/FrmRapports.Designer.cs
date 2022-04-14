
namespace GSBMission3
{
    partial class FrmRapports
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
            this.btFermer = new System.Windows.Forms.Button();
            this.lblAfficher = new System.Windows.Forms.Label();
            this.lblSentence = new System.Windows.Forms.Label();
            this.bdgVisiteurs = new System.Windows.Forms.BindingSource(this.components);
            this.bdgRapport = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.XMLbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btFermer
            // 
            this.btFermer.Location = new System.Drawing.Point(713, 412);
            this.btFermer.Name = "btFermer";
            this.btFermer.Size = new System.Drawing.Size(75, 26);
            this.btFermer.TabIndex = 1;
            this.btFermer.Text = "Fermer";
            this.btFermer.UseVisualStyleBackColor = true;
            this.btFermer.Click += new System.EventHandler(this.btFermer_Click);
            // 
            // lblAfficher
            // 
            this.lblAfficher.AutoSize = true;
            this.lblAfficher.Location = new System.Drawing.Point(12, 9);
            this.lblAfficher.Name = "lblAfficher";
            this.lblAfficher.Size = new System.Drawing.Size(215, 17);
            this.lblAfficher.TabIndex = 2;
            this.lblAfficher.Text = "Afficher les rapports d’un visiteur";
            // 
            // lblSentence
            // 
            this.lblSentence.AutoSize = true;
            this.lblSentence.Location = new System.Drawing.Point(10, 47);
            this.lblSentence.Name = "lblSentence";
            this.lblSentence.Size = new System.Drawing.Size(166, 17);
            this.lblSentence.TabIndex = 25;
            this.lblSentence.Text = "Selectionnez un visiteur: ";
            // 
            // bdgVisiteurs
            // 
            this.bdgVisiteurs.DataSource = typeof(GSBMission3.visiteur);
            // 
            // bdgRapport
            // 
            this.bdgRapport.DataSource = typeof(GSBMission3.rapport);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 302);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(203, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // XMLbtn
            // 
            this.XMLbtn.Location = new System.Drawing.Point(632, 413);
            this.XMLbtn.Name = "XMLbtn";
            this.XMLbtn.Size = new System.Drawing.Size(75, 25);
            this.XMLbtn.TabIndex = 28;
            this.XMLbtn.Text = "XML";
            this.XMLbtn.UseVisualStyleBackColor = true;
            this.XMLbtn.Click += new System.EventHandler(this.XMLbtn_Click);
            // 
            // FrmRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.XMLbtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSentence);
            this.Controls.Add(this.lblAfficher);
            this.Controls.Add(this.btFermer);
            this.Name = "FrmRapports";
            this.Text = "Afficher les rapports d\'un visiteur";
            this.Load += new System.EventHandler(this.FrmRapports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bdgRapport;
        private System.Windows.Forms.BindingSource bdgVisiteurs;
        private System.Windows.Forms.Button btFermer;
        private System.Windows.Forms.Label lblAfficher;
        private System.Windows.Forms.Label lblSentence;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button XMLbtn;
    }
}