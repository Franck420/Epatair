namespace Epatair.Formulaires
{
    partial class FrmGestionPilotes
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAssigner = new System.Windows.Forms.Button();
            this.btnDesassigner = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(32, 36);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(101, 47);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter un pilote à la base de donnée";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(166, 36);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(101, 47);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier les informations d\'un pilote";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(92, 109);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(101, 47);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer un pilote de la base de donnée";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAssigner
            // 
            this.btnAssigner.Location = new System.Drawing.Point(32, 224);
            this.btnAssigner.Name = "btnAssigner";
            this.btnAssigner.Size = new System.Drawing.Size(101, 47);
            this.btnAssigner.TabIndex = 3;
            this.btnAssigner.Text = "Assigner un pilote à un avion dans l\'horaire";
            this.btnAssigner.UseVisualStyleBackColor = true;
            this.btnAssigner.Click += new System.EventHandler(this.btnAssigner_Click);
            // 
            // btnDesassigner
            // 
            this.btnDesassigner.Location = new System.Drawing.Point(166, 224);
            this.btnDesassigner.Name = "btnDesassigner";
            this.btnDesassigner.Size = new System.Drawing.Size(101, 47);
            this.btnDesassigner.TabIndex = 4;
            this.btnDesassigner.Text = "Déassigner un pilote ";
            this.btnDesassigner.UseVisualStyleBackColor = true;
            this.btnDesassigner.Click += new System.EventHandler(this.btnDesassigner_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(92, 314);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(101, 47);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Revenir au menu principal";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmGestionPilotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 400);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnDesassigner);
            this.Controls.Add(this.btnAssigner);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "FrmGestionPilotes";
            this.Text = "FrmGestionPilotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAssigner;
        private System.Windows.Forms.Button btnDesassigner;
        private System.Windows.Forms.Button btnQuitter;
    }
}