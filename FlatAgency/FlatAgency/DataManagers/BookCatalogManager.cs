using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.Catalogs;
using FlatAgency.Models;
using System.Runtime.Serialization.Json;
using System.IO;
using FlatAgency.Exceptions;

namespace FlatAgency.DataManagers
{
    class BookCatalogManager
    {
        public BookCatalog BookCatalog = new BookCatalog();
        string path = @"..\..\Data\flats.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(BookCatalog));

        public BookCatalogManager()
        {
            LoadData();
        }
       
        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write))
            {
                serializer.WriteObject(fs, BookCatalog);
            }
        }

        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BookCatalog = (BookCatalog)serializer.ReadObject(fs);
            }
        }

        public void AddFlat()
        {
            Book buf = new Book();

            try
            {
                Console.WriteLine("Введите имя книг: ");
                buf.Name = Console.ReadLine();

                Console.WriteLine("Введите цену книги: ");
                buf.Price = Double.Parse(Console.ReadLine());

                Console.WriteLine("Введите автора книги: ");
                buf.Author = Console.ReadLine();

                BookCatalog.Flats.Add(buf);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            SaveData();
        }
    }
}
