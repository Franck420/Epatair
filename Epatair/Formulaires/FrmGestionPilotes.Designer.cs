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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lstViewPilote = new System.Windows.Forms.ListView();
            this.txtSupprimer = new System.Windows.Forms.TextBox();
            this.lblSupprimer = new System.Windows.Forms.Label();
            this.lblModifier = new System.Windows.Forms.Label();
            this.txtModifier = new System.Windows.Forms.TextBox();
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
            this.btnSupprimer.Location = new System.Drawing.Point(166, 150);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(101, 47);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer un pilote de la base de donnée";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(166, 203);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(101, 47);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Revenir au menu principal";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lstViewPilote
            // 
            this.lstViewPilote.HideSelection = false;
            this.lstViewPilote.Location = new System.Drawing.Point(32, 112);
            this.lstViewPilote.Name = "lstViewPilote";
            this.lstViewPilote.Size = new System.Drawing.Size(121, 97);
            this.lstViewPilote.TabIndex = 7;
            this.lstViewPilote.UseCompatibleStateImageBehavior = false;
            // 
            // txtSupprimer
            // 
            this.txtSupprimer.Location = new System.Drawing.Point(167, 124);
            this.txtSupprimer.Name = "txtSupprimer";
            this.txtSupprimer.Size = new System.Drawing.Size(100, 20);
            this.txtSupprimer.TabIndex = 8;
            // 
            // lblSupprimer
            // 
            this.lblSupprimer.AutoSize = true;
            this.lblSupprimer.Location = new System.Drawing.Point(119, 86);
            this.lblSupprimer.Name = "lblSupprimer";
            this.lblSupprimer.Size = new System.Drawing.Size(233, 13);
            this.lblSupprimer.TabIndex = 9;
            this.lblSupprimer.Text = "Entrez le Id du Pilote que vous voulez supprimer";
            // 
            // lblModifier
            // 
            this.lblModifier.AutoSize = true;
            this.lblModifier.Location = new System.Drawing.Point(63, 328);
            this.lblModifier.Name = "lblModifier";
            this.lblModifier.Size = new System.Drawing.Size(223, 13);
            this.lblModifier.TabIndex = 10;
            this.lblModifier.Text = "Entrez le Id du pilote que vous voulez modifier";
            // 
            // txtModifier
            // 
            this.txtModifier.Location = new System.Drawing.Point(115, 344);
            this.txtModifier.Name = "txtModifier";
            this.txtModifier.Size = new System.Drawing.Size(100, 20);
            this.txtModifier.TabIndex = 11;
            // 
            // FrmGestionPilotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 488);
            this.Controls.Add(this.txtModifier);
            this.Controls.Add(this.lblModifier);
            this.Controls.Add(this.lblSupprimer);
            this.Controls.Add(this.txtSupprimer);
            this.Controls.Add(this.lstViewPilote);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "FrmGestionPilotes";
            this.Text = "FrmGestionPilotes";
            this.Load += new System.EventHandler(this.FrmGestionPilotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ListView lstViewPilote;
        private System.Windows.Forms.TextBox txtSupprimer;
        private System.Windows.Forms.Label lblSupprimer;
        private System.Windows.Forms.Label lblModifier;
        private System.Windows.Forms.TextBox txtModifier;
    }
}