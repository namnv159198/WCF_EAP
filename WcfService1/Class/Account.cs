using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService1.Class
{
    [DataContract]
    public class Account
    {
        [DataMember]
        public int Code { get; set; }
        [DataMember]
        public string pass { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public decimal Blance { get; set; }

    }
}