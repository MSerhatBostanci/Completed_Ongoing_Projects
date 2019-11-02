using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKayit
{
    public partial class Form1 : Form
    {
        SqlConnection _cnn;
        public Form1()
        {
            InitializeComponent();
            _cnn = new SqlConnection("server=.;database=Gorev_9_PersonelKayitDB;Trusted_Connection=true");
            lvPersonelListesi.FullRowSelect = true;
            txtTcKimlikNo.MaxLength = 11;
            picBoxAvatar.Image = picBoxAvatar.InitialImage;
            rbtnBekar.Checked = true;
            rbtnErkek.Checked = true;
            this.Load += ListeGuncelle;
            this.Load += BilgileriTemizle;
        }
        private void ListedenSecileniGoster(object sender, EventArgs e)
        {
            if (lvPersonelListesi.SelectedItems.Count > 0)
            {

                string seciliPersonelID = lvPersonelListesi.SelectedItems[0].Text;


                long seciliTc = Convert.ToInt64(seciliPersonelID);

                SqlCommand cmd = new SqlCommand("select * from PersonelBilgileri where TCKimlikNo=@TcKimlikNo ", _cnn);

                cmd.Parameters.AddWithValue("@TcKimlikNo", seciliTc);

                if (_cnn.State != ConnectionState.Open)
                {
                    _cnn.Open();
                }
                try
                {
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            PersonelBilgileri Personel = new PersonelBilgileri();
                            Personel.ID = (int)rd["PersonelID"];
                            Personel.TcKimlikNo = (long)rd["TCKimlikNo"];
                            Personel.Ad = rd["Ad"].ToString();
                            Personel.Soyad = rd["Soyad"].ToString();
                            Personel.IseGirisTarihi = rd["IseGirisTarihi"].ToString();
                            Personel.Telefon = rd["Telefon"].ToString();
                            Personel.Eposta = rd["E-Posta"].ToString();
                            Personel.MedeniHal = rd["MedeniHali"].ToString();
                            Personel.Ehliyet = rd["Ehliyet"].ToString();
                            Personel.Cinsiyet = rd["Cinsiyet"].ToString();
                            Personel.Adres = rd["Adres"].ToString();
                            Personel.DogumTarihi = rd["DogumTarihi"].ToString();
                            Personel.Unvan = rd["Unvan"].ToString();

                            txtTcKimlikNo.Text = Personel.TcKimlikNo.ToString();
                            txtAd.Text = Personel.Ad;
                            txtSoyad.Text = Personel.Soyad;
                            txtEPosta.Text = Personel.Eposta;
                            txtAdres.Text = Personel.Adres;
                            txtUnvan.Text = Personel.Unvan;
                            dtpDogumTarihi.Text = Personel.DogumTarihi;
                            dtpIseGiris.Text = Personel.IseGirisTarihi;
                            mtxtTelefon.Text = Personel.Telefon;

                            if (Personel.Cinsiyet == "Erkek")
                            {
                                rbtnErkek.Checked = true;
                            }
                            else
                            {
                                rbtnKadin.Checked = true;
                            }
                            if (Personel.MedeniHal == "Bekar")
                            {
                                rbtnBekar.Checked = true;
                            }
                            else
                            {
                                rbtnEvli.Checked = true;
                            }
                            if (Personel.Ehliyet.Contains("A1"))
                            {
                                cboxA1.Checked = true;
                            }
                            if (Personel.Ehliyet.Contains("A2"))
                            {
                                cboxA2.Checked = true;
                            }
                            if (Personel.Ehliyet.Contains("B"))
                            {
                                cboxB.Checked = true;
                            }
                            if (Personel.Ehliyet.Contains("C"))
                            {
                                cboxC.Checked = true;
                            }
                            if (Personel.Ehliyet.Contains("D"))
                            {
                                cboxD.Checked = true;
                            }
                            if (Personel.Ehliyet.Contains("E"))
                            {
                                cboxE.Checked = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Seçili Öge Değişirken Hata Oluştu");
                }
                finally
                {
                    _cnn.Close();
                }
            }
        }
        private void KayıtSil(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kaydı \"Silmek\" istediğinize emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            string silinecekID = txtTcKimlikNo.Text;

            SqlCommand cmd = new SqlCommand("delete from PersonelBilgileri where TCKimlikNo=@TcKimlikNo", _cnn);
            cmd.Parameters.AddWithValue("@TcKimlikNo", silinecekID);

            if (_cnn.State != ConnectionState.Open)
            {
                _cnn.Open();
            }
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu");
            }
            finally
            {
                ListeGuncelle(null, null);
                BilgileriTemizle(null, null);
                _cnn.Close();
            }
        }
        private void YeniKayit(object sender, EventArgs e)
        {
            if (txtTcKimlikNo.TextLength < 11)
            {
                errorProvider1.SetError(txtTcKimlikNo, "Kimlik numarası 11 haneli olmalıdır ve boş geçilemez");
                return;
            }
            if (txtAd.Text == "")
            {
                errorProvider2.SetError(txtAd, "Ad bölgesi boş geçilemez");
                return;
            }
            if (txtSoyad.Text == "")
            {
                errorProvider3.SetError(txtSoyad, "Soyad bölgesi boş geçilemez");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("\"Yeni Kayıt\" yapmak istediğinize emin misiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            string seciliCinsiyet="";
            if (rbtnErkek.Checked)
                seciliCinsiyet = "Erkek";
            else if (rbtnKadin.Checked)
                seciliCinsiyet = "Kadin";

            string medeniHal="";
            if (rbtnBekar.Checked)
                medeniHal = "Bekar";
            else if (rbtnEvli.Checked)
                medeniHal = "Evli";

            string ehliyetBilgisi = "";
            if (cboxA1.Checked)
                ehliyetBilgisi = ehliyetBilgisi + " A1 ";
            if (cboxA2.Checked)
                ehliyetBilgisi = ehliyetBilgisi + " A2 ";
            if (cboxB.Checked)
                ehliyetBilgisi = ehliyetBilgisi + " B ";
            if (cboxC.Checked)
                ehliyetBilgisi = ehliyetBilgisi + " C ";
            if (cboxD.Checked)
                ehliyetBilgisi = ehliyetBilgisi + " D ";
            if (cboxE.Checked)
                ehliyetBilgisi = ehliyetBilgisi + " E ";

            SqlCommand cmd = new SqlCommand("insert into PersonelBilgileri values(@TcKimlikNo,@Ad,@Soyad,@Unvan,@Cinsiyet,@MedeniHal,@DogumTarihi,@IseGirisTarihi,@Telefon,@Eposta,@Adres,@Ehliyet)", _cnn);

            string kayitUnvan= txtUnvan.Text;
            string kayitTelefon = mtxtTelefon.Text;
            string kayitEposta = txtEPosta.Text;
            string kayitAdres= txtAdres.Text;

            if (txtUnvan.Text.Length < 1)
                kayitUnvan = "";
            if (mtxtTelefon.Text.Length < 1)
                kayitTelefon = "";
            if (txtEPosta.Text.Length < 1)
                kayitEposta = "";
            if (txtAdres.Text.Length < 1)
                kayitTelefon = "";


            cmd.Parameters.AddWithValue("@TcKimlikNo", Convert.ToInt64(txtTcKimlikNo.Text));
            cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@Unvan", kayitUnvan);
            cmd.Parameters.AddWithValue("@Cinsiyet", seciliCinsiyet);
            cmd.Parameters.AddWithValue("@MedeniHal", medeniHal);
            cmd.Parameters.AddWithValue("@DogumTarihi", dtpDogumTarihi.Value);
            cmd.Parameters.AddWithValue("@IseGirisTarihi", dtpIseGiris.Value);
            cmd.Parameters.AddWithValue("@Telefon", kayitTelefon);
            cmd.Parameters.AddWithValue("@Eposta", kayitEposta);
            cmd.Parameters.AddWithValue("@Adres", kayitAdres);
            cmd.Parameters.AddWithValue("@Ehliyet", ehliyetBilgisi);

            try
            {
                if (_cnn.State != ConnectionState.Open)
                {
                    _cnn.Open();
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Aynı \"Kimlik Numarasında\" yeni kayıt oluşturulamaz");
                return;
            }
            finally
            {
                ListeGuncelle(null, null);
                BilgileriTemizle(null, null);
                _cnn.Close();
            }
        }
        private void KayitGuncelle(object sender, EventArgs e)
        {
            if (txtTcKimlikNo.TextLength < 11)
            {
                errorProvider1.SetError(txtTcKimlikNo, "Kimlik numarası 11 haneli olmalıdır ve boş geçilemez");
                return;
            }
            if (txtAd.Text == "")
            {
                errorProvider2.SetError(txtAd, "Ad bölgesi boş geçilemez");
                return;
            }
            if (txtSoyad.Text == "")
            {
                errorProvider3.SetError(txtSoyad, "Soyad bölgesi boş geçilemez");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Kaydı \"Güncellemek\" istediğinize emin misiniz?", "Kayıt Güncelleme", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
                return;

            if (lvPersonelListesi.SelectedItems.Count > 0)
            {
                string seciliPersonelID = lvPersonelListesi.SelectedItems[0].Text;
                long seciliTc = Convert.ToInt64(seciliPersonelID);

                string seciliCinsiyet;
                if (rbtnErkek.Checked)
                    seciliCinsiyet = "Erkek";
                else if (rbtnKadin.Checked)
                    seciliCinsiyet = "Kadin";
                else
                    return;

                string medeniHal;
                if (rbtnBekar.Checked)
                    medeniHal = "Bekar";
                else if (rbtnEvli.Checked)
                    medeniHal = "Evli";
                else
                    return;

                string ehliyetBilgisi = "";
                if (cboxA1.Checked)
                    ehliyetBilgisi = ehliyetBilgisi + " A1 ";
                if (cboxA2.Checked)
                    ehliyetBilgisi = ehliyetBilgisi + " A2 ";
                if (cboxB.Checked)
                    ehliyetBilgisi = ehliyetBilgisi + " B ";
                if (cboxC.Checked)
                    ehliyetBilgisi = ehliyetBilgisi + " C ";
                if (cboxD.Checked)
                    ehliyetBilgisi = ehliyetBilgisi + " D ";
                if (cboxE.Checked)
                    ehliyetBilgisi = ehliyetBilgisi + " E ";

                SqlCommand cmd = new SqlCommand("update PersonelBilgileri set TCKimlikNo=@TcKimlikNo,Ad=@Ad,Soyad=@Soyad,Unvan=@Unvan,Cinsiyet=@Cinsiyet,MedeniHali=@MedeniHal,DogumTarihi=@DogumTarihi,IseGirisTarihi=@IseGirisTarihi,Telefon=@Telefon,[E-Posta]=@Eposta,Adres=@Adres,Ehliyet=@Ehliyet where TCKimlikNo=@SeciliTC", _cnn);

                cmd.Parameters.AddWithValue("@SeciliTC", seciliTc);
                cmd.Parameters.AddWithValue("@TcKimlikNo", Convert.ToInt64(txtTcKimlikNo.Text));
                cmd.Parameters.AddWithValue("@Ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@Unvan", txtUnvan.Text);
                cmd.Parameters.AddWithValue("@Cinsiyet", seciliCinsiyet);
                cmd.Parameters.AddWithValue("@MedeniHal", medeniHal);
                cmd.Parameters.AddWithValue("@DogumTarihi", dtpDogumTarihi.Value);
                cmd.Parameters.AddWithValue("@IseGirisTarihi", dtpIseGiris.Value);
                cmd.Parameters.AddWithValue("@Telefon", mtxtTelefon.Text);
                cmd.Parameters.AddWithValue("@Eposta", txtEPosta.Text);
                cmd.Parameters.AddWithValue("@Adres", txtAdres.Text);
                cmd.Parameters.AddWithValue("@Ehliyet", ehliyetBilgisi);

                try
                {
                    if (_cnn.State != ConnectionState.Open)
                    {
                        _cnn.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Aynı \"Kimlik Numarasında\" yeni kayıt oluşturulamaz");
                    return;
                }
                finally
                {
                    ListeGuncelle(null, null);
                    _cnn.Close();
                }
            }
        }
        private void ListeGuncelle(object sender, EventArgs e)
        {
            lvPersonelListesi.Items.Clear();

            SqlCommand cmd = new SqlCommand("select * from PersonelBilgileri", _cnn);

            if (_cnn.State != ConnectionState.Open)
            {
                _cnn.Open();
            }
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        ListViewItem item = new ListViewItem(rd["TCKimlikNo"].ToString());
                        item.SubItems.Add(rd["Ad"].ToString());
                        item.SubItems.Add(rd["Soyad"].ToString());
                        item.SubItems.Add(rd["IseGirisTarihi"].ToString());
                        item.SubItems.Add(rd["Telefon"].ToString());
                        item.SubItems.Add(rd["E-Posta"].ToString());
                        item.SubItems.Add(rd["MedeniHali"].ToString());
                        item.SubItems.Add(rd["Ehliyet"].ToString());
                        lvPersonelListesi.Items.Add(item);
                    }
                    rd.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database'den veri alınırken bir hata oluştu");
            }
            finally
            {
                _cnn.Close();
            }
        }
        private void BilgileriTemizle(object sender, EventArgs e)
        {
            txtTcKimlikNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtAdres.Clear();
            txtEPosta.Clear();
            txtUnvan.Clear();
            mtxtTelefon.Clear();
            dtpDogumTarihi.ResetText();
            dtpIseGiris.ResetText();
            rbtnErkek.Checked = false;
            rbtnKadin.Checked = false;
            rbtnEvli.Checked = false;
            rbtnBekar.Checked = false;
            cboxA1.Checked = false;
            cboxA2.Checked = false;
            cboxB.Checked = false;
            cboxC.Checked = false;
            cboxD.Checked = false;
            cboxE.Checked = false;
            dtpDogumTarihi.Value = DateTime.Now.AddYears(-20);
            dtpIseGiris.Value = DateTime.Now;
        }
        private void ResimSecveGoster(object sender,EventArgs e)
        {
            OpenFileDialog ResimSecimi = new OpenFileDialog();
            ResimSecimi.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ResimSecimi.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;*.pgn)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (ResimSecimi.ShowDialog() == DialogResult.OK)
            {
                picBoxAvatar.Image = new Bitmap(ResimSecimi.FileName);
            }
        }
        private void ResimTemizle(object sender, EventArgs e)
        {
            picBoxAvatar.Image = picBoxAvatar.InitialImage;
        }
        private void txtTcKimlikNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void mtxtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtTcKimlikNo_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider1.Clear();
        }
        private void txtAd_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider2.Clear();
        }

        private void txtSoyad_KeyDown(object sender, KeyEventArgs e)
        {
            errorProvider3.Clear();
        }


        //private void SqlResimEkle(object sender, EventArgs e)

        //{
        //    OpenFileDialog ResimSecimi = new OpenFileDialog();
        //    ResimSecimi.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //    ResimSecimi.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;*.pgn)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
        //    if (ResimSecimi.ShowDialog() == DialogResult.OK)
        //    {
        //        picBoxAvatar.Image = new Bitmap(ResimSecimi.FileName);

        //        //textBox1.Text = ResimSecimi.FileName;
        //    }

        //    if (picBoxAvatar.ImageLocation != null)       // dosya var mı
        //    {
        //        byte[] ImageByteArray = File.ReadAllBytes(picBoxAvatar.ImageLocation.ToString());

        //        SqlCommand cmd = new SqlCommand("update PersonelBilgileri set Fotograf=@GidenImage where TCKimlikNo=@SeciliTC", _cnn);

        //        cmd.Parameters.AddWithValue("@GidenImage", ImageByteArray);
        //        cmd.Parameters.AddWithValue("@SeciliTC", txtTcKimlikNo.Text);

        //        if (_cnn.State != ConnectionState.Open)
        //        {
        //            _cnn.Open();
        //        }
        //        try
        //        {
        //            cmd.ExecuteNonQuery();
        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show("Resim yükelnirken hata oluştu");
        //        }
        //        finally
        //        {
        //            _cnn.Close();
        //        }
        //    }
        //}


    }
}
