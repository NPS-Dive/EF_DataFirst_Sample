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
    
    public partial class CourseSelect
    {
        public long CoSeID { get; set; }
        public string CoSeDate { get; set; }
        public Nullable<decimal> CoseScore { get; set; }
        public Nullable<long> FK_ApprenticeID { get; set; }
        public Nullable<int> FK_CourseID { get; set; }
    
        public virtual Apprentice Apprentice { get; set; }
        public virtual Course Course { get; set; }
    }
}