namespace Epatair.Formulaires
{
    partial class FrmFacturation
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
            this.btnRetour = new System.Windows.Forms.Button();
            this.GRBFacture = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lstviewFacture = new System.Windows.Forms.ListView();
            this.GRBinformation = new System.Windows.Forms.GroupBox();
            this.btnvalidation = new System.Windows.Forms.Button();
            this.Btnannuler = new System.Windows.Forms.Button();
            this.btnaccepterFacture = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtHDecolage = new System.Windows.Forms.TextBox();
            this.LblHDecolage = new System.Windows.Forms.Label();
            this.txtHAtterissage = new System.Windows.Forms.TextBox();
            this.cmbAvionUtiliser = new System.Windows.Forms.ComboBox();
            this.lblAvion = new System.Windows.Forms.Label();
            this.lblHAtterissage = new System.Windows.Forms.Label();
            this.lblInstruteur = new System.Windows.Forms.Label();
            this.txtHArret = new System.Windows.Forms.TextBox();
            this.lblNomclien = new System.Windows.Forms.Label();
            this.lblHArret = new System.Windows.Forms.Label();
            this.cmbinstruteur = new System.Windows.Forms.ComboBox();
            this.txtDemarage = new System.Windows.Forms.TextBox();
            this.cmbClien = new System.Windows.Forms.ComboBox();
            this.lblHDemarage = new System.Windows.Forms.Label();
            this.txtIdFacture = new System.Windows.Forms.TextBox();
            this.lblIdFacture = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GRBFacture.SuspendLayout();
            this.GRBinformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(12, 516);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(136, 39);
            this.btnRetour.TabIndex = 0;
            this.btnRetour.Text = "Retour au menu";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // GRBFacture
            // 
            this.GRBFacture.Controls.Add(this.btnAjouter);
            this.GRBFacture.Controls.Add(this.lstviewFacture);
            this.GRBFacture.Location = new System.Drawing.Point(12, 12);
            this.GRBFacture.Name = "GRBFacture";
            this.GRBFacture.Size = new System.Drawing.Size(296, 426);
            this.GRBFacture.TabIndex = 4;
            this.GRBFacture.TabStop = false;
            this.GRBFacture.Text = "Facture";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(6, 375);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(124, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter une facture";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // lstviewFacture
            // 
            this.lstviewFacture.HideSelection = false;
            this.lstviewFacture.Location = new System.Drawing.Point(3, 16);
            this.lstviewFacture.Name = "lstviewFacture";
            this.lstviewFacture.Size = new System.Drawing.Size(287, 350);
            this.lstviewFacture.TabIndex = 0;
            this.lstviewFacture.UseCompatibleStateImageBehavior = false;
            // 
            // GRBinformation
            // 
            this.GRBinformation.Controls.Add(this.label1);
            this.GRBinformation.Controls.Add(this.textBox1);
            this.GRBinformation.Controls.Add(this.btnvalidation);
            this.GRBinformation.Controls.Add(this.Btnannuler);
            this.GRBinformation.Controls.Add(this.btnaccepterFacture);
            this.GRBinformation.Controls.Add(this.txtTotal);
            this.GRBinformation.Controls.Add(this.lblTotal);
            this.GRBinformation.Controls.Add(this.txtHDecolage);
            this.GRBinformation.Controls.Add(this.LblHDecolage);
            this.GRBinformation.Controls.Add(this.txtHAtterissage);
            this.GRBinformation.Controls.Add(this.cmbAvionUtiliser);
            this.GRBinformation.Controls.Add(this.lblAvion);
            this.GRBinformation.Controls.Add(this.lblHAtterissage);
            this.GRBinformation.Controls.Add(this.lblInstruteur);
            this.GRBinformation.Controls.Add(this.txtHArret);
            this.GRBinformation.Controls.Add(this.lblNomclien);
            this.GRBinformation.Controls.Add(this.lblHArret);
            this.GRBinformation.Controls.Add(this.cmbinstruteur);
            this.GRBinformation.Controls.Add(this.txtDemarage);
            this.GRBinformation.Controls.Add(this.cmbClien);
            this.GRBinformation.Controls.Add(this.lblHDemarage);
            this.GRBinformation.Controls.Add(this.txtIdFacture);
            this.GRBinformation.Controls.Add(this.lblIdFacture);
            this.GRBinformation.Enabled = false;
            this.GRBinformation.Location = new System.Drawing.Point(320, 12);
            this.GRBinformation.Name = "GRBinformation";
            this.GRBinformation.Size = new System.Drawing.Size(254, 493);
            this.GRBinformation.TabIndex = 5;
            this.GRBinformation.TabStop = false;
            this.GRBinformation.Text = "information facture";
            // 
            // btnvalidation
            // 
            this.btnvalidation.Location = new System.Drawing.Point(9, 444);
            this.btnvalidation.Name = "btnvalidation";
            this.btnvalidation.Size = new System.Drawing.Size(158, 23);
            this.btnvalidation.TabIndex = 14;
            this.btnvalidation.Text = "Valider et calculer total facture";
            this.btnvalidation.UseVisualStyleBackColor = true;
            this.btnvalidation.Click += new System.EventHandler(this.btnvalidation_Click);
            // 
            // Btnannuler
            // 
            this.Btnannuler.Location = new System.Drawing.Point(173, 444);
            this.Btnannuler.Name = "Btnannuler";
            this.Btnannuler.Size = new System.Drawing.Size(75, 23);
            this.Btnannuler.TabIndex = 13;
            this.Btnannuler.Text = "annuler";
            this.Btnannuler.UseVisualStyleBackColor = true;
            // 
            // btnaccepterFacture
            // 
            this.btnaccepterFacture.Location = new System.Drawing.Point(6, 444);
            this.btnaccepterFacture.Name = "btnaccepterFacture";
            this.btnaccepterFacture.Size = new System.Drawing.Size(121, 23);
            this.btnaccepterFacture.TabIndex = 12;
            this.btnaccepterFacture.Text = "Ajouter";
            this.btnaccepterFacture.UseVisualStyleBackColor = true;
            this.btnaccepterFacture.Visible = false;
            this.btnaccepterFacture.Click += new System.EventHandler(this.btnaccepterFacture_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(119, 400);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Enabled = false;
            this.lblTotal.Location = new System.Drawing.Point(70, 403);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total :";
            // 
            // txtHDecolage
            // 
            this.txtHDecolage.Location = new System.Drawing.Point(119, 367);
            this.txtHDecolage.Name = "txtHDecolage";
            this.txtHDecolage.Size = new System.Drawing.Size(100, 20);
            this.txtHDecolage.TabIndex = 11;
            // 
            // LblHDecolage
            // 
            this.LblHDecolage.AutoSize = true;
            this.LblHDecolage.Enabled = false;
            this.LblHDecolage.Location = new System.Drawing.Point(6, 370);
            this.LblHDecolage.Name = "LblHDecolage";
            this.LblHDecolage.Size = new System.Drawing.Size(98, 13);
            this.LblHDecolage.TabIndex = 0;
            this.LblHDecolage.Text = "Heure de decolage";
            // 
            // txtHAtterissage
            // 
            this.txtHAtterissage.Location = new System.Drawing.Point(119, 329);
            this.txtHAtterissage.Name = "txtHAtterissage";
            this.txtHAtterissage.Size = new System.Drawing.Size(100, 20);
            this.txtHAtterissage.TabIndex = 10;
            // 
            // cmbAvionUtiliser
            // 
            this.cmbAvionUtiliser.FormattingEnabled = true;
            this.cmbAvionUtiliser.Location = new System.Drawing.Point(119, 70);
            this.cmbAvionUtiliser.Name = "cmbAvionUtiliser";
            this.cmbAvionUtiliser.Size = new System.Drawing.Size(100, 21);
            this.cmbAvionUtiliser.TabIndex = 3;
            // 
            // lblAvion
            // 
            this.lblAvion.AutoSize = true;
            this.lblAvion.Enabled = false;
            this.lblAvion.Location = new System.Drawing.Point(6, 70);
            this.lblAvion.Name = "lblAvion";
            this.lblAvion.Size = new System.Drawing.Size(66, 13);
            this.lblAvion.TabIndex = 0;
            this.lblAvion.Text = "Avion utiliser";
            // 
            // lblHAtterissage
            // 
            this.lblHAtterissage.AutoSize = true;
            this.lblHAtterissage.Enabled = false;
            this.lblHAtterissage.Location = new System.Drawing.Point(6, 332);
            this.lblHAtterissage.Name = "lblHAtterissage";
            this.lblHAtterissage.Size = new System.Drawing.Size(98, 13);
            this.lblHAtterissage.TabIndex = 0;
            this.lblHAtterissage.Text = "Heure d\'atterissage";
            // 
            // lblInstruteur
            // 
            this.lblInstruteur.AutoSize = true;
            this.lblInstruteur.Enabled = false;
            this.lblInstruteur.Location = new System.Drawing.Point(6, 156);
            this.lblInstruteur.Name = "lblInstruteur";
            this.lblInstruteur.Size = new System.Drawing.Size(90, 13);
            this.lblInstruteur.TabIndex = 0;
            this.lblInstruteur.Text = "Nom de instruteur";
            // 
            // txtHArret
            // 
            this.txtHArret.Location = new System.Drawing.Point(119, 286);
            this.txtHArret.Name = "txtHArret";
            this.txtHArret.Size = new System.Drawing.Size(100, 20);
            this.txtHArret.TabIndex = 9;
            // 
            // lblNomclien
            // 
            this.lblNomclien.AutoSize = true;
            this.lblNomclien.Enabled = false;
            this.lblNomclien.Location = new System.Drawing.Point(6, 200);
            this.lblNomclien.Name = "lblNomclien";
            this.lblNomclien.Size = new System.Drawing.Size(69, 13);
            this.lblNomclien.TabIndex = 0;
            this.lblNomclien.Text = "Nom du clien";
            // 
            // lblHArret
            // 
            this.lblHArret.AutoSize = true;
            this.lblHArret.Enabled = false;
            this.lblHArret.Location = new System.Drawing.Point(6, 289);
            this.lblHArret.Name = "lblHArret";
            this.lblHArret.Size = new System.Drawing.Size(68, 13);
            this.lblHArret.TabIndex = 0;
            this.lblHArret.Text = "Heure d\'arret";
            // 
            // cmbinstruteur
            // 
            this.cmbinstruteur.FormattingEnabled = true;
            this.cmbinstruteur.Location = new System.Drawing.Point(119, 156);
            this.cmbinstruteur.Name = "cmbinstruteur";
            this.cmbinstruteur.Size = new System.Drawing.Size(100, 21);
            this.cmbinstruteur.TabIndex = 4;
            // 
            // txtDemarage
            // 
            this.txtDemarage.Location = new System.Drawing.Point(119, 242);
            this.txtDemarage.Name = "txtDemarage";
            this.txtDemarage.Size = new System.Drawing.Size(100, 20);
            this.txtDemarage.TabIndex = 8;
            // 
            // cmbClien
            // 
            this.cmbClien.FormattingEnabled = true;
            this.cmbClien.Location = new System.Drawing.Point(119, 197);
            this.cmbClien.Name = "cmbClien";
            this.cmbClien.Size = new System.Drawing.Size(100, 21);
            this.cmbClien.TabIndex = 5;
            // 
            // lblHDemarage
            // 
            this.lblHDemarage.AutoSize = true;
            this.lblHDemarage.Enabled = false;
            this.lblHDemarage.Location = new System.Drawing.Point(6, 245);
            this.lblHDemarage.Name = "lblHDemarage";
            this.lblHDemarage.Size = new System.Drawing.Size(106, 13);
            this.lblHDemarage.TabIndex = 0;
            this.lblHDemarage.Text = "Heure de Démarrage";
            // 
            // txtIdFacture
            // 
            this.txtIdFacture.Enabled = false;
            this.txtIdFacture.Location = new System.Drawing.Point(119, 33);
            this.txtIdFacture.Name = "txtIdFacture";
            this.txtIdFacture.Size = new System.Drawing.Size(100, 20);
            this.txtIdFacture.TabIndex = 0;
            // 
            // lblIdFacture
            // 
            this.lblIdFacture.AutoSize = true;
            this.lblIdFacture.Enabled = false;
            this.lblIdFacture.Location = new System.Drawing.Point(6, 36);
            this.lblIdFacture.Name = "lblIdFacture";
            this.lblIdFacture.Size = new System.Drawing.Size(92, 13);
            this.lblIdFacture.TabIndex = 0;
            this.lblIdFacture.Text = "Identifieur Facture";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(9, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Avion Tarif";
            // 
            // FrmFacturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 590);
            this.Controls.Add(this.GRBinformation);
            this.Controls.Add(this.GRBFacture);
            this.Controls.Add(this.btnRetour);
            this.Name = "FrmFacturation";
            this.Text = "FrmFacturation";
            this.Load += new System.EventHandler(this.FrmFacturation_Load);
            this.GRBFacture.ResumeLayout(false);
            this.GRBinformation.ResumeLayout(false);
            this.GRBinformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.GroupBox GRBFacture;
        private System.Windows.Forms.GroupBox GRBinformation;
        private System.Windows.Forms.TextBox txtIdFacture;
        private System.Windows.Forms.Label lblIdFacture;
        private System.Windows.Forms.Label lblNomclien;
        private System.Windows.Forms.Label lblInstruteur;
        private System.Windows.Forms.Label lblAvion;
        private System.Windows.Forms.ComboBox cmbClien;
        private System.Windows.Forms.ComboBox cmbinstruteur;
        private System.Windows.Forms.ComboBox cmbAvionUtiliser;
        private System.Windows.Forms.TextBox txtHDecolage;
        private System.Windows.Forms.Label LblHDecolage;
        private System.Windows.Forms.TextBox txtHAtterissage;
        private System.Windows.Forms.Label lblHAtterissage;
        private System.Windows.Forms.TextBox txtHArret;
        private System.Windows.Forms.Label lblHArret;
        private System.Windows.Forms.TextBox txtDemarage;
        private System.Windows.Forms.Label lblHDemarage;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button Btnannuler;
        private System.Windows.Forms.Button btnaccepterFacture;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListView lstviewFacture;
        private System.Windows.Forms.Button btnvalidation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}