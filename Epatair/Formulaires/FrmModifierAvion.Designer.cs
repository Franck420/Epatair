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
            this.txtIdAvion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdLogbook = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblLogbook = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbinfoavion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(40, 171);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(87, 23);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier Avion";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(167, 171);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(88, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // grbinfoavion
            // 
            this.grbinfoavion.Controls.Add(this.txtIdAvion);
            this.grbinfoavion.Controls.Add(this.label1);
            this.grbinfoavion.Controls.Add(this.txtIdLogbook);
            this.grbinfoavion.Controls.Add(this.txtNom);
            this.grbinfoavion.Controls.Add(this.lblLogbook);
            this.grbinfoavion.Controls.Add(this.lblNom);
            this.grbinfoavion.Location = new System.Drawing.Point(27, 48);
            this.grbinfoavion.Name = "grbinfoavion";
            this.grbinfoavion.Size = new System.Drawing.Size(238, 100);
            this.grbinfoavion.TabIndex = 2;
            this.grbinfoavion.TabStop = false;
            this.grbinfoavion.Text = "information avion";
            // 
            // txtIdAvion
            // 
            this.txtIdAvion.Enabled = false;
            this.txtIdAvion.Location = new System.Drawing.Point(91, 15);
            this.txtIdAvion.Name = "txtIdAvion";
            this.txtIdAvion.Size = new System.Drawing.Size(127, 20);
            this.txtIdAvion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IdAvion";
            // 
            // txtIdLogbook
            // 
            this.txtIdLogbook.Location = new System.Drawing.Point(91, 67);
            this.txtIdLogbook.Name = "txtIdLogbook";
            this.txtIdLogbook.Size = new System.Drawing.Size(127, 20);
            this.txtIdLogbook.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(91, 41);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(127, 20);
            this.txtNom.TabIndex = 2;
            // 
            // lblLogbook
            // 
            this.lblLogbook.AutoSize = true;
            this.lblLogbook.Location = new System.Drawing.Point(10, 74);
            this.lblLogbook.Name = "lblLogbook";
            this.lblLogbook.Size = new System.Drawing.Size(58, 13);
            this.lblLogbook.TabIndex = 1;
            this.lblLogbook.Text = "IdLogbook";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(11, 48);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Attention! Vous devez entrez un ID de logbook déja éxistant!";
            // 
            // FrmModifierAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 210);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbinfoavion);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Name = "FrmModifierAvion";
            this.Text = "FrmModifierAvion";
            this.Load += new System.EventHandler(this.FrmModifierAvion_Load);
            this.grbinfoavion.ResumeLayout(false);
            this.grbinfoavion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox grbinfoavion;
        private System.Windows.Forms.TextBox txtIdLogbook;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblLogbook;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtIdAvion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}