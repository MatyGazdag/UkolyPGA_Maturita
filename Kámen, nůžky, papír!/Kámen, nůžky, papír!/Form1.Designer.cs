namespace Kámen__nůžky__papír_
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
            this.LBL_Nadpis = new System.Windows.Forms.Label();
            this.LBL_Hrac1 = new System.Windows.Forms.Label();
            this.LBL_Hrac2 = new System.Windows.Forms.Label();
            this.PB_Hrac1 = new System.Windows.Forms.PictureBox();
            this.PB_Hrac2 = new System.Windows.Forms.PictureBox();
            this.TXB_Hrac1 = new System.Windows.Forms.TextBox();
            this.TXB_Hrac2 = new System.Windows.Forms.TextBox();
            this.BTN_Hra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Hrac1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Hrac2)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Nadpis
            // 
            this.LBL_Nadpis.AutoSize = true;
            this.LBL_Nadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Nadpis.Location = new System.Drawing.Point(6, 9);
            this.LBL_Nadpis.Name = "LBL_Nadpis";
            this.LBL_Nadpis.Size = new System.Drawing.Size(106, 31);
            this.LBL_Nadpis.TabIndex = 0;
            this.LBL_Nadpis.Text = "Střižba";
            // 
            // LBL_Hrac1
            // 
            this.LBL_Hrac1.AutoSize = true;
            this.LBL_Hrac1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Hrac1.Location = new System.Drawing.Point(9, 54);
            this.LBL_Hrac1.Name = "LBL_Hrac1";
            this.LBL_Hrac1.Size = new System.Drawing.Size(45, 13);
            this.LBL_Hrac1.TabIndex = 1;
            this.LBL_Hrac1.Text = "Hráč 1";
            // 
            // LBL_Hrac2
            // 
            this.LBL_Hrac2.AutoSize = true;
            this.LBL_Hrac2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Hrac2.Location = new System.Drawing.Point(261, 54);
            this.LBL_Hrac2.Name = "LBL_Hrac2";
            this.LBL_Hrac2.Size = new System.Drawing.Size(45, 13);
            this.LBL_Hrac2.TabIndex = 2;
            this.LBL_Hrac2.Text = "Hráč 2";
            this.LBL_Hrac2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PB_Hrac1
            // 
            this.PB_Hrac1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Hrac1.Location = new System.Drawing.Point(11, 80);
            this.PB_Hrac1.Name = "PB_Hrac1";
            this.PB_Hrac1.Size = new System.Drawing.Size(160, 160);
            this.PB_Hrac1.TabIndex = 3;
            this.PB_Hrac1.TabStop = false;
            // 
            // PB_Hrac2
            // 
            this.PB_Hrac2.BackgroundImage = global::Kámen__nůžky__papír_.Properties.Resources.kamen;
            this.PB_Hrac2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_Hrac2.Location = new System.Drawing.Point(264, 80);
            this.PB_Hrac2.Name = "PB_Hrac2";
            this.PB_Hrac2.Size = new System.Drawing.Size(160, 160);
            this.PB_Hrac2.TabIndex = 4;
            this.PB_Hrac2.TabStop = false;
            // 
            // TXB_Hrac1
            // 
            this.TXB_Hrac1.Location = new System.Drawing.Point(11, 246);
            this.TXB_Hrac1.Name = "TXB_Hrac1";
            this.TXB_Hrac1.ReadOnly = true;
            this.TXB_Hrac1.Size = new System.Drawing.Size(163, 20);
            this.TXB_Hrac1.TabIndex = 5;
            // 
            // TXB_Hrac2
            // 
            this.TXB_Hrac2.Location = new System.Drawing.Point(264, 246);
            this.TXB_Hrac2.Name = "TXB_Hrac2";
            this.TXB_Hrac2.ReadOnly = true;
            this.TXB_Hrac2.Size = new System.Drawing.Size(160, 20);
            this.TXB_Hrac2.TabIndex = 6;
            // 
            // BTN_Hra
            // 
            this.BTN_Hra.Location = new System.Drawing.Point(125, 272);
            this.BTN_Hra.Name = "BTN_Hra";
            this.BTN_Hra.Size = new System.Drawing.Size(181, 23);
            this.BTN_Hra.TabIndex = 7;
            this.BTN_Hra.Text = "Hra";
            this.BTN_Hra.UseVisualStyleBackColor = true;
            this.BTN_Hra.Click += new System.EventHandler(this.BTN_Hra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 306);
            this.Controls.Add(this.BTN_Hra);
            this.Controls.Add(this.TXB_Hrac2);
            this.Controls.Add(this.TXB_Hrac1);
            this.Controls.Add(this.PB_Hrac2);
            this.Controls.Add(this.PB_Hrac1);
            this.Controls.Add(this.LBL_Hrac2);
            this.Controls.Add(this.LBL_Hrac1);
            this.Controls.Add(this.LBL_Nadpis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(Properties.Resources.ikona2));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Střižba";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Hrac1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Hrac2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Nadpis;
        private System.Windows.Forms.Label LBL_Hrac1;
        private System.Windows.Forms.Label LBL_Hrac2;
        private System.Windows.Forms.PictureBox PB_Hrac1;
        private System.Windows.Forms.PictureBox PB_Hrac2;
        private System.Windows.Forms.TextBox TXB_Hrac1;
        private System.Windows.Forms.TextBox TXB_Hrac2;
        private System.Windows.Forms.Button BTN_Hra;
    }
}

