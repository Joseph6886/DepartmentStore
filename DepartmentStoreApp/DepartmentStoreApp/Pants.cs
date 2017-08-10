using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreApp
{

    enum Slacks
    {
        SaleItem = 1,
        BPants,
        BlkPants,
        RPants,
        WPants,
        BrwnPants

    }
    public class Pants : Shirts
    {

        public static void SaleItem2(ref int NewBalance)
        {
            NewBalance = 70;
            Console.WriteLine("This item is $100.00 30% off = $70.00");
            Console.ReadLine();
            Console.Clear();
        }
        public static void BPants(ref int NewBalance)
        {
            NewBalance = 50;
            Console.WriteLine("This blue Pants is $50.00");
            Console.ReadLine();
            Console.Clear();

        }
        public static void BlkPants(ref int NewBalance)
        {
            NewBalance = 100;
            Console.WriteLine("This black Pants is $100.00");
            Console.ReadLine();
            Console.Clear();
        }
        public static void RPants(ref int NewBalance)
        {
            NewBalance = 35;
            Console.WriteLine("This red Pants is $35.00");
            Console.ReadLine();
            Console.Clear();
        }
        public static void WPants(ref int NewBalance)
        {
            NewBalance = 45;
            Console.WriteLine("This white Pants is $45.00");
            Console.ReadLine();
            Console.Clear();
        }
        public static void BrwnPants(ref int NewBalance)
        {
            NewBalance = 60;
            Console.WriteLine("This brown Pants is $60.00");
            Console.ReadLine();
            Console.Clear();
        }
        public void Pant(ref int x)
        {
            int number;
            Console.WriteLine("What type of shoes are you looking for \n 1.Sale Item\n2.Blue Pants\n3.Black Pants\n4.Red Pants\n5.White Pants\n6.Brown Pants ?");
            string type = Console.ReadLine();
            int.TryParse(type, out number);
            switch ((Slacks)number)
            {
                case Slacks.SaleItem:
                    SaleItem2(ref x);
                    break;
                case Slacks.BPants:
                    BPants(ref x);
                    break;
                case Slacks.BlkPants:
                    BlkPants(ref x);
                    break;
                case Slacks.RPants:
                    RPants(ref x);
                    break;
                case Slacks.WPants:
                    WPants(ref x);
                    break;
                case Slacks.BrwnPants:
                    BrwnPants(ref x);
                    break;
            }
        }
    }
}



