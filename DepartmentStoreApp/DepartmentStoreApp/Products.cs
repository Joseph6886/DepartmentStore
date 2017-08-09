using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentStoreApp
{
    
    enum kicks
    {
        SaleItem=1,
        BShoes,
        BlkShoes,
        RShoes,
        WShoes,
        BrwnShoes

    }
    public class Shoes
    {
       
        public static void SaleItem()
        {
            Console.WriteLine("This item is $100.00 30% off = $70.00");
        }
        public static void BShoes()
        {
            Console.WriteLine("This blue shirt is $50.00");

        }
        public static void BlkShoes()
        {
            Console.WriteLine("This black shirt is $100.00");
        }
        public static void RShoes()
        {
            Console.WriteLine("This red shirt is $35.00");
        }
        public static void WShoes()
        {
            Console.WriteLine("This white shirt is $45.00");
        }
        public static void BrwnShoes()
        {
            Console.WriteLine("This brown shirt is $60.00");
        }
        public void Shoe()
        {
            int number;
            Console.WriteLine("What type of shoes are you looking for \n 1.Sale Item\n2.Blue Shoes\n3.Black Shoes\n4.Red Shoes\n5.White Shoes\n6.Brown Shoes ?");
            string type = Console.ReadLine();
            int.TryParse(type, out number);
            switch((kicks)number)
            {
                case kicks.SaleItem:
                    SaleItem();
                    break;
                case kicks.BShoes:
                    BShoes();
                        break;
                case kicks.BlkShoes:
                    BlkShoes();
                    break;
                case kicks.RShoes:
                    RShoes();
                    break;
                case kicks.WShoes:
                    WShoes();
                    break;
                case kicks.BrwnShoes:
                    BrwnShoes();
                    break;



            }
        }

        
        

    }
    ////public class Pants
    //{
    //    string SaleItem = "30% off";
    //    string BPants = "Blue Pants";
    //    string BklPants = "Black Pants";
    //    string RPants = "Red Pants";
    //    string WPants = "White Pants";
    //    string BrwnPants = "Brown Pants";

    //}
    //public class Shirts
    //{
    //    string SaleItem = "30% off";
    //    string Bshirt = "Blue Shirt";
    //    string Blkshirt = "Black Shirt";
    //    string Rshirt = "Red Shirt";
    //    string Wshirt = "White Shirt";
    //    string Brwnhirt = "Brown Shirt";

        //}
        //public class Hats
        //{
        //    string SaleItem = "30% off";
        //    string BHat = "Blue Hat";
        //    string BlkHat = "Black Hat";
        //    string RHat = "Red Hat";
        //    string WHat = "White Hat";
        //    string BrwnHat = "Brown Hat";


        //}

    }
