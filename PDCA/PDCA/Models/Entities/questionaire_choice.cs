//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDCA.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class questionaire_choice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public questionaire_choice()
        {
            this.questionaire_ans_point = new HashSet<questionaire_ans_point>();
        }
    
        public long id { get; set; }
        public int questionaire { get; set; }
        public int no { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    
        public virtual questionaire questionaire1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<questionaire_ans_point> questionaire_ans_point { get; set; }
    }
}