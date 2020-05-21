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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupprimer = new System.Windows.Forms.TextBox();
            this.txtModifier = new System.Windows.Forms.TextBox();
            this.grbliste = new System.Windows.Forms.GroupBox();
            this.grbgestionavion = new System.Windows.Forms.GroupBox();
            this.grbliste.SuspendLayout();
            this.grbgestionavion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(6, 229);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(134, 55);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "Ajouter un avion à la base de donnée";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(6, 51);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(140, 55);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier les informations d\'un avion";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(6, 141);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(140, 55);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer un avion de la base de donnée";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnRevenir
            // 
            this.btnRevenir.Location = new System.Drawing.Point(18, 332);
            this.btnRevenir.Name = "btnRevenir";
            this.btnRevenir.Size = new System.Drawing.Size(156, 55);
            this.btnRevenir.TabIndex = 6;
            this.btnRevenir.Text = "Revenir au menu principal";
            this.btnRevenir.UseVisualStyleBackColor = true;
            this.btnRevenir.Click += new System.EventHandler(this.btnRevenir_Click);
            // 
            // lstViewAvion
            // 
            this.lstViewAvion.HideSelection = false;
            this.lstViewAvion.Location = new System.Drawing.Point(6, 19);
            this.lstViewAvion.Name = "lstViewAvion";
            this.lstViewAvion.Size = new System.Drawing.Size(230, 278);
            this.lstViewAvion.TabIndex = 4;
            this.lstViewAvion.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entrez l\'identifiant de l\'avion à supprimer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Entrez l\'identifiant de l\'avion à modifier";
            // 
            // txtSupprimer
            // 
            this.txtSupprimer.Location = new System.Drawing.Point(152, 159);
            this.txtSupprimer.Name = "txtSupprimer";
            this.txtSupprimer.Size = new System.Drawing.Size(100, 20);
            this.txtSupprimer.TabIndex = 4;
            // 
            // txtModifier
            // 
            this.txtModifier.Location = new System.Drawing.Point(152, 69);
            this.txtModifier.Name = "txtModifier";
            this.txtModifier.Size = new System.Drawing.Size(100, 20);
            this.txtModifier.TabIndex = 2;
            // 
            // grbliste
            // 
            this.grbliste.Controls.Add(this.lstViewAvion);
            this.grbliste.Location = new System.Drawing.Point(12, 14);
            this.grbliste.Name = "grbliste";
            this.grbliste.Size = new System.Drawing.Size(242, 312);
            this.grbliste.TabIndex = 9;
            this.grbliste.TabStop = false;
            this.grbliste.Text = "Liste avion";
            // 
            // grbgestionavion
            // 
            this.grbgestionavion.Controls.Add(this.btnSupprimer);
            this.grbgestionavion.Controls.Add(this.btnModifier);
            this.grbgestionavion.Controls.Add(this.txtSupprimer);
            this.grbgestionavion.Controls.Add(this.txtModifier);
            this.grbgestionavion.Controls.Add(this.btnAjouter);
            this.grbgestionavion.Controls.Add(this.label1);
            this.grbgestionavion.Controls.Add(this.label2);
            this.grbgestionavion.Location = new System.Drawing.Point(279, 14);
            this.grbgestionavion.Name = "grbgestionavion";
            this.grbgestionavion.Size = new System.Drawing.Size(350, 312);
            this.grbgestionavion.TabIndex = 0;
            this.grbgestionavion.TabStop = false;
            this.grbgestionavion.Text = "Gestion des avions";
            // 
            // FrmGestionAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 402);
            this.Controls.Add(this.grbgestionavion);
            this.Controls.Add(this.grbliste);
            this.Controls.Add(this.btnRevenir);
            this.Name = "FrmGestionAvion";
            this.Text = "FrmGestionAvion";
            this.Load += new System.EventHandler(this.FrmGestionAvion_Load);
            this.grbliste.ResumeLayout(false);
            this.grbgestionavion.ResumeLayout(false);
            this.grbgestionavion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRevenir;
        private System.Windows.Forms.ListView lstViewAvion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupprimer;
        private System.Windows.Forms.TextBox txtModifier;
        private System.Windows.Forms.GroupBox grbliste;
        private System.Windows.Forms.GroupBox grbgestionavion;
    }
}