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
    
    public partial class Subject
    {
        public Subject()
        {
            this.Tutorials = new HashSet<Tutorial>();
        }
    
        public int id { get; set; }
        public string subject1 { get; set; }
        public int techid { get; set; }
    
        public virtual Technology Technology { get; set; }
        public virtual ICollection<Tutorial> Tutorials { get; set; }
    }
}
