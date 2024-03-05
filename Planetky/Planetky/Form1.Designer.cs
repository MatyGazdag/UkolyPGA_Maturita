namespace Planetky
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
            this.BTN_Start = new System.Windows.Forms.Button();
            this.P_SolarniSystem = new System.Windows.Forms.Panel();
            this.AnimaceSolSystem = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(12, 393);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(350, 45);
            this.BTN_Start.TabIndex = 0;
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // P_SolarniSystem
            // 
            this.P_SolarniSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_SolarniSystem.Location = new System.Drawing.Point(12, 12);
            this.P_SolarniSystem.Name = "P_SolarniSystem";
            this.P_SolarniSystem.Size = new System.Drawing.Size(350, 366);
            this.P_SolarniSystem.TabIndex = 1;
            this.P_SolarniSystem.Paint += new System.Windows.Forms.PaintEventHandler(this.P_SolarniSystem_Paint);
            // 
            // AnimaceSolSystem
            // 
            this.AnimaceSolSystem.Tick += new System.EventHandler(this.AnimaceSolSystem_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.P_SolarniSystem);
            this.Controls.Add(this.BTN_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Planetky";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Panel P_SolarniSystem;
        private System.Windows.Forms.Timer AnimaceSolSystem;
    }
}

