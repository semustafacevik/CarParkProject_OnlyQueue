using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Queue
{
    public partial class frmAnaEkran : Form
    {
        private Otopark otopark;
        private Araba araba;
        private ArabaKuyrugu arabaKuyrugu;
        private ArabaKuyrugu_Oncelikli arabaKuyrugu_Oncelikli;

        public frmAnaEkran()
        {
            InitializeComponent();
            btnEkle.Enabled = false;
            btnCikar.Hide();
            btnCikar_Oncelikli.Hide();
        }

        private int arabaSayisi;
        private int arabaSayaci;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListeAktivasyon_Temizle();

            arabaSayisi = Convert.ToInt32(txtArabaSayisi.Text);
            arabaSayaci = 1;
            int islemSuresi;
            Random randIslemsuresi = new Random();
            IlgiliNesneleriUret(arabaSayisi);

            while (arabaSayaci <= arabaSayisi)
            {
                islemSuresi = randIslemsuresi.Next(10, 300);
                string arabaAdi = "Araba" + arabaSayaci;
                araba = new Araba(arabaAdi, islemSuresi);
                IlgiliEklemeleriYap(araba);

                lstArabalar.Items.Add("Araba" + arabaSayaci + " - İşlem Süresi: " + islemSuresi + " sn");
                arabaSayaci++;
            }
            btnCikar.Show();
            btnEkle.Hide();
            txtArabaSayisi.Enabled = false;
        }

        private double[] ortIslTam;  // ortalama işlem sürelerinin tutulacağı diziler
        private double[] ortIslTam_Oncelikli;

        private void btnCikar_Click(object sender, EventArgs e)
        {
            arabaSayaci = 1;
            ortIslTam = new double[arabaSayisi];

            while (arabaSayaci <= arabaSayisi)
            {
                double ortIsl = ortIslTam[arabaSayaci - 1];

                Araba cikanAraba = arabaKuyrugu.Remove();
                ortIsl = (cikanAraba.islemTamamlamasuresi / Convert.ToDouble(arabaSayaci));
                ortIsl = Math.Round(ortIsl, 2);
                cikanAraba.kuyrukSirasi = arabaSayaci;
                cikanAraba.ortIslemtamamlamaSuresi = ortIsl;

                lstKuyruk.Items.Add(cikanAraba.kuyrukSirasi + " -> " + cikanAraba.ad + " - Süre: " + cikanAraba.islemTamamlamasuresi + " sn");
                lstOrtIslemSuresi.Items.Add(cikanAraba.kuyrukSirasi + " araba için ort. süre: " + cikanAraba.ortIslemtamamlamaSuresi + " sn");

                ortIslTam[arabaSayaci - 1] = ortIsl;
                arabaSayaci++;
            }
            btnCikar_Oncelikli.Show();
            btnCikar.Hide();
        }

        private void btnCikar_Oncelikli_Click(object sender, EventArgs e)
        {
            arabaSayaci = 1;
            ortIslTam_Oncelikli = new double[arabaSayisi];

            while (arabaSayaci <= arabaSayisi)
            {
                double ortIsl = ortIslTam_Oncelikli[arabaSayaci - 1];

                Araba cikanAraba = arabaKuyrugu_Oncelikli.Remove();                
                ortIsl = (cikanAraba.islemTamamlamasuresi_Oncelikli / Convert.ToDouble(arabaSayaci));
                ortIsl = Math.Round(ortIsl, 2);
                cikanAraba.kuyrukSirasi_Oncelikli = arabaSayaci;
                cikanAraba.ortIslemtamamlamaSuresi_Oncelikli = ortIsl;

                lstKuyruk_Oncelikli.Items.Add(cikanAraba.kuyrukSirasi_Oncelikli + " -> " + cikanAraba.ad + " - Süre: " + cikanAraba.islemTamamlamasuresi_Oncelikli + " sn");
                lstOrtIslemSuresi_Oncelikli.Items.Add(cikanAraba.kuyrukSirasi_Oncelikli + " araba için ort. süre: " + cikanAraba.ortIslemtamamlamaSuresi_Oncelikli + " sn");

                ortIslTam_Oncelikli[arabaSayaci - 1] = ortIsl;
                
                double fark_ortSure = ortIslTam[arabaSayaci - 1] - ortIslTam_Oncelikli[arabaSayaci - 1];
                double yuzde_ortSure = (fark_ortSure / ortIslTam_Oncelikli[arabaSayaci - 1]) * 100;
                fark_ortSure = Math.Round(fark_ortSure, 2);
                yuzde_ortSure = Math.Round(yuzde_ortSure, 2);

                lstOrtIslKazanc.Items.Add("Fark: " + fark_ortSure + " sn - Yüzde: %" + yuzde_ortSure);
                arabaSayaci++;

                otopark.OncelikliCikanArabayiEkle(cikanAraba);
            }

            foreach (Araba kazancliAraba in otopark.OncelikliCikanArabalar)
            {
                if(kazancliAraba.kuyrukSirasi_Oncelikli < kazancliAraba.kuyrukSirasi)
                {
                    double sureKazanci = kazancliAraba.islemTamamlamasuresi - kazancliAraba.islemTamamlamasuresi_Oncelikli;
                    lstArabalar_Kazancli.Items.Add(kazancliAraba.ad + " - Kazanç: " + sureKazanci + " sn" +
                                                  " (" + kazancliAraba.kuyrukSirasi + ". siradan -> " + kazancliAraba.kuyrukSirasi_Oncelikli + ". siraya)");
                }
            }

            txtArabaSayisi.Clear();
            txtArabaSayisi.Enabled = true;          
            btnEkle.Show();
            btnEkle.Enabled = false;
            btnCikar_Oncelikli.Hide();
        }

        private void IlgiliNesneleriUret(int kapasite)
        {
            otopark = new Otopark(kapasite);
            arabaKuyrugu = new ArabaKuyrugu(kapasite);
            arabaKuyrugu_Oncelikli = new ArabaKuyrugu_Oncelikli(kapasite);
        }

        private void IlgiliEklemeleriYap(Araba yeniAraba)
        {
            otopark.OtoparkaArabaEkle(yeniAraba);
            arabaKuyrugu.Insert(yeniAraba);
            arabaKuyrugu_Oncelikli.Insert(yeniAraba);
        }

        private void ListeAktivasyon_Temizle()
        {
            lstArabalar.Items.Clear();
            lstKuyruk.Items.Clear();
            lstOrtIslemSuresi.Items.Clear();
            lstKuyruk_Oncelikli.Items.Clear();
            lstOrtIslemSuresi_Oncelikli.Items.Clear();
            lstOrtIslKazanc.Items.Clear();
            lstArabalar_Kazancli.Items.Clear();
        }

        private void txtArabaSayisi_TextChanged(object sender, EventArgs e)
        {
            if (txtArabaSayisi.TextLength != 0)
                btnEkle.Enabled = true;

            else
                btnEkle.Enabled = false;
        }

        private void txtArabaSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
