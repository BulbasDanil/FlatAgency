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
    class HouseCatalogManager
    {
        public BrochureCatalog BrochureCatalog = new BrochureCatalog();
        string path = @"..\..\Data\houses.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(BrochureCatalog));

        public HouseCatalogManager()
        {
            LoadData();
        }

        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write))
            {
                serializer.WriteObject(fs, BrochureCatalog);
            }
        }

        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                BrochureCatalog = (BrochureCatalog)serializer.ReadObject(fs);
            }
        }

        public void AddHouse()
        {
            Brochure buf = new Brochure();

            try
            {
                Console.WriteLine("Введите имя брошюры: ");
                buf.Name = Console.ReadLine();

                Console.WriteLine("Введите цену брошюры: ");
                buf.Price = Double.Parse(Console.ReadLine());

                Console.WriteLine("Введите компанию-автора брошюры: ");
                buf.Company = Console.ReadLine();

                BrochureCatalog.Houses.Add(buf);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            SaveData();
        }
    }
}