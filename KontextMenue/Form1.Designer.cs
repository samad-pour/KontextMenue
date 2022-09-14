namespace KontextMenue
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.readOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multilineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MnuFett = new System.Windows.Forms.ToolStripButton();
            this.MnuKursiv = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CboxTextSize = new System.Windows.Forms.ToolStripComboBox();
            this.LblDisplay = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StsLblDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.StsPrgBar = new System.Windows.Forms.ToolStripProgressBar();
            this.TimerEnde = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernunterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.druckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seitenansichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rückgängigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wiederholenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ausschneidenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.allesauswählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inhaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readOnlyToolStripMenuItem,
            this.multilineToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 100);
            // 
            // readOnlyToolStripMenuItem
            // 
            this.readOnlyToolStripMenuItem.Name = "readOnlyToolStripMenuItem";
            this.readOnlyToolStripMenuItem.Size = new System.Drawing.Size(224, 48);
            this.readOnlyToolStripMenuItem.Text = "ReadOnly";
            this.readOnlyToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuItem_Click);
            // 
            // multilineToolStripMenuItem
            // 
            this.multilineToolStripMenuItem.Name = "multilineToolStripMenuItem";
            this.multilineToolStripMenuItem.Size = new System.Drawing.Size(224, 48);
            this.multilineToolStripMenuItem.Text = "Multiline";
            this.multilineToolStripMenuItem.Click += new System.EventHandler(this.ContextMenuItem_Click);
            // 
            // TxtInput
            // 
            this.TxtInput.ContextMenuStrip = this.contextMenuStrip1;
            this.TxtInput.Location = new System.Drawing.Point(22, 234);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(250, 47);
            this.TxtInput.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuFett,
            this.MnuKursiv,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.CboxTextSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 49);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 51);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MnuFett
            // 
            this.MnuFett.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MnuFett.Image = ((System.Drawing.Image)(resources.GetObject("MnuFett.Image")));
            this.MnuFett.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MnuFett.Name = "MnuFett";
            this.MnuFett.Size = new System.Drawing.Size(58, 44);
            this.MnuFett.Text = "toolStripButton2";
            this.MnuFett.Click += new System.EventHandler(this.MnuFett_Click);
            // 
            // MnuKursiv
            // 
            this.MnuKursiv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MnuKursiv.Image = ((System.Drawing.Image)(resources.GetObject("MnuKursiv.Image")));
            this.MnuKursiv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MnuKursiv.Name = "MnuKursiv";
            this.MnuKursiv.Size = new System.Drawing.Size(58, 44);
            this.MnuKursiv.Text = "toolStripButton1";
            this.MnuKursiv.Click += new System.EventHandler(this.MnuKursiv_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(196, 44);
            this.toolStripLabel1.Text = "Schriftgrösse:";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // CboxTextSize
            // 
            this.CboxTextSize.Items.AddRange(new object[] {
            "8.25",
            "10",
            "13",
            "18"});
            this.CboxTextSize.Name = "CboxTextSize";
            this.CboxTextSize.Size = new System.Drawing.Size(121, 51);
            this.CboxTextSize.TextChanged += new System.EventHandler(this.CboxTextSize_TextChanged);
            // 
            // LblDisplay
            // 
            this.LblDisplay.AutoSize = true;
            this.LblDisplay.Location = new System.Drawing.Point(22, 284);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(74, 41);
            this.LblDisplay.TabIndex = 3;
            this.LblDisplay.Text = "Leer";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StsLblDisplay,
            this.StsPrgBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 54);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StsLblDisplay
            // 
            this.StsLblDisplay.Name = "StsLblDisplay";
            this.StsLblDisplay.Size = new System.Drawing.Size(160, 41);
            this.StsLblDisplay.Text = "00.00.0000";
            // 
            // StsPrgBar
            // 
            this.StsPrgBar.Name = "StsPrgBar";
            this.StsPrgBar.Size = new System.Drawing.Size(300, 38);
            // 
            // TimerEnde
            // 
            this.TimerEnde.Tick += new System.EventHandler(this.TimerEnde_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 49);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.öffnenToolStripMenuItem,
            this.toolStripSeparator,
            this.speichernToolStripMenuItem,
            this.speichernunterToolStripMenuItem,
            this.toolStripSeparator2,
            this.druckenToolStripMenuItem,
            this.seitenansichtToolStripMenuItem,
            this.toolStripSeparator3,
            this.MnuBeenden});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(111, 45);
            this.dateiToolStripMenuItem.Text = "&Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("neuToolStripMenuItem.Image")));
            this.neuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.neuToolStripMenuItem.Text = "&Neu";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("öffnenToolStripMenuItem.Image")));
            this.öffnenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.öffnenToolStripMenuItem.Text = "Ö&ffnen";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(445, 6);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("speichernToolStripMenuItem.Image")));
            this.speichernToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.speichernToolStripMenuItem.Text = "&Speichern";
            // 
            // speichernunterToolStripMenuItem
            // 
            this.speichernunterToolStripMenuItem.Name = "speichernunterToolStripMenuItem";
            this.speichernunterToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.speichernunterToolStripMenuItem.Text = "Speichern &unter";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(445, 6);
            // 
            // druckenToolStripMenuItem
            // 
            this.druckenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("druckenToolStripMenuItem.Image")));
            this.druckenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.druckenToolStripMenuItem.Name = "druckenToolStripMenuItem";
            this.druckenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.druckenToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.druckenToolStripMenuItem.Text = "&Drucken";
            // 
            // seitenansichtToolStripMenuItem
            // 
            this.seitenansichtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("seitenansichtToolStripMenuItem.Image")));
            this.seitenansichtToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.seitenansichtToolStripMenuItem.Name = "seitenansichtToolStripMenuItem";
            this.seitenansichtToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.seitenansichtToolStripMenuItem.Text = "&Seitenansicht";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(445, 6);
            // 
            // MnuBeenden
            // 
            this.MnuBeenden.Name = "MnuBeenden";
            this.MnuBeenden.Size = new System.Drawing.Size(448, 54);
            this.MnuBeenden.Text = "&Beenden";
            this.MnuBeenden.Click += new System.EventHandler(this.MnuBeenden_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rückgängigToolStripMenuItem,
            this.wiederholenToolStripMenuItem,
            this.toolStripSeparator4,
            this.ausschneidenToolStripMenuItem,
            this.kopierenToolStripMenuItem,
            this.einfügenToolStripMenuItem,
            this.toolStripSeparator5,
            this.allesauswählenToolStripMenuItem});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(184, 45);
            this.bearbeitenToolStripMenuItem.Text = "&Bearbeiten";
            // 
            // rückgängigToolStripMenuItem
            // 
            this.rückgängigToolStripMenuItem.Name = "rückgängigToolStripMenuItem";
            this.rückgängigToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.rückgängigToolStripMenuItem.Size = new System.Drawing.Size(478, 54);
            this.rückgängigToolStripMenuItem.Text = "&Rückgängig";
            // 
            // wiederholenToolStripMenuItem
            // 
            this.wiederholenToolStripMenuItem.Name = "wiederholenToolStripMenuItem";
            this.wiederholenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.wiederholenToolStripMenuItem.Size = new System.Drawing.Size(478, 54);
            this.wiederholenToolStripMenuItem.Text = "&Wiederholen";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(475, 6);
            // 
            // ausschneidenToolStripMenuItem
            // 
            this.ausschneidenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ausschneidenToolStripMenuItem.Image")));
            this.ausschneidenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ausschneidenToolStripMenuItem.Name = "ausschneidenToolStripMenuItem";
            this.ausschneidenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ausschneidenToolStripMenuItem.Size = new System.Drawing.Size(478, 54);
            this.ausschneidenToolStripMenuItem.Text = "Aussc&hneiden";
            // 
            // kopierenToolStripMenuItem
            // 
            this.kopierenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kopierenToolStripMenuItem.Image")));
            this.kopierenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.kopierenToolStripMenuItem.Name = "kopierenToolStripMenuItem";
            this.kopierenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopierenToolStripMenuItem.Size = new System.Drawing.Size(478, 54);
            this.kopierenToolStripMenuItem.Text = "&Kopieren";
            // 
            // einfügenToolStripMenuItem
            // 
            this.einfügenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("einfügenToolStripMenuItem.Image")));
            this.einfügenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.einfügenToolStripMenuItem.Name = "einfügenToolStripMenuItem";
            this.einfügenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.einfügenToolStripMenuItem.Size = new System.Drawing.Size(478, 54);
            this.einfügenToolStripMenuItem.Text = "&Einfügen";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(475, 6);
            // 
            // allesauswählenToolStripMenuItem
            // 
            this.allesauswählenToolStripMenuItem.Name = "allesauswählenToolStripMenuItem";
            this.allesauswählenToolStripMenuItem.Size = new System.Drawing.Size(478, 54);
            this.allesauswählenToolStripMenuItem.Text = "&Alles auswählen";
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anpassenToolStripMenuItem,
            this.optionenToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(119, 45);
            this.extrasToolStripMenuItem.Text = "E&xtras";
            // 
            // anpassenToolStripMenuItem
            // 
            this.anpassenToolStripMenuItem.Name = "anpassenToolStripMenuItem";
            this.anpassenToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.anpassenToolStripMenuItem.Text = "&Anpassen";
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.optionenToolStripMenuItem.Text = "&Optionen";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inhaltToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.suchenToolStripMenuItem,
            this.toolStripSeparator6,
            this.infoToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(102, 45);
            this.hilfeToolStripMenuItem.Text = "&Hilfe";
            // 
            // inhaltToolStripMenuItem
            // 
            this.inhaltToolStripMenuItem.Name = "inhaltToolStripMenuItem";
            this.inhaltToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.inhaltToolStripMenuItem.Text = "&Inhalt";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // suchenToolStripMenuItem
            // 
            this.suchenToolStripMenuItem.Name = "suchenToolStripMenuItem";
            this.suchenToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.suchenToolStripMenuItem.Text = "&Suchen";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(445, 6);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.infoToolStripMenuItem.Text = "Inf&o...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.LblDisplay);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TxtInput);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem readOnlyToolStripMenuItem;
        private ToolStripMenuItem multilineToolStripMenuItem;
        private TextBox TxtInput;
        private ToolStrip toolStrip1;
        private ToolStripButton MnuKursiv;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton MnuFett;
        private ToolStripComboBox CboxTextSize;
        private Label LblDisplay;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StsLblDisplay;
        private ToolStripProgressBar StsPrgBar;
        private System.Windows.Forms.Timer TimerEnde;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem neuToolStripMenuItem;
        private ToolStripMenuItem öffnenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem speichernToolStripMenuItem;
        private ToolStripMenuItem speichernunterToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem druckenToolStripMenuItem;
        private ToolStripMenuItem seitenansichtToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem MnuBeenden;
        private ToolStripMenuItem bearbeitenToolStripMenuItem;
        private ToolStripMenuItem rückgängigToolStripMenuItem;
        private ToolStripMenuItem wiederholenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem ausschneidenToolStripMenuItem;
        private ToolStripMenuItem kopierenToolStripMenuItem;
        private ToolStripMenuItem einfügenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem allesauswählenToolStripMenuItem;
        private ToolStripMenuItem extrasToolStripMenuItem;
        private ToolStripMenuItem anpassenToolStripMenuItem;
        private ToolStripMenuItem optionenToolStripMenuItem;
        private ToolStripMenuItem hilfeToolStripMenuItem;
        private ToolStripMenuItem inhaltToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem suchenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem infoToolStripMenuItem;
    }
}