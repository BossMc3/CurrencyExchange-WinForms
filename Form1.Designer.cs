namespace ProiectPaw_CasaDeSchimbValutar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbValuta = new System.Windows.Forms.Label();
            this.cbValuta = new System.Windows.Forms.ComboBox();
            this.lb2TipTranzacție = new System.Windows.Forms.Label();
            this.cbTipTranzactie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCursCumparare = new System.Windows.Forms.TextBox();
            this.tbCursVanzare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculeaza = new System.Windows.Forms.Button();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lvTranzactii = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ștergeTranzacțiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printeazăChitanțăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnIncarca = new System.Windows.Forms.Button();
            this.menuSalveaza = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazăToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIncarca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.graficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pdChitanta = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnSalveazaBD = new System.Windows.Forms.Button();
            this.btnIncarcaBD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panouCursValutar1 = new ProiectPaw_CasaDeSchimbValutar.PanouCursValutar();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbValuta
            // 
            this.lbValuta.AutoSize = true;
            this.lbValuta.Location = new System.Drawing.Point(27, 16);
            this.lbValuta.Name = "lbValuta";
            this.lbValuta.Size = new System.Drawing.Size(37, 13);
            this.lbValuta.TabIndex = 0;
            this.lbValuta.Text = "Valuta";
            // 
            // cbValuta
            // 
            this.cbValuta.FormattingEnabled = true;
            this.cbValuta.Location = new System.Drawing.Point(0, 31);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Size = new System.Drawing.Size(100, 21);
            this.cbValuta.TabIndex = 1;
            // 
            // lb2TipTranzacție
            // 
            this.lb2TipTranzacție.AutoSize = true;
            this.lb2TipTranzacție.Location = new System.Drawing.Point(116, 17);
            this.lb2TipTranzacție.Name = "lb2TipTranzacție";
            this.lb2TipTranzacție.Size = new System.Drawing.Size(75, 13);
            this.lb2TipTranzacție.TabIndex = 2;
            this.lb2TipTranzacție.Text = "Tip Tranzacție";
            // 
            // cbTipTranzactie
            // 
            this.cbTipTranzactie.FormattingEnabled = true;
            this.cbTipTranzactie.Location = new System.Drawing.Point(106, 31);
            this.cbTipTranzactie.Name = "cbTipTranzactie";
            this.cbTipTranzactie.Size = new System.Drawing.Size(100, 21);
            this.cbTipTranzactie.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sumă încasată";
            // 
            // tbSuma
            // 
            this.tbSuma.Location = new System.Drawing.Point(212, 33);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(100, 20);
            this.tbSuma.TabIndex = 5;
            this.tbSuma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSuma_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Curs Cumpărare";
            // 
            // tbCursCumparare
            // 
            this.tbCursCumparare.Location = new System.Drawing.Point(315, 33);
            this.tbCursCumparare.Name = "tbCursCumparare";
            this.tbCursCumparare.Size = new System.Drawing.Size(100, 20);
            this.tbCursCumparare.TabIndex = 7;
            // 
            // tbCursVanzare
            // 
            this.tbCursVanzare.Location = new System.Drawing.Point(421, 32);
            this.tbCursVanzare.Name = "tbCursVanzare";
            this.tbCursVanzare.Size = new System.Drawing.Size(100, 20);
            this.tbCursVanzare.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Curs Vânzare:";
            // 
            // btnCalculeaza
            // 
            this.btnCalculeaza.Location = new System.Drawing.Point(6, 71);
            this.btnCalculeaza.Name = "btnCalculeaza";
            this.btnCalculeaza.Size = new System.Drawing.Size(75, 23);
            this.btnCalculeaza.TabIndex = 10;
            this.btnCalculeaza.Text = "Calculează";
            this.btnCalculeaza.UseVisualStyleBackColor = true;
            this.btnCalculeaza.Click += new System.EventHandler(this.btnCalculeaza_Click);
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(106, 74);
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.ReadOnly = true;
            this.tbRezultat.Size = new System.Drawing.Size(100, 20);
            this.tbRezultat.TabIndex = 11;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(6, 110);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 12;
            this.btnAdauga.Text = "Adaugă Tranzacție";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lvTranzactii
            // 
            this.lvTranzactii.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvTranzactii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvTranzactii.ContextMenuStrip = this.contextMenuStrip1;
            this.lvTranzactii.FullRowSelect = true;
            this.lvTranzactii.GridLines = true;
            this.lvTranzactii.HideSelection = false;
            this.lvTranzactii.Location = new System.Drawing.Point(-1, 355);
            this.lvTranzactii.Name = "lvTranzactii";
            this.lvTranzactii.Size = new System.Drawing.Size(801, 97);
            this.lvTranzactii.TabIndex = 13;
            this.lvTranzactii.UseCompatibleStateImageBehavior = false;
            this.lvTranzactii.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Valută";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tip";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sumă Încasată";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Curs";
            this.columnHeader4.Width = 78;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sumă Eliberată";
            this.columnHeader5.Width = 113;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ștergeTranzacțiaToolStripMenuItem,
            this.printeazăChitanțăToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 48);
            // 
            // ștergeTranzacțiaToolStripMenuItem
            // 
            this.ștergeTranzacțiaToolStripMenuItem.Name = "ștergeTranzacțiaToolStripMenuItem";
            this.ștergeTranzacțiaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.ștergeTranzacțiaToolStripMenuItem.Text = "Șterge Tranzacția";
            this.ștergeTranzacțiaToolStripMenuItem.Click += new System.EventHandler(this.ștergeTranzacțiaToolStripMenuItem_Click);
            // 
            // printeazăChitanțăToolStripMenuItem
            // 
            this.printeazăChitanțăToolStripMenuItem.Name = "printeazăChitanțăToolStripMenuItem";
            this.printeazăChitanțăToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.printeazăChitanțăToolStripMenuItem.Text = "Printează Chitanță.";
            this.printeazăChitanțăToolStripMenuItem.Click += new System.EventHandler(this.printeazăChitanțăToolStripMenuItem_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(94, 32);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(97, 23);
            this.btnSalveaza.TabIndex = 14;
            this.btnSalveaza.Text = "Salvează Date";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnIncarca
            // 
            this.btnIncarca.Location = new System.Drawing.Point(94, 77);
            this.btnIncarca.Name = "btnIncarca";
            this.btnIncarca.Size = new System.Drawing.Size(97, 23);
            this.btnIncarca.TabIndex = 15;
            this.btnIncarca.Text = "Încarcă Date";
            this.btnIncarca.UseVisualStyleBackColor = true;
            this.btnIncarca.Click += new System.EventHandler(this.btnIncarca_Click);
            // 
            // menuSalveaza
            // 
            this.menuSalveaza.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazăToolStripMenuItem,
            this.menuIncarca,
            this.menuIesire});
            this.menuSalveaza.Name = "menuSalveaza";
            this.menuSalveaza.Size = new System.Drawing.Size(46, 20);
            this.menuSalveaza.Text = "&Fisier";
            // 
            // salveazăToolStripMenuItem
            // 
            this.salveazăToolStripMenuItem.Name = "salveazăToolStripMenuItem";
            this.salveazăToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salveazăToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salveazăToolStripMenuItem.Text = "&Salvează";
            this.salveazăToolStripMenuItem.Click += new System.EventHandler(this.salveazăToolStripMenuItem_Click);
            // 
            // menuIncarca
            // 
            this.menuIncarca.Name = "menuIncarca";
            this.menuIncarca.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuIncarca.Size = new System.Drawing.Size(158, 22);
            this.menuIncarca.Text = "&Încarcă";
            this.menuIncarca.Click += new System.EventHandler(this.menuIncarca_Click);
            // 
            // menuIesire
            // 
            this.menuIesire.Name = "menuIesire";
            this.menuIesire.Size = new System.Drawing.Size(158, 22);
            this.menuIesire.Text = "&Ieșire";
            this.menuIesire.Click += new System.EventHandler(this.menuIesire_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSalveaza,
            this.graficeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 17;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // graficeToolStripMenuItem
            // 
            this.graficeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afișeazăGraficToolStripMenuItem});
            this.graficeToolStripMenuItem.Name = "graficeToolStripMenuItem";
            this.graficeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.graficeToolStripMenuItem.Text = "&Grafice";
            // 
            // afișeazăGraficToolStripMenuItem
            // 
            this.afișeazăGraficToolStripMenuItem.Name = "afișeazăGraficToolStripMenuItem";
            this.afișeazăGraficToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.afișeazăGraficToolStripMenuItem.Text = "Afișează Grafic";
            this.afișeazăGraficToolStripMenuItem.Click += new System.EventHandler(this.afișeazăGraficToolStripMenuItem_Click);
            // 
            // pdChitanta
            // 
            this.pdChitanta.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdChitanta_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.pdChitanta;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnSalveazaBD
            // 
            this.btnSalveazaBD.Location = new System.Drawing.Point(308, 32);
            this.btnSalveazaBD.Name = "btnSalveazaBD";
            this.btnSalveazaBD.Size = new System.Drawing.Size(97, 23);
            this.btnSalveazaBD.TabIndex = 19;
            this.btnSalveazaBD.Text = "Salvează în BD";
            this.btnSalveazaBD.UseVisualStyleBackColor = true;
            this.btnSalveazaBD.Click += new System.EventHandler(this.btnSalveazaBD_Click);
            // 
            // btnIncarcaBD
            // 
            this.btnIncarcaBD.Location = new System.Drawing.Point(308, 77);
            this.btnIncarcaBD.Name = "btnIncarcaBD";
            this.btnIncarcaBD.Size = new System.Drawing.Size(97, 23);
            this.btnIncarcaBD.TabIndex = 20;
            this.btnIncarcaBD.Text = "Încarcă din BD";
            this.btnIncarcaBD.UseVisualStyleBackColor = true;
            this.btnIncarcaBD.Click += new System.EventHandler(this.btnIncarcaBD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbValuta);
            this.groupBox1.Controls.Add(this.cbValuta);
            this.groupBox1.Controls.Add(this.lb2TipTranzacție);
            this.groupBox1.Controls.Add(this.cbTipTranzactie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbSuma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCursCumparare);
            this.groupBox1.Controls.Add(this.btnAdauga);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbRezultat);
            this.groupBox1.Controls.Add(this.tbCursVanzare);
            this.groupBox1.Controls.Add(this.btnCalculeaza);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 139);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii Tranzacție";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalveazaBD);
            this.groupBox2.Controls.Add(this.btnSalveaza);
            this.groupBox2.Controls.Add(this.btnIncarca);
            this.groupBox2.Controls.Add(this.btnIncarcaBD);
            this.groupBox2.Location = new System.Drawing.Point(21, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 106);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gestiune Date";
            // 
            // panouCursValutar1
            // 
            this.panouCursValutar1.Location = new System.Drawing.Point(586, 41);
            this.panouCursValutar1.Name = "panouCursValutar1";
            this.panouCursValutar1.Size = new System.Drawing.Size(192, 198);
            this.panouCursValutar1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panouCursValutar1);
            this.Controls.Add(this.lvTranzactii);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Currency Exchange System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValuta;
        private System.Windows.Forms.ComboBox cbValuta;
        private System.Windows.Forms.Label lb2TipTranzacție;
        private System.Windows.Forms.ComboBox cbTipTranzactie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCursCumparare;
        private System.Windows.Forms.TextBox tbCursVanzare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculeaza;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ListView lvTranzactii;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnIncarca;
        private System.Windows.Forms.ToolStripMenuItem menuSalveaza;
        private System.Windows.Forms.ToolStripMenuItem salveazăToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuIncarca;
        private System.Windows.Forms.ToolStripMenuItem menuIesire;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ștergeTranzacțiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afișeazăGraficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printeazăChitanțăToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument pdChitanta;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnSalveazaBD;
        private System.Windows.Forms.Button btnIncarcaBD;
        private PanouCursValutar panouCursValutar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

