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
    
    public partial class Bolumler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bolumler()
        {
            this.Siniflar = new HashSet<Siniflar>();
        }
    
        public int BolumID { get; set; }
        public string BolumAdi { get; set; }
        public string BolumAciklama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siniflar> Siniflar { get; set; }
    }
}
