namespace Semafor
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
            this.PPanel = new System.Windows.Forms.Panel();
            this.BTN_Cervena = new System.Windows.Forms.Button();
            this.BTN_Oranzova = new System.Windows.Forms.Button();
            this.BTN_Zelena = new System.Windows.Forms.Button();
            this.BTN_Stop = new System.Windows.Forms.Button();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.Animace = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PPanel
            // 
            this.PPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PPanel.Location = new System.Drawing.Point(12, 12);
            this.PPanel.Name = "PPanel";
            this.PPanel.Size = new System.Drawing.Size(160, 400);
            this.PPanel.TabIndex = 0;
            this.PPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PPanel_Paint);
            // 
            // BTN_Cervena
            // 
            this.BTN_Cervena.Location = new System.Drawing.Point(196, 12);
            this.BTN_Cervena.Name = "BTN_Cervena";
            this.BTN_Cervena.Size = new System.Drawing.Size(126, 50);
            this.BTN_Cervena.TabIndex = 1;
            this.BTN_Cervena.Tag = "0";
            this.BTN_Cervena.Text = "Červená";
            this.BTN_Cervena.UseVisualStyleBackColor = true;
            this.BTN_Cervena.Click += new System.EventHandler(this.BTN_Click);
            // 
            // BTN_Oranzova
            // 
            this.BTN_Oranzova.Location = new System.Drawing.Point(196, 68);
            this.BTN_Oranzova.Name = "BTN_Oranzova";
            this.BTN_Oranzova.Size = new System.Drawing.Size(126, 50);
            this.BTN_Oranzova.TabIndex = 2;
            this.BTN_Oranzova.Tag = "1";
            this.BTN_Oranzova.Text = "Oranžová";
            this.BTN_Oranzova.UseVisualStyleBackColor = true;
            this.BTN_Oranzova.Click += new System.EventHandler(this.BTN_Click);
            // 
            // BTN_Zelena
            // 
            this.BTN_Zelena.Location = new System.Drawing.Point(196, 124);
            this.BTN_Zelena.Name = "BTN_Zelena";
            this.BTN_Zelena.Size = new System.Drawing.Size(126, 50);
            this.BTN_Zelena.TabIndex = 3;
            this.BTN_Zelena.Tag = "2";
            this.BTN_Zelena.Text = "Zelená";
            this.BTN_Zelena.UseVisualStyleBackColor = true;
            this.BTN_Zelena.Click += new System.EventHandler(this.BTN_Click);
            // 
            // BTN_Stop
            // 
            this.BTN_Stop.Location = new System.Drawing.Point(196, 362);
            this.BTN_Stop.Name = "BTN_Stop";
            this.BTN_Stop.Size = new System.Drawing.Size(126, 50);
            this.BTN_Stop.TabIndex = 4;
            this.BTN_Stop.Tag = "Stop";
            this.BTN_Stop.Text = "Stop";
            this.BTN_Stop.UseVisualStyleBackColor = true;
            this.BTN_Stop.Click += new System.EventHandler(this.BTN_AnimaceSwitch_Click);
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(196, 306);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(126, 50);
            this.BTN_Start.TabIndex = 5;
            this.BTN_Start.Tag = "Start";
            this.BTN_Start.Text = "Start";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_AnimaceSwitch_Click);
            // 
            // Animace
            // 
            this.Animace.Tick += new System.EventHandler(this.Animace_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 430);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.BTN_Stop);
            this.Controls.Add(this.BTN_Zelena);
            this.Controls.Add(this.BTN_Oranzova);
            this.Controls.Add(this.BTN_Cervena);
            this.Controls.Add(this.PPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Semafor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PPanel;
        private System.Windows.Forms.Button BTN_Cervena;
        private System.Windows.Forms.Button BTN_Oranzova;
        private System.Windows.Forms.Button BTN_Zelena;
        private System.Windows.Forms.Button BTN_Stop;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Timer Animace;
    }
}

