using System;

namespace GroceryShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            string guacomoleResponse;
            bool isQuacomoleOnSale;
            double  moneyInPocket;

            Console.WriteLine("Is guacomole on sale?  Enter yes or no.");
            guacomoleResponse = Console.ReadLine();

           if (guacomoleResponse == "yes")
            {    
                isQuacomoleOnSale = true;
            }
            else
            {
                isQuacomoleOnSale = false;
            }

            Console.WriteLine("How much money is in your pocket? ");
            moneyInPocket = Convert.ToDouble(Console.ReadLine());

            if ((isQuacomoleOnSale && moneyInPocket >= 10) || moneyInPocket >= 100)
            {
                Console.WriteLine("Lets go shopping!");
            }
            else
            {
                Console.WriteLine("We better stay home. We don't have enough money.");
            }

        }
    }
}
