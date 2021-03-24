using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine v = new VendingMachine();

            v.DisplayProduct();

            int totalAmount = 0;

            Console.Write("If you want to exits ,press N else press Y");
            while (true)
            {
                Console.Write("Insert Y/N : ");
                var input = Console.ReadLine();
                if (input.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                //Entering Weight and Size
                Console.Write("For Entering Coins weight :");
                int weightValue = Convert.ToInt32(Console.ReadLine());
                Console.Write("For Entering Coins size : ");
                int sizeValue = Convert.ToInt32(Console.ReadLine());
                int coin = v.GetCoinValue(weightValue, sizeValue);
                //Get the amount
                //int amount = v.UpdatedTotalAmount(coin);
                 totalAmount += coin;
                Console.WriteLine("Total updated Amount is :" + totalAmount);

                Console.WriteLine("For Cola Select 1, Chps select 2, Candy select 3");
                int number = Convert.ToInt32(Console.ReadLine());


                if (number == 1)
                {

                    v.DispenseProduct(number);

                }
                else if (number == 2)
                {

                    v.DispenseProduct(number);
                }
                else if( number==3)
                {
                    v.DispenseProduct(number);
                }

                Console.ReadLine();


            }


        }
    }
}
