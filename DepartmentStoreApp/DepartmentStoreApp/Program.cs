using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreApp
{
    enum Clothes
    {
        Shirts,
        Shoes,
        Pants,
        Hats,

        
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Welcome to E and J's Department Store");
            Console.WriteLine("What department would you like to begin shopping...\n Shirts\nPants\nShoes\nHats\nSales Items");
            string department = Console.ReadLine();
            int.TryParse(department, out choice);

            



            Console.WriteLine("Whats up?");
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
