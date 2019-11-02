using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    interface IOgrenciDisiplin
    {
        string OgrenciDisiplinKaydet(int ogrenciID,string ogrenciDisiplinSebebi,int ogrenciDisiplinSorumluOgretmen);
        string OgrenciDisiplinGuncelle(int ogrenciDisiplinID, int ogrenciID, string ogrenciDisiplinSebebi, int ogrenciDisiplinSorumluOgretmen);

        List<OgrenciDisiplinKayitlari> OgrenciDisiplinListesi();
    }
}
