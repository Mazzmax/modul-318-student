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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFahrplan = new System.Windows.Forms.TabPage();
            this.tpAushangfahrten = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpFahrplan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVon
            // 
            this.lVon.AutoSize = true;
            this.lVon.Location = new System.Drawing.Point(21, 21);
            this.lVon.Name = "lVon";
            this.lVon.Size = new System.Drawing.Size(37, 17);
            this.lVon.TabIndex = 0;
            this.lVon.Text = "Von:";
            // 
            // lNach
            // 
            this.lNach.AutoSize = true;
            this.lNach.Location = new System.Drawing.Point(21, 58);
            this.lNach.Name = "lNach";
            this.lNach.Size = new System.Drawing.Size(45, 17);
            this.lNach.TabIndex = 1;
            this.lNach.Text = "Nach:";
            // 
            // tVon
            // 
            this.tVon.Location = new System.Drawing.Point(73, 18);
            this.tVon.Name = "tVon";
            this.tVon.Size = new System.Drawing.Size(150, 22);
            this.tVon.TabIndex = 2;
            // 
            // tNach
            // 
            this.tNach.Location = new System.Drawing.Point(73, 58);
            this.tNach.Name = "tNach";
            this.tNach.Size = new System.Drawing.Size(150, 22);
            this.tNach.TabIndex = 3;
            // 
            // bSuchen
            // 
            this.bSuchen.Location = new System.Drawing.Point(73, 97);
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
            this.lvFahrplan.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.lvFahrplan.Location = new System.Drawing.Point(24, 167);
            this.lvFahrplan.Name = "lvFahrplan";
            this.lvFahrplan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvFahrplan.Size = new System.Drawing.Size(964, 309);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFahrplan);
            this.tabControl1.Controls.Add(this.tpAushangfahrten);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1015, 526);
            this.tabControl1.TabIndex = 7;
            // 
            // tpFahrplan
            // 
            this.tpFahrplan.Controls.Add(this.lVon);
            this.tpFahrplan.Controls.Add(this.lvFahrplan);
            this.tpFahrplan.Controls.Add(this.lNach);
            this.tpFahrplan.Controls.Add(this.bSuchen);
            this.tpFahrplan.Controls.Add(this.tVon);
            this.tpFahrplan.Controls.Add(this.tNach);
            this.tpFahrplan.Location = new System.Drawing.Point(4, 25);
            this.tpFahrplan.Name = "tpFahrplan";
            this.tpFahrplan.Padding = new System.Windows.Forms.Padding(3);
            this.tpFahrplan.Size = new System.Drawing.Size(1007, 497);
            this.tpFahrplan.TabIndex = 0;
            this.tpFahrplan.Text = "Fahrplan";
            this.tpFahrplan.UseVisualStyleBackColor = true;
            // 
            // tpAushangfahrten
            // 
            this.tpAushangfahrten.Location = new System.Drawing.Point(4, 25);
            this.tpAushangfahrten.Name = "tpAushangfahrten";
            this.tpAushangfahrten.Padding = new System.Windows.Forms.Padding(3);
            this.tpAushangfahrten.Size = new System.Drawing.Size(1007, 497);
            this.tpAushangfahrten.TabIndex = 1;
            this.tpAushangfahrten.Text = "Aushangfahrten";
            this.tpAushangfahrten.UseVisualStyleBackColor = true;
            // 
            // GUI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "GUI1";
            this.Text = "GUI1";
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpFahrplan.ResumeLayout(false);
            this.tpFahrplan.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFahrplan;
        private System.Windows.Forms.TabPage tpAushangfahrten;
    }
}