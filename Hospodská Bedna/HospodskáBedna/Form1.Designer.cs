namespace HospodskáBedna
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LBL_Nadpis = new System.Windows.Forms.Label();
            this.TXB_AktualniKredit = new System.Windows.Forms.TextBox();
            this.TXB_CelkemVyhozeno = new System.Windows.Forms.TextBox();
            this.CB_CenaRoztoceni = new System.Windows.Forms.ComboBox();
            this.BTN_Vloz = new System.Windows.Forms.Button();
            this.BTN_Vybrat = new System.Windows.Forms.Button();
            this.PB_Valec1 = new System.Windows.Forms.PictureBox();
            this.PB_Valec2 = new System.Windows.Forms.PictureBox();
            this.PB_Valec3 = new System.Windows.Forms.PictureBox();
            this.BTN_Roztoc = new System.Windows.Forms.Button();
            this.NUM_hotovost = new System.Windows.Forms.NumericUpDown();
            this.LBL_Vhodte = new System.Windows.Forms.Label();
            this.LBL_Kredit = new System.Windows.Forms.Label();
            this.LBL_CenaRoztoceni = new System.Windows.Forms.Label();
            this.LBL_CelkemVyhozeno = new System.Windows.Forms.Label();
            this.AnimaceUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Valec1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Valec2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Valec3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_hotovost)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Nadpis
            // 
            this.LBL_Nadpis.AutoSize = true;
            this.LBL_Nadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Nadpis.Location = new System.Drawing.Point(12, 9);
            this.LBL_Nadpis.Name = "LBL_Nadpis";
            this.LBL_Nadpis.Size = new System.Drawing.Size(97, 31);
            this.LBL_Nadpis.TabIndex = 0;
            this.LBL_Nadpis.Text = "Bedna";
            // 
            // TXB_AktualniKredit
            // 
            this.TXB_AktualniKredit.Location = new System.Drawing.Point(128, 97);
            this.TXB_AktualniKredit.Name = "TXB_AktualniKredit";
            this.TXB_AktualniKredit.ReadOnly = true;
            this.TXB_AktualniKredit.Size = new System.Drawing.Size(100, 20);
            this.TXB_AktualniKredit.TabIndex = 2;
            this.TXB_AktualniKredit.Text = "0.- Kč";
            // 
            // TXB_CelkemVyhozeno
            // 
            this.TXB_CelkemVyhozeno.Location = new System.Drawing.Point(128, 155);
            this.TXB_CelkemVyhozeno.Name = "TXB_CelkemVyhozeno";
            this.TXB_CelkemVyhozeno.ReadOnly = true;
            this.TXB_CelkemVyhozeno.Size = new System.Drawing.Size(100, 20);
            this.TXB_CelkemVyhozeno.TabIndex = 3;
            this.TXB_CelkemVyhozeno.Text = "0.- Kč";
            // 
            // CB_CenaRoztoceni
            // 
            this.CB_CenaRoztoceni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_CenaRoztoceni.FormattingEnabled = true;
            this.CB_CenaRoztoceni.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "20",
            "50",
            "100"});
            this.CB_CenaRoztoceni.Location = new System.Drawing.Point(128, 128);
            this.CB_CenaRoztoceni.Name = "CB_CenaRoztoceni";
            this.CB_CenaRoztoceni.Size = new System.Drawing.Size(100, 21);
            this.CB_CenaRoztoceni.TabIndex = 4;
            // 
            // BTN_Vloz
            // 
            this.BTN_Vloz.Location = new System.Drawing.Point(270, 65);
            this.BTN_Vloz.Name = "BTN_Vloz";
            this.BTN_Vloz.Size = new System.Drawing.Size(75, 23);
            this.BTN_Vloz.TabIndex = 5;
            this.BTN_Vloz.Text = "Vložit kredit";
            this.BTN_Vloz.UseVisualStyleBackColor = true;
            this.BTN_Vloz.Click += new System.EventHandler(this.BTN_Vloz_Click);
            // 
            // BTN_Vybrat
            // 
            this.BTN_Vybrat.Location = new System.Drawing.Point(270, 94);
            this.BTN_Vybrat.Name = "BTN_Vybrat";
            this.BTN_Vybrat.Size = new System.Drawing.Size(75, 23);
            this.BTN_Vybrat.TabIndex = 6;
            this.BTN_Vybrat.Text = "Vybrat kredit";
            this.BTN_Vybrat.UseVisualStyleBackColor = true;
            this.BTN_Vybrat.Click += new System.EventHandler(this.BTN_Vybrat_Click);
            // 
            // PB_Valec1
            // 
            this.PB_Valec1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Valec1.Location = new System.Drawing.Point(12, 199);
            this.PB_Valec1.Name = "PB_Valec1";
            this.PB_Valec1.Size = new System.Drawing.Size(150, 150);
            this.PB_Valec1.TabIndex = 7;
            this.PB_Valec1.TabStop = false;
            // 
            // PB_Valec2
            // 
            this.PB_Valec2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Valec2.Location = new System.Drawing.Point(168, 199);
            this.PB_Valec2.Name = "PB_Valec2";
            this.PB_Valec2.Size = new System.Drawing.Size(150, 150);
            this.PB_Valec2.TabIndex = 8;
            this.PB_Valec2.TabStop = false;
            // 
            // PB_Valec3
            // 
            this.PB_Valec3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Valec3.Location = new System.Drawing.Point(324, 199);
            this.PB_Valec3.Name = "PB_Valec3";
            this.PB_Valec3.Size = new System.Drawing.Size(150, 150);
            this.PB_Valec3.TabIndex = 9;
            this.PB_Valec3.TabStop = false;
            // 
            // BTN_Roztoc
            // 
            this.BTN_Roztoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_Roztoc.Location = new System.Drawing.Point(12, 355);
            this.BTN_Roztoc.Name = "BTN_Roztoc";
            this.BTN_Roztoc.Size = new System.Drawing.Size(462, 59);
            this.BTN_Roztoc.TabIndex = 10;
            this.BTN_Roztoc.Text = "Roztočit válce";
            this.BTN_Roztoc.UseVisualStyleBackColor = true;
            this.BTN_Roztoc.Click += new System.EventHandler(this.BTN_Roztoc_Click);
            // 
            // NUM_hotovost
            // 
            this.NUM_hotovost.Location = new System.Drawing.Point(128, 68);
            this.NUM_hotovost.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NUM_hotovost.Name = "NUM_hotovost";
            this.NUM_hotovost.Size = new System.Drawing.Size(100, 20);
            this.NUM_hotovost.TabIndex = 11;
            // 
            // LBL_Vhodte
            // 
            this.LBL_Vhodte.AutoSize = true;
            this.LBL_Vhodte.Location = new System.Drawing.Point(15, 68);
            this.LBL_Vhodte.Name = "LBL_Vhodte";
            this.LBL_Vhodte.Size = new System.Drawing.Size(87, 13);
            this.LBL_Vhodte.TabIndex = 12;
            this.LBL_Vhodte.Text = "Vhoďte hotovost";
            // 
            // LBL_Kredit
            // 
            this.LBL_Kredit.AutoSize = true;
            this.LBL_Kredit.Location = new System.Drawing.Point(15, 99);
            this.LBL_Kredit.Name = "LBL_Kredit";
            this.LBL_Kredit.Size = new System.Drawing.Size(76, 13);
            this.LBL_Kredit.TabIndex = 13;
            this.LBL_Kredit.Text = "Aktuální kredit";
            // 
            // LBL_CenaRoztoceni
            // 
            this.LBL_CenaRoztoceni.AutoSize = true;
            this.LBL_CenaRoztoceni.Location = new System.Drawing.Point(15, 131);
            this.LBL_CenaRoztoceni.Name = "LBL_CenaRoztoceni";
            this.LBL_CenaRoztoceni.Size = new System.Drawing.Size(80, 13);
            this.LBL_CenaRoztoceni.TabIndex = 14;
            this.LBL_CenaRoztoceni.Text = "Cena roztočení";
            // 
            // LBL_CelkemVyhozeno
            // 
            this.LBL_CelkemVyhozeno.AutoSize = true;
            this.LBL_CelkemVyhozeno.Location = new System.Drawing.Point(15, 155);
            this.LBL_CelkemVyhozeno.Name = "LBL_CelkemVyhozeno";
            this.LBL_CelkemVyhozeno.Size = new System.Drawing.Size(91, 13);
            this.LBL_CelkemVyhozeno.TabIndex = 15;
            this.LBL_CelkemVyhozeno.Text = "Celkem vyhozeno";
            // 
            // AnimaceUpdate
            // 
            this.AnimaceUpdate.Tick += new System.EventHandler(this.AnimaceUpdate_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 424);
            this.Controls.Add(this.LBL_CelkemVyhozeno);
            this.Controls.Add(this.LBL_CenaRoztoceni);
            this.Controls.Add(this.LBL_Kredit);
            this.Controls.Add(this.LBL_Vhodte);
            this.Controls.Add(this.NUM_hotovost);
            this.Controls.Add(this.BTN_Roztoc);
            this.Controls.Add(this.PB_Valec3);
            this.Controls.Add(this.PB_Valec2);
            this.Controls.Add(this.PB_Valec1);
            this.Controls.Add(this.BTN_Vybrat);
            this.Controls.Add(this.BTN_Vloz);
            this.Controls.Add(this.CB_CenaRoztoceni);
            this.Controls.Add(this.TXB_CelkemVyhozeno);
            this.Controls.Add(this.TXB_AktualniKredit);
            this.Controls.Add(this.LBL_Nadpis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bedna";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Valec1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Valec2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Valec3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_hotovost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Nadpis;
        private System.Windows.Forms.TextBox TXB_AktualniKredit;
        private System.Windows.Forms.TextBox TXB_CelkemVyhozeno;
        private System.Windows.Forms.ComboBox CB_CenaRoztoceni;
        private System.Windows.Forms.Button BTN_Vloz;
        private System.Windows.Forms.Button BTN_Vybrat;
        private System.Windows.Forms.PictureBox PB_Valec1;
        private System.Windows.Forms.PictureBox PB_Valec2;
        private System.Windows.Forms.PictureBox PB_Valec3;
        private System.Windows.Forms.Button BTN_Roztoc;
        private System.Windows.Forms.NumericUpDown NUM_hotovost;
        private System.Windows.Forms.Label LBL_Vhodte;
        private System.Windows.Forms.Label LBL_Kredit;
        private System.Windows.Forms.Label LBL_CenaRoztoceni;
        private System.Windows.Forms.Label LBL_CelkemVyhozeno;
        private System.Windows.Forms.Timer AnimaceUpdate;
    }
}

