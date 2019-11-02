using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    class Ogrenci_Manage : IOgrenciler, IOgrenciBilgileri, IOgrenciDevamsizlik, IOgrenciDersleri, IOgrenciDisiplin, IOgrenciSinavlari
    {
        public string OgrenciBilgileriGuncelle(int ogrenciID, string ogrenciTelefonu, string ogrenciMailAdresi, string ogrenciEvAdresi, string ogrenciVeliAdiSoyadi, string ogrenciVeliTelefonu, string ogrenciVeli2AdiSoyadi, string ogrenciVeli2Telefonu, DateTime ogrenciDogumTarihi)
        {
            throw new NotImplementedException();
        }

        public string OgrenciBilgileriKaydet(string ogrenciTelefonu, string ogrenciMailAdresi, string ogrenciEvAdresi, string ogrenciVeliAdiSoyadi, string ogrenciVeliTelefonu, string ogrenciVeli2AdiSoyadi, string ogrenciVeli2Telefonu, DateTime ogrenciDogumTarihi)
        {
            throw new NotImplementedException();
        }

        public List<OgrenciBilgileri> OgrenciBilgileriListesi()
        {
            throw new NotImplementedException();
        }

        public string OgrenciDersleriGuncelle(int ogrenciDersleriID, int ogrenciID, int dersID)
        {
            throw new NotImplementedException();
        }

        public string OgrenciDersleriKaydet(int ogrenciID, int dersID)
        {
            throw new NotImplementedException();
        }

        public List<OgrenciDersleri> OgrenciDersleriListesi()
        {
            throw new NotImplementedException();
        }

        public string OgrenciDevamsizlikGuncelle(int ogrenciDevamsizlikID, int ogrenciID, DateTime ogrenciDevamsizlikTarihi, string ogrenciDevamsizikMazereti, bool raporBilgisi, bool veliBilgilendirilmesi)
        {
            throw new NotImplementedException();
        }

        public string OgrenciDevamsizlikKaydet(int ogrenciID, DateTime ogrenciDevamsizlikTarihi, string ogrenciDevamsizikMazereti, bool raporBilgisi, bool veliBilgilendirilmesi)
        {
            throw new NotImplementedException();
        }

        public List<OgrenciDevamsizlik> OgrenciDevamsizlikListesi()
        {
            throw new NotImplementedException();
        }

        public string OgrenciDisiplinGuncelle(int ogrenciDisiplinID, int ogrenciID, string ogrenciDisiplinSebebi, int ogrenciDisiplinSorumluOgretmen)
        {
            throw new NotImplementedException();
        }

        public string OgrenciDisiplinKaydet(int ogrenciID, string ogrenciDisiplinSebebi, int ogrenciDisiplinSorumluOgretmen)
        {
            throw new NotImplementedException();
        }

        public List<OgrenciDisiplinKayitlari> OgrenciDisiplinListesi()
        {
            throw new NotImplementedException();
        }

        public string OgrencilerGuncelle(int ogrenciID, string ogrenciAdi, string ogrenciSoyadi, string ogrenciKimlikNo, int kullaniciID)
        {
            throw new NotImplementedException();
        }

        public string OgrencilerKaydet(string ogrenciAdi, string ogrenciSoyadi, string ogrenciKimlikNo, int kullaniciID)
        {
            throw new NotImplementedException();
        }

        public List<Ogrenciler> OgrencilerListesi()
        {
            throw new NotImplementedException();
        }

        public string OgrenciSinavlariGuncelle(int ogrenciSinavlariID, int ogrenciID, int ogrenciSinavNotu, int ogrenciSinavlariKullaniciID)
        {
            throw new NotImplementedException();
        }

        public string OgrenciSinavlariKaydet(int ogrenciID, int ogrenciSinavNotu, int ogrenciSinavlariKullaniciID)
        {
            throw new NotImplementedException();
        }

        public List<OgrenciSinavlari> OgrenciSinavlariListesi()
        {
            throw new NotImplementedException();
        }
    }
}
