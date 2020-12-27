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
    public class BookCatalog
    {
        [DataMember]
        public List<Book> Flats { get; set; } = new List<Book>();

        public void DisplayFlats()
        {
            foreach (Book b in Flats)
            {
                Console.WriteLine(b);
            }
        }

    }
}
