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
    
    public partial class Materyaller
    {
        public int Mid { get; set; }
        public string Madi { get; set; }
        public string Micerik { get; set; }
        public Nullable<System.DateTime> Mtrh { get; set; }
        public Nullable<int> Krsid { get; set; }
        public Nullable<int> Eid { get; set; }
    
        public virtual Egitmen Egitmen { get; set; }
        public virtual Kurs Kurs { get; set; }
    }
}
