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
            sorular["Görsel Programlama"] = new List<string>
            {
                "Soru 1:  Timer’in aktif olduðu durumda çalýþacak kodlar\n hangi özelliðine yazýlýr?",
                "interval ",
                "Enabled  ",
                "False",
                "Tick",
                "Tick",

                "Soru 2: Hangisi TextBox’a kaç karakter girileceðini ayarlar?",
                "Visible",
                "MaxLength",
                "MultiLine",
                "Clear",
                "MaxLength",

                "Soru 3:Formun üzerine bmp, jpg.. gibi nesneleri eklemek için\n hangisi kullanýlýr?",
                "Radiobutton",
                "TextBox",
                "PictureBox",
                "MessageBox",
                "PictureBox",
                "Soru 4: Birden fazla nesneye ayný iþlemi uygulamak için\n hangi yöntem kullanýlýr?",
                "Visible ",
                "MaxLength",
                "GroupBox",
                "MultiLine",
                "GroupBox",

                "Soru 5: Birden fazla nesneye ayný iþlemi uygulamak için \nhangi yöntem kullanýlýr?",
                "Aktif yapar ",
                "Pasif yapar",
                "Görünür yapar",
                "Hiçbiri",
                "Görünür yapar",

                "Soru 6: Karþýlaþtýrma iþlemlerinde kullanýlan\n “eþit deðildir” operatörü aþaðýdakilerden hangisidir?",
                "=",
                "<>",
                "= =",
                "!=",
                "!=",
            };

            sorular["Veri Tabaný 2"] = new List<string>
            {
                "Soru 1: From ifadesi ne için kullanýlýr?",
                "Arama için þart belirtir",
                "Hangi Tablodan bilgi çekileceðini belirtmek için",
                "Arama iþlemi için sýnýr koyar",
                "Tablo oluþturur",
                "Hangi Tablodan bilgi çekileceðini belirtmek için",

                "Soru 2: Aþaðýdakilerden hangisi SQL'de kullanýlan bir komut deðildir ? ",
                "Insert",
                "Select",
                "Invert",
                "Update",
                "Invert",

                "Soru 3: En yüksek deðeri bulmak için\n hangi fonksiyon kullanýlýr ? ",
                "Most",
                "Max",
                "Top",
                "Upper",
                "Max",

                 "Soru 4: Tablodan kayýt silmek için kullanýlan komut hangisidir ?",
                "Drop Data",
                "Remove",
                "Delete",
                "Clear",
                "Delete",

                 "Soru 5: Personel tablosundan Adý \"a\" harfi ile baþlayanlarý seçmek için\n hangisi kullanýlýr ?",
                "SELECT * FROM Personel WHERE Adi='a'",
                "SELECT * FROM Personel WHERE Adi LIKE 'a%'",
                "SELECT * FROM Personel WHERE Adi LIKE '%a'",
                "SELECT * FROM Personel WHERE Adi='%a%'",
                "SELECT * FROM Personel WHERE Adi LIKE 'a%'",

            };

            sorular["Python"] = new List<string>
            {
                "Soru 1: Aþaðýdakilerden hangisi deðiþken ismi olarak kullanýlmaktadýr? ",
                "deðer1",
                "deger1",
                "1deðer",
                "birinci.deger",
                "deger1",


                "Soru 2: Aþaðýdaki operatörlerden hangisi kalaný bulma\n (mod alma, örn: 7’nin 3 ile bölümünden kalaný bulma)\n ifadesinin karþýlýðýdýr? ",
                "//",
                "%",
                "<>",
                "**",
                "%",

                  "Soru 3: Metinsel bir ifadeyi sayýsal bir ifadeye çevirmek için \n aþaðýdaki komutlardan hangisi kullanýlmaktadýr? ",
                "char()",
                "num()",
                "int()",
                "str()",
                "int()",


                "Soru 4: Aþaðýdaki operatörlerden hangisi üs alma (örn: 2’nin küpü) ifadesinin karþýlýðýdýr? ",
                "=!",
                "<>",
                "^^",
                "**",
                "**",

               "Soru 5:  p_deger = 3.141818\r\n Yukarýda tanýmlanan deðiþkenin türü aþaðýdakilerden hangisidir?",
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
                MessageBox.Show("Lütfen bir ders seçiniz!");
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
                MessageBox.Show("Tüm sorularý cevapladýnýz!");
                return;
            }
            if (!rbSecenekA.Checked && !rbSecenekB.Checked && !rbSecenekC.Checked && !rbSecenekD.Checked)
            {
                MessageBox.Show("Lütfen bir seçenek seçin!");
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
                MessageBox.Show("Lütfen bir ders seçin!");
                return;
            }

            string secilenDers = cmbDersler.SelectedItem.ToString();
            if (!sorular.ContainsKey(secilenDers))
            {
                MessageBox.Show("Seçilen derse ait sorular bulunamadý!");
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
            MessageBox.Show("Sýnav bitti!\n\nDoðru cevap sayýsý: " + dogruCevapSayisi + "\nYanlýþ cevap sayýsý: " + yanlisCevapSayisi);

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
                MessageBox.Show("Süreniz doldu!");
                SinaviBitirBTN.PerformClick();
                return;
            }
            Surelbl.Text = string.Format("{0}:{1:00}", kalanSure.Minutes, kalanSure.Seconds);
        }
    }
}