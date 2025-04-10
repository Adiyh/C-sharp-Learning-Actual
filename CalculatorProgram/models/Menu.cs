using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorProgram.Operations;

namespace CalculatorProgram.models
{
    internal class Menu
    {
        public static int choice;

        public static void menu()
        {
           
                try
                {
                    Console.WriteLine("Choose the operation you want to perform");
                    Console.WriteLine("1.Arithmatic Operations");
                    Console.WriteLine("2.Simple interst");

                    choice = int.Parse(Console.ReadLine());
                }
               
                
                catch (Exception ex)
                {

                    Console.WriteLine("Enter number in 1 or 2");

                }
            

            switch (choice)
            {
                case 1: FindArithmatic.find(); 
                    break;
                case 2: FindInterst.findinterst();
                    break;
              default:  Console.WriteLine("Invalid choice, please try again.");
                    break;  

            }
        }
    }
}
