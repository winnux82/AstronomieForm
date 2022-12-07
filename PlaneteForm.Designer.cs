namespace AstronomieForm
{
    partial class PlaneteForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNom = new System.Windows.Forms.Label();
            this.TxbNom = new System.Windows.Forms.TextBox();
            this.TxbDiamètre = new System.Windows.Forms.TextBox();
            this.LblDiametre = new System.Windows.Forms.Label();
            this.TxbMasse = new System.Windows.Forms.TextBox();
            this.LblMasse = new System.Windows.Forms.Label();
            this.TxbGalaxie = new System.Windows.Forms.TextBox();
            this.LblGalaxie = new System.Windows.Forms.Label();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(33, 39);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(29, 13);
            this.LblNom.TabIndex = 0;
            this.LblNom.Text = "Nom";
            // 
            // TxbNom
            // 
            this.TxbNom.Location = new System.Drawing.Point(79, 36);
            this.TxbNom.Name = "TxbNom";
            this.TxbNom.Size = new System.Drawing.Size(100, 20);
            this.TxbNom.TabIndex = 1;
            this.TxbNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbNom_KeyPress);
            // 
            // TxbDiamètre
            // 
            this.TxbDiamètre.Location = new System.Drawing.Point(79, 65);
            this.TxbDiamètre.Name = "TxbDiamètre";
            this.TxbDiamètre.Size = new System.Drawing.Size(100, 20);
            this.TxbDiamètre.TabIndex = 3;
            this.TxbDiamètre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitOnly_KeyPress);
            // 
            // LblDiametre
            // 
            this.LblDiametre.AutoSize = true;
            this.LblDiametre.Location = new System.Drawing.Point(33, 68);
            this.LblDiametre.Name = "LblDiametre";
            this.LblDiametre.Size = new System.Drawing.Size(49, 13);
            this.LblDiametre.TabIndex = 2;
            this.LblDiametre.Text = "Diamètre";
            // 
            // TxbMasse
            // 
            this.TxbMasse.Location = new System.Drawing.Point(79, 101);
            this.TxbMasse.Name = "TxbMasse";
            this.TxbMasse.Size = new System.Drawing.Size(100, 20);
            this.TxbMasse.TabIndex = 5;
            this.TxbMasse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DigitOnly_KeyPress);
            // 
            // LblMasse
            // 
            this.LblMasse.AutoSize = true;
            this.LblMasse.Location = new System.Drawing.Point(33, 104);
            this.LblMasse.Name = "LblMasse";
            this.LblMasse.Size = new System.Drawing.Size(38, 13);
            this.LblMasse.TabIndex = 4;
            this.LblMasse.Text = "Masse";
            // 
            // TxbGalaxie
            // 
            this.TxbGalaxie.Location = new System.Drawing.Point(79, 133);
            this.TxbGalaxie.Name = "TxbGalaxie";
            this.TxbGalaxie.Size = new System.Drawing.Size(100, 20);
            this.TxbGalaxie.TabIndex = 7;
            // 
            // LblGalaxie
            // 
            this.LblGalaxie.AutoSize = true;
            this.LblGalaxie.Location = new System.Drawing.Point(33, 136);
            this.LblGalaxie.Name = "LblGalaxie";
            this.LblGalaxie.Size = new System.Drawing.Size(42, 13);
            this.LblGalaxie.TabIndex = 6;
            this.LblGalaxie.Text = "Galaxie";
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(79, 199);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(75, 23);
            this.BtnAjouter.TabIndex = 8;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // PlaneteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 280);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.TxbGalaxie);
            this.Controls.Add(this.LblGalaxie);
            this.Controls.Add(this.TxbMasse);
            this.Controls.Add(this.LblMasse);
            this.Controls.Add(this.TxbDiamètre);
            this.Controls.Add(this.LblDiametre);
            this.Controls.Add(this.TxbNom);
            this.Controls.Add(this.LblNom);
            this.Name = "PlaneteForm";
            this.Text = "Gestion des planètes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNom;
        public System.Windows.Forms.TextBox TxbNom;
        public System.Windows.Forms.TextBox TxbDiamètre;
        private System.Windows.Forms.Label LblDiametre;
        public System.Windows.Forms.TextBox TxbMasse;
        private System.Windows.Forms.Label LblMasse;
        public System.Windows.Forms.TextBox TxbGalaxie;
        private System.Windows.Forms.Label LblGalaxie;
        private System.Windows.Forms.Button BtnAjouter;
    }
}

