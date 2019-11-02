using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    interface IOgrenciBilgileri
    {

        string OgrenciBilgileriKaydet(string ogrenciTelefonu,string ogrenciMailAdresi, string ogrenciEvAdresi, string ogrenciVeliAdiSoyadi, string ogrenciVeliTelefonu, string ogrenciVeli2AdiSoyadi, string ogrenciVeli2Telefonu, DateTime ogrenciDogumTarihi);
        string OgrenciBilgileriGuncelle(int ogrenciID, string ogrenciTelefonu, string ogrenciMailAdresi, string ogrenciEvAdresi, string ogrenciVeliAdiSoyadi, string ogrenciVeliTelefonu, string ogrenciVeli2AdiSoyadi, string ogrenciVeli2Telefonu, DateTime ogrenciDogumTarihi);

        List<OgrenciBilgileri> OgrenciBilgileriListesi();
    }
}
