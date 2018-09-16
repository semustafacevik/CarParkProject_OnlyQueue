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
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int arabaSayisi = Convert.ToInt32(txtArabaSayisi.Text);
            int arabaSayaci = 1;
            int islemSuresi;
            Random randIslemsuresi = new Random();
            IlgiliNesneleriUret(arabaSayisi);

            while (arabaSayaci <= arabaSayisi)
            {
                islemSuresi = randIslemsuresi.Next(10, 15);

                araba = new Araba("Araba" + arabaSayaci, islemSuresi);
                IlgiliEklemeleriYap(araba);

                lstArabalar.Items.Add("Araba" + arabaSayaci + " - İşlem Süresi: " + islemSuresi + " sn");
                arabaSayaci++;
            }

            btnOnayla.Enabled = false;
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
