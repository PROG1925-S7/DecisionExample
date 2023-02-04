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
            string suit, category, day;
            bool socksOn, hatOn;

            Random randGen = new Random();

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

            // 2. Create a program that determines the max value between 2 random values.

            number1 = randGen.Next(-10, 10);
            number2 = randGen.Next(-10, 10);

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

            //6. same as above but with OR 

            suit = "clubs";

            if (suit == "hearts" || suit == "diamonds")
            {
                Console.WriteLine("colour is red");
            }
            else if (suit == "clubs" || suit == "spades")
            {
                Console.WriteLine("colour is black");
            }
            else
            {
                Console.WriteLine("User Input Error!!!!!!!");
            }

            //8. Use AND statements to see if two conditions are true
            socksOn = false;
            hatOn = true;

            if (socksOn == true && hatOn == true) //if(socksOn && hatOn)
            {
                Console.WriteLine("Both your socks and hat are on");
            }
            else if (socksOn == false && hatOn == false) //if(!socksOn && !hatOn)
            {
                Console.WriteLine("You are chilly");
            }
            else if (socksOn == true)
            {
                Console.WriteLine("Your toes are warm, but your head is not");
            }
            else
            {
                Console.WriteLine("Your head is warm but my toes are cold");
            }

            // 9. Determine hurricane wind speeds
            //category = randGen.Next(1, 6);
            Console.Write("Enter a category:");
            category = Console.ReadLine();

            switch (category)
            {
                case "1":
                    Console.WriteLine($"{category}: 119-153 km/hr");
                    break;
                case "2":
                    Console.WriteLine($"{category}: 154-177 km/hr");
                    break;
                case "3":
                    Console.WriteLine($"{category}: 178-209 km/hr");
                    break;
                case "4":
                    Console.WriteLine($"{category}: 210-249 km/hr");
                    break;
                case "5":
                    Console.WriteLine($"{category}: greater than 249 km/hr");
                    break;
                default:
                    Console.WriteLine("Only 1-5 are valid");
                    break;
            }

            day = "Saturday";

            switch(day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine($"{day} is a weekday");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine($"{day} is a weekend day ");
                    break;
                default:
                    Console.WriteLine($"{day} is not a day");
                    break;
            }

            Console.ReadKey();

        }
    }
}
