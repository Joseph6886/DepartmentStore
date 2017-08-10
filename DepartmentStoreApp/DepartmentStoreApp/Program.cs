using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreApp
{
    public class Clothes : Shoes
    {




    }
    class Program
    {
        public static int NewBalance;
        static void Main(string[] args)
        {




            string answer;
            do
            {


                Begin:
                Clothes cs = new Clothes();


                int choice;
                int x = 0;

                Console.Write("Welcome to E and J's Department Store");
                Console.WriteLine("What department would you like to begin shopping...\n1.Shirts\n2.Pants\n3.Shoes\n4.Hats");
                string department = Console.ReadLine();
                int.TryParse(department, out choice);

                if (choice == 1)
                {

                    cs.Shirt(ref x);
                    Console.WriteLine("Your balance is {0}", x);



                }
                else if (choice == 2)
                {
                    cs.Pant(ref x);
                    Console.WriteLine("Your balance is {0}", x);

                }
                else if (choice == 3)
                {
                    cs.Shoe(ref x);
                    Console.WriteLine("Your balance is {0}", x);


                }
                else if (choice == 4)
                {
                    cs.Hat(ref x);
                    Console.WriteLine("Your balance is {0}", x);

                }
                else
                {
                    Console.WriteLine("Please enter a valid value");
                    Console.ReadKey();
                    Console.Clear();
                    goto Begin;

                }
                Console.WriteLine("Would you like to continue shopping ?");
                answer = Console.ReadLine();
                if (answer == "yes" || answer == "y")
                {
                    Console.Clear();
                    goto Begin;


                }
                      
                
            }
            while (answer != "n" && answer != "no");
            

                Console.WriteLine("Thank You Please visit us again");
                Console.ReadLine();
            

        }






















    }
}
