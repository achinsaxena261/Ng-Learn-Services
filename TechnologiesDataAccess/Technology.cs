//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnologiesDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Technology
    {
        public Technology()
        {
            this.Subjects = new HashSet<Subject>();
        }
    
        public int id { get; set; }
        public string domain { get; set; }
    
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
