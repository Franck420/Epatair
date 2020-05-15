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
            this.btnRemplir = new System.Windows.Forms.Button();
            this.btnPilote = new System.Windows.Forms.Button();
            this.btnCours = new System.Windows.Forms.Button();
            this.btnFacturer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnFacturation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemplir
            // 
            this.btnRemplir.Location = new System.Drawing.Point(26, 104);
            this.btnRemplir.Name = "btnRemplir";
            this.btnRemplir.Size = new System.Drawing.Size(111, 47);
            this.btnRemplir.TabIndex = 0;
            this.btnRemplir.Text = "Allez vers les logbooks";
            this.btnRemplir.UseVisualStyleBackColor = true;
            this.btnRemplir.Click += new System.EventHandler(this.btnRemplir_Click);
            // 
            // btnPilote
            // 
            this.btnPilote.Location = new System.Drawing.Point(214, 104);
            this.btnPilote.Name = "btnPilote";
            this.btnPilote.Size = new System.Drawing.Size(111, 47);
            this.btnPilote.TabIndex = 1;
            this.btnPilote.Text = "Gérer les pilotes";
            this.btnPilote.UseVisualStyleBackColor = true;
            this.btnPilote.Click += new System.EventHandler(this.btnPilote_Click);
            // 
            // btnCours
            // 
            this.btnCours.Location = new System.Drawing.Point(214, 26);
            this.btnCours.Name = "btnCours";
            this.btnCours.Size = new System.Drawing.Size(111, 47);
            this.btnCours.TabIndex = 2;
            this.btnCours.Text = "Gérer les cours";
            this.btnCours.UseVisualStyleBackColor = true;
            this.btnCours.Click += new System.EventHandler(this.btnCours_Click);
            // 
            // btnFacturer
            // 
            this.btnFacturer.Location = new System.Drawing.Point(26, 12);
            this.btnFacturer.Name = "btnFacturer";
            this.btnFacturer.Size = new System.Drawing.Size(111, 47);
            this.btnFacturer.TabIndex = 3;
            this.btnFacturer.Text = "Gérer les avions";
            this.btnFacturer.UseVisualStyleBackColor = true;
            this.btnFacturer.Click += new System.EventHandler(this.btnFacturer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(123, 191);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(111, 47);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Fermer le logiciel";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnFacturation
            // 
            this.btnFacturation.Location = new System.Drawing.Point(133, 65);
            this.btnFacturation.Name = "btnFacturation";
            this.btnFacturation.Size = new System.Drawing.Size(75, 49);
            this.btnFacturation.TabIndex = 5;
            this.btnFacturation.Text = "Allez vers la facturation";
            this.btnFacturation.UseVisualStyleBackColor = true;
            this.btnFacturation.Click += new System.EventHandler(this.btnFacturation_Click);
            // 
            // FrmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 256);
            this.Controls.Add(this.btnFacturation);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnFacturer);
            this.Controls.Add(this.btnCours);
            this.Controls.Add(this.btnPilote);
            this.Controls.Add(this.btnRemplir);
            this.Name = "FrmMenuAdmin";
            this.Text = "Menu Administrateur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemplir;
        private System.Windows.Forms.Button btnPilote;
        private System.Windows.Forms.Button btnCours;
        private System.Windows.Forms.Button btnFacturer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnFacturation;
    }
}

