namespace Epatair.Formulaires
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
            this.SuspendLayout();
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(12, 116);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(178, 47);
            this.BtnAjouter.TabIndex = 0;
            this.BtnAjouter.Text = "Ajouter un avion à la base de donnée";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Location = new System.Drawing.Point(214, 116);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(178, 47);
            this.BtnAnnuler.TabIndex = 1;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(97, 48);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(119, 20);
            this.TxtNom.TabIndex = 2;
            this.TxtNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(14, 51);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(77, 13);
            this.LblNom.TabIndex = 3;
            this.LblNom.Text = "Nom de l\'avion";
            // 
            // txtIdLogbook
            // 
            this.txtIdLogbook.Location = new System.Drawing.Point(97, 73);
            this.txtIdLogbook.Name = "txtIdLogbook";
            this.txtIdLogbook.Size = new System.Drawing.Size(119, 20);
            this.txtIdLogbook.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 73);
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
            // FrmAjouterAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 175);
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
    }
}