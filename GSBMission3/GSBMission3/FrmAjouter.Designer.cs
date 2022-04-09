
namespace GSBMission3
{
    partial class FrmAjouter
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtMDP = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.dtEmbauche = new System.Windows.Forms.DateTimePicker();
            this.visiteurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prénom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Login:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "MDP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Adresse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "CP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ville:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Date d\'embauche: ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(187, 35);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(172, 22);
            this.txtId.TabIndex = 11;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(187, 78);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(172, 22);
            this.txtNom.TabIndex = 12;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(187, 118);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(172, 22);
            this.txtPrenom.TabIndex = 13;
            // 
            // txtlogin
            // 
            this.txtlogin.Location = new System.Drawing.Point(187, 162);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.ReadOnly = true;
            this.txtlogin.Size = new System.Drawing.Size(172, 22);
            this.txtlogin.TabIndex = 14;
            // 
            // txtMDP
            // 
            this.txtMDP.Location = new System.Drawing.Point(187, 202);
            this.txtMDP.Name = "txtMDP";
            this.txtMDP.ReadOnly = true;
            this.txtMDP.Size = new System.Drawing.Size(172, 22);
            this.txtMDP.TabIndex = 15;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(187, 240);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(172, 22);
            this.txtAdresse.TabIndex = 16;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(187, 277);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(172, 22);
            this.txtCP.TabIndex = 17;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(187, 312);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(172, 22);
            this.txtVille.TabIndex = 18;
            // 
            // dtEmbauche
            // 
            this.dtEmbauche.Location = new System.Drawing.Point(187, 349);
            this.dtEmbauche.Name = "dtEmbauche";
            this.dtEmbauche.Size = new System.Drawing.Size(172, 22);
            this.dtEmbauche.TabIndex = 19;
            // 
            // visiteurBindingSource1
            // 
            this.visiteurBindingSource1.DataSource = typeof(GSBMission3.visiteur);
            // 
            // FrmAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 455);
            this.Controls.Add(this.dtEmbauche);
            this.Controls.Add(this.txtVille);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtMDP);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmAjouter";
            this.Text = "Ajouter";
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.TextBox txtMDP;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.DateTimePicker dtEmbauche;
        private System.Windows.Forms.BindingSource visiteurBindingSource1;
    }
}