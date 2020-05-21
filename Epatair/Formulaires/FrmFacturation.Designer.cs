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
            this.lblinformation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarifAvion = new System.Windows.Forms.TextBox();
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
            this.GRBFacture.Size = new System.Drawing.Size(338, 426);
            this.GRBFacture.TabIndex = 4;
            this.GRBFacture.TabStop = false;
            this.GRBFacture.Text = "Facture";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(6, 375);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(124, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter une facture";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // lstviewFacture
            // 
            this.lstviewFacture.HideSelection = false;
            this.lstviewFacture.Location = new System.Drawing.Point(3, 16);
            this.lstviewFacture.Name = "lstviewFacture";
            this.lstviewFacture.Size = new System.Drawing.Size(326, 350);
            this.lstviewFacture.TabIndex = 0;
            this.lstviewFacture.UseCompatibleStateImageBehavior = false;
            this.lstviewFacture.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstviewFacture_ItemSelectionChanged);
            // 
            // GRBinformation
            // 
            this.GRBinformation.Controls.Add(this.lblinformation);
            this.GRBinformation.Controls.Add(this.label1);
            this.GRBinformation.Controls.Add(this.txtTarifAvion);
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
            this.GRBinformation.Location = new System.Drawing.Point(370, 12);
            this.GRBinformation.Name = "GRBinformation";
            this.GRBinformation.Size = new System.Drawing.Size(276, 524);
            this.GRBinformation.TabIndex = 5;
            this.GRBinformation.TabStop = false;
            this.GRBinformation.Text = "Information facture";
            // 
            // lblinformation
            // 
            this.lblinformation.AutoSize = true;
            this.lblinformation.Location = new System.Drawing.Point(3, 38);
            this.lblinformation.Name = "lblinformation";
            this.lblinformation.Size = new System.Drawing.Size(272, 13);
            this.lblinformation.TabIndex = 17;
            this.lblinformation.Text = "Les heures doivent  être entrées de cette façon: HH:mm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(44, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tarif de l\'avion";
            // 
            // txtTarifAvion
            // 
            this.txtTarifAvion.Location = new System.Drawing.Point(134, 146);
            this.txtTarifAvion.Name = "txtTarifAvion";
            this.txtTarifAvion.Size = new System.Drawing.Size(100, 20);
            this.txtTarifAvion.TabIndex = 100000;
            // 
            // btnvalidation
            // 
            this.btnvalidation.Location = new System.Drawing.Point(21, 476);
            this.btnvalidation.Name = "btnvalidation";
            this.btnvalidation.Size = new System.Drawing.Size(158, 23);
            this.btnvalidation.TabIndex = 9;
            this.btnvalidation.Text = "Valider et calculer total facture";
            this.btnvalidation.UseVisualStyleBackColor = true;
            this.btnvalidation.Click += new System.EventHandler(this.btnvalidation_Click);
            // 
            // Btnannuler
            // 
            this.Btnannuler.Location = new System.Drawing.Point(188, 476);
            this.Btnannuler.Name = "Btnannuler";
            this.Btnannuler.Size = new System.Drawing.Size(75, 23);
            this.Btnannuler.TabIndex = 11;
            this.Btnannuler.Text = "Annuler";
            this.Btnannuler.UseVisualStyleBackColor = true;
            this.Btnannuler.Click += new System.EventHandler(this.Btnannuler_Click);
            // 
            // btnaccepterFacture
            // 
            this.btnaccepterFacture.Location = new System.Drawing.Point(21, 476);
            this.btnaccepterFacture.Name = "btnaccepterFacture";
            this.btnaccepterFacture.Size = new System.Drawing.Size(121, 23);
            this.btnaccepterFacture.TabIndex = 10;
            this.btnaccepterFacture.Text = "Ajouter";
            this.btnaccepterFacture.UseVisualStyleBackColor = true;
            this.btnaccepterFacture.Visible = false;
            this.btnaccepterFacture.Click += new System.EventHandler(this.btnaccepterFacture_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(134, 432);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Enabled = false;
            this.lblTotal.Location = new System.Drawing.Point(32, 435);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(93, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total de la facture";
            // 
            // txtHDecolage
            // 
            this.txtHDecolage.Location = new System.Drawing.Point(134, 321);
            this.txtHDecolage.Name = "txtHDecolage";
            this.txtHDecolage.Size = new System.Drawing.Size(100, 20);
            this.txtHDecolage.TabIndex = 6;
            // 
            // LblHDecolage
            // 
            this.LblHDecolage.AutoSize = true;
            this.LblHDecolage.Enabled = false;
            this.LblHDecolage.Location = new System.Drawing.Point(22, 324);
            this.LblHDecolage.Name = "LblHDecolage";
            this.LblHDecolage.Size = new System.Drawing.Size(100, 13);
            this.LblHDecolage.TabIndex = 0;
            this.LblHDecolage.Text = "Heure de décollage";
            // 
            // txtHAtterissage
            // 
            this.txtHAtterissage.Location = new System.Drawing.Point(134, 361);
            this.txtHAtterissage.Name = "txtHAtterissage";
            this.txtHAtterissage.Size = new System.Drawing.Size(100, 20);
            this.txtHAtterissage.TabIndex = 7;
            // 
            // cmbAvionUtiliser
            // 
            this.cmbAvionUtiliser.FormattingEnabled = true;
            this.cmbAvionUtiliser.Location = new System.Drawing.Point(134, 102);
            this.cmbAvionUtiliser.Name = "cmbAvionUtiliser";
            this.cmbAvionUtiliser.Size = new System.Drawing.Size(100, 21);
            this.cmbAvionUtiliser.TabIndex = 1;
            this.cmbAvionUtiliser.SelectedIndexChanged += new System.EventHandler(this.cmbAvionUtiliser_SelectedIndexChanged);
            // 
            // lblAvion
            // 
            this.lblAvion.AutoSize = true;
            this.lblAvion.Enabled = false;
            this.lblAvion.Location = new System.Drawing.Point(54, 106);
            this.lblAvion.Name = "lblAvion";
            this.lblAvion.Size = new System.Drawing.Size(63, 13);
            this.lblAvion.TabIndex = 0;
            this.lblAvion.Text = "Avion utilisé";
            // 
            // lblHAtterissage
            // 
            this.lblHAtterissage.AutoSize = true;
            this.lblHAtterissage.Enabled = false;
            this.lblHAtterissage.Location = new System.Drawing.Point(21, 364);
            this.lblHAtterissage.Name = "lblHAtterissage";
            this.lblHAtterissage.Size = new System.Drawing.Size(101, 13);
            this.lblHAtterissage.TabIndex = 0;
            this.lblHAtterissage.Text = "Heure d\'atterrissage";
            // 
            // lblInstruteur
            // 
            this.lblInstruteur.AutoSize = true;
            this.lblInstruteur.Enabled = false;
            this.lblInstruteur.Location = new System.Drawing.Point(21, 188);
            this.lblInstruteur.Name = "lblInstruteur";
            this.lblInstruteur.Size = new System.Drawing.Size(100, 13);
            this.lblInstruteur.TabIndex = 0;
            this.lblInstruteur.Text = "Nom de l\'instructeur";
            // 
            // txtHArret
            // 
            this.txtHArret.Location = new System.Drawing.Point(134, 400);
            this.txtHArret.Name = "txtHArret";
            this.txtHArret.Size = new System.Drawing.Size(100, 20);
            this.txtHArret.TabIndex = 8;
            // 
            // lblNomclien
            // 
            this.lblNomclien.AutoSize = true;
            this.lblNomclien.Enabled = false;
            this.lblNomclien.Location = new System.Drawing.Point(49, 232);
            this.lblNomclien.Name = "lblNomclien";
            this.lblNomclien.Size = new System.Drawing.Size(72, 13);
            this.lblNomclien.TabIndex = 0;
            this.lblNomclien.Text = "Nom du client";
            // 
            // lblHArret
            // 
            this.lblHArret.AutoSize = true;
            this.lblHArret.Enabled = false;
            this.lblHArret.Location = new System.Drawing.Point(53, 403);
            this.lblHArret.Name = "lblHArret";
            this.lblHArret.Size = new System.Drawing.Size(68, 13);
            this.lblHArret.TabIndex = 0;
            this.lblHArret.Text = "Heure d\'arrêt";
            // 
            // cmbinstruteur
            // 
            this.cmbinstruteur.FormattingEnabled = true;
            this.cmbinstruteur.Location = new System.Drawing.Point(134, 188);
            this.cmbinstruteur.Name = "cmbinstruteur";
            this.cmbinstruteur.Size = new System.Drawing.Size(100, 21);
            this.cmbinstruteur.TabIndex = 3;
            // 
            // txtDemarage
            // 
            this.txtDemarage.Location = new System.Drawing.Point(134, 274);
            this.txtDemarage.Name = "txtDemarage";
            this.txtDemarage.Size = new System.Drawing.Size(100, 20);
            this.txtDemarage.TabIndex = 5;
            // 
            // cmbClien
            // 
            this.cmbClien.FormattingEnabled = true;
            this.cmbClien.Location = new System.Drawing.Point(134, 229);
            this.cmbClien.Name = "cmbClien";
            this.cmbClien.Size = new System.Drawing.Size(100, 21);
            this.cmbClien.TabIndex = 4;
            // 
            // lblHDemarage
            // 
            this.lblHDemarage.AutoSize = true;
            this.lblHDemarage.Enabled = false;
            this.lblHDemarage.Location = new System.Drawing.Point(19, 277);
            this.lblHDemarage.Name = "lblHDemarage";
            this.lblHDemarage.Size = new System.Drawing.Size(106, 13);
            this.lblHDemarage.TabIndex = 0;
            this.lblHDemarage.Text = "Heure du Démarrage";
            // 
            // txtIdFacture
            // 
            this.txtIdFacture.Enabled = false;
            this.txtIdFacture.Location = new System.Drawing.Point(134, 65);
            this.txtIdFacture.Name = "txtIdFacture";
            this.txtIdFacture.Size = new System.Drawing.Size(100, 20);
            this.txtIdFacture.TabIndex = 0;
            // 
            // lblIdFacture
            // 
            this.lblIdFacture.AutoSize = true;
            this.lblIdFacture.Enabled = false;
            this.lblIdFacture.Location = new System.Drawing.Point(27, 68);
            this.lblIdFacture.Name = "lblIdFacture";
            this.lblIdFacture.Size = new System.Drawing.Size(92, 13);
            this.lblIdFacture.TabIndex = 0;
            this.lblIdFacture.Text = "Identifiant Facture";
            // 
            // FrmFacturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 590);
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
        private System.Windows.Forms.TextBox txtTarifAvion;
        private System.Windows.Forms.Label lblinformation;
    }
}