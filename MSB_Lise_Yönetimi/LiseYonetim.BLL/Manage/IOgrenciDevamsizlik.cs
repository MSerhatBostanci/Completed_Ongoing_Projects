using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    interface IOgrenciDevamsizlik
    {
        string OgrenciDevamsizlikKaydet(int ogrenciID,DateTime ogrenciDevamsizlikTarihi,string ogrenciDevamsizikMazereti,bool raporBilgisi, bool veliBilgilendirilmesi);
        string OgrenciDevamsizlikGuncelle(int ogrenciDevamsizlikID, int ogrenciID, DateTime ogrenciDevamsizlikTarihi, string ogrenciDevamsizikMazereti, bool raporBilgisi, bool veliBilgilendirilmesi);

        List<OgrenciDevamsizlik> OgrenciDevamsizlikListesi();
    }
}
