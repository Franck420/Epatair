namespace Epatair.Formulaires
{
    partial class FrmGestionLogbook
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
            this.btnAssigner = new System.Windows.Forms.Button();
            this.btnDesassigner = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnRemplir = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAssigner
            // 
            this.btnAssigner.Location = new System.Drawing.Point(32, 30);
            this.btnAssigner.Name = "btnAssigner";
            this.btnAssigner.Size = new System.Drawing.Size(91, 53);
            this.btnAssigner.TabIndex = 0;
            this.btnAssigner.Text = "Assigner un entretien";
            this.btnAssigner.UseVisualStyleBackColor = true;
            this.btnAssigner.Click += new System.EventHandler(this.btnAssigner_Click);
            // 
            // btnDesassigner
            // 
            this.btnDesassigner.Location = new System.Drawing.Point(172, 30);
            this.btnDesassigner.Name = "btnDesassigner";
            this.btnDesassigner.Size = new System.Drawing.Size(91, 53);
            this.btnDesassigner.TabIndex = 1;
            this.btnDesassigner.Text = "Désassigner un entretien";
            this.btnDesassigner.UseVisualStyleBackColor = true;
            this.btnDesassigner.Click += new System.EventHandler(this.btnDesassigner_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(32, 103);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(91, 53);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier les informations d\'un entretien";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnRemplir
            // 
            this.btnRemplir.Location = new System.Drawing.Point(172, 103);
            this.btnRemplir.Name = "btnRemplir";
            this.btnRemplir.Size = new System.Drawing.Size(91, 53);
            this.btnRemplir.TabIndex = 3;
            this.btnRemplir.Text = "Remplir les heures de vols";
            this.btnRemplir.UseVisualStyleBackColor = true;
            this.btnRemplir.Click += new System.EventHandler(this.btnRemplir_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(96, 184);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(91, 53);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Revenir au menu principal";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // FrmGestionLogbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnRemplir);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnDesassigner);
            this.Controls.Add(this.btnAssigner);
            this.Name = "FrmGestionLogbook";
            this.Text = "FrmGestionLogbook";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAssigner;
        private System.Windows.Forms.Button btnDesassigner;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnRemplir;
        private System.Windows.Forms.Button btnQuitter;
    }
}