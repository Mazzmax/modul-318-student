namespace TransitApp
{
    partial class GUI1
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
            this.components = new System.ComponentModel.Container();
            this.lVon = new System.Windows.Forms.Label();
            this.lNach = new System.Windows.Forms.Label();
            this.tVon = new System.Windows.Forms.TextBox();
            this.tNach = new System.Windows.Forms.TextBox();
            this.bSuchen = new System.Windows.Forms.Button();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lvFahrplan = new System.Windows.Forms.ListView();
            this.chLinie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAbfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGleis1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnkunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGleis2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUmsteigen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lVon
            // 
            this.lVon.AutoSize = true;
            this.lVon.Location = new System.Drawing.Point(23, 22);
            this.lVon.Name = "lVon";
            this.lVon.Size = new System.Drawing.Size(37, 17);
            this.lVon.TabIndex = 0;
            this.lVon.Text = "Von:";
            // 
            // lNach
            // 
            this.lNach.AutoSize = true;
            this.lNach.Location = new System.Drawing.Point(23, 59);
            this.lNach.Name = "lNach";
            this.lNach.Size = new System.Drawing.Size(45, 17);
            this.lNach.TabIndex = 1;
            this.lNach.Text = "Nach:";
            // 
            // tVon
            // 
            this.tVon.Location = new System.Drawing.Point(75, 19);
            this.tVon.Name = "tVon";
            this.tVon.Size = new System.Drawing.Size(150, 22);
            this.tVon.TabIndex = 2;
            // 
            // tNach
            // 
            this.tNach.Location = new System.Drawing.Point(75, 59);
            this.tNach.Name = "tNach";
            this.tNach.Size = new System.Drawing.Size(150, 22);
            this.tNach.TabIndex = 3;
            // 
            // bSuchen
            // 
            this.bSuchen.Location = new System.Drawing.Point(75, 98);
            this.bSuchen.Name = "bSuchen";
            this.bSuchen.Size = new System.Drawing.Size(150, 22);
            this.bSuchen.TabIndex = 4;
            this.bSuchen.Text = "Suchen";
            this.bSuchen.UseVisualStyleBackColor = true;
            this.bSuchen.Click += new System.EventHandler(this.bSuchen_Click);
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataSource = typeof(SwissTransport.Transport);
            // 
            // lvFahrplan
            // 
            this.lvFahrplan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLinie,
            this.chAbfahrt,
            this.chVon,
            this.chGleis1,
            this.chAnkunft,
            this.chNach,
            this.chGleis2,
            this.chDauer,
            this.chUmsteigen});
            this.lvFahrplan.Location = new System.Drawing.Point(26, 187);
            this.lvFahrplan.Name = "lvFahrplan";
            this.lvFahrplan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvFahrplan.Size = new System.Drawing.Size(1030, 309);
            this.lvFahrplan.TabIndex = 6;
            this.lvFahrplan.UseCompatibleStateImageBehavior = false;
            this.lvFahrplan.View = System.Windows.Forms.View.Details;
            // 
            // chLinie
            // 
            this.chLinie.Text = "Linie";
            this.chLinie.Width = 42;
            // 
            // chAbfahrt
            // 
            this.chAbfahrt.Text = "Abfahrt";
            this.chAbfahrt.Width = 68;
            // 
            // chVon
            // 
            this.chVon.Text = "Von";
            this.chVon.Width = 179;
            // 
            // chGleis1
            // 
            this.chGleis1.Text = "Gleis";
            // 
            // chAnkunft
            // 
            this.chAnkunft.Text = "Ankunft";
            // 
            // chNach
            // 
            this.chNach.Text = "Nach";
            this.chNach.Width = 188;
            // 
            // chGleis2
            // 
            this.chGleis2.Text = "Gleis";
            // 
            // chDauer
            // 
            this.chDauer.Text = "Dauer";
            // 
            // chUmsteigen
            // 
            this.chUmsteigen.Text = "Umsteigen";
            this.chUmsteigen.Width = 86;
            // 
            // GUI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 508);
            this.Controls.Add(this.lvFahrplan);
            this.Controls.Add(this.bSuchen);
            this.Controls.Add(this.tNach);
            this.Controls.Add(this.tVon);
            this.Controls.Add(this.lNach);
            this.Controls.Add(this.lVon);
            this.Name = "GUI1";
            this.Text = "GUI1";
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lVon;
        private System.Windows.Forms.Label lNach;
        private System.Windows.Forms.TextBox tVon;
        private System.Windows.Forms.TextBox tNach;
        private System.Windows.Forms.Button bSuchen;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private System.Windows.Forms.ListView lvFahrplan;
        private System.Windows.Forms.ColumnHeader chLinie;
        private System.Windows.Forms.ColumnHeader chAbfahrt;
        private System.Windows.Forms.ColumnHeader chVon;
        private System.Windows.Forms.ColumnHeader chGleis1;
        private System.Windows.Forms.ColumnHeader chAnkunft;
        private System.Windows.Forms.ColumnHeader chNach;
        private System.Windows.Forms.ColumnHeader chGleis2;
        private System.Windows.Forms.ColumnHeader chDauer;
        private System.Windows.Forms.ColumnHeader chUmsteigen;
    }
}