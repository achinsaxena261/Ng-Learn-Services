using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace NgLearnService.Models
{
    [DataContract]
    public class Users
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string gender { get; set; }
        [DataMember]
        public string img { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string pwd { get; set; }
    }
}