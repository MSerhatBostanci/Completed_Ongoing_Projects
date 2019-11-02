using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiseYonetim.BLL.Manage;
using LiseYonetim.DLL;

namespace LiseYonetim.UI
{
    public partial class FrmOgretmenListesi : Form
    {
        public FrmOgretmenListesi()
        {
            InitializeComponent();
        }


        Ogretmen_Manage ogrt = new Ogretmen_Manage();
        int seciliogretmenID;

        private void FrmOgretmenListesi_Load(object sender, EventArgs e)
        {
            dgvOgretmenlerListesi.DataSource = ogrt.OgretmenlerListesi();
            KolonlariGizle();
        }

        public void KolonlariGizle()
        {
            dgvOgretmenlerListesi.Columns["OgretmenDevamsizlik"].Visible = false;
            dgvOgretmenlerListesi.Columns["OgretmenBranslari"].Visible = false;
            dgvOgretmenlerListesi.Columns["OgretmenBilgileri"].Visible = false;
            dgvOgretmenlerListesi.Columns["OgretmenDisiplinKayitlari"].Visible = false;
            dgvOgretmenlerListesi.Columns["OgrenciDisiplinKayitlari"].Visible = false;
            dgvOgretmenlerListesi.Columns["Kullanicilar"].Visible = false;
            dgvOgretmenlerListesi.Columns["OgretmenDersleri"].Visible = false;
        }

        private void DataGridGuncelle()
        {
            dgvOgretmenlerListesi.DataSource = null;
            dgvOgretmenlerListesi.DataSource = ogrt.OgretmenlerListesi();
            KolonlariGizle();
        }

        private void tsbYeniOgretmenKaydet_Click(object sender, EventArgs e)
        {
            ogrt.OgretmenKaydet(txtOgretmenAdi.Text, txtOgretmenSoyadi.Text, txtOgretmenKimlikNo.Text, Convert.ToInt32(txtOgretmenBransKodu.Text), Convert.ToInt32(txtOgretmenKullaniciKodu.Text));

            DataGridGuncelle();
        }

        private void tsbMuvcutOgretmeniGuncelle_Click(object sender, EventArgs e)
        {
            seciliogretmenID = Convert.ToInt32(dgvOgretmenlerListesi.CurrentRow.Cells[0].Value);

            ogrt.OgretmenGuncelle(seciliogretmenID, txtOgretmenAdi.Text, txtOgretmenSoyadi.Text, txtOgretmenKimlikNo.Text, Convert.ToInt32(txtOgretmenBransKodu.Text), Convert.ToInt32(txtOgretmenKullaniciKodu.Text));

            DataGridGuncelle();
        }

        private void tsbMevcutOgretmeniSil_Click(object sender, EventArgs e)
        {
            ogrt.OgretmenBilgileriSil(seciliogretmenID);

            ogrt.OgretmenSil(seciliogretmenID);

            DataGridGuncelle();
        }


        private void dgvOgretmenlerListesi_SelectionChanged(object sender, EventArgs e)
        {
            seciliogretmenID = Convert.ToInt32(dgvOgretmenlerListesi.CurrentRow.Cells[0].Value);
            try
            {
                txtOgretmenID.Text = seciliogretmenID.ToString();
            }
            catch (Exception){}
            try
            {
                txtOgretmenAdi.Text = dgvOgretmenlerListesi.CurrentRow.Cells[1].Value.ToString();
            }catch (Exception){}
            try
            {
                txtOgretmenSoyadi.Text = dgvOgretmenlerListesi.CurrentRow.Cells[2].Value.ToString();
            }catch (Exception){}
            try
            {
                txtOgretmenKimlikNo.Text = dgvOgretmenlerListesi.CurrentRow.Cells[3].Value.ToString();

            }catch (Exception){}
            try
            {
                txtOgretmenBransKodu.Text = dgvOgretmenlerListesi.CurrentRow.Cells[4].Value.ToString();

            }catch (Exception){}
            try
            {
                txtOgretmenKullaniciKodu.Text = dgvOgretmenlerListesi.CurrentRow.Cells[5].Value.ToString();

            } catch (Exception){}
        }
    }
}
