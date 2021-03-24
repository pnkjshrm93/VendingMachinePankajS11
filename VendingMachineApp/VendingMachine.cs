using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineApp
{


    public class VendingMachine
    {
        //private int depositedAmount;
        private const int CostofCola = 100;
        private const int CostofChips = 50;
        private const int CostofCandy = 65;
        private int coinValue;
        private int updatedAmount;

        public VendingMachine()
        {
            //depositedAmount = 0;
            updatedAmount = 0;
        }

        public void DisplayProduct()
        {
            List<string> products = new List<string>();
            products.Add("Cola for 100 cents");
            products.Add("Chips for 50 cents");
            products.Add("Candy for 65 cents");
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }


        }
        public int GetCoinValue(int weight, int size)
        {
           
                   
                    if (weight == 20 && size == 20)
                    {
                        coinValue = 20;
                        Console.WriteLine("The Coin Value  is :" + coinValue);
                    }
                
               
                   else if (weight == 25 && size == 15)
                    {
                        coinValue = 10;
                        Console.WriteLine("The Coin Value  is :" + coinValue);
                    }
                 

                   else if (weight == 30 && size == 25)
                    {
                        coinValue = 25;
                        Console.WriteLine("The Coin Value  is :" + coinValue);
                    }
                  
                else
                    Console.WriteLine("You have not inserted any coin, PLEASE INSERT COIN");
                    
               
          
            return coinValue;
        }
        //public int UpdatedTotalAmount(int value)
        //{
        //    updatedAmount += value;
        //    Console.WriteLine("The total updated Amount is :" + updatedAmount);
        //    return updatedAmount;
        //}      
        public void DispenseProduct(int num)
        {
            switch (num)
            {
                case 1:
                    if (updatedAmount >= CostofCola)
                    {

                        updatedAmount = updatedAmount - CostofCola;
                        Console.WriteLine("Thank you!, You have your Cola Ready and the balance left is : " + updatedAmount);

                    }
                    else
                    {
                        Console.WriteLine("You have insufficient Amount, the price is 100 cents");
                        
                    }
                    break;

                case 2:
                    if (updatedAmount >= CostofChips)
                    {

                        updatedAmount = updatedAmount - CostofChips;
                        Console.WriteLine("Thank you!, You have your Chips Ready and the balance left is: " + updatedAmount);

                    }
                    else
                    {
                        Console.WriteLine("You have insufficient Amount,the price is 50 cents");
                        
                    }
                    break;

                case 3:
                    if (updatedAmount >= CostofCandy)
                    {

                        updatedAmount = updatedAmount - CostofCandy;
                        Console.WriteLine("Thank you!, You have your Candy Ready and the balance left is: " + updatedAmount);

                    }
                    else
                    {
                        Console.WriteLine("You have insufficient Amount,the price is 65 cents");
                    }
                    break;
            }


        }
    }
}
