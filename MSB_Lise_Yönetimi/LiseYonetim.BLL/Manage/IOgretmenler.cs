using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    interface IOgretmenler
    {
        string OgretmenKaydet(string ogretmenAdi,string ogretmenSoyadi,string ogretmenKimlikNo,int ogretmenBrans,int kullaniciID);
        string OgretmenGuncelle(int ogretmenID,string ogretmenAdi, string ogretmenSoyadi, string ogretmenKimlikNo, int ogretmenBrans, int kullaniciID);
        string OgretmenSil(int ogretmenID);
        List<Ogretmenler> OgretmenlerListesi();
    }
}
