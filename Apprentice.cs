//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF_DataFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apprentice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Apprentice()
        {
            this.CourseSelects = new HashSet<CourseSelect>();
        }
    
        public long ApprenticeID { get; set; }
        public Nullable<long> ApprenticeCode { get; set; }
        public string ApprenticeName { get; set; }
        public string ApprenticeFamily { get; set; }
        public Nullable<byte> ApprenticeAge { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSelect> CourseSelects { get; set; }
    }
}
