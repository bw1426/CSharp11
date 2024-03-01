using System.Windows.Forms;

namespace listyRozwijalne
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
            this.opis = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.zwierzeta = new System.Windows.Forms.ComboBox();
            this.obrazki = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.obrazki)).BeginInit();
            this.SuspendLayout();
            // 
            // opis
            // 
            this.opis.BackColor = System.Drawing.Color.Yellow;
            this.opis.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opis.ForeColor = System.Drawing.Color.MediumBlue;
            this.opis.Location = new System.Drawing.Point(47, 89);
            this.opis.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.opis.Name = "opis";
            this.opis.Size = new System.Drawing.Size(361, 100);
            this.opis.TabIndex = 1;
            this.opis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox1.Location = new System.Drawing.Point(19, 35);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(491, 45);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Wybierz  dzień tygodnia";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // zwierzeta
            // 
            this.zwierzeta.FormattingEnabled = true;
            this.zwierzeta.Items.AddRange(new object[] {
            "pies",
            "kot",
            "koń"});
            this.zwierzeta.Location = new System.Drawing.Point(54, 289);
            this.zwierzeta.Name = "zwierzeta";
            this.zwierzeta.Size = new System.Drawing.Size(387, 45);
            this.zwierzeta.TabIndex = 5;
            this.zwierzeta.Text = "Zwierzęta";
            this.zwierzeta.SelectedIndexChanged += new System.EventHandler(this.zwierzeta_SelectedIndexChanged);
            // 
            // obrazki
            // 
            this.obrazki.Location = new System.Drawing.Point(64, 360);
            this.obrazki.Name = "obrazki";
            this.obrazki.Size = new System.Drawing.Size(800, 600);
            this.obrazki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obrazki.TabIndex = 6;
            this.obrazki.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.obrazki);
            this.Controls.Add(this.zwierzeta);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.opis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.obrazki)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label opis;
        private ComboBox comboBox1;
        private ComboBox zwierzeta;
        private PictureBox obrazki;
    }
}

