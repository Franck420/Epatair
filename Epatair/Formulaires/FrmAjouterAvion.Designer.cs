﻿namespace Epatair.Formulaires
{
    partial class FrmAjouterAvion
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
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.LblNom = new System.Windows.Forms.Label();
            this.txtIdLogbook = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarif = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(12, 141);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(178, 47);
            this.BtnAjouter.TabIndex = 0;
            this.BtnAjouter.Text = "Ajouter un avion à la base de donnée";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(214, 141);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(178, 47);
            this.BtnAnnuler.TabIndex = 1;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(191, 51);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(119, 20);
            this.TxtNom.TabIndex = 2;
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(102, 54);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(77, 13);
            this.LblNom.TabIndex = 3;
            this.LblNom.Text = "Nom de l\'avion";
            // 
            // txtIdLogbook
            // 
            this.txtIdLogbook.Location = new System.Drawing.Point(191, 76);
            this.txtIdLogbook.Name = "txtIdLogbook";
            this.txtIdLogbook.Size = new System.Drawing.Size(119, 20);
            this.txtIdLogbook.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(103, 76);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(76, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id du Logbook";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Attention! Vous devez entrez un ID de logbook déja éxistant!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tarif de location";
            // 
            // txtTarif
            // 
            this.txtTarif.Location = new System.Drawing.Point(191, 102);
            this.txtTarif.Name = "txtTarif";
            this.txtTarif.Size = new System.Drawing.Size(119, 20);
            this.txtTarif.TabIndex = 7;
            // 
            // FrmAjouterAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 203);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTarif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtIdLogbook);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.BtnAjouter);
            this.Name = "FrmAjouterAvion";
            this.Text = "FrmAjouterAvion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.TextBox txtIdLogbook;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarif;
    }
}