namespace Závody
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
            this.PPole = new System.Windows.Forms.Panel();
            this.LBL_Nadpis = new System.Windows.Forms.Label();
            this.BTN_Hraj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TXB_Hrac1 = new System.Windows.Forms.TextBox();
            this.TXB_Hrac2 = new System.Windows.Forms.TextBox();
            this.PB_Vyherce = new System.Windows.Forms.PictureBox();
            this.LBL_StavHry = new System.Windows.Forms.Label();
            this.BTN_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Vyherce)).BeginInit();
            this.SuspendLayout();
            // 
            // PPole
            // 
            this.PPole.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PPole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PPole.Location = new System.Drawing.Point(12, 70);
            this.PPole.Margin = new System.Windows.Forms.Padding(0);
            this.PPole.Name = "PPole";
            this.PPole.Size = new System.Drawing.Size(750, 80);
            this.PPole.TabIndex = 0;
            this.PPole.Paint += new System.Windows.Forms.PaintEventHandler(this.PPole_Paint);
            // 
            // LBL_Nadpis
            // 
            this.LBL_Nadpis.AutoSize = true;
            this.LBL_Nadpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_Nadpis.Location = new System.Drawing.Point(5, 9);
            this.LBL_Nadpis.Name = "LBL_Nadpis";
            this.LBL_Nadpis.Size = new System.Drawing.Size(135, 39);
            this.LBL_Nadpis.TabIndex = 2;
            this.LBL_Nadpis.Text = "Závody";
            // 
            // BTN_Hraj
            // 
            this.BTN_Hraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_Hraj.Location = new System.Drawing.Point(12, 167);
            this.BTN_Hraj.Name = "BTN_Hraj";
            this.BTN_Hraj.Size = new System.Drawing.Size(177, 93);
            this.BTN_Hraj.TabIndex = 3;
            this.BTN_Hraj.Text = "Hraj";
            this.BTN_Hraj.UseVisualStyleBackColor = true;
            this.BTN_Hraj.Click += new System.EventHandler(this.BTN_Hraj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Závody.Properties.Resources.player1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(215, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Závody.Properties.Resources.player2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(215, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // TXB_Hrac1
            // 
            this.TXB_Hrac1.Location = new System.Drawing.Point(265, 193);
            this.TXB_Hrac1.Name = "TXB_Hrac1";
            this.TXB_Hrac1.ReadOnly = true;
            this.TXB_Hrac1.Size = new System.Drawing.Size(100, 20);
            this.TXB_Hrac1.TabIndex = 6;
            // 
            // TXB_Hrac2
            // 
            this.TXB_Hrac2.Location = new System.Drawing.Point(265, 231);
            this.TXB_Hrac2.Name = "TXB_Hrac2";
            this.TXB_Hrac2.ReadOnly = true;
            this.TXB_Hrac2.Size = new System.Drawing.Size(100, 20);
            this.TXB_Hrac2.TabIndex = 7;
            // 
            // PB_Vyherce
            // 
            this.PB_Vyherce.Location = new System.Drawing.Point(620, 176);
            this.PB_Vyherce.Name = "PB_Vyherce";
            this.PB_Vyherce.Size = new System.Drawing.Size(80, 80);
            this.PB_Vyherce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Vyherce.TabIndex = 8;
            this.PB_Vyherce.TabStop = false;
            this.PB_Vyherce.Visible = false;
            // 
            // LBL_StavHry
            // 
            this.LBL_StavHry.AutoSize = true;
            this.LBL_StavHry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBL_StavHry.Location = new System.Drawing.Point(494, 199);
            this.LBL_StavHry.Name = "LBL_StavHry";
            this.LBL_StavHry.Size = new System.Drawing.Size(89, 31);
            this.LBL_StavHry.TabIndex = 9;
            this.LBL_StavHry.Text = "Vítěz:";
            this.LBL_StavHry.Visible = false;
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Enabled = false;
            this.BTN_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTN_Reset.Location = new System.Drawing.Point(12, 167);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(177, 93);
            this.BTN_Reset.TabIndex = 10;
            this.BTN_Reset.Text = "Hraj znovu";
            this.BTN_Reset.UseVisualStyleBackColor = true;
            this.BTN_Reset.Visible = false;
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 284);
            this.Controls.Add(this.BTN_Reset);
            this.Controls.Add(this.LBL_StavHry);
            this.Controls.Add(this.PB_Vyherce);
            this.Controls.Add(this.TXB_Hrac2);
            this.Controls.Add(this.TXB_Hrac1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Hraj);
            this.Controls.Add(this.LBL_Nadpis);
            this.Controls.Add(this.PPole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Závody";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Vyherce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PPole;
        private System.Windows.Forms.Label LBL_Nadpis;
        private System.Windows.Forms.Button BTN_Hraj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TXB_Hrac1;
        private System.Windows.Forms.TextBox TXB_Hrac2;
        private System.Windows.Forms.PictureBox PB_Vyherce;
        private System.Windows.Forms.Label LBL_StavHry;
        private System.Windows.Forms.Button BTN_Reset;
    }
}

