using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreApp
{

    enum Tees
    {
        SaleItem = 1,
        BShirt,
        BlkShirt,
        RShirt,
        WShirt,
        BrwnShirt

    }
    public class Shirts : Hats
    {

        public static void SaleItem3(ref int NewBalance)
        {
            NewBalance = 70;
            Console.WriteLine("This item is $100.00 30% off = $70.00");
            Console.ReadLine();
            Console.Clear();
        }
        public static void BShirt(ref int NewBalance)
        {
            NewBalance = 50;
            Console.WriteLine("This blue Shirt is $50.00");
            Console.ReadLine();
            Console.Clear();

        }
        public static void BlkShirt(ref int NewBalance)
        {
            NewBalance = 100;
            Console.WriteLine("This black Shirt is $100.00");
            Console.ReadLine();
            Console.Clear();
        }
        public static void RShirt(ref int NewBalance)
        {
            NewBalance = 35;
            Console.WriteLine("This red Shirt is $35.00");
            Console.ReadLine();
            Console.Clear();
        }
        public static void WShirt(ref int NewBalance)
        {
            NewBalance = 45;
            Console.WriteLine("This white Shirt is $45.00");
            Console.ReadLine();
            Console.Clear();
        }
        public static void BrwnShirt(ref int NewBalance)
        {
            NewBalance = 60;
            Console.WriteLine("This brown Shirt is $60.00");
            Console.ReadLine();
            Console.Clear();
        }
        public void Shirt(ref int x)
        {
            int number;
            Console.WriteLine("What type of shirt are you looking for \n 1.Sale Item\n2.Blue Shirt\n3.Black Shirt\n4.Red Shirt\n5.White Shirt\n6.Brown Shirt ?");
            string type = Console.ReadLine();
            int.TryParse(type, out number);
            switch ((Tees)number)
            {
                case Tees.SaleItem:
                    SaleItem3(ref x);
                    break;
                case Tees.BShirt:
                    BShirt(ref x);
                    break;
                case Tees.BlkShirt:
                    BlkShirt(ref x);
                    break;
                case Tees.RShirt:
                    RShirt(ref x);
                    break;
                case Tees.WShirt:
                    WShirt(ref x);
                    break;
                case Tees.BrwnShirt:
                    BrwnShirt(ref x);
                    break;
            }
        }
    }
}
