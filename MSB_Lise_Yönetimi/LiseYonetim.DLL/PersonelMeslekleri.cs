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
    
    public partial class PersonelMeslekleri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonelMeslekleri()
        {
            this.Personeller = new HashSet<Personeller>();
        }
    
        public int MeslekID { get; set; }
        public string MeslekAdi { get; set; }
        public string MeslekAçiklamasi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personeller> Personeller { get; set; }
    }
}
