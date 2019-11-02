using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    interface IOgretmenDersleri
    {

        string OgretmenDersleriKaydet(int ogretmenID,int dersID);
        string OgretmenDersleriGuncelle(int ogretmenDersleriID, int ogretmenID, int dersID);

        List<OgretmenDersleri> OgretmenDersleriListesi();

    }
}
