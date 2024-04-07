namespace Park
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
            this.PB_Park = new System.Windows.Forms.PictureBox();
            this.GB_Brana = new System.Windows.Forms.GroupBox();
            this.CB_Otevreno = new System.Windows.Forms.CheckBox();
            this.GB_Balonky = new System.Windows.Forms.GroupBox();
            this.BTN_Vypustit = new System.Windows.Forms.Button();
            this.CB_Umisteni = new System.Windows.Forms.CheckBox();
            this.GB_Slunicka = new System.Windows.Forms.GroupBox();
            this.RB_Vecer = new System.Windows.Forms.RadioButton();
            this.BTN_Putovani = new System.Windows.Forms.Button();
            this.RB_Odpoledne = new System.Windows.Forms.RadioButton();
            this.RB_Rano = new System.Windows.Forms.RadioButton();
            this.BalonekAnim = new System.Windows.Forms.Timer(this.components);
            this.PutovaniAnim = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Park)).BeginInit();
            this.GB_Brana.SuspendLayout();
            this.GB_Balonky.SuspendLayout();
            this.GB_Slunicka.SuspendLayout();
            this.SuspendLayout();
            // 
            // PB_Park
            // 
            this.PB_Park.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PB_Park.Location = new System.Drawing.Point(12, 12);
            this.PB_Park.Name = "PB_Park";
            this.PB_Park.Size = new System.Drawing.Size(640, 480);
            this.PB_Park.TabIndex = 0;
            this.PB_Park.TabStop = false;
            this.PB_Park.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // GB_Brana
            // 
            this.GB_Brana.Controls.Add(this.CB_Otevreno);
            this.GB_Brana.Location = new System.Drawing.Point(13, 498);
            this.GB_Brana.Name = "GB_Brana";
            this.GB_Brana.Size = new System.Drawing.Size(86, 48);
            this.GB_Brana.TabIndex = 1;
            this.GB_Brana.TabStop = false;
            this.GB_Brana.Text = "Brána";
            // 
            // CB_Otevreno
            // 
            this.CB_Otevreno.AutoSize = true;
            this.CB_Otevreno.Location = new System.Drawing.Point(7, 20);
            this.CB_Otevreno.Name = "CB_Otevreno";
            this.CB_Otevreno.Size = new System.Drawing.Size(71, 17);
            this.CB_Otevreno.TabIndex = 0;
            this.CB_Otevreno.Text = "Otevřená";
            this.CB_Otevreno.UseVisualStyleBackColor = true;
            this.CB_Otevreno.CheckedChanged += new System.EventHandler(this.CB_Otevreno_CheckedChanged);
            // 
            // GB_Balonky
            // 
            this.GB_Balonky.Controls.Add(this.BTN_Vypustit);
            this.GB_Balonky.Controls.Add(this.CB_Umisteni);
            this.GB_Balonky.Location = new System.Drawing.Point(105, 498);
            this.GB_Balonky.Name = "GB_Balonky";
            this.GB_Balonky.Size = new System.Drawing.Size(170, 48);
            this.GB_Balonky.TabIndex = 2;
            this.GB_Balonky.TabStop = false;
            this.GB_Balonky.Text = "Balónky";
            // 
            // BTN_Vypustit
            // 
            this.BTN_Vypustit.Location = new System.Drawing.Point(72, 16);
            this.BTN_Vypustit.Name = "BTN_Vypustit";
            this.BTN_Vypustit.Size = new System.Drawing.Size(86, 23);
            this.BTN_Vypustit.TabIndex = 1;
            this.BTN_Vypustit.Text = "Vypustit";
            this.BTN_Vypustit.UseVisualStyleBackColor = true;
            this.BTN_Vypustit.Click += new System.EventHandler(this.BTN_Vypustit_Click);
            // 
            // CB_Umisteni
            // 
            this.CB_Umisteni.AutoSize = true;
            this.CB_Umisteni.Location = new System.Drawing.Point(7, 20);
            this.CB_Umisteni.Name = "CB_Umisteni";
            this.CB_Umisteni.Size = new System.Drawing.Size(59, 17);
            this.CB_Umisteni.TabIndex = 0;
            this.CB_Umisteni.Text = "Umístit";
            this.CB_Umisteni.UseVisualStyleBackColor = true;
            this.CB_Umisteni.CheckedChanged += new System.EventHandler(this.CB_Umisteni_CheckedChanged);
            // 
            // GB_Slunicka
            // 
            this.GB_Slunicka.Controls.Add(this.RB_Vecer);
            this.GB_Slunicka.Controls.Add(this.BTN_Putovani);
            this.GB_Slunicka.Controls.Add(this.RB_Odpoledne);
            this.GB_Slunicka.Controls.Add(this.RB_Rano);
            this.GB_Slunicka.Location = new System.Drawing.Point(281, 498);
            this.GB_Slunicka.Name = "GB_Slunicka";
            this.GB_Slunicka.Size = new System.Drawing.Size(371, 48);
            this.GB_Slunicka.TabIndex = 2;
            this.GB_Slunicka.TabStop = false;
            this.GB_Slunicka.Text = "Sluníčka";
            // 
            // RB_Vecer
            // 
            this.RB_Vecer.AutoSize = true;
            this.RB_Vecer.Location = new System.Drawing.Point(143, 19);
            this.RB_Vecer.Name = "RB_Vecer";
            this.RB_Vecer.Size = new System.Drawing.Size(53, 17);
            this.RB_Vecer.TabIndex = 3;
            this.RB_Vecer.Tag = "80";
            this.RB_Vecer.Text = "Večer";
            this.RB_Vecer.UseVisualStyleBackColor = true;
            this.RB_Vecer.CheckedChanged += new System.EventHandler(this.RB_ChangeEvent);
            // 
            // BTN_Putovani
            // 
            this.BTN_Putovani.Location = new System.Drawing.Point(202, 16);
            this.BTN_Putovani.Name = "BTN_Putovani";
            this.BTN_Putovani.Size = new System.Drawing.Size(163, 23);
            this.BTN_Putovani.TabIndex = 2;
            this.BTN_Putovani.Text = "Putování sluníčka";
            this.BTN_Putovani.UseVisualStyleBackColor = true;
            this.BTN_Putovani.Click += new System.EventHandler(this.BTN_Putovani_Click);
            // 
            // RB_Odpoledne
            // 
            this.RB_Odpoledne.AutoSize = true;
            this.RB_Odpoledne.Checked = true;
            this.RB_Odpoledne.Location = new System.Drawing.Point(64, 19);
            this.RB_Odpoledne.Name = "RB_Odpoledne";
            this.RB_Odpoledne.Size = new System.Drawing.Size(64, 17);
            this.RB_Odpoledne.TabIndex = 1;
            this.RB_Odpoledne.TabStop = true;
            this.RB_Odpoledne.Tag = "0";
            this.RB_Odpoledne.Text = "Poledne";
            this.RB_Odpoledne.UseVisualStyleBackColor = true;
            this.RB_Odpoledne.CheckedChanged += new System.EventHandler(this.RB_ChangeEvent);
            // 
            // RB_Rano
            // 
            this.RB_Rano.AutoSize = true;
            this.RB_Rano.Location = new System.Drawing.Point(7, 20);
            this.RB_Rano.Name = "RB_Rano";
            this.RB_Rano.Size = new System.Drawing.Size(51, 17);
            this.RB_Rano.TabIndex = 0;
            this.RB_Rano.Tag = "290";
            this.RB_Rano.Text = "Ráno";
            this.RB_Rano.UseVisualStyleBackColor = true;
            this.RB_Rano.CheckedChanged += new System.EventHandler(this.RB_ChangeEvent);
            // 
            // BalonekAnim
            // 
            this.BalonekAnim.Tick += new System.EventHandler(this.BalonekAnim_Tick);
            // 
            // PutovaniAnim
            // 
            this.PutovaniAnim.Tick += new System.EventHandler(this.PutovaniAnim_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 553);
            this.Controls.Add(this.GB_Slunicka);
            this.Controls.Add(this.GB_Balonky);
            this.Controls.Add(this.GB_Brana);
            this.Controls.Add(this.PB_Park);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Park)).EndInit();
            this.GB_Brana.ResumeLayout(false);
            this.GB_Brana.PerformLayout();
            this.GB_Balonky.ResumeLayout(false);
            this.GB_Balonky.PerformLayout();
            this.GB_Slunicka.ResumeLayout(false);
            this.GB_Slunicka.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Park;
        private System.Windows.Forms.GroupBox GB_Brana;
        private System.Windows.Forms.CheckBox CB_Otevreno;
        private System.Windows.Forms.GroupBox GB_Balonky;
        private System.Windows.Forms.GroupBox GB_Slunicka;
        private System.Windows.Forms.CheckBox CB_Umisteni;
        private System.Windows.Forms.Button BTN_Vypustit;
        private System.Windows.Forms.Button BTN_Putovani;
        private System.Windows.Forms.RadioButton RB_Odpoledne;
        private System.Windows.Forms.RadioButton RB_Rano;
        private System.Windows.Forms.RadioButton RB_Vecer;
        private System.Windows.Forms.Timer BalonekAnim;
        private System.Windows.Forms.Timer PutovaniAnim;
    }
}

