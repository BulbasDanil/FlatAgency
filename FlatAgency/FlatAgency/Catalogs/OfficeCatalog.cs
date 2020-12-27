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
    public class JournalCatalog
    {
        [DataMember]
        public List<Journal> Offices { get; set; } = new List<Journal>();

        public void DisplayOffices()
        {
            foreach (Journal j in Offices)
            {
                Console.WriteLine(j);
            }
        }
    }
}