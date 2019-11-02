using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    interface IOgretmenDevamsizlik
    {
        string OgretmenDevamsizlikKaydet(int ogretmenID, DateTime OgretmenDevamsizlikTarihi, string ogretmenDevamsizlikMazereti, bool RaporDurumu);
        string OgretmenDevamsizlikGuncelle(int ogretmenDevamsizlikID, int ogretmenID, DateTime OgretmenDevamsizlikTarihi, string ogretmenDevamsizlikMazereti, bool RaporDurumu);

        List<OgretmenDevamsizlik> OgretmenDevamsizlikListesi();
    }
}
