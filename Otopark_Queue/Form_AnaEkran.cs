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
            lstOrtIslKazanc.Items.Clear();
            lstArabalar_Kazancli.Items.Clear();

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

        private double[] ortIslTam;
        private double[] ortIslTam_Oncelikli;

        private void btnCikar_Click(object sender, EventArgs e)
        {
            arabaSayaci = 1;
            ortIslTam = new double[arabaSayisi];

            while (arabaSayaci <= arabaSayisi)
            {
                double ortIsl = ortIslTam[arabaSayaci - 1];

                Araba cikanAraba = arabaKuyrugu.Remove();
                ortIsl = (cikanAraba.kuyruktanCikissuresi / Convert.ToDouble(arabaSayaci));
                ortIsl = Math.Round(ortIsl, 2);
                cikanAraba.kuyrukSirasi = arabaSayaci;
                cikanAraba.islemTamamlamasuresi = ortIsl;


                //otopark.CikanArabayiEkle(cikanAraba);

                lstKuyruk.Items.Add(cikanAraba.kuyrukSirasi + " -> " + cikanAraba.ad + " - Süre: " + cikanAraba.kuyruktanCikissuresi + " sn");
                lstOrtIslemSuresi.Items.Add(cikanAraba.kuyrukSirasi + " araba için ort. süre: " + cikanAraba.islemTamamlamasuresi + " sn");

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
                ortIsl = (cikanAraba.kuyruktanCikissuresi_Oncelikli / Convert.ToDouble(arabaSayaci));
                ortIsl = Math.Round(ortIsl, 2);
                cikanAraba.kuyrukSirasi_Oncelikli = arabaSayaci;
                cikanAraba.islemTamamlamasuresi_Oncelikli = ortIsl;

                lstOrtIslemSuresi_Oncelikli.Items.Add(cikanAraba.kuyrukSirasi_Oncelikli + " araba için ort. süre: " + cikanAraba.islemTamamlamasuresi_Oncelikli + " sn");
                lstKuyruk_Oncelikli.Items.Add(cikanAraba.kuyrukSirasi_Oncelikli + " -> " + cikanAraba.ad + " - Süre: " + cikanAraba.kuyruktanCikissuresi_Oncelikli + " sn");

                ortIslTam_Oncelikli[arabaSayaci - 1] = ortIsl;
                

                double islemSuresi_Fark = ortIslTam[arabaSayaci - 1] - ortIslTam_Oncelikli[arabaSayaci - 1];
                double islemSuresi_Yuzde = (islemSuresi_Fark / ortIslTam_Oncelikli[arabaSayaci - 1]) * 100;
                islemSuresi_Fark = Math.Round(islemSuresi_Fark, 2);
                islemSuresi_Yuzde = Math.Round(islemSuresi_Yuzde, 2);

                lstOrtIslKazanc.Items.Add("Fark: " + islemSuresi_Fark + " sn - Yüzde: %" + islemSuresi_Yuzde);
                arabaSayaci++;
            }

            foreach (Araba kazancliAraba in otopark.OtoparktakiArabalar)
            {
                if(kazancliAraba.kuyrukSirasi_Oncelikli < kazancliAraba.kuyrukSirasi)
                {
                    lstArabalar_Kazancli.Items.Add(kazancliAraba.ad + " - Kazanç: " + (kazancliAraba.kuyruktanCikissuresi - kazancliAraba.kuyruktanCikissuresi_Oncelikli) + " sn" +
                                                   " (" + kazancliAraba.kuyrukSirasi + ". siradan -> " + kazancliAraba.kuyrukSirasi_Oncelikli + ". siraya)");
                }
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
