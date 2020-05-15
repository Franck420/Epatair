namespace Epatair.Formulaires
{
    partial class FrmGestionRendezVous
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
            this.btnModifierRDV = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifierRDV
            // 
            this.btnModifierRDV.Location = new System.Drawing.Point(129, 48);
            this.btnModifierRDV.Name = "btnModifierRDV";
            this.btnModifierRDV.Size = new System.Drawing.Size(103, 47);
            this.btnModifierRDV.TabIndex = 4;
            this.btnModifierRDV.Text = "Ajouter ou modifier un rendez-vous";
            this.btnModifierRDV.Click += new System.EventHandler(this.btnModifierRDV_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(129, 136);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(103, 53);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.Text = "Revenir au menu principal";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmGestionRendezVous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 210);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnModifierRDV);
            this.Name = "FrmGestionRendezVous";
            this.Text = "FrmGestionRendezVous";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnModifierRDV;
        private System.Windows.Forms.Button btnQuitter;
    }
}