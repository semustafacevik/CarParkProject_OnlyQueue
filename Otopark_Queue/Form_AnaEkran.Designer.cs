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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstOrtIslKazanc = new System.Windows.Forms.ListBox();
            this.lstArabalar_Kazancli = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.txtArabaSayisi.TabIndex = 0;
            this.txtArabaSayisi.TextChanged += new System.EventHandler(this.txtArabaSayisi_TextChanged);
            this.txtArabaSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtArabaSayisi_KeyPress);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(372, 29);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 38);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstArabalar
            // 
            this.lstArabalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstArabalar.FormattingEnabled = true;
            this.lstArabalar.ItemHeight = 16;
            this.lstArabalar.Location = new System.Drawing.Point(20, 124);
            this.lstArabalar.Name = "lstArabalar";
            this.lstArabalar.Size = new System.Drawing.Size(212, 148);
            this.lstArabalar.TabIndex = 10;
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
            this.lstKuyruk.Location = new System.Drawing.Point(265, 124);
            this.lstKuyruk.Name = "lstKuyruk";
            this.lstKuyruk.Size = new System.Drawing.Size(212, 148);
            this.lstKuyruk.TabIndex = 11;
            // 
            // lstKuyruk_Oncelikli
            // 
            this.lstKuyruk_Oncelikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstKuyruk_Oncelikli.FormattingEnabled = true;
            this.lstKuyruk_Oncelikli.ItemHeight = 16;
            this.lstKuyruk_Oncelikli.Location = new System.Drawing.Point(514, 124);
            this.lstKuyruk_Oncelikli.Name = "lstKuyruk_Oncelikli";
            this.lstKuyruk_Oncelikli.Size = new System.Drawing.Size(212, 148);
            this.lstKuyruk_Oncelikli.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "OTOPARKTAKİ ARABALAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(305, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "ÇIKAN ARABALAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(527, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "ÖNCELİKLİ ÇIKAN ARABALAR";
            // 
            // btnCikar_Oncelikli
            // 
            this.btnCikar_Oncelikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikar_Oncelikli.Location = new System.Drawing.Point(371, 26);
            this.btnCikar_Oncelikli.Name = "btnCikar_Oncelikli";
            this.btnCikar_Oncelikli.Size = new System.Drawing.Size(88, 45);
            this.btnCikar_Oncelikli.TabIndex = 3;
            this.btnCikar_Oncelikli.Text = "ÖNCELİKLİ ÇIKAR";
            this.btnCikar_Oncelikli.UseVisualStyleBackColor = true;
            this.btnCikar_Oncelikli.Click += new System.EventHandler(this.btnCikar_Oncelikli_Click);
            // 
            // lstOrtIslemSuresi
            // 
            this.lstOrtIslemSuresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstOrtIslemSuresi.FormattingEnabled = true;
            this.lstOrtIslemSuresi.ItemHeight = 16;
            this.lstOrtIslemSuresi.Location = new System.Drawing.Point(265, 313);
            this.lstOrtIslemSuresi.Name = "lstOrtIslemSuresi";
            this.lstOrtIslemSuresi.Size = new System.Drawing.Size(212, 148);
            this.lstOrtIslemSuresi.TabIndex = 13;
            // 
            // lstOrtIslemSuresi_Oncelikli
            // 
            this.lstOrtIslemSuresi_Oncelikli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstOrtIslemSuresi_Oncelikli.FormattingEnabled = true;
            this.lstOrtIslemSuresi_Oncelikli.ItemHeight = 16;
            this.lstOrtIslemSuresi_Oncelikli.Location = new System.Drawing.Point(514, 313);
            this.lstOrtIslemSuresi_Oncelikli.Name = "lstOrtIslemSuresi_Oncelikli";
            this.lstOrtIslemSuresi_Oncelikli.Size = new System.Drawing.Size(215, 148);
            this.lstOrtIslemSuresi_Oncelikli.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(286, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "İşlem Tamamlama Süreleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(552, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "İşlem Tamamlama Süreleri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(17, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Araba Listesi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(271, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ort. İşlem Tamamlama Süreleri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(527, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ort. İşlem Tamamlama Süreleri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(452, 480);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(287, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ort. İşlem Tamamlama Sürelerindeki Kazanç";
            // 
            // lstOrtIslKazanc
            // 
            this.lstOrtIslKazanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstOrtIslKazanc.FormattingEnabled = true;
            this.lstOrtIslKazanc.ItemHeight = 16;
            this.lstOrtIslKazanc.Location = new System.Drawing.Point(514, 500);
            this.lstOrtIslKazanc.Name = "lstOrtIslKazanc";
            this.lstOrtIslKazanc.Size = new System.Drawing.Size(215, 148);
            this.lstOrtIslKazanc.TabIndex = 15;
            // 
            // lstArabalar_Kazancli
            // 
            this.lstArabalar_Kazancli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstArabalar_Kazancli.FormattingEnabled = true;
            this.lstArabalar_Kazancli.ItemHeight = 16;
            this.lstArabalar_Kazancli.Location = new System.Drawing.Point(20, 500);
            this.lstArabalar_Kazancli.Name = "lstArabalar_Kazancli";
            this.lstArabalar_Kazancli.Size = new System.Drawing.Size(341, 148);
            this.lstArabalar_Kazancli.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(14, 480);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Kazançlı Arabalar";
            // 
            // frmAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 667);
            this.Controls.Add(this.lstArabalar_Kazancli);
            this.Controls.Add(this.lstOrtIslKazanc);
            this.Controls.Add(this.lstOrtIslemSuresi_Oncelikli);
            this.Controls.Add(this.lstKuyruk_Oncelikli);
            this.Controls.Add(this.lstArabalar);
            this.Controls.Add(this.txtArabaSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOrtIslemSuresi);
            this.Controls.Add(this.lstKuyruk);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnCikar_Oncelikli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(300, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstOrtIslKazanc;
        private System.Windows.Forms.ListBox lstArabalar_Kazancli;
        private System.Windows.Forms.Label label11;
    }
}

