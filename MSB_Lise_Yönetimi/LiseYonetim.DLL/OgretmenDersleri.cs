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
    
    public partial class OgretmenDersleri
    {
        public int OgretmenDersleriID { get; set; }
        public int OgretmenID { get; set; }
        public Nullable<int> DersID { get; set; }
    
        public virtual Dersler Dersler { get; set; }
        public virtual Ogretmenler Ogretmenler { get; set; }
    }
}
