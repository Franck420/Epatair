namespace Epatair.Formulaires
{
    partial class FrmGestionAvion
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
            this.btnRevenir = new System.Windows.Forms.Button();
            this.lstViewAvion = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(31, 74);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(109, 55);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter un avion à la base de donnée";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(158, 74);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(109, 55);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier les informations d\'un avion";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(284, 74);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(108, 55);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer un avion de la base de donnée";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnRevenir
            // 
            this.btnRevenir.Location = new System.Drawing.Point(159, 160);
            this.btnRevenir.Name = "btnRevenir";
            this.btnRevenir.Size = new System.Drawing.Size(108, 55);
            this.btnRevenir.TabIndex = 3;
            this.btnRevenir.Text = "Revenir au menu principal";
            this.btnRevenir.UseVisualStyleBackColor = true;
            this.btnRevenir.Click += new System.EventHandler(this.btnRevenir_Click);
            // 
            // lstViewAvion
            // 
            this.lstViewAvion.HideSelection = false;
            this.lstViewAvion.Location = new System.Drawing.Point(31, 135);
            this.lstViewAvion.Name = "lstViewAvion";
            this.lstViewAvion.Size = new System.Drawing.Size(121, 97);
            this.lstViewAvion.TabIndex = 4;
            this.lstViewAvion.UseCompatibleStateImageBehavior = false;
            // 
            // FrmGestionAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 300);
            this.Controls.Add(this.lstViewAvion);
            this.Controls.Add(this.btnRevenir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Name = "FrmGestionAvion";
            this.Text = "FrmGestionAvion";
            this.Load += new System.EventHandler(this.FrmGestionAvion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRevenir;
        private System.Windows.Forms.ListView lstViewAvion;
    }
}