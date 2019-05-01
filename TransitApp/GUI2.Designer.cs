namespace TransitApp
{
    partial class TransitApp
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bFahrplan2 = new System.Windows.Forms.Button();
            this.bKarte2 = new System.Windows.Forms.Button();
            this.bAushangfahrplan2 = new System.Windows.Forms.Button();
            this.laHaltestelle = new System.Windows.Forms.Label();
            this.tbHaltestelle = new System.Windows.Forms.TextBox();
            this.bSuchenKarte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bFahrplan2
            // 
            this.bFahrplan2.Location = new System.Drawing.Point(12, 12);
            this.bFahrplan2.Name = "bFahrplan2";
            this.bFahrplan2.Size = new System.Drawing.Size(128, 48);
            this.bFahrplan2.TabIndex = 0;
            this.bFahrplan2.Text = "Fahrplan";
            this.bFahrplan2.UseVisualStyleBackColor = true;
            // 
            // bKarte2
            // 
            this.bKarte2.ForeColor = System.Drawing.Color.Black;
            this.bKarte2.Location = new System.Drawing.Point(155, 12);
            this.bKarte2.Name = "bKarte2";
            this.bKarte2.Size = new System.Drawing.Size(128, 48);
            this.bKarte2.TabIndex = 1;
            this.bKarte2.Text = "Karte";
            this.bKarte2.UseVisualStyleBackColor = true;
            // 
            // bAushangfahrplan2
            // 
            this.bAushangfahrplan2.Location = new System.Drawing.Point(297, 12);
            this.bAushangfahrplan2.Name = "bAushangfahrplan2";
            this.bAushangfahrplan2.Size = new System.Drawing.Size(128, 48);
            this.bAushangfahrplan2.TabIndex = 2;
            this.bAushangfahrplan2.Text = "Aushangfahrplan";
            this.bAushangfahrplan2.UseVisualStyleBackColor = true;
            // 
            // laHaltestelle
            // 
            this.laHaltestelle.AutoSize = true;
            this.laHaltestelle.Location = new System.Drawing.Point(12, 102);
            this.laHaltestelle.Name = "laHaltestelle";
            this.laHaltestelle.Size = new System.Drawing.Size(74, 17);
            this.laHaltestelle.TabIndex = 3;
            this.laHaltestelle.Text = "Haltestelle";
            // 
            // tbHaltestelle
            // 
            this.tbHaltestelle.Location = new System.Drawing.Point(12, 122);
            this.tbHaltestelle.Name = "tbHaltestelle";
            this.tbHaltestelle.Size = new System.Drawing.Size(243, 22);
            this.tbHaltestelle.TabIndex = 6;
            // 
            // bSuchenKarte
            // 
            this.bSuchenKarte.Location = new System.Drawing.Point(12, 162);
            this.bSuchenKarte.Name = "bSuchenKarte";
            this.bSuchenKarte.Size = new System.Drawing.Size(243, 48);
            this.bSuchenKarte.TabIndex = 12;
            this.bSuchenKarte.Text = "Suchen";
            this.bSuchenKarte.UseVisualStyleBackColor = true;
            // 
            // TransitApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 516);
            this.Controls.Add(this.bSuchenKarte);
            this.Controls.Add(this.tbHaltestelle);
            this.Controls.Add(this.laHaltestelle);
            this.Controls.Add(this.bAushangfahrplan2);
            this.Controls.Add(this.bKarte2);
            this.Controls.Add(this.bFahrplan2);
            this.Name = "TransitApp";
            this.Text = "TransitApp";
            this.Load += new System.EventHandler(this.TransitApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bFahrplan2;
        private System.Windows.Forms.Button bKarte2;
        private System.Windows.Forms.Button bAushangfahrplan2;
        private System.Windows.Forms.Label laHaltestelle;
        private System.Windows.Forms.TextBox tbHaltestelle;
        private System.Windows.Forms.Button bSuchenKarte;
    }
}

