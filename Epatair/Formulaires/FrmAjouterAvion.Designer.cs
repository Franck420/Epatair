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
            this.TxtNom.Location = new System.Drawing.Point(132, 63);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(119, 20);
            this.TxtNom.TabIndex = 2;
            this.TxtNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(49, 66);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(77, 13);
            this.LblNom.TabIndex = 3;
            this.LblNom.Text = "Nom de l\'avion";
            // 
            // FrmAjouterAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 175);
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
    }
}