namespace AstronomieForm
{
    partial class GalaxieForm
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
            this.Nom = new System.Windows.Forms.Label();
            this.TxbNom = new System.Windows.Forms.TextBox();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(24, 58);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // TxbNom
            // 
            this.TxbNom.Location = new System.Drawing.Point(75, 50);
            this.TxbNom.Name = "TxbNom";
            this.TxbNom.Size = new System.Drawing.Size(100, 20);
            this.TxbNom.TabIndex = 1;
            this.TxbNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbNom_KeyPress);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(57, 103);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(75, 23);
            this.BtnAjouter.TabIndex = 2;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // GalaxieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 161);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.TxbNom);
            this.Controls.Add(this.Nom);
            this.Name = "GalaxieForm";
            this.Text = "Formulaire Galaxie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox TxbNom;
        private System.Windows.Forms.Button BtnAjouter;
    }
}