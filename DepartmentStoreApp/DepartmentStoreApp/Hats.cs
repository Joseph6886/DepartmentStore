using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreApp
{

    enum Lids
    {
        SaleItem = 1,
        BHat,
        BlkHat,
        RHat,
        WHat,
        BrwnHat

    }
    public class Hats
    {

        public static void SaleItem(ref int NewBalance)
        {
            NewBalance = 70;
            Console.WriteLine("This item is $100.00 30% off = $70.00");
            Console.ReadLine();
            Console.Clear();
        }
        public static void BHats(ref int NewBalance)
        {
            NewBalance = 50;
            Console.WriteLine("This blue Hats is $50.00");
            Console.ReadLine();
            Console.Clear();

        }
        public static void BlkHats(ref int NewBalance)
        {
            NewBalance = 100;
            Console.WriteLine("This black Hats is $100.00");
            Console.ReadLine();
            Console.Clear();
        }
        public static void RHats(ref int NewBalance)
        {
            NewBalance = 35;
            Console.WriteLine("This red Hats is $35.00");
            Console.ReadLine();
            Console.Clear();
        }
        public static void WHats(ref int NewBalance)
        {
            NewBalance = 45;
            Console.WriteLine("This white Hats is $45.00");
            Console.ReadLine();
            Console.Clear();
        }
        public static void BrwnHats(ref int NewBalance)
        {
            NewBalance = 60;
            Console.WriteLine("This brown Hats is $60.00");
            Console.ReadLine();
            Console.Clear();
        }
        public void Hat(ref int x)
        {
            int number;
            Console.WriteLine("What type of shoes are you looking for \n 1.Sale Item\n2.Blue Hat\n3.Black Hat\n4.Red Hat\n5.White Hat\n6.Brown Hat ?");
            string type = Console.ReadLine();
            int.TryParse(type, out number);
            switch ((Lids)number)
            {
                case Lids.SaleItem:
                    SaleItem(ref x);
                    break;
                case Lids.BHat:
                    BHats(ref x);
                    break;
                case Lids.BlkHat:
                    BlkHats(ref x);
                    break;
                case Lids.RHat:
                    RHats(ref x);
                    break;
                case Lids.WHat:
                    WHats(ref x);
                    break;
                case Lids.BrwnHat:
                    BrwnHats(ref x);
                    break;
            }
        }
    }
}