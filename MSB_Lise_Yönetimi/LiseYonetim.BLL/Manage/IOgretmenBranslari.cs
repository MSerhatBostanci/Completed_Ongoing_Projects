using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    interface IOgretmenBranslari
    {

        string OgretmenBransKaydet(string bransAdi);
        string OgretmenBransGuncelle(int bransID, string bransAdi);
        List<OgretmenBranslari> OgretmenBransListesi();
      
    }
}
