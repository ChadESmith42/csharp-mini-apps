using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main()
        {
            //Admin functions for Console:
            Console.Title = "   Chad's Spiffy C# Console Application";

            Console.WriteLine("Please choose an option: ");
            //Prints the menu for the user
            PrintMenu();
            //Capture the user's input
            string userOption = Console.ReadLine();
            //Use a switch to implement the user's choice
            switch (userOption)
            {
                case "1":
                    Multiplication();
                    break;
                case "2":
                    AverageNumbers();
                    break;
                case "3":
                    FizzBuzz();
                    break;
                case "4":
                    Fibonacci();
                    break;
                case "5":
                    Multiples3and5();
                    break;
                case "6":
                    EvenFibonacci();
                    break;
                case "7":
                    PrimeFactors();
                    break;
                case "8":
                    UpWorkCalculator();
                    break;
                case "X":
                case "x":
                    ExitApp();
                    break;
                default:
                    //Defaults back to the main menu of the user makes an
                    //improper choice
                    PrintMenu();
                    break;
            }//end switch
            
        }//end Main()

        //Create a multiplication table based on user input of an integer
        static void Multiplication()
        {
            //Clear the console
            Console.Clear();
            //Ask the user for the number to generate the multiplication table
            Console.WriteLine("Please enter a number: ");
            //Convert the string input to an integer and assign to a variable
            int userNumber = Convert.ToInt32(Console.ReadLine());
            //Loop through the first 10 products of the table
            for (int i = 0; i < 11; i++)
            {   
                //Write the product to the screen
                Console.WriteLine($"{userNumber} x {i} = {userNumber * i}");
            }
            //Prompt the user to press any key to continue, return to menu
            WaitAndClear();
        }//end Multiplication()

        static void AverageNumbers()
        {
            Console.Clear();
            //Prompt the user for the length of their number array/collection
            Console.WriteLine("How many numbers do you need to average? ");
            //Convert and assign the input to an integer variable
            int totalNumbers = Convert.ToInt32(Console.ReadLine());
            //Create a total of the array to be averaged;
            int runningTotal = 0;
            //Create a list of number input by the user as string;
            string numberInventory = "";
            //Loop to allow the user to enter their numbers to be averaged
            for (int i = 0; i < (totalNumbers); i++)
            {
                //Prompt for a number
                Console.WriteLine("Enter a number: ");
                //Capture the number to a throw-away variable
                string tempNumber = Console.ReadLine();
                //Convert the input to an integer and add it to the total
                runningTotal += Convert.ToInt32(tempNumber);
                //This section will test if the number is the last to be entered
                //If it's not the last number, the number will be added to a 
                //string followed by a comma and a space
                if (i < (totalNumbers - 1))
                {
                    numberInventory += tempNumber + ", ";
                }
                //If this is the last number, the number is just added to the string
                else
                {
                    numberInventory += tempNumber;
                }
                
            }//end FOR LOOP

            //Calculate the average
            int average = runningTotal / totalNumbers;
            //Provide the user with the average and an inventory of the numbers the user
            //provided to get the average.
            Console.WriteLine($"The average of {numberInventory} is {average}.");

            //Prompt the user to continue, clear the screen, and restart the app
            WaitAndClear();

        }//end Average()

        static void FizzBuzz()
        {
            Console.Clear();
            //Request ending number for FizzBuzz Game
            Console.WriteLine("Enter the ending number for the Fizz Buzz game: ");
            //Capture input from user
            int endNumber = Convert.ToInt32(Console.ReadLine());
            //Loop through numbers in the game:
            for (int i = 1; i <= endNumber; i++)
            {
                //Test for FizzBuzz
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                //Test for Buzz
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                //Test for Fizz
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                //Print the rest
                else
                {
                    Console.WriteLine($"{i:n0}");
                }
            }//end FOR loop
            //Require User to press a key to return to the Main Menu
            WaitAndClear();
        }//end FizzBuzz();

        static void Fibonacci()
        {
            Console.Clear();
            Console.WriteLine("Enter the end number for your Fibonacci Sequence: ");
            int endNumber = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 1;

            Console.WriteLine(a);
            Console.WriteLine(b);

            do
            {

                Console.WriteLine($"{c:n0}");
                a = b;
                b = c;
                c = a + b;
            }
            while ((a + b) <
            endNumber);

            WaitAndClear();
        }//end Fibonacci

        static void Multiples3and5()
        {
            Console.Clear();
            //Find all natural multiples of 3 and 5 from 0 to a specified range end.
            //Find the sum of those natural multiples.
            //Problem 1 of Project Euler

            //Describe the funciton of the application:
            Console.WriteLine("Find the sum of all multiples of 3 and 5 within a range.");
            Console.WriteLine("Please enter an ending number for the range: ");
            //Capture the ending number:
            int stopNumber = Convert.ToInt32(Console.ReadLine());
            //Create variable to capture the sum of the multiples:
            int sumOfMultiples = 0;

            //Loop through every number in the range:
            for (int i = 0; i < stopNumber; i++)
            {
                //Test if i is a multiple of 3 or 5
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    //Add i to the sum
                    sumOfMultiples += i;
                }//end IF
            }//end FOR loop

            //Output the result:
            Console.WriteLine($"The sum of all natural multiples of 3 and 5 between 0 and {stopNumber:n0} is {sumOfMultiples:n0}.");

            WaitAndClear();
        }//end Multiples3and5()

        static void EvenFibonacci()
        {
            Console.Clear();
            //Sum the even numbers in the Fibonacci Sequence that are less than 4 million
            //Give the user the option to limit the Sequence
            Console.WriteLine("Sum of all EVEN numbers in the Fibonacci Sequence, less than 4 million.");
            Console.WriteLine("1. Full Sequence\n2.Partial Sequence");
            Console.WriteLine("Do you want the full sequence or a subset? ");
            //Get answer from user
            string answer = Console.ReadLine();
            //Assign default value to endSequence
            double endSequence = 4000000000;
            //If user wants their own range, get it now:
            if (answer == "2")
            {
                Console.Clear();
                Console.WriteLine("Enter the end number for the range: ");
                //Assign User's end number to the range:
                endSequence = Convert.ToDouble(Console.ReadLine());
            }

            //Create the variables for the Fibonacci Sequence
            double a = 0;
            double b = 1;
            double c = 0;
            //Create variable for the final answer
            double sumOfEvens = 0;

            //Loop through the sequence, while the end number isn't exceeded
            do
            {
                c = a + b;
                //Test for EVEN number value
                if (c % 2 == 0)
                {
                    //Add value of c to the sumOfEvens
                    sumOfEvens += c;
                }

                //Increment the variables to get the next number in the Fibonacci Sequence
                a = b;
                b = c;
            //Using (a+b) rather than c will keep the sequence within the bounds of the
            //range supplied.
            } while (a + b < endSequence);

            Console.Clear();
            //Print the answer for the User:
            Console.WriteLine($"The sum of all EVEN numbers in the Fibonacci Sequence under {endSequence:n0} is {sumOfEvens:n0}.");

            //Require the User to press any key to get back to the Main Menu
            WaitAndClear();

        }//end EvenFibonacci()

        static void PrimeFactors()
        {
            Console.Clear();
            //Find Prime Factors for a given number
            Console.WriteLine("Enter a number to find all of it's Prime Factors: ");
            double findPrimes = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            //Create variable to hold List of factors for each input
            List<double> factorNumbers = new List<double>();
            //Create variable to hold List of Prime Factors for each input
            List<double> primeFactors = new List<double>();
            //Create variable identify a number being PRIME; Used for logic/UX decisions
            bool isPrime = false;

            //Test if findPrimes is PRIME
            if (IsPrime(findPrimes))
            {
                isPrime = true;
            }

            //Create factors for each number:
            for (int i = 0; i <= findPrimes; i++)
            {
                if (findPrimes % i == 0)
                {
                    factorNumbers.Add(i);
                }
            }//end FOR loop
            
            //Test each factor in factorNumbers for being PRIME
            foreach (double factor in factorNumbers)
            {
                if (IsPrime(factor))
                {
                    primeFactors.Add(factor);
                }
            }

            Console.WriteLine($"{findPrimes} {(isPrime ? "is" : "is not")} prime.");
            
            Console.WriteLine("The factors are: ");

            factorNumbers.Sort();
            foreach (double factor in factorNumbers.Distinct())
            {
                Console.WriteLine($"{factor}");
            }

            if (!isPrime)
            {
                //Print final answer of Prime Factors
                Console.WriteLine($"The Prime Factors for {findPrimes} are: ");
                primeFactors.Sort();
                foreach (var item in primeFactors.Distinct())
                {
                    Console.WriteLine($"{item}");
                }
            }
            WaitAndClear();
        }//end PrimeFactors()

        public static void UpWorkCalculator()
        {
            Console.Clear();
            double payRate500 = 0.80d;
            double payRate10000 = 0.90d;
            double payRate10001 = 0.95d;
            double paycheck = 0d;

            Console.WriteLine("How much money does the job pay? ");
            double pay = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Have you worked for this client before? Y/N");
            string repeat = Console.ReadLine().ToUpper();
            bool repeatClient = (repeat == "Y") ? true : false;
            double previousIncome = 0;
            if (repeatClient)
            {
                Console.WriteLine("How much have you made for previous work with this client? ");
                previousIncome = Convert.ToDouble(Console.ReadLine());
            }
            double totalComp = pay + previousIncome;

            if (totalComp <= 500)
            {
                paycheck = pay * payRate500;
            }
            if (repeatClient)
            {
                if (totalComp > 500 && totalComp < 10001)
                {
                    paycheck = pay * payRate10000;
                }
                if (totalComp > 10000)
                {
                    paycheck = pay * payRate10001;
                }
            }
            if (!repeatClient)
            {
                if (totalComp > 500 && totalComp < 10001)
                {
                    paycheck = (500 * payRate500) + ((pay - 500) * payRate10000);
                }
                if (totalComp > 10000)
                {
                    paycheck = (500 * payRate500) + (9500 * payRate10000) + ((pay - 10000 * payRate10001));
                }
            }

            Console.WriteLine($"Your expected paycheck is {paycheck:c}");

            WaitAndClear();
        }


        #region Menu and Display Methods
        //Prompt the user to press a key to continue and clear the console
        static void WaitAndClear()
        {
            Console.WriteLine("Please press any key to continue.");
            Console.ReadLine();
            Console.Clear();
            Main();
        }

        //Print the menu for a user to make a selection
        static void PrintMenu()
        {
            Console.WriteLine("1. Multiplcation Tables");
            Console.WriteLine("2. Average Numbers");
            Console.WriteLine("3. Fizz Buzz");
            Console.WriteLine("4. Fibonacci Sequence");
            Console.WriteLine("***** Project Euler Challenges *****");
            Console.WriteLine("5. Sum Natural Multiple of 3 and 5");
            Console.WriteLine("6. Sum of Even Numbers in the Fibonacci Sequence");
            Console.WriteLine("7. Prime Factors For A Number");
            Console.WriteLine("8. UpWork Pay Calculator");
            Console.WriteLine("X. Exit the Application");
        }
        
        //Exit Application Option
        static void ExitApp()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using Chad's Spiffy C# Console Application.");
            Console.WriteLine("Please close the window when you are ready.");
            WaitAndClear();
        }

        //Tests if int is prime
        static bool IsPrime(double n)
        {
            if (n > 1)
            {   
                //Create a list of factors:
                List<double> factorList = new List<double>();
                //Iterate through the range of numbers between 1 and n
                for (int i = 0; i <= n; i++)
                {
                    //Check if n is divisible by a factor
                    if (n % i == 0)
                    {
                        factorList.Add(i);
                    }
                }

                //Prime numbers only have 2 factors: 1 and the prime number
                //If the list of factors has more than 2 factors, the number
                //isn't Prime, so ... IsPrime returns FALSE
                if (factorList.Count > 2)
                {
                    return false;
                }
            }
            //This code should only be reached if there are 2 factors in
            //the factorList. 2 factors indicates a PRIME number.
            return true;

            //Only works for INTS, can't find all PRIMES using this method
            //if (n > 1)
            //{
            //    return Enumerable.Range(1, n).Where(x => n % x == 0).SequenceEqual(new[] { 1, n });
            //}
            //return false;
        }
        #endregion

    }
}
