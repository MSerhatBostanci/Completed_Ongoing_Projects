//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LiseYonetim.DLL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personeller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personeller()
        {
            this.Duyurular = new HashSet<Duyurular>();
            this.PersonelDevamsizlik = new HashSet<PersonelDevamsizlik>();
        }
    
        public int PersonelID { get; set; }
        public string PersonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
        public string PersonelKimlikNo { get; set; }
        public int PersonelMeslekID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Duyurular> Duyurular { get; set; }
        public virtual PersonelBilgileri PersonelBilgileri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonelDevamsizlik> PersonelDevamsizlik { get; set; }
        public virtual PersonelMeslekleri PersonelMeslekleri { get; set; }
    }
}
