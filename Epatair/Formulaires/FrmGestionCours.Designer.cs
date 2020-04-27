namespace Epatair.Formulaires
{
    partial class FrmGestionCours
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
            this.btnAssignerPilote = new System.Windows.Forms.Button();
            this.btnDesassignerPilote = new System.Windows.Forms.Button();
            this.btnAssignerApprenti = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAssignerPilote
            // 
            this.btnAssignerPilote.Location = new System.Drawing.Point(12, 30);
            this.btnAssignerPilote.Name = "btnAssignerPilote";
            this.btnAssignerPilote.Size = new System.Drawing.Size(103, 53);
            this.btnAssignerPilote.TabIndex = 0;
            this.btnAssignerPilote.Text = "Assigner un pilote à un cours";
            this.btnAssignerPilote.UseVisualStyleBackColor = true;
            this.btnAssignerPilote.Click += new System.EventHandler(this.btnAssignerPilote_Click);
            // 
            // btnDesassignerPilote
            // 
            this.btnDesassignerPilote.Location = new System.Drawing.Point(129, 30);
            this.btnDesassignerPilote.Name = "btnDesassignerPilote";
            this.btnDesassignerPilote.Size = new System.Drawing.Size(103, 53);
            this.btnDesassignerPilote.TabIndex = 1;
            this.btnDesassignerPilote.Text = "Désassigner un pilote ";
            this.btnDesassignerPilote.UseVisualStyleBackColor = true;
            this.btnDesassignerPilote.Click += new System.EventHandler(this.btnDesassignerPilote_Click);
            // 
            // btnAssignerApprenti
            // 
            this.btnAssignerApprenti.Location = new System.Drawing.Point(252, 30);
            this.btnAssignerApprenti.Name = "btnAssignerApprenti";
            this.btnAssignerApprenti.Size = new System.Drawing.Size(103, 53);
            this.btnAssignerApprenti.TabIndex = 2;
            this.btnAssignerApprenti.Text = "Assigner un apprenti à un pilote";
            this.btnAssignerApprenti.UseVisualStyleBackColor = true;
            this.btnAssignerApprenti.Click += new System.EventHandler(this.btnAssignerApprenti_Click);
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
            // FrmGestionCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 210);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnAssignerApprenti);
            this.Controls.Add(this.btnDesassignerPilote);
            this.Controls.Add(this.btnAssignerPilote);
            this.Name = "FrmGestionCours";
            this.Text = "FrmGestionCours";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAssignerPilote;
        private System.Windows.Forms.Button btnDesassignerPilote;
        private System.Windows.Forms.Button btnAssignerApprenti;
        private System.Windows.Forms.Button btnQuitter;
    }
}