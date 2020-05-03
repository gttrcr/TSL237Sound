namespace A5000
{
    partial class LTS237Sound
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox_time = new System.Windows.Forms.ComboBox();
            this.richTextBox_sheet = new System.Windows.Forms.RichTextBox();
            this.button_play = new System.Windows.Forms.Button();
            this.textBox_bpm = new System.Windows.Forms.TextBox();
            this.button_test = new System.Windows.Forms.Button();
            this.timer_bpm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboBox_time
            // 
            this.comboBox_time.FormattingEnabled = true;
            this.comboBox_time.Items.AddRange(new object[] {
            "4/4",
            "3/4"});
            this.comboBox_time.Location = new System.Drawing.Point(185, 15);
            this.comboBox_time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_time.Name = "comboBox_time";
            this.comboBox_time.Size = new System.Drawing.Size(160, 24);
            this.comboBox_time.TabIndex = 0;
            // 
            // richTextBox_sheet
            // 
            this.richTextBox_sheet.Location = new System.Drawing.Point(16, 15);
            this.richTextBox_sheet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_sheet.Name = "richTextBox_sheet";
            this.richTextBox_sheet.Size = new System.Drawing.Size(160, 607);
            this.richTextBox_sheet.TabIndex = 1;
            this.richTextBox_sheet.Text = "";
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(355, 15);
            this.button_play.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(100, 28);
            this.button_play.TabIndex = 2;
            this.button_play.Text = "PLAY";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // textBox_bpm
            // 
            this.textBox_bpm.Location = new System.Drawing.Point(185, 48);
            this.textBox_bpm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_bpm.Name = "textBox_bpm";
            this.textBox_bpm.Size = new System.Drawing.Size(160, 22);
            this.textBox_bpm.TabIndex = 3;
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(355, 50);
            this.button_test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(100, 28);
            this.button_test.TabIndex = 5;
            this.button_test.Text = "TEST";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // timer_bpm
            // 
            this.timer_bpm.Interval = 1000;
            this.timer_bpm.Tick += new System.EventHandler(this.bpm_Tick);
            // 
            // LTS237Sound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1369, 782);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.textBox_bpm);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.richTextBox_sheet);
            this.Controls.Add(this.comboBox_time);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LTS237Sound";
            this.Text = "LTS237Sound";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_time;
        private System.Windows.Forms.RichTextBox richTextBox_sheet;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.TextBox textBox_bpm;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Timer timer_bpm;
    }
}

