using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    interface IOgrenciSinavlari
    {
        string OgrenciSinavlariKaydet(int ogrenciID,int ogrenciSinavNotu,int ogrenciSinavlariKullaniciID);
        string OgrenciSinavlariGuncelle(int ogrenciSinavlariID, int ogrenciID, int ogrenciSinavNotu, int ogrenciSinavlariKullaniciID);

        List<OgrenciSinavlari> OgrenciSinavlariListesi();
    }
}
