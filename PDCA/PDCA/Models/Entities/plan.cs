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
    
    public partial class plan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public plan()
        {
            this.questionaire = new HashSet<questionaire>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string problem { get; set; }
        public string objective { get; set; }
        public string steps { get; set; }
        public int owner_id { get; set; }
    
        public virtual auth_user auth_user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<questionaire> questionaire { get; set; }
    }
}