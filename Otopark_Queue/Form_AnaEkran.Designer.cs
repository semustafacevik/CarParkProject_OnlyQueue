namespace Otopark_Queue
{
    partial class frmAnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtArabaSayisi = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.lstArabalar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otoparktaki Araba Sayısı";
            // 
            // txtArabaSayisi
            // 
            this.txtArabaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArabaSayisi.Location = new System.Drawing.Point(46, 43);
            this.txtArabaSayisi.Multiline = true;
            this.txtArabaSayisi.Name = "txtArabaSayisi";
            this.txtArabaSayisi.Size = new System.Drawing.Size(59, 31);
            this.txtArabaSayisi.TabIndex = 1;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(119, 40);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(88, 38);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // lstArabalar
            // 
            this.lstArabalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstArabalar.FormattingEnabled = true;
            this.lstArabalar.ItemHeight = 16;
            this.lstArabalar.Location = new System.Drawing.Point(21, 91);
            this.lstArabalar.Name = "lstArabalar";
            this.lstArabalar.Size = new System.Drawing.Size(212, 228);
            this.lstArabalar.TabIndex = 3;
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 345);
            this.Controls.Add(this.lstArabalar);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtArabaSayisi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAnaEkran";
            this.Text = "ANA EKRAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArabaSayisi;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.ListBox lstArabalar;
    }
}

