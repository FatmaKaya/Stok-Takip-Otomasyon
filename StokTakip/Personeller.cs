//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StokTakip
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personeller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personeller()
        {
            this.Odalars = new HashSet<Odalar>();
        }
    
        public int PersonelID { get; set; }
        public string PersonelAdi { get; set; }
        public Nullable<int> YetkiID { get; set; }
        public string Sifre { get; set; }
        public int FakulteID { get; set; }
        public int DepartmanID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odalar> Odalars { get; set; }
        public virtual Departmanlar Departmanlar { get; set; }
        public virtual Fakulteler Fakulteler { get; set; }
    }
}
