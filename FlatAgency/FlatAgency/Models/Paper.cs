using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FlatAgency.Models
{
    [DataContract]
    public class Paper
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public double Price { get; set; }

    }
}
