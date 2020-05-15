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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lsbFacture = new System.Windows.Forms.ListBox();
            this.GRBFacture = new System.Windows.Forms.GroupBox();
            this.GRBModification = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtHDemarrage2 = new System.Windows.Forms.TextBox();
            this.LblHDemarrage2 = new System.Windows.Forms.Label();
            this.txtHAtterissage = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAvion = new System.Windows.Forms.Label();
            this.lblHAtterissage = new System.Windows.Forms.Label();
            this.lblInstruteur = new System.Windows.Forms.Label();
            this.txtHArret = new System.Windows.Forms.TextBox();
            this.lblNomclien = new System.Windows.Forms.Label();
            this.lblHArret = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtDemarage = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblHDemarage = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblHSol = new System.Windows.Forms.Label();
            this.txtHeureVol = new System.Windows.Forms.TextBox();
            this.lblHVol = new System.Windows.Forms.Label();
            this.txtIdFacture = new System.Windows.Forms.TextBox();
            this.lblIdFacture = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GRBFacture.SuspendLayout();
            this.GRBModification.SuspendLayout();
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
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(18, 397);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(124, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter une facture";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // lsbFacture
            // 
            this.lsbFacture.FormattingEnabled = true;
            this.lsbFacture.Location = new System.Drawing.Point(6, 19);
            this.lsbFacture.Name = "lsbFacture";
            this.lsbFacture.Size = new System.Drawing.Size(284, 368);
            this.lsbFacture.TabIndex = 3;
            // 
            // GRBFacture
            // 
            this.GRBFacture.Controls.Add(this.lsbFacture);
            this.GRBFacture.Controls.Add(this.btnAjouter);
            this.GRBFacture.Location = new System.Drawing.Point(12, 12);
            this.GRBFacture.Name = "GRBFacture";
            this.GRBFacture.Size = new System.Drawing.Size(296, 426);
            this.GRBFacture.TabIndex = 4;
            this.GRBFacture.TabStop = false;
            this.GRBFacture.Text = "Facture";
            // 
            // GRBModification
            // 
            this.GRBModification.Controls.Add(this.button2);
            this.GRBModification.Controls.Add(this.button1);
            this.GRBModification.Controls.Add(this.txtTotal);
            this.GRBModification.Controls.Add(this.lblTotal);
            this.GRBModification.Controls.Add(this.txtHDemarrage2);
            this.GRBModification.Controls.Add(this.LblHDemarrage2);
            this.GRBModification.Controls.Add(this.txtHAtterissage);
            this.GRBModification.Controls.Add(this.comboBox1);
            this.GRBModification.Controls.Add(this.lblAvion);
            this.GRBModification.Controls.Add(this.lblHAtterissage);
            this.GRBModification.Controls.Add(this.lblInstruteur);
            this.GRBModification.Controls.Add(this.txtHArret);
            this.GRBModification.Controls.Add(this.lblNomclien);
            this.GRBModification.Controls.Add(this.lblHArret);
            this.GRBModification.Controls.Add(this.comboBox2);
            this.GRBModification.Controls.Add(this.txtDemarage);
            this.GRBModification.Controls.Add(this.comboBox3);
            this.GRBModification.Controls.Add(this.lblHDemarage);
            this.GRBModification.Controls.Add(this.textBox3);
            this.GRBModification.Controls.Add(this.lblHSol);
            this.GRBModification.Controls.Add(this.txtHeureVol);
            this.GRBModification.Controls.Add(this.lblHVol);
            this.GRBModification.Controls.Add(this.txtIdFacture);
            this.GRBModification.Controls.Add(this.lblIdFacture);
            this.GRBModification.Location = new System.Drawing.Point(320, 12);
            this.GRBModification.Name = "GRBModification";
            this.GRBModification.Size = new System.Drawing.Size(254, 516);
            this.GRBModification.TabIndex = 5;
            this.GRBModification.TabStop = false;
            this.GRBModification.Text = "Modifier information facture";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(119, 443);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Enabled = false;
            this.lblTotal.Location = new System.Drawing.Point(70, 446);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total :";
            // 
            // txtHDemarrage2
            // 
            this.txtHDemarrage2.Location = new System.Drawing.Point(119, 410);
            this.txtHDemarrage2.Name = "txtHDemarrage2";
            this.txtHDemarrage2.Size = new System.Drawing.Size(100, 20);
            this.txtHDemarrage2.TabIndex = 11;
            // 
            // LblHDemarrage2
            // 
            this.LblHDemarrage2.AutoSize = true;
            this.LblHDemarrage2.Enabled = false;
            this.LblHDemarrage2.Location = new System.Drawing.Point(6, 413);
            this.LblHDemarrage2.Name = "LblHDemarrage2";
            this.LblHDemarrage2.Size = new System.Drawing.Size(101, 13);
            this.LblHDemarrage2.TabIndex = 0;
            this.LblHDemarrage2.Text = "Heure de démarage";
            // 
            // txtHAtterissage
            // 
            this.txtHAtterissage.Location = new System.Drawing.Point(119, 372);
            this.txtHAtterissage.Name = "txtHAtterissage";
            this.txtHAtterissage.Size = new System.Drawing.Size(100, 20);
            this.txtHAtterissage.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 3;
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
            this.lblHAtterissage.Location = new System.Drawing.Point(6, 375);
            this.lblHAtterissage.Name = "lblHAtterissage";
            this.lblHAtterissage.Size = new System.Drawing.Size(98, 13);
            this.lblHAtterissage.TabIndex = 0;
            this.lblHAtterissage.Text = "Heure d\'atterissage";
            // 
            // lblInstruteur
            // 
            this.lblInstruteur.AutoSize = true;
            this.lblInstruteur.Enabled = false;
            this.lblInstruteur.Location = new System.Drawing.Point(6, 116);
            this.lblInstruteur.Name = "lblInstruteur";
            this.lblInstruteur.Size = new System.Drawing.Size(90, 13);
            this.lblInstruteur.TabIndex = 0;
            this.lblInstruteur.Text = "Nom de instruteur";
            // 
            // txtHArret
            // 
            this.txtHArret.Location = new System.Drawing.Point(119, 329);
            this.txtHArret.Name = "txtHArret";
            this.txtHArret.Size = new System.Drawing.Size(100, 20);
            this.txtHArret.TabIndex = 9;
            // 
            // lblNomclien
            // 
            this.lblNomclien.AutoSize = true;
            this.lblNomclien.Enabled = false;
            this.lblNomclien.Location = new System.Drawing.Point(6, 160);
            this.lblNomclien.Name = "lblNomclien";
            this.lblNomclien.Size = new System.Drawing.Size(69, 13);
            this.lblNomclien.TabIndex = 0;
            this.lblNomclien.Text = "Nom du clien";
            // 
            // lblHArret
            // 
            this.lblHArret.AutoSize = true;
            this.lblHArret.Enabled = false;
            this.lblHArret.Location = new System.Drawing.Point(6, 332);
            this.lblHArret.Name = "lblHArret";
            this.lblHArret.Size = new System.Drawing.Size(68, 13);
            this.lblHArret.TabIndex = 0;
            this.lblHArret.Text = "Heure d\'arret";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(119, 116);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // txtDemarage
            // 
            this.txtDemarage.Location = new System.Drawing.Point(119, 285);
            this.txtDemarage.Name = "txtDemarage";
            this.txtDemarage.Size = new System.Drawing.Size(100, 20);
            this.txtDemarage.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(119, 157);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // lblHDemarage
            // 
            this.lblHDemarage.AutoSize = true;
            this.lblHDemarage.Enabled = false;
            this.lblHDemarage.Location = new System.Drawing.Point(6, 288);
            this.lblHDemarage.Name = "lblHDemarage";
            this.lblHDemarage.Size = new System.Drawing.Size(106, 13);
            this.lblHDemarage.TabIndex = 0;
            this.lblHDemarage.Text = "Heure de Démarrage";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 240);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // lblHSol
            // 
            this.lblHSol.AutoSize = true;
            this.lblHSol.Enabled = false;
            this.lblHSol.Location = new System.Drawing.Point(6, 243);
            this.lblHSol.Name = "lblHSol";
            this.lblHSol.Size = new System.Drawing.Size(67, 13);
            this.lblHSol.TabIndex = 0;
            this.lblHSol.Text = "Heure au sol";
            // 
            // txtHeureVol
            // 
            this.txtHeureVol.Location = new System.Drawing.Point(119, 197);
            this.txtHeureVol.Name = "txtHeureVol";
            this.txtHeureVol.Size = new System.Drawing.Size(100, 20);
            this.txtHeureVol.TabIndex = 6;
            // 
            // lblHVol
            // 
            this.lblHVol.AutoSize = true;
            this.lblHVol.Enabled = false;
            this.lblHVol.Location = new System.Drawing.Point(6, 200);
            this.lblHVol.Name = "lblHVol";
            this.lblHVol.Size = new System.Drawing.Size(69, 13);
            this.lblHVol.TabIndex = 0;
            this.lblHVol.Text = "Heure de Vol";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmFacturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 590);
            this.Controls.Add(this.GRBModification);
            this.Controls.Add(this.GRBFacture);
            this.Controls.Add(this.btnRetour);
            this.Name = "FrmFacturation";
            this.Text = "FrmFacturation";
            this.Load += new System.EventHandler(this.FrmFacturation_Load);
            this.GRBFacture.ResumeLayout(false);
            this.GRBModification.ResumeLayout(false);
            this.GRBModification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListBox lsbFacture;
        private System.Windows.Forms.GroupBox GRBFacture;
        private System.Windows.Forms.GroupBox GRBModification;
        private System.Windows.Forms.TextBox txtIdFacture;
        private System.Windows.Forms.Label lblIdFacture;
        private System.Windows.Forms.Label lblNomclien;
        private System.Windows.Forms.Label lblInstruteur;
        private System.Windows.Forms.Label lblAvion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblHSol;
        private System.Windows.Forms.TextBox txtHeureVol;
        private System.Windows.Forms.Label lblHVol;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtHDemarrage2;
        private System.Windows.Forms.Label LblHDemarrage2;
        private System.Windows.Forms.TextBox txtHAtterissage;
        private System.Windows.Forms.Label lblHAtterissage;
        private System.Windows.Forms.TextBox txtHArret;
        private System.Windows.Forms.Label lblHArret;
        private System.Windows.Forms.TextBox txtDemarage;
        private System.Windows.Forms.Label lblHDemarage;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}