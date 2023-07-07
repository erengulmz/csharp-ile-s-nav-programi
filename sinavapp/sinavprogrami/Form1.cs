namespace sinavprogrami
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> sorular;
        private int soruSayisi;
        private int dogruCevapSayisi;
        private int yanlisCevapSayisi;
        private DateTime baslangicZamani;
        private DateTime bitisZamani;
        private bool sureDoldu = false;
        public Form1()
        {
            InitializeComponent();
            sorular = new Dictionary<string, List<string>>();
            sorular["G�rsel Programlama"] = new List<string>
            {
                "Soru 1:  Timer�in aktif oldu�u durumda �al��acak kodlar\n hangi �zelli�ine yaz�l�r?",
                "interval ",
                "Enabled  ",
                "False",
                "Tick",
                "Tick",

                "Soru 2: Hangisi TextBox�a ka� karakter girilece�ini ayarlar?",
                "Visible",
                "MaxLength",
                "MultiLine",
                "Clear",
                "MaxLength",

                "Soru 3:Formun �zerine bmp, jpg.. gibi nesneleri eklemek i�in\n hangisi kullan�l�r?",
                "Radiobutton",
                "TextBox",
                "PictureBox",
                "MessageBox",
                "PictureBox",
                "Soru 4: Birden fazla nesneye ayn� i�lemi uygulamak i�in\n hangi y�ntem kullan�l�r?",
                "Visible ",
                "MaxLength",
                "GroupBox",
                "MultiLine",
                "GroupBox",

                "Soru 5: Birden fazla nesneye ayn� i�lemi uygulamak i�in \nhangi y�ntem kullan�l�r?",
                "Aktif yapar ",
                "Pasif yapar",
                "G�r�n�r yapar",
                "Hi�biri",
                "G�r�n�r yapar",

                "Soru 6: Kar��la�t�rma i�lemlerinde kullan�lan\n �e�it de�ildir� operat�r� a�a��dakilerden hangisidir?",
                "=",
                "<>",
                "= =",
                "!=",
                "!=",
            };

            sorular["Veri Taban� 2"] = new List<string>
            {
                "Soru 1: From ifadesi ne i�in kullan�l�r?",
                "Arama i�in �art belirtir",
                "Hangi Tablodan bilgi �ekilece�ini belirtmek i�in",
                "Arama i�lemi i�in s�n�r koyar",
                "Tablo olu�turur",
                "Hangi Tablodan bilgi �ekilece�ini belirtmek i�in",

                "Soru 2: A�a��dakilerden hangisi SQL'de kullan�lan bir komut de�ildir ? ",
                "Insert",
                "Select",
                "Invert",
                "Update",
                "Invert",

                "Soru 3: En y�ksek de�eri bulmak i�in\n hangi fonksiyon kullan�l�r ? ",
                "Most",
                "Max",
                "Top",
                "Upper",
                "Max",

                 "Soru 4: Tablodan kay�t silmek i�in kullan�lan komut hangisidir ?",
                "Drop Data",
                "Remove",
                "Delete",
                "Clear",
                "Delete",

                 "Soru 5: Personel tablosundan Ad� \"a\" harfi ile ba�layanlar� se�mek i�in\n hangisi kullan�l�r ?",
                "SELECT * FROM Personel WHERE Adi='a'",
                "SELECT * FROM Personel WHERE Adi LIKE 'a%'",
                "SELECT * FROM Personel WHERE Adi LIKE '%a'",
                "SELECT * FROM Personel WHERE Adi='%a%'",
                "SELECT * FROM Personel WHERE Adi LIKE 'a%'",

            };

            sorular["Python"] = new List<string>
            {
                "Soru 1: A�a��dakilerden hangisi de�i�ken ismi olarak kullan�lmaktad�r? ",
                "de�er1",
                "deger1",
                "1de�er",
                "birinci.deger",
                "deger1",


                "Soru 2: A�a��daki operat�rlerden hangisi kalan� bulma\n (mod alma, �rn: 7�nin 3 ile b�l�m�nden kalan� bulma)\n ifadesinin kar��l���d�r? ",
                "//",
                "%",
                "<>",
                "**",
                "%",

                  "Soru 3: Metinsel bir ifadeyi say�sal bir ifadeye �evirmek i�in \n a�a��daki komutlardan hangisi kullan�lmaktad�r? ",
                "char()",
                "num()",
                "int()",
                "str()",
                "int()",


                "Soru 4: A�a��daki operat�rlerden hangisi �s alma (�rn: 2�nin k�p�) ifadesinin kar��l���d�r? ",
                "=!",
                "<>",
                "^^",
                "**",
                "**",

               "Soru 5:  p_deger = 3.141818\r\n Yukar�da tan�mlanan de�i�kenin t�r� a�a��dakilerden hangisidir?",
                "integer",
                "float",
                "string",
                "char",
                "float",
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string ders in sorular.Keys)
            {
                cmbDersler.Items.Add(ders);
            }
            timer1.Interval = 1000;
            timer1.Stop();
        }

        private void SinavBaslaBTN_Click(object sender, EventArgs e)
        {

            if (cmbDersler.SelectedIndex == -1)
            {
                MessageBox.Show("L�tfen bir ders se�iniz!");
                return;
            }
            string secilenDers = cmbDersler.SelectedItem.ToString(); ;
            List<string> secilenSorular = sorular[secilenDers];
            soruSayisi = secilenSorular.Count / 6;
            dogruCevapSayisi = 0;
            yanlisCevapSayisi = 0;
            baslangicZamani = DateTime.Now;
            bitisZamani = baslangicZamani.AddMinutes(5);

            this.Text = secilenDers;

            lblSoru.Text = secilenSorular[0];
            rbSecenekA.Text = secilenSorular[1];
            rbSecenekB.Text = secilenSorular[2];
            rbSecenekC.Text = secilenSorular[3];
            rbSecenekD.Text = secilenSorular[4];
            SinavBaslaBTN.Enabled = false;
            IleriBTN.Enabled = true;
            GeriBTN.Enabled = false;
            SinaviBitirBTN.Enabled = true;
            timer1.Start();
        }

        private void IleriBTN_Click(object sender, EventArgs e)
        {
            if (dogruCevapSayisi + yanlisCevapSayisi >= soruSayisi)
            {
                MessageBox.Show("T�m sorular� cevaplad�n�z!");
                return;
            }
            if (!rbSecenekA.Checked && !rbSecenekB.Checked && !rbSecenekC.Checked && !rbSecenekD.Checked)
            {
                MessageBox.Show("L�tfen bir se�enek se�in!");
                return;
            }
            string dogruCevap = sorular[cmbDersler.SelectedItem.ToString()][(dogruCevapSayisi + 1) * 6 - 1];
            if (rbSecenekA.Checked && rbSecenekA.Text == dogruCevap)
                dogruCevapSayisi++;
            else if (rbSecenekB.Checked && rbSecenekB.Text == dogruCevap)
                dogruCevapSayisi++;
            else if (rbSecenekC.Checked && rbSecenekC.Text == dogruCevap)
                dogruCevapSayisi++;
            else if (rbSecenekD.Checked && rbSecenekD.Text == dogruCevap)
                dogruCevapSayisi++;
            else
                yanlisCevapSayisi++;
            int siradakiSoruIndex = dogruCevapSayisi + yanlisCevapSayisi;
            lblSoru.Text = sorular[cmbDersler.SelectedItem.ToString()][siradakiSoruIndex * 6];
            rbSecenekA.Text = sorular[cmbDersler.SelectedItem.ToString()][siradakiSoruIndex * 6 + 1];
            rbSecenekB.Text = sorular[cmbDersler.SelectedItem.ToString()][siradakiSoruIndex * 6 + 2];
            rbSecenekC.Text = sorular[cmbDersler.SelectedItem.ToString()][siradakiSoruIndex * 6 + 3];
            rbSecenekD.Text = sorular[cmbDersler.SelectedItem.ToString()][siradakiSoruIndex * 6 + 4];
            if (siradakiSoruIndex == soruSayisi - 1)
            {
                IleriBTN.Enabled = false;
            }
            if (siradakiSoruIndex > 0)
            {
                GeriBTN.Enabled = true;
            }
            rbSecenekA.Checked = false;
            rbSecenekB.Checked = false;
            rbSecenekC.Checked = false;
            rbSecenekD.Checked = false;
        }

        private void GeriBTN_Click(object sender, EventArgs e)
        {
            if (dogruCevapSayisi + yanlisCevapSayisi <= 0)
            {
                MessageBox.Show("Bu ilk soru!");
                return;
            }
            int oncekiSoruIndex = dogruCevapSayisi + yanlisCevapSayisi - 1;
            lblSoru.Text = sorular[cmbDersler.SelectedItem.ToString()][oncekiSoruIndex * 6];
            rbSecenekA.Text = sorular[cmbDersler.SelectedItem.ToString()][oncekiSoruIndex * 6 + 1];
            rbSecenekB.Text = sorular[cmbDersler.SelectedItem.ToString()][oncekiSoruIndex * 6 + 2];
            rbSecenekC.Text = sorular[cmbDersler.SelectedItem.ToString()][oncekiSoruIndex * 6 + 3];
            rbSecenekD.Text = sorular[cmbDersler.SelectedItem.ToString()][oncekiSoruIndex * 6 + 4];
            if (oncekiSoruIndex == 0)
            {
                GeriBTN.Enabled = false;
            }
            if (oncekiSoruIndex < soruSayisi - 1)
            {
                IleriBTN.Enabled = true;
            }
        }

        private void SinaviBitirBTN_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                return;
            }
            if (cmbDersler.SelectedItem == null)
            {
                MessageBox.Show("L�tfen bir ders se�in!");
                return;
            }

            string secilenDers = cmbDersler.SelectedItem.ToString();
            if (!sorular.ContainsKey(secilenDers))
            {
                MessageBox.Show("Se�ilen derse ait sorular bulunamad�!");
                return;
            }
            string dogruCevap = sorular[secilenDers][(dogruCevapSayisi + 1) * 6 - 1];
            if (rbSecenekA.Checked && rbSecenekA.Text == dogruCevap)
                dogruCevapSayisi++;
            else if (rbSecenekB.Checked && rbSecenekB.Text == dogruCevap)
                dogruCevapSayisi++;
            else if (rbSecenekC.Checked && rbSecenekC.Text == dogruCevap)
                dogruCevapSayisi++;
            else if (rbSecenekD.Checked && rbSecenekD.Text == dogruCevap)
                dogruCevapSayisi++;
            else
                yanlisCevapSayisi++;
            timer1.Stop();
            MessageBox.Show("S�nav bitti!\n\nDo�ru cevap say�s�: " + dogruCevapSayisi + "\nYanl�� cevap say�s�: " + yanlisCevapSayisi);

            SinavBaslaBTN.Enabled = true;
            IleriBTN.Enabled = false;
            GeriBTN.Enabled = false;
            SinaviBitirBTN.Enabled = false;

            rbSecenekA.Checked = false;
            rbSecenekB.Checked = false;
            rbSecenekC.Checked = false;
            rbSecenekD.Checked = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan kalanSure = bitisZamani - DateTime.Now;
            if (kalanSure.TotalSeconds <= 1 && !sureDoldu)
            {
                sureDoldu = true;
                timer1.Stop();
                MessageBox.Show("S�reniz doldu!");
                SinaviBitirBTN.PerformClick();
                return;
            }
            Surelbl.Text = string.Format("{0}:{1:00}", kalanSure.Minutes, kalanSure.Seconds);
        }
    }
}