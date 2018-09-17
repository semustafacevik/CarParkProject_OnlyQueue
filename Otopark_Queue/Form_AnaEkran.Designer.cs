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
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstArabalar = new System.Windows.Forms.ListBox();
            this.btnCikar = new System.Windows.Forms.Button();
            this.lstKuyruk = new System.Windows.Forms.ListBox();
            this.lstKuyruk_Oncelikli = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCikar_Oncelikli = new System.Windows.Forms.Button();
            this.lstOrtIslemSuresi = new System.Windows.Forms.ListBox();
            this.lstOrtIslemSuresi_Oncelikli = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Otoparka Eklenecek Araba Sayısı";
            // 
            // txtArabaSayisi
            // 
            this.txtArabaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArabaSayisi.Location = new System.Drawing.Point(299, 32);
            this.txtArabaSayisi.Multiline = true;
            this.txtArabaSayisi.Name = "txtArabaSayisi";
            this.txtArabaSayisi.Size = new System.Drawing.Size(59, 31);
            this.txtArabaSayisi.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(372, 29);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 38);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstArabalar
            // 
            this.lstArabalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstArabalar.FormattingEnabled = true;
            this.lstArabalar.ItemHeight = 16;
            this.lstArabalar.Location = new System.Drawing.Point(20, 96);
            this.lstArabalar.Name = "lstArabalar";
            this.lstArabalar.Size = new System.Drawing.Size(212, 196);
            this.lstArabalar.TabIndex = 3;
            // 
            // btnCikar
            // 
            this.btnCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar.Location = new System.Drawing.Point(372, 29);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(88, 38);
            this.btnCikar.TabIndex = 2;
            this.btnCikar.Text = "ÇIKAR";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // lstKuyruk
            // 
            this.lstKuyruk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstKuyruk.FormattingEnabled = true;
            this.lstKuyruk.ItemHeight = 16;
            this.lstKuyruk.Location = new System.Drawing.Point(265, 96);
            this.lstKuyruk.Name = "lstKuyruk";
            this.lstKuyruk.Size = new System.Drawing.Size(212, 196);
            this.lstKuyruk.TabIndex = 3;
            // 
            // lstKuyruk_Oncelikli
            // 
            this.lstKuyruk_Oncelikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstKuyruk_Oncelikli.FormattingEnabled = true;
            this.lstKuyruk_Oncelikli.ItemHeight = 16;
            this.lstKuyruk_Oncelikli.Location = new System.Drawing.Point(514, 96);
            this.lstKuyruk_Oncelikli.Name = "lstKuyruk_Oncelikli";
            this.lstKuyruk_Oncelikli.Size = new System.Drawing.Size(212, 196);
            this.lstKuyruk_Oncelikli.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Otoparktaki Arabalar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(283, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Otoparktan Çıkan Arabalar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(493, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Otoparktan Öncelikli Çıkan Arabalar";
            // 
            // btnCikar_Oncelikli
            // 
            this.btnCikar_Oncelikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar_Oncelikli.Location = new System.Drawing.Point(371, 26);
            this.btnCikar_Oncelikli.Name = "btnCikar_Oncelikli";
            this.btnCikar_Oncelikli.Size = new System.Drawing.Size(88, 45);
            this.btnCikar_Oncelikli.TabIndex = 2;
            this.btnCikar_Oncelikli.Text = "ÖNCELİKLİ ÇIKAR";
            this.btnCikar_Oncelikli.UseVisualStyleBackColor = true;
            this.btnCikar_Oncelikli.Click += new System.EventHandler(this.btnCikar_Oncelikli_Click);
            // 
            // lstOrtIslemSuresi
            // 
            this.lstOrtIslemSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstOrtIslemSuresi.FormattingEnabled = true;
            this.lstOrtIslemSuresi.ItemHeight = 16;
            this.lstOrtIslemSuresi.Location = new System.Drawing.Point(265, 341);
            this.lstOrtIslemSuresi.Name = "lstOrtIslemSuresi";
            this.lstOrtIslemSuresi.Size = new System.Drawing.Size(212, 196);
            this.lstOrtIslemSuresi.TabIndex = 3;
            // 
            // lstOrtIslemSuresi_Oncelikli
            // 
            this.lstOrtIslemSuresi_Oncelikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstOrtIslemSuresi_Oncelikli.FormattingEnabled = true;
            this.lstOrtIslemSuresi_Oncelikli.ItemHeight = 16;
            this.lstOrtIslemSuresi_Oncelikli.Location = new System.Drawing.Point(514, 341);
            this.lstOrtIslemSuresi_Oncelikli.Name = "lstOrtIslemSuresi_Oncelikli";
            this.lstOrtIslemSuresi_Oncelikli.Size = new System.Drawing.Size(337, 196);
            this.lstOrtIslemSuresi_Oncelikli.TabIndex = 3;
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 749);
            this.Controls.Add(this.lstOrtIslemSuresi_Oncelikli);
            this.Controls.Add(this.lstKuyruk_Oncelikli);
            this.Controls.Add(this.lstArabalar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtArabaSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnCikar_Oncelikli);
            this.Controls.Add(this.lstOrtIslemSuresi);
            this.Controls.Add(this.lstKuyruk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAnaEkran";
            this.Text = "ANA EKRAN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArabaSayisi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstArabalar;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.ListBox lstKuyruk;
        private System.Windows.Forms.ListBox lstKuyruk_Oncelikli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCikar_Oncelikli;
        private System.Windows.Forms.ListBox lstOrtIslemSuresi;
        private System.Windows.Forms.ListBox lstOrtIslemSuresi_Oncelikli;
    }
}

