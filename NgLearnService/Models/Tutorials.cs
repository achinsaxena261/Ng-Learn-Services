using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace NgLearnService.Models
{
    [DataContract]
    public class Tutorials
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public int subid { get; set; }
    }
}