//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineCourse
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kurs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kurs()
        {
            this.Kategori = new HashSet<Kategori>();
            this.Materyaller = new HashSet<Materyaller>();
        }
    
        public int Krsid { get; set; }
        public string Krsadi { get; set; }
        public string Krsicerik { get; set; }
        public Nullable<System.DateTime> Krstrh { get; set; }
        public Nullable<int> Eid { get; set; }
    
        public virtual Egitmen Egitmen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kategori> Kategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materyaller> Materyaller { get; set; }
    }
}