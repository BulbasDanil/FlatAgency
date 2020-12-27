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
    class OfficeCatalogManager
    {
        public JournalCatalog JournalCatalog = new JournalCatalog();
        string path = @"..\..\Data\offices.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(JournalCatalog));

        public OfficeCatalogManager()
        {
            LoadData();
        }

        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write))
            {
                serializer.WriteObject(fs, JournalCatalog);
            }
        }

        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                JournalCatalog = (JournalCatalog)serializer.ReadObject(fs);
            }
        }

        public void AddOffice()
        {
            Journal buf = new Journal();

            try
            {
                Console.WriteLine("Введите имя журнала: ");
                buf.Name = Console.ReadLine();

                Console.WriteLine("Введите цену журнала: ");
                buf.Price = Double.Parse(Console.ReadLine());

                Console.WriteLine("Введите агентство журнала: ");
                buf.Agency = Console.ReadLine();

                JournalCatalog.Offices.Add(buf);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            SaveData();
        }

    }
}