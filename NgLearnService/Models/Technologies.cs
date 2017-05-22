using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechnologiesDataAccess;
using System.Runtime.Serialization;

namespace NgLearnService.Models
{
    [KnownType(typeof(List<Subjects>))]
    [DataContract]
    public class Technologies
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string domain { get; set; }
        [DataMember]
        public List<Subjects> subjects { get; set; }
    }
}