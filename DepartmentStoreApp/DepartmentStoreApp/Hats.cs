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

        public static void SaleItem()
        {
            Console.WriteLine("This item is $100.00 30% off = $70.00");
        }
        public static void BHats()
        {
            Console.WriteLine("This blue Hats is $50.00");

        }
        public static void BlkHats()
        {
            Console.WriteLine("This black Hats is $100.00");
        }
        public static void RHats()
        {
            Console.WriteLine("This red Hats is $35.00");
        }
        public static void WHats()
        {
            Console.WriteLine("This white Hats is $45.00");
        }
        public static void BrwnHats()
        {
            Console.WriteLine("This brown Hats is $60.00");
        }
        public  void Hat()
        {
            int number;
            Console.WriteLine("What type of shoes are you looking for \n 1.Sale Item\n2.Blue Hat\n3.Black Hat\n4.Red Hat\n5.White Hat\n6.Brown Hat ?");
            string type = Console.ReadLine();
            int.TryParse(type, out number);
            switch ((Lids)number)
            {
                case Lids.SaleItem:
                    SaleItem();
                    break;
                case Lids.BHat:
                    BHats();
                    break;
                case Lids.BlkHat:
                    BlkHats();
                    break;
                case Lids.RHat:
                    RHats();
                    break;
                case Lids.WHat:
                    WHats();
                    break;
                case Lids.BrwnHat:
                    BrwnHats();
                    break;
            }
        }
    }
}
