namespace Epatair.Formulaires
{
    partial class FrmModifierPilote
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.LblNom = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(57, 125);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 0;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(228, 125);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(137, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 51);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Identifient";
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(187, 51);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(29, 13);
            this.LblNom.TabIndex = 6;
            this.LblNom.Text = "Nom";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(96, 89);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(36, 13);
            this.lblGrade.TabIndex = 7;
            this.lblGrade.Text = "Grade";
            // 
            // FrmModifierPilote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 171);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Name = "FrmModifierPilote";
            this.Text = "FrmModifierPilote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label lblGrade;
    }
}