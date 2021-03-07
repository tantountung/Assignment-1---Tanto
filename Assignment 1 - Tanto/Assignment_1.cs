using System;

namespace Assignment_1
{
    public static class Assignment_1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Sir/Madam!!");
            bool keepLooping = true;

            do
            {
                MainMenu();
                Console.WriteLine("Do you want to do calculation again?\nCLick Y if Yes or other key to end the program"  );
                string userAnswer = Console.ReadLine();
                if (userAnswer.ToUpper() != "Y")//if true, no need to put inside 'if', Y always in "" because it is string
                {
                    keepLooping = false;//dont use 'wrong'
                }
                    
            } while (keepLooping);
            //Ctrl KD, make it neat

        }

        public static void MainMenu()//menu same level with Main and uppercase, except variable

        {
            Console.WriteLine("  ");//cw double tap
            Console.WriteLine("  ");
            Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division\n5.End the program");
            Console.WriteLine("  ");
            Console.Write("Please enter your choice:");

            int userChoice = Convert.ToInt32(Console.ReadLine());


            switch (userChoice)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Substraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Console.WriteLine("  ");
                    Console.WriteLine("  ");
                    Console.WriteLine("Thank you");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please choice from the main menu");
                    break;
            }







        }

        public static void Addition(int num1, int num2)

        {
            Console.WriteLine("Enter first number you want to add to: ");
            int firstNumberAdd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number you want to add on:");
            int secondNumberAdd = Convert.ToInt32(Console.ReadLine());
            int addRes = firstNumberAdd + secondNumberAdd;

            Console.WriteLine("The addition result is:  {0}", addRes);
            Console.ReadKey();


        }

        public static void Substraction()


        {
            Console.WriteLine("Enter first number you want to substract on: ");
            int firstNumberSubs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the substraction number:");
            int secondNumberSubs = Convert.ToInt32(Console.ReadLine());
            int subRes = firstNumberSubs - secondNumberSubs;
            Console.WriteLine("The substraction result is: {0} ", subRes);
            Console.ReadKey();


        }

        public static void Multiplication()


        {
            Console.WriteLine("Enter first number you want to multiply: ");
            int firstNumberTimes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the multiplier number:");
            int secondNumberTimes = Convert.ToInt32(Console.ReadLine());
            int mulRes = firstNumberTimes * secondNumberTimes;
            Console.WriteLine("The multiplication result is: {0}", mulRes);
            Console.ReadKey();


        }

        public static void Division()


        {
            Console.WriteLine("Enter number you want to divide: ");
            int firstNumberDiv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divider number:");
            int secondNumberDiv = Convert.ToInt32(Console.ReadLine());

            if (secondNumberDiv == 0)
            {
                Console.WriteLine("You cannot divide with 0, please repeat entering correct divider number.");
                

            }
            else
            {
                int divRes = firstNumberDiv / secondNumberDiv;

                Console.WriteLine("The division result is: {0} ", divRes);



            }
                Console.ReadKey();//only at the end because no use in every method

        }
    }
}
