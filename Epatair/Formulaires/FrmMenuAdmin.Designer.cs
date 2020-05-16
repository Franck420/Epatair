namespace Epatair
{
    partial class FrmMenuAdmin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnFacturation = new System.Windows.Forms.Button();
            this.btnAvion = new System.Windows.Forms.Button();
            this.btnPilote = new System.Windows.Forms.Button();
            this.btnLogbook = new System.Windows.Forms.Button();
            this.btnRendezVous = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(87, 181);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(255, 47);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Fermer le logiciel";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnFacturation
            // 
            this.btnFacturation.Location = new System.Drawing.Point(6, 21);
            this.btnFacturation.Name = "btnFacturation";
            this.btnFacturation.Size = new System.Drawing.Size(113, 49);
            this.btnFacturation.TabIndex = 5;
            this.btnFacturation.Text = "Allez vers la facturation";
            this.btnFacturation.UseVisualStyleBackColor = true;
            this.btnFacturation.Click += new System.EventHandler(this.btnFacturation_Click);
            // 
            // btnAvion
            // 
            this.btnAvion.Location = new System.Drawing.Point(75, 87);
            this.btnAvion.Name = "btnAvion";
            this.btnAvion.Size = new System.Drawing.Size(113, 49);
            this.btnAvion.TabIndex = 6;
            this.btnAvion.Text = "Gérer les avions";
            this.btnAvion.UseVisualStyleBackColor = true;
            this.btnAvion.Click += new System.EventHandler(this.btnAvion_Click);
            // 
            // btnPilote
            // 
            this.btnPilote.Location = new System.Drawing.Point(284, 19);
            this.btnPilote.Name = "btnPilote";
            this.btnPilote.Size = new System.Drawing.Size(113, 51);
            this.btnPilote.TabIndex = 7;
            this.btnPilote.Text = "Gérez les pilotes";
            this.btnPilote.UseVisualStyleBackColor = true;
            this.btnPilote.Click += new System.EventHandler(this.btnPilote_Click);
            // 
            // btnLogbook
            // 
            this.btnLogbook.Location = new System.Drawing.Point(217, 87);
            this.btnLogbook.Name = "btnLogbook";
            this.btnLogbook.Size = new System.Drawing.Size(113, 51);
            this.btnLogbook.TabIndex = 8;
            this.btnLogbook.Text = "Gérez les logbook";
            this.btnLogbook.UseVisualStyleBackColor = true;
            this.btnLogbook.Click += new System.EventHandler(this.btnLogbook_Click);
            // 
            // btnRendezVous
            // 
            this.btnRendezVous.Location = new System.Drawing.Point(144, 21);
            this.btnRendezVous.Name = "btnRendezVous";
            this.btnRendezVous.Size = new System.Drawing.Size(113, 49);
            this.btnRendezVous.TabIndex = 9;
            this.btnRendezVous.Text = "Gérez les rendez vous";
            this.btnRendezVous.UseVisualStyleBackColor = true;
            this.btnRendezVous.Click += new System.EventHandler(this.btnRendezVous_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFacturation);
            this.groupBox1.Controls.Add(this.btnAvion);
            this.groupBox1.Controls.Add(this.btnLogbook);
            this.groupBox1.Controls.Add(this.btnRendezVous);
            this.groupBox1.Controls.Add(this.btnPilote);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 152);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion";
            // 
            // FrmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 258);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuitter);
            this.Name = "FrmMenuAdmin";
            this.Text = "Menu Administrateur";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnFacturation;
        private System.Windows.Forms.Button btnAvion;
        private System.Windows.Forms.Button btnPilote;
        private System.Windows.Forms.Button btnLogbook;
        private System.Windows.Forms.Button btnRendezVous;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

