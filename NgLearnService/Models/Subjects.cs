using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace NgLearnService.Models
{
    [DataContract]
    public class Subjects
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string subject { get; set; }
        [DataMember]
        public int techid { get; set; }
    }
}