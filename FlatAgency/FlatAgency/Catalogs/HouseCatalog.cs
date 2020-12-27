using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using FlatAgency.Models;

namespace FlatAgency.Catalogs
{
    [DataContract]
    public class BrochureCatalog
    {
        [DataMember]
        public List<Brochure> Houses { get; set; } = new List<Brochure>();

        public void DisplayHouses()
        {
            foreach (Brochure b in Houses)
            {
                Console.WriteLine(b);
            }
        }
    }
}