using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiseYonetim.DLL;

namespace LiseYonetim.BLL.Manage
{
    public class Ogretmen_Manage : IOgretmenler, IOgretmenBilgileri, IOgretmenBranslari, IOgretmenDevamsizlik, IOgretmenDisiplin, IOgretmenDersleri
    {
        Lise_Yönetim_DBEntities DB = new Lise_Yönetim_DBEntities();
        public string OgretmenBilgileriGuncelle(int ogretmenID, string ogretmenTelefonu, string ogretmenMailAdresi, string ogretmenEvAdresi, DateTime ogretmenDogumTarihi, bool ogretmenMedeniDurum)
        {
            try
            {
                var secimOgretmen = DB.OgretmenBilgileri.SingleOrDefault(o => o.OgretmenID == ogretmenID);
                if (secimOgretmen != null)
                {
                    secimOgretmen.OgretmenTelefonu = ogretmenTelefonu;
                    secimOgretmen.OgretmenMailAdresi = ogretmenMailAdresi;
                    secimOgretmen.OgretmenEvAdresi = ogretmenEvAdresi;
                    secimOgretmen.OgretmenDogumTarihi = ogretmenDogumTarihi;
                    secimOgretmen.OgretmenMedeniDurum = ogretmenMedeniDurum;
                    DB.SaveChanges();
                }
                else
                {
                    OgretmenBilgileri yeniOgretmenBilgileri = new OgretmenBilgileri();
                    yeniOgretmenBilgileri.OgretmenID = ogretmenID;
                    yeniOgretmenBilgileri.OgretmenTelefonu = ogretmenTelefonu;
                    yeniOgretmenBilgileri.OgretmenMailAdresi = ogretmenMailAdresi;
                    yeniOgretmenBilgileri.OgretmenEvAdresi = ogretmenEvAdresi;
                    yeniOgretmenBilgileri.OgretmenDogumTarihi = ogretmenDogumTarihi;
                    yeniOgretmenBilgileri.OgretmenMedeniDurum = ogretmenMedeniDurum;
                    DB.OgretmenBilgileri.Add(yeniOgretmenBilgileri);
                    DB.SaveChanges();
                }
                return "Bu kayıtta öğretmen bilgileri bulunamadı";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string OgretmenBilgileriKaydet(string ogretmenTelefonu, string ogretmenMailAdresi, string ogretmenEvAdresi, DateTime ogretmenDogumTarihi, bool ogretmenMedeniDurum)
        {
            try
            {
                var varmiTC = 1;
                if (varmiTC == null)
                {
                    OgretmenBilgileri yeniOgretmenBilgileri = new OgretmenBilgileri();
                    yeniOgretmenBilgileri.OgretmenTelefonu = ogretmenTelefonu;
                    yeniOgretmenBilgileri.OgretmenMailAdresi = ogretmenMailAdresi;
                    yeniOgretmenBilgileri.OgretmenEvAdresi = ogretmenEvAdresi;
                    yeniOgretmenBilgileri.OgretmenDogumTarihi = ogretmenDogumTarihi;
                    yeniOgretmenBilgileri.OgretmenMedeniDurum = ogretmenMedeniDurum;
                    DB.OgretmenBilgileri.Add(yeniOgretmenBilgileri);
                    DB.SaveChanges();
                }
                return "Bu Kimlik Numarasına sahip öğretmen mevcut";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string OgretmenBilgileriSil(int ogretmenID)
        {
            try
            {
                int seciliogretmenID = ogretmenID;
                var seciliOgretmen = DB.OgretmenBilgileri.FirstOrDefault(o => o.OgretmenID == seciliogretmenID);
                if (seciliOgretmen != null)
                {
                    DB.OgretmenBilgileri.Remove(seciliOgretmen);
                    DB.SaveChanges();
                }
                return "Böyle bir Öğretmen bulunamadı";
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public OgretmenBilgileri SeciliOgretmenBilgileriniGetir(int ogretmenID)
        {
            OgretmenBilgileri seciliOgretmen = DB.OgretmenBilgileri.SingleOrDefault(ob => ob.OgretmenID == ogretmenID);

            return seciliOgretmen;

        }
        public List<OgretmenBilgileri> OgretmenBilgileriListesi()
        {
            return DB.OgretmenBilgileri.ToList();
        }

        public string OgretmenBransGuncelle(int bransID, string bransAdi)
        {
            throw new NotImplementedException();
        }

        public string OgretmenBransKaydet(string bransAdi)
        {
            throw new NotImplementedException();
        }

        public List<OgretmenBranslari> OgretmenBransListesi()
        {
            throw new NotImplementedException();
        }

        public string OgretmenDersleriGuncelle(int ogretmenDersleriID, int ogretmenID, int dersID)
        {
            throw new NotImplementedException();
        }

        public string OgretmenDersleriKaydet(int ogretmenID, int dersID)
        {
            throw new NotImplementedException();
        }

        public List<OgretmenDersleri> OgretmenDersleriListesi()
        {
            throw new NotImplementedException();
        }

        public string OgretmenDevamsizlikGuncelle(int ogretmenDevamsizlikID, int ogretmenID, DateTime OgretmenDevamsizlikTarihi, string ogretmenDevamsizlikMazereti, bool RaporDurumu)
        {
            throw new NotImplementedException();
        }

        public string OgretmenDevamsizlikKaydet(int ogretmenID, DateTime OgretmenDevamsizlikTarihi, string ogretmenDevamsizlikMazereti, bool RaporDurumu)
        {
            throw new NotImplementedException();
        }

        public List<OgretmenDevamsizlik> OgretmenDevamsizlikListesi()
        {
            throw new NotImplementedException();
        }

        public string OgretmenDisiplinGuncelle(int ogretmenDisiplinID, int ogretmenID, string ogretmenDisiplinSebebi)
        {
            throw new NotImplementedException();
        }

        public string OgretmenDisiplinKaydet(int ogtretmenID, string ogretmenDisiplinSebebi)
        {
            throw new NotImplementedException();
        }

        public List<OgretmenDisiplinKayitlari> OgretmenDisiplinListesi()
        {
            throw new NotImplementedException();
        }

        public string OgretmenGuncelle(int ogretmenID, string ogretmenAdi, string ogretmenSoyadi, string ogretmenKimlikNo, int ogretmenBrans, int kullaniciID)
        {
            try
            {
                var secimOgretmen = DB.Ogretmenler.SingleOrDefault(o => o.OgretmenID == ogretmenID);
                if (secimOgretmen != null)
                {
                    secimOgretmen.OgretmenAdi = ogretmenAdi;
                    secimOgretmen.OgretmenSoyadi = ogretmenSoyadi;
                    secimOgretmen.OgretmenKimlikNo = ogretmenKimlikNo;
                    secimOgretmen.OgretmenBrans = ogretmenBrans;
                    secimOgretmen.KullaniciID = kullaniciID;
                    DB.SaveChanges();
                }
                return "Bu kayıtta öğretmen bulunamadı";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string OgretmenKaydet(string ogretmenAdi, string ogretmenSoyadi, string ogretmenKimlikNo, int ogretmenBrans, int kullaniciID)
        {
            try
            {
                var varmiTC = DB.Ogretmenler.FirstOrDefault(k => k.OgretmenKimlikNo == ogretmenKimlikNo);
                if (varmiTC == null)
                {
                    Ogretmenler yeniOgretmen = new Ogretmenler();
                    yeniOgretmen.OgretmenAdi = ogretmenAdi;
                    yeniOgretmen.OgretmenSoyadi = ogretmenSoyadi;
                    yeniOgretmen.OgretmenKimlikNo = ogretmenKimlikNo;
                    yeniOgretmen.OgretmenBrans = ogretmenBrans;
                    yeniOgretmen.KullaniciID = kullaniciID;
                    DB.Ogretmenler.Add(yeniOgretmen);
                    DB.SaveChanges();
                }
                return "Bu Kimlik Numarasına sahip öğretmen mevcut";
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public List<Ogretmenler> OgretmenlerListesi()
        {
            return DB.Ogretmenler.ToList();
        }

        public string OgretmenSil(int ogretmenID)
        {
            try
            {
                int seciliogretmenID = Convert.ToInt32(ogretmenID);
                var seciliOgretmen = DB.Ogretmenler.SingleOrDefault(o => o.OgretmenID == seciliogretmenID);
                if (seciliOgretmen != null)
                {
                    DB.Ogretmenler.Remove(seciliOgretmen);
                    DB.SaveChanges();
                }
                return "Böyle bir Öğretmen bulunamadı";
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        
    }
}
