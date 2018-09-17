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
            btnCikar.Hide();
            btnCikar_Oncelikli.Hide();
        }

        private int arabaSayisi;
        private int arabaSayaci;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstArabalar.Items.Clear();
            lstKuyruk.Items.Clear();
            lstOrtIslemSuresi.Items.Clear();
            lstKuyruk_Oncelikli.Items.Clear();
            lstOrtIslemSuresi_Oncelikli.Items.Clear();

            arabaSayisi = Convert.ToInt32(txtArabaSayisi.Text);
            arabaSayaci = 1;
            int islemSuresi;
            Random randIslemsuresi = new Random();
            IlgiliNesneleriUret(arabaSayisi);

            while (arabaSayaci <= arabaSayisi)
            {
                islemSuresi = randIslemsuresi.Next(10, 300);

                araba = new Araba("Araba" + arabaSayaci, islemSuresi);
                IlgiliEklemeleriYap(araba);

                lstArabalar.Items.Add("Araba" + arabaSayaci + " - İşlem Süresi: " + islemSuresi + " sn");
                arabaSayaci++;
            }
            btnCikar.Show();
            btnEkle.Hide();
            txtArabaSayisi.Enabled = false;
        }

        double[] ortIslTamSuresi;
        double[] ortIslTamSuresi_Oncelikli;

        private void btnCikar_Click(object sender, EventArgs e)
        {
            arabaSayaci = 1;
            ortIslTamSuresi = new double[arabaSayisi];

            while (arabaSayaci <= arabaSayisi)
            {
                Araba cikanAraba = arabaKuyrugu.Remove();
                lstKuyruk.Items.Add(cikanAraba.ad + " - Çıkış Süresi: " + cikanAraba.kuyruktanCikisSuresi);

                ortIslTamSuresi[arabaSayaci - 1] = (cikanAraba.kuyruktanCikisSuresi / Convert.ToDouble(arabaSayaci));

                double ortIslTam = ortIslTamSuresi[arabaSayaci - 1];

                lstOrtIslemSuresi.Items.Add(cikanAraba.ad + "Ort. : " + ortIslTam);

                arabaSayaci++;
            }
            btnCikar_Oncelikli.Show();
            btnCikar.Hide();
        }

        private void btnCikar_Oncelikli_Click(object sender, EventArgs e)
        {
            arabaSayaci = 1;
            ortIslTamSuresi_Oncelikli = new double[arabaSayisi];

            while (arabaSayaci <= arabaSayisi)
            {
                Araba cikanAraba = arabaKuyrugu_Oncelikli.Remove();
                lstKuyruk_Oncelikli.Items.Add(cikanAraba.ad + " - Çıkış Süresi: " + cikanAraba.kuyruktanCikisSuresi_Oncelikli);

                ortIslTamSuresi_Oncelikli[arabaSayaci - 1] = (cikanAraba.kuyruktanCikisSuresi_Oncelikli / Convert.ToDouble(arabaSayaci));

                double ortIslTam_Oncelikli = ortIslTamSuresi_Oncelikli[arabaSayaci - 1];
                double ortIslTam = ortIslTamSuresi[arabaSayaci - 1];
                double kazanc = ortIslTam_Oncelikli - ortIslTam;

                lstOrtIslemSuresi_Oncelikli.Items.Add(cikanAraba.ad + "Ort. : " + ortIslTam_Oncelikli + " -- k : " + kazanc);
                arabaSayaci++;
            }

            txtArabaSayisi.Enabled = true;
            txtArabaSayisi.Clear();
            btnEkle.Show();
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

    }
}
