using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Week9_Graded_Assignment_
{
    class Program
    {
        static void Main(string[] args)
        {

            Pizza pizzaSlice = new Pizza("small", 2, 3, 5); //make Pizza

            double cost = pizzaSlice.calculateCost(); //Calculate Pizza


            Console.WriteLine(pizzaSlice.ToString());
            Console.ReadLine();

        }
    }
}

