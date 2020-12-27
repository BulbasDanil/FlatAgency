using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.Models;
using System.Runtime.Serialization;

namespace FlatAgency.Models
{
    [DataContract]
    public class Book : Paper
    {
        [DataMember]
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Name,10} {Author,10} {Price,10}";
        }
    }
}
