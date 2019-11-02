using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    interface IOgrenciDersleri
    {
        string OgrenciDersleriKaydet(int ogrenciID,int dersID);
        string OgrenciDersleriGuncelle(int ogrenciDersleriID, int ogrenciID, int dersID);

        List<OgrenciDersleri> OgrenciDersleriListesi();
    }
}
