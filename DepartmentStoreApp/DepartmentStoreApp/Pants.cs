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
    public class Pants
    {

        public static void SaleItem()
        {
            Console.WriteLine("This item is $100.00 30% off = $70.00");
        }
        public static void BPants()
        {
            Console.WriteLine("This blue Pants is $50.00");

        }
        public static void BlkPants()
        {
            Console.WriteLine("This black Pants is $100.00");
        }
        public static void RPants()
        {
            Console.WriteLine("This red Pants is $35.00");
        }
        public static void WPants()
        {
            Console.WriteLine("This white Pants is $45.00");
        }
        public static void BrwnPants()
        {
            Console.WriteLine("This brown Pants is $60.00");
        }
        public void Pant()
        {
            int number;
            Console.WriteLine("What type of shoes are you looking for \n 1.Sale Item\n2.Blue Pants\n3.Black Pants\n4.Red Pants\n5.White Pants\n6.Brown Pants ?");
            string type = Console.ReadLine();
            int.TryParse(type, out number);
            switch ((Slacks)number)
            {
                case Slacks.SaleItem:
                    SaleItem();
                    break;
                case Slacks.BPants:
                    BPants();
                    break;
                case Slacks.BlkPants:
                    BlkPants();
                    break;
                case Slacks.RPants:
                    RPants();
                    break;
                case Slacks.WPants:
                    WPants();
                    break;
                case Slacks.BrwnPants:
                    BrwnPants();
                    break;
            }
        }
    }
}



            
