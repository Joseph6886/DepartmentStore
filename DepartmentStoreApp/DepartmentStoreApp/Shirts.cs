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
    public class Shirts
    {

        public static void SaleItem()
        {
            Console.WriteLine("This item is $100.00 30% off = $70.00");
        }
        public static void BShirt()
        {
            Console.WriteLine("This blue Shirt is $50.00");

        }
        public static void BlkShirt()
        {
            Console.WriteLine("This black Shirt is $100.00");
        }
        public static void RShirt()
        {
            Console.WriteLine("This red Shirt is $35.00");
        }
        public static void WShirt()
        {
            Console.WriteLine("This white Shirt is $45.00");
        }
        public static void BrwnShirt()
        {
            Console.WriteLine("This brown Shirt is $60.00");
        }
        public  void Shirt()
        {
            int number;
            Console.WriteLine("What type of shirt are you looking for \n 1.Sale Item\n2.Blue Shirt\n3.Black Shirt\n4.Red Shirt\n5.White Shirt\n6.Brown Shirt ?");
            string type = Console.ReadLine();
            int.TryParse(type, out number);
            switch ((Tees)number)
            {
                case Tees.SaleItem:
                    SaleItem();
                    break;
                case Tees.BShirt:
                    BShirt();
                    break;
                case Tees.BlkShirt:
                    BlkShirt();
                    break;
                case Tees.RShirt:
                    RShirt();
                    break;
                case Tees.WShirt:
                    WShirt();
                    break;
                case Tees.BrwnShirt:
                    BrwnShirt();
                    break;
            }
        }
    }
}
