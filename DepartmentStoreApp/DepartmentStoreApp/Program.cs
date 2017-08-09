using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreApp
{
    

    class Program
    {
        
        static void Main(string[] args)
        {
            Hats h = new Hats();
            Pants p = new Pants();
            Shoes s = new Shoes();
            Shirts ss = new Shirts();

            int choice;
            Console.WriteLine("Welcome to E and J's Department Store");
            Console.WriteLine("What department would you like to begin shopping...\n1.Shirts\n2.Pants\n3.Shoes\n4.Hats");
            string department = Console.ReadLine();
            int.TryParse(department, out choice);

            if(choice == 1)
            {
                ss.Shirt();

            }
            else if(choice == 2)
            {
                p.Pant();
            }
            else if(choice == 3)
            {
                s.Shoe();
            }
            else
            {
                h.Hat();
            }


            
            


            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
