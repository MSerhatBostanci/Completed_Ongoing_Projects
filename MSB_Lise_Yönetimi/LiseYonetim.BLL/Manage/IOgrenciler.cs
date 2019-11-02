using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    interface IOgrenciler
    {
        string OgrencilerKaydet(string ogrenciAdi,string ogrenciSoyadi,string ogrenciKimlikNo,int kullaniciID);
        string OgrencilerGuncelle(int ogrenciID, string ogrenciAdi, string ogrenciSoyadi, string ogrenciKimlikNo, int kullaniciID);

        List<Ogrenciler> OgrencilerListesi();
    }
}
