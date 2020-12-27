using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.UI;
using FlatAgency.DataManagers;
using FlatAgency.Exceptions;

namespace FlatAgency.UI
{
    class MenuForClient
    {
        DialogController dc = new DialogController();
        BookCatalogManager fcm = new BookCatalogManager();
        HouseCatalogManager hcm = new HouseCatalogManager();
        OfficeCatalogManager ocm = new OfficeCatalogManager();

        public void Display()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\nМодуль системы просмотра библиотеки\n");
                dc.displayClient();
                Console.WriteLine("\nВыберите действие:");
                if (!Int32.TryParse(Console.ReadLine(), out int choice))
                    throw new InputException("Incorrect format", "Incorrect format");

                switch (choice)
                {
                    case 1:
                        fcm.BookCatalog.DisplayFlats();
                        break;
                    case 2:
                        hcm.BrochureCatalog.DisplayHouses();
                        break;
                    case 3:
                        ocm.JournalCatalog.DisplayOffices();
                        break;
                    case 4:
                        fcm.AddFlat();
                        break;
                    case 5:
                        hcm.AddHouse();
                        break;
                    case 6:
                        ocm.AddOffice();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод");
                        break;
                }
            } while (dc.allowContinue());
            Environment.Exit(0);
        }
    }
}
