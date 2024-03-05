namespace JakDěláZvířátko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PB_Obrazky = new System.Windows.Forms.PictureBox();
            this.LBL_Nadpis = new System.Windows.Forms.Label();
            this.BTN_NovaHra = new System.Windows.Forms.Button();
            this.BTN_Buu = new System.Windows.Forms.Button();
            this.BTN_Haf = new System.Windows.Forms.Button();
            this.BTN_Chro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Obrazky)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Obrazky
            // 
            this.PB_Obrazky.BackColor = System.Drawing.Color.White;
            this.PB_Obrazky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PB_Obrazky.Location = new System.Drawing.Point(12, 108);
            this.PB_Obrazky.Name = "PB_Obrazky";
            this.PB_Obrazky.Size = new System.Drawing.Size(307, 174);
            this.PB_Obrazky.TabIndex = 0;
            this.PB_Obrazky.TabStop = false;
            // 
            // LBL_Nadpis
            // 
            this.LBL_Nadpis.AutoSize = true;
            this.LBL_Nadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Nadpis.Location = new System.Drawing.Point(12, 9);
            this.LBL_Nadpis.Name = "LBL_Nadpis";
            this.LBL_Nadpis.Size = new System.Drawing.Size(307, 39);
            this.LBL_Nadpis.TabIndex = 1;
            this.LBL_Nadpis.Text = "Jak dělá zvířátko?";
            this.LBL_Nadpis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_NovaHra
            // 
            this.BTN_NovaHra.Location = new System.Drawing.Point(12, 59);
            this.BTN_NovaHra.Name = "BTN_NovaHra";
            this.BTN_NovaHra.Size = new System.Drawing.Size(307, 37);
            this.BTN_NovaHra.TabIndex = 2;
            this.BTN_NovaHra.Text = "Nová Hra";
            this.BTN_NovaHra.UseVisualStyleBackColor = true;
            this.BTN_NovaHra.Click += new System.EventHandler(this.BTN_NovaHra_Click);
            // 
            // BTN_Buu
            // 
            this.BTN_Buu.AccessibleName = "";
            this.BTN_Buu.Location = new System.Drawing.Point(12, 297);
            this.BTN_Buu.Name = "BTN_Buu";
            this.BTN_Buu.Size = new System.Drawing.Size(307, 29);
            this.BTN_Buu.TabIndex = 3;
            this.BTN_Buu.Tag = "0";
            this.BTN_Buu.Text = "Bůůůů";
            this.BTN_Buu.UseVisualStyleBackColor = true;
            this.BTN_Buu.Visible = false;
            this.BTN_Buu.Click += new System.EventHandler(this.BTN_Click);
            // 
            // BTN_Haf
            // 
            this.BTN_Haf.AccessibleName = "";
            this.BTN_Haf.Location = new System.Drawing.Point(12, 332);
            this.BTN_Haf.Name = "BTN_Haf";
            this.BTN_Haf.Size = new System.Drawing.Size(307, 29);
            this.BTN_Haf.TabIndex = 4;
            this.BTN_Haf.Tag = "1";
            this.BTN_Haf.Text = "Haf, Haf, Haf";
            this.BTN_Haf.UseVisualStyleBackColor = true;
            this.BTN_Haf.Visible = false;
            this.BTN_Haf.Click += new System.EventHandler(this.BTN_Click);
            // 
            // BTN_Chro
            // 
            this.BTN_Chro.AccessibleName = "";
            this.BTN_Chro.Location = new System.Drawing.Point(12, 367);
            this.BTN_Chro.Name = "BTN_Chro";
            this.BTN_Chro.Size = new System.Drawing.Size(307, 29);
            this.BTN_Chro.TabIndex = 5;
            this.BTN_Chro.Tag = "2";
            this.BTN_Chro.Text = "Chro, Chro";
            this.BTN_Chro.UseVisualStyleBackColor = true;
            this.BTN_Chro.Visible = false;
            this.BTN_Chro.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 413);
            this.Controls.Add(this.BTN_Chro);
            this.Controls.Add(this.BTN_Haf);
            this.Controls.Add(this.BTN_Buu);
            this.Controls.Add(this.BTN_NovaHra);
            this.Controls.Add(this.LBL_Nadpis);
            this.Controls.Add(this.PB_Obrazky);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Jak dělá zvířátko?";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Obrazky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Obrazky;
        private System.Windows.Forms.Label LBL_Nadpis;
        private System.Windows.Forms.Button BTN_NovaHra;
        private System.Windows.Forms.Button BTN_Buu;
        private System.Windows.Forms.Button BTN_Haf;
        private System.Windows.Forms.Button BTN_Chro;
    }
}

