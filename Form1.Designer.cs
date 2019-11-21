namespace Sebastian_MortaLab1
{
    partial class FormName
    {
        int number=0;
        int number2 = 0;
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Name = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.timerCount = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerCount2 = new System.Windows.Forms.Timer(this.components);
            this.NewWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 70.25F);
            this.Name.ForeColor = System.Drawing.Color.Coral;
            this.Name.Location = new System.Drawing.Point(12, 9);
            this.Name.MinimumSize = new System.Drawing.Size(100, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(513, 107);
            this.Name.TabIndex = 0;
            this.Name.Text = "FormName";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonColor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonColor.Location = new System.Drawing.Point(30, 136);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPlus.Location = new System.Drawing.Point(195, 119);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 2;
            this.buttonPlus.Text = "Dodaj";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(183, 148);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 3;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBoxCount_TextChanged);
            // 
            // timerCount
            // 
            this.timerCount.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(30, 357);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(388, 357);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timerCount2
            // 
            this.timerCount2.Interval = 10;
            this.timerCount2.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // NewWindow
            // 
            this.NewWindow.Location = new System.Drawing.Point(387, 135);
            this.NewWindow.Name = "NewWindow";
            this.NewWindow.Size = new System.Drawing.Size(75, 23);
            this.NewWindow.TabIndex = 6;
            this.NewWindow.Text = "Nowe okno";
            this.NewWindow.UseVisualStyleBackColor = true;
            this.NewWindow.Click += new System.EventHandler(this.NewWindow_Click);
            // 
            // FormName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewWindow);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.Name);
            this.Name.Text = "FormName";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Timer timerCount;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timerCount2;
        private System.Windows.Forms.Button NewWindow;
    }
}

