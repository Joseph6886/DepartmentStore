using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreApp
{

    enum kicks
    {
        SaleItem = 1,
        BShoes,
        BlkShoes,
        RShoes,
        WShoes,
        BrwnShoes

    }
    public class Shoes : Pants
    {

        public static void SaleItem1(ref int NewBalance)
        {
            NewBalance = 70;
            Console.WriteLine("This item is $100.00 30% off = $70.00");
            Console.ReadLine();
            Console.Clear();


        }
        public static void BShoes(ref int NewBalance)
        {
            NewBalance = 50;
            Console.WriteLine("This blue shirt is $50.00");
            Console.ReadLine();
            Console.Clear();


        }
        public static void BlkShoes(ref int NewBalance)
        {
            NewBalance = 100;
            Console.WriteLine("This black shirt is $100.00");
            Console.ReadLine();
            Console.Clear();

        }
        public static void RShoes(ref int NewBalance)
        {
            NewBalance = 35;
            Console.WriteLine("This red shirt is $35.00");
            Console.ReadLine();
            Console.Clear();

        }
        public static void WShoes(ref int NewBalance)
        {
            NewBalance = 45;
            Console.WriteLine("This white shirt is $45.00");
            Console.ReadLine();
            Console.Clear();

        }
        public static void BrwnShoes(ref int NewBalance)
        {
            NewBalance = 60;
            Console.WriteLine("This brown shirt is $60.00");
            Console.ReadLine();
            Console.Clear();

        }
        public void Shoe(ref int x)
        {
            int number;
            Console.WriteLine("What type of shoes are you looking for \n 1.Sale Item\n2.Blue Shoes\n3.Black Shoes\n4.Red Shoes\n5.White Shoes\n6.Brown Shoes ?");
            string type = Console.ReadLine();
            int.TryParse(type, out number);
            switch ((kicks)number)
            {
                case kicks.SaleItem:
                    SaleItem1(ref x);
                    break;
                case kicks.BShoes:
                    BShoes(ref x);
                    break;
                case kicks.BlkShoes:
                    BlkShoes(ref x);
                    break;
                case kicks.RShoes:
                    RShoes(ref x);
                    break;
                case kicks.WShoes:
                    WShoes(ref x);
                    break;
                case kicks.BrwnShoes:
                    BrwnShoes(ref x);
                    break;



            }
        }




    }
}
