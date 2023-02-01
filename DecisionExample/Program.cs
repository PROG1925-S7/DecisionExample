using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age, number1, number2;
            double hours, overtime;
            string suit;

            // 1. determine if a person is old enough to vote. 
            age = 11;

            if (age >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("GO AWAY KID!");
            }

            // 2. Create a program that determines the max value between 2 values
            number1 = 11;
            number2 = 12;

            if (number1 > number2)
            {
                Console.WriteLine($"{number1} is greater than {number2}");
            }
            else
            {
                Console.WriteLine($"{number2} is greater than {number1}");
            }

            // 3. Check if two numbers are equal
            if (number1 == number2)
            {
                Console.WriteLine($"{number1} is equal to {number2}");
            }

            // 4. Check if two numbers are NOT equal
            if (number1 != number2)
            {
                Console.WriteLine($"{number1} is NOT equal to {number2}");
            }

            //5. Determine overtime hours from user input
            Console.Write("Please enter hours worked: ");
            hours = Convert.ToDouble(Console.ReadLine());


            if (hours <= 40)
            {
                Console.WriteLine($"You worked {hours} hours");
            }
            else
            {
                overtime = hours - 40;
                Console.WriteLine($"You worked {hours} hours, {overtime} of which was overtime");
            }

            //6. determine the colour of a card suit
            suit = "Clubs";

            if (suit == "hearts")
            {
                Console.WriteLine("colour is red");
            }
            else if (suit == "diamonds")
            {
                Console.WriteLine("colour is red");
            }
            else if (suit == "clubs")
            {
                Console.WriteLine("colour is black");
            }
            else if (suit == "spades")
            {
                Console.WriteLine("colour is black");
            }
            else
            {
                Console.WriteLine("User Input Error!!!!!!!");
            }

            Console.ReadKey();
        }
    }
}
