//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eksin_EczaneOtomasyonProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calisanlar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Calisanlar()
        {
            this.Satislar = new HashSet<Satislar>();
        }
    
        public int CalisanID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Unvan { get; set; }
        public string KimlikNo { get; set; }
        public Nullable<bool> Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string E_Posta { get; set; }
        public string ErisimSeviyesi { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satislar> Satislar { get; set; }
    }
}
