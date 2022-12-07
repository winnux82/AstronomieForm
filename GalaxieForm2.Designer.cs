namespace AstronomieForm
{
    partial class GalaxieForm2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNom = new System.Windows.Forms.Label();
            this.TxbNom = new System.Windows.Forms.TextBox();
            this.BtnAjouter = new System.Windows.Forms.Button();

            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(28, 36);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(29, 13);
            this.LblNom.TabIndex = 0;
            this.LblNom.Text = "Nom";
            // 
            // TxbNom
            // 
            this.TxbNom.Location = new System.Drawing.Point(75, 36);
            this.TxbNom.Name = "TxbNom";
            this.TxbNom.Size = new System.Drawing.Size(100, 20);
            this.TxbNom.TabIndex = 1;
            this.TxbNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbNom_KeyPress);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Location = new System.Drawing.Point(62, 63);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(75, 23);
            this.BtnAjouter.TabIndex = 2;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);


        }

        #endregion

        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.TextBox TxbNom;
        private System.Windows.Forms.Button BtnAjouter;
    }
}