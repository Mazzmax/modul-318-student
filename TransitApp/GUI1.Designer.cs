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
            this.bSuchen = new System.Windows.Forms.Button();
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lvFahrplan = new System.Windows.Forms.ListView();
            this.chVoid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAbfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chVon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGleis1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAnkunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGleis2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpFahrplan = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpZeit = new System.Windows.Forms.DateTimePicker();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cbNach = new System.Windows.Forms.ComboBox();
            this.cbVon = new System.Windows.Forms.ComboBox();
            this.tpAushangfahrplan = new System.Windows.Forms.TabPage();
            this.bSuchen2 = new System.Windows.Forms.Button();
            this.lvAushangfahrplan = new System.Windows.Forms.ListView();
            this.chLinie2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAbfahrt3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRichtung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.lStation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpFahrplan.SuspendLayout();
            this.tpAushangfahrplan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lVon
            // 
            this.lVon.AutoSize = true;
            this.lVon.Location = new System.Drawing.Point(21, 23);
            this.lVon.Name = "lVon";
            this.lVon.Size = new System.Drawing.Size(37, 17);
            this.lVon.TabIndex = 0;
            this.lVon.Text = "Von:";
            // 
            // lNach
            // 
            this.lNach.AutoSize = true;
            this.lNach.Location = new System.Drawing.Point(21, 63);
            this.lNach.Name = "lNach";
            this.lNach.Size = new System.Drawing.Size(45, 17);
            this.lNach.TabIndex = 1;
            this.lNach.Text = "Nach:";
            // 
            // bSuchen
            // 
            this.bSuchen.Location = new System.Drawing.Point(80, 138);
            this.bSuchen.Name = "bSuchen";
            this.bSuchen.Size = new System.Drawing.Size(229, 28);
            this.bSuchen.TabIndex = 5;
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
            this.chVoid,
            this.chAbfahrt,
            this.chVon,
            this.chGleis1,
            this.chAnkunft,
            this.chNach,
            this.chGleis2});
            this.lvFahrplan.Location = new System.Drawing.Point(339, 20);
            this.lvFahrplan.Name = "lvFahrplan";
            this.lvFahrplan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvFahrplan.Size = new System.Drawing.Size(820, 458);
            this.lvFahrplan.TabIndex = 6;
            this.lvFahrplan.UseCompatibleStateImageBehavior = false;
            this.lvFahrplan.View = System.Windows.Forms.View.Details;
            // 
            // chVoid
            // 
            this.chVoid.DisplayIndex = 6;
            this.chVoid.Text = "";
            this.chVoid.Width = 0;
            // 
            // chAbfahrt
            // 
            this.chAbfahrt.DisplayIndex = 0;
            this.chAbfahrt.Text = "Abfahrt";
            this.chAbfahrt.Width = 55;
            // 
            // chVon
            // 
            this.chVon.DisplayIndex = 1;
            this.chVon.Text = "Von";
            this.chVon.Width = 180;
            // 
            // chGleis1
            // 
            this.chGleis1.DisplayIndex = 2;
            this.chGleis1.Text = "Gleis";
            this.chGleis1.Width = 45;
            // 
            // chAnkunft
            // 
            this.chAnkunft.DisplayIndex = 3;
            this.chAnkunft.Text = "Ankunft";
            this.chAnkunft.Width = 55;
            // 
            // chNach
            // 
            this.chNach.DisplayIndex = 4;
            this.chNach.Text = "Nach";
            this.chNach.Width = 180;
            // 
            // chGleis2
            // 
            this.chGleis2.DisplayIndex = 5;
            this.chGleis2.Text = "Gleis";
            this.chGleis2.Width = 95;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpFahrplan);
            this.tabControl1.Controls.Add(this.tpAushangfahrplan);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1173, 513);
            this.tabControl1.TabIndex = 7;
            // 
            // tpFahrplan
            // 
            this.tpFahrplan.Controls.Add(this.label1);
            this.tpFahrplan.Controls.Add(this.dtpZeit);
            this.tpFahrplan.Controls.Add(this.dtpDatum);
            this.tpFahrplan.Controls.Add(this.cbNach);
            this.tpFahrplan.Controls.Add(this.cbVon);
            this.tpFahrplan.Controls.Add(this.lVon);
            this.tpFahrplan.Controls.Add(this.lvFahrplan);
            this.tpFahrplan.Controls.Add(this.lNach);
            this.tpFahrplan.Controls.Add(this.bSuchen);
            this.tpFahrplan.Controls.Add(this.label2);
            this.tpFahrplan.Location = new System.Drawing.Point(4, 25);
            this.tpFahrplan.Name = "tpFahrplan";
            this.tpFahrplan.Padding = new System.Windows.Forms.Padding(3);
            this.tpFahrplan.Size = new System.Drawing.Size(1165, 484);
            this.tpFahrplan.TabIndex = 0;
            this.tpFahrplan.Text = "Fahrplan";
            this.tpFahrplan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Zeit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Datum:";
            // 
            // dtpZeit
            // 
            this.dtpZeit.CustomFormat = "HH:mm";
            this.dtpZeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpZeit.Location = new System.Drawing.Point(242, 100);
            this.dtpZeit.Name = "dtpZeit";
            this.dtpZeit.Size = new System.Drawing.Size(67, 22);
            this.dtpZeit.TabIndex = 4;
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "dd.MM.yyyy";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(80, 100);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(124, 22);
            this.dtpDatum.TabIndex = 3;
            // 
            // cbNach
            // 
            this.cbNach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbNach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNach.FormattingEnabled = true;
            this.cbNach.Location = new System.Drawing.Point(80, 60);
            this.cbNach.Name = "cbNach";
            this.cbNach.Size = new System.Drawing.Size(229, 24);
            this.cbNach.TabIndex = 2;
            this.cbNach.TextChanged += new System.EventHandler(this.autoComplete);
            // 
            // cbVon
            // 
            this.cbVon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbVon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbVon.FormattingEnabled = true;
            this.cbVon.Location = new System.Drawing.Point(80, 20);
            this.cbVon.Name = "cbVon";
            this.cbVon.Size = new System.Drawing.Size(229, 24);
            this.cbVon.TabIndex = 1;
            this.cbVon.TextChanged += new System.EventHandler(this.autoComplete);
            // 
            // tpAushangfahrplan
            // 
            this.tpAushangfahrplan.AllowDrop = true;
            this.tpAushangfahrplan.Controls.Add(this.bSuchen2);
            this.tpAushangfahrplan.Controls.Add(this.lvAushangfahrplan);
            this.tpAushangfahrplan.Controls.Add(this.cbStation);
            this.tpAushangfahrplan.Controls.Add(this.lStation);
            this.tpAushangfahrplan.Location = new System.Drawing.Point(4, 25);
            this.tpAushangfahrplan.Name = "tpAushangfahrplan";
            this.tpAushangfahrplan.Padding = new System.Windows.Forms.Padding(3);
            this.tpAushangfahrplan.Size = new System.Drawing.Size(1165, 484);
            this.tpAushangfahrplan.TabIndex = 1;
            this.tpAushangfahrplan.Text = "Aushangfahrplan";
            this.tpAushangfahrplan.UseVisualStyleBackColor = true;
            // 
            // bSuchen2
            // 
            this.bSuchen2.Location = new System.Drawing.Point(80, 60);
            this.bSuchen2.Name = "bSuchen2";
            this.bSuchen2.Size = new System.Drawing.Size(229, 28);
            this.bSuchen2.TabIndex = 2;
            this.bSuchen2.Text = "Suchen";
            this.bSuchen2.UseVisualStyleBackColor = true;
            this.bSuchen2.Click += new System.EventHandler(this.bSuchen2_Click);
            // 
            // lvAushangfahrplan
            // 
            this.lvAushangfahrplan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLinie2,
            this.chAbfahrt3,
            this.chRichtung});
            this.lvAushangfahrplan.Location = new System.Drawing.Point(339, 20);
            this.lvAushangfahrplan.Name = "lvAushangfahrplan";
            this.lvAushangfahrplan.Size = new System.Drawing.Size(820, 458);
            this.lvAushangfahrplan.TabIndex = 2;
            this.lvAushangfahrplan.UseCompatibleStateImageBehavior = false;
            this.lvAushangfahrplan.View = System.Windows.Forms.View.Details;
            // 
            // chLinie2
            // 
            this.chLinie2.Text = "Linie";
            // 
            // chAbfahrt3
            // 
            this.chAbfahrt3.Text = "Abfahrt";
            // 
            // chRichtung
            // 
            this.chRichtung.Text = "Richtung";
            this.chRichtung.Width = 400;
            // 
            // cbStation
            // 
            this.cbStation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbStation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Location = new System.Drawing.Point(80, 20);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(229, 24);
            this.cbStation.TabIndex = 1;
            this.cbStation.TextChanged += new System.EventHandler(this.autoComplete);
            // 
            // lStation
            // 
            this.lStation.AutoSize = true;
            this.lStation.Location = new System.Drawing.Point(21, 23);
            this.lStation.Name = "lStation";
            this.lStation.Size = new System.Drawing.Size(56, 17);
            this.lStation.TabIndex = 0;
            this.lStation.Text = "Station:";
            // 
            // GUI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 535);
            this.Controls.Add(this.tabControl1);
            this.Name = "GUI1";
            this.Text = "TransitApp";
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpFahrplan.ResumeLayout(false);
            this.tpFahrplan.PerformLayout();
            this.tpAushangfahrplan.ResumeLayout(false);
            this.tpAushangfahrplan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lVon;
        private System.Windows.Forms.Label lNach;
        private System.Windows.Forms.Button bSuchen;
        private System.Windows.Forms.BindingSource transportBindingSource;
        private System.Windows.Forms.ListView lvFahrplan;
        private System.Windows.Forms.ColumnHeader chAbfahrt;
        private System.Windows.Forms.ColumnHeader chVon;
        private System.Windows.Forms.ColumnHeader chGleis1;
        private System.Windows.Forms.ColumnHeader chAnkunft;
        private System.Windows.Forms.ColumnHeader chNach;
        private System.Windows.Forms.ColumnHeader chGleis2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpFahrplan;
        private System.Windows.Forms.TabPage tpAushangfahrplan;
        private System.Windows.Forms.ComboBox cbVon;
        private System.Windows.Forms.ComboBox cbNach;
        private System.Windows.Forms.Button bSuchen2;
        private System.Windows.Forms.ListView lvAushangfahrplan;
        private System.Windows.Forms.ComboBox cbStation;
        private System.Windows.Forms.Label lStation;
        private System.Windows.Forms.ColumnHeader chVoid;
        private System.Windows.Forms.ColumnHeader chLinie2;
        private System.Windows.Forms.ColumnHeader chAbfahrt3;
        private System.Windows.Forms.ColumnHeader chRichtung;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpZeit;
    }
}