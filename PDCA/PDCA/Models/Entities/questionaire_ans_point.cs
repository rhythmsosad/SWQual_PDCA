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
    
    public partial class questionaire_ans_point
    {
        public long answer_id { get; set; }
        public long choice_id { get; set; }
        public int answer_point { get; set; }
    
        public virtual questionaire_ans questionaire_ans { get; set; }
        public virtual questionaire_choice questionaire_choice { get; set; }
    }
}