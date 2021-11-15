using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// Lab 9 (Graded Assignment)    
/// File Name: Lab-Week9(Graded Assignment)
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
/// 
/// 
///This a class named Pizza that stores information about a single pizza. It contains the following:
///Private instance variables to store the size of the pizza (either small, medium, or large), 
///the number of cheese toppings, the number of pepperoni toppings and the number of ham toppings.
///Constructors that set all instance variables.
///Public methods to do get and set the instance variables.
///A public method named CalculateCost() that returns a double that is the cost of the pizza.
///Pizza cost is $10 for small, $12 for medium, $14 for large and $2 per topping.
///Override the ToString method that returns the pizza size, quantity of each topping and the pizza cost as calculated by the calcCost method.
///This is Written a program (in the main) to test all the methods in your class definition.

namespace Lab_Week9_Graded_Assignment_
{


    class Pizza
    {
        private string pizzaSize;
        private int cheeseToppingsCount;
        private int pepperoniToppingsCount;
        private int hamToppingsCount;

        public Pizza()

        {
            this.pizzaSize = "";
            this.cheeseToppingsCount = 0;
            this.pepperoniToppingsCount = 0;
            this.hamToppingsCount = 0;
        }
        public Pizza(String pizzaSize, int cheeseToppingsCount, int pepperoniToppingsCount, int hamToppingsCount)
        {
            this.pizzaSize = pizzaSize;
            this.cheeseToppingsCount = cheeseToppingsCount;
            this.pepperoniToppingsCount = pepperoniToppingsCount;
            this.hamToppingsCount = hamToppingsCount;
        }

        public String getPizzaSize()
        {
            return pizzaSize;
        }

        public void setPizzaSize(String pizzaSize)
        {
            this.pizzaSize = pizzaSize;
        }
        public int getCheeseToppingsCount()
        {
            return cheeseToppingsCount;
        }

        public void setCheeseToppingsCount(int cheeseToppingsCount)
        {
            this.cheeseToppingsCount = cheeseToppingsCount;
        }
        public int getPepperoniToppingsCount()
        {
            return pepperoniToppingsCount;
        }

        public void setPepperoniToppingsCount(int pepperoniToppingsCount)
        {
            this.pepperoniToppingsCount = pepperoniToppingsCount;
        }
        public int getHamToppingsCount()
        {
            return hamToppingsCount;
        }

        public void setHamToppingsCount(int hamToppingsCount)
        {
            this.hamToppingsCount = hamToppingsCount;
        }

        public double calculateCost()
        {
            double PizzaCost;
            if (pizzaSize == "small")
            {

                PizzaCost = 10.00;
                return PizzaCost + ((cheeseToppingsCount + pepperoniToppingsCount + hamToppingsCount) * 2);
            }
            else if (pizzaSize == "medium")
            {
                PizzaCost = 12.00;
                return PizzaCost + (cheeseToppingsCount + pepperoniToppingsCount + hamToppingsCount) * 2;
            }
            else if (pizzaSize == "large")
            {
                PizzaCost = 14.00;
                return PizzaCost + (cheeseToppingsCount + pepperoniToppingsCount + hamToppingsCount) * 2;
            }
            else

                return 0.0;
        }

        public override String ToString()
        {
            return "Pizza Size: " + pizzaSize + "\t\n" + "cheese toppings count: " + cheeseToppingsCount + "\t\n" + "Pepperroni toppings: " + pepperoniToppingsCount + "\t\n"
                + "Ham toppings: " + hamToppingsCount + "\t\n" + "Total Price: $" + calculateCost();

        }
    }



}
