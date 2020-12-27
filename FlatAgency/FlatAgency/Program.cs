using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.UI;
using FlatAgency.Exceptions;

// Система управления квартирным агентством

namespace FlatAgency
{
    class Program
    {        
        static void Main(string[] args)
        {
            try
            {
                MenuForClient mfc = new MenuForClient();
                mfc.Display();
            }
            catch (InputException ie)
            {
                Console.WriteLine(ie.Message);
            }
        }
    }
}