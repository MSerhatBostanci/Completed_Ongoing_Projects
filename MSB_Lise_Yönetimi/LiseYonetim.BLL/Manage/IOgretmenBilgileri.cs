using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    interface IOgretmenBilgileri
    {
        string OgretmenBilgileriKaydet(string ogretmenTelefonu,string ogretmenMailAdresi,string ogretmenEvAdresi,DateTime ogretmenDogumTarihi,bool ogretmenMedeniDurum);
        string OgretmenBilgileriGuncelle(int ogretmenID,string ogretmenTelefonu, string ogretmenMailAdresi, string ogretmenEvAdresi, DateTime ogretmenDogumTarihi, bool ogretmenMedeniDurum);

        List<OgretmenBilgileri> OgretmenBilgileriListesi();
    }
}
