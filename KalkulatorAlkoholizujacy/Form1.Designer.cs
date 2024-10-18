namespace KalkulatorAlkoholizujacy
{
    partial class Form1
    {
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
            this.comboBoxDish = new System.Windows.Forms.ComboBox();
            this.comboBoxDrink = new System.Windows.Forms.ComboBox();
            this.textBoxPieces = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDish
            // 
            this.comboBoxDish.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxDish.FormattingEnabled = true;
            this.comboBoxDish.Location = new System.Drawing.Point(0, 39);
            this.comboBoxDish.Margin = new System.Windows.Forms.Padding(4, 12, 4, 4);
            this.comboBoxDish.Name = "comboBoxDish";
            this.comboBoxDish.Size = new System.Drawing.Size(347, 39);
            this.comboBoxDish.TabIndex = 0;
            // 
            // comboBoxDrink
            // 
            this.comboBoxDrink.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBoxDrink.FormattingEnabled = true;
            this.comboBoxDrink.Location = new System.Drawing.Point(0, 0);
            this.comboBoxDrink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDrink.Name = "comboBoxDrink";
            this.comboBoxDrink.Size = new System.Drawing.Size(347, 39);
            this.comboBoxDrink.TabIndex = 1;
            // 
            // textBoxPieces
            // 
            this.textBoxPieces.Location = new System.Drawing.Point(679, 223);
            this.textBoxPieces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPieces.Name = "textBoxPieces";
            this.textBoxPieces.Size = new System.Drawing.Size(132, 22);
            this.textBoxPieces.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxDish);
            this.panel1.Controls.Add(this.comboBoxDrink);
            this.panel1.Location = new System.Drawing.Point(143, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 169);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(829, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "labelResult";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 443);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "buttonResult";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPieces);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Kalkulator Alkoholizujący";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDish;
        private System.Windows.Forms.ComboBox comboBoxDrink;
        private System.Windows.Forms.TextBox textBoxPieces;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

