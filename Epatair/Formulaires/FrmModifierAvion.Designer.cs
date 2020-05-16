namespace Epatair.Formulaires
{
    partial class FrmModifierAvion
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.grbinfoavion = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblLogbook = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtLogbook = new System.Windows.Forms.TextBox();
            this.grbinfoavion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(37, 135);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(87, 23);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier Avion";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(164, 135);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(88, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // grbinfoavion
            // 
            this.grbinfoavion.Controls.Add(this.txtLogbook);
            this.grbinfoavion.Controls.Add(this.txtNom);
            this.grbinfoavion.Controls.Add(this.lblLogbook);
            this.grbinfoavion.Controls.Add(this.lblNom);
            this.grbinfoavion.Location = new System.Drawing.Point(24, 12);
            this.grbinfoavion.Name = "grbinfoavion";
            this.grbinfoavion.Size = new System.Drawing.Size(238, 100);
            this.grbinfoavion.TabIndex = 2;
            this.grbinfoavion.TabStop = false;
            this.grbinfoavion.Text = "information avion";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(11, 27);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblLogbook
            // 
            this.lblLogbook.AutoSize = true;
            this.lblLogbook.Location = new System.Drawing.Point(10, 74);
            this.lblLogbook.Name = "lblLogbook";
            this.lblLogbook.Size = new System.Drawing.Size(49, 13);
            this.lblLogbook.TabIndex = 1;
            this.lblLogbook.Text = "Logbook";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(65, 24);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(127, 20);
            this.txtNom.TabIndex = 2;
            // 
            // txtLogbook
            // 
            this.txtLogbook.Location = new System.Drawing.Point(65, 71);
            this.txtLogbook.Name = "txtLogbook";
            this.txtLogbook.Size = new System.Drawing.Size(127, 20);
            this.txtLogbook.TabIndex = 3;
            // 
            // FrmModifierAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 190);
            this.Controls.Add(this.grbinfoavion);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Name = "FrmModifierAvion";
            this.Text = "FrmModifierAvion";
            this.grbinfoavion.ResumeLayout(false);
            this.grbinfoavion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox grbinfoavion;
        private System.Windows.Forms.TextBox txtLogbook;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblLogbook;
        private System.Windows.Forms.Label lblNom;
    }
}