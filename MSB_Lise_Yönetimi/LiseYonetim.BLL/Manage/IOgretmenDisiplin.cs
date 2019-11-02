using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    interface IOgretmenDisiplin
    {

        string OgretmenDisiplinKaydet(int ogtretmenID,string ogretmenDisiplinSebebi);
        string OgretmenDisiplinGuncelle(int ogretmenDisiplinID, int ogretmenID, string ogretmenDisiplinSebebi);

        List<OgretmenDisiplinKayitlari> OgretmenDisiplinListesi();
    }
}
