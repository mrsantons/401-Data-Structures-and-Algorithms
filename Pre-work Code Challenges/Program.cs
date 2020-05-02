﻿using System;
using System.Dynamic;

namespace Pre_work_Code_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Challenge 1: Array Max Result");
           // arrayMaxResult();
           // Console.WriteLine("Challeng 2: Leap Year Calculator");
           // leapYearCalculator();
            Console.WriteLine("Challenge 3: Perfect Sequence");
            perfectSequence();

        }
        //PROBLEM 1: Array Max Result: Not a guessing game after all, we are just asking a user for 5 inputs then asking them for a new number to check their array to see if they have had that number. Then we need to sum it! 
        public static void arrayMaxResult()

        {
            // 1st step: Request 5 numbers between 1-10 from User
            // set array length
            int arrayLength = 5;
            int[] userInputArray = new int[arrayLength];
            //Use for loop to ask user for 5 inputs 
            for (int i = 0; i < arrayLength; i++)
            {
                //ask user for input
                Console.WriteLine("Please enter a number between 1-10, we will ask you this question 5 times. ");
                // Next we need to put those numbers into the array- we will need to parse into integer for this: https://docs.microsoft.com/en-us/dotnet/api/system.int32.parse?view=netcore-3.1
                userInputArray[i] = int.Parse(Console.ReadLine());
            }
            //2nd step: Ask the user for a number to check for.
            Console.WriteLine("Please enter a number to check: ");
            int numberCheck = int.Parse(Console.ReadLine());

            //3rd step is to hceck how many times that number appeaars and sum them (Addition) Sample inout includes two 4's and the user checks for 4 so the output is 8.
            int returnVariable = 0;
            //use a for loop to iterate through the users input array length
            for (int i = 0; i < arrayLength; i++)
            {
                //we need to check if the user's array contains the number that they chose to check for their score
                if (userInputArray[i] == numberCheck)
                {
                    returnVariable += numberCheck;
                }
            }
            //Tell the user their score, use string interpolation to input the return variable
            Console.WriteLine($"You have a score of {returnVariable}!");
        }
        // Problem 2: Check if a given year is a leap year
       public static void leapYearCalculator()
        {
            // we need a year to check: input by the user
            Console.WriteLine("What year would you like to check to see if it is a leap year or not?");
            int userYearInput = int.Parse(Console.ReadLine());

            // we need t set leapYear to either true or false
            bool leapYearCheck = false;

            //we need to check if it is divisible by 400 (if/else? else if) if a year is EVENLY divisible by 400 then it is a leap year.
            if (userYearInput % 400 == 0)
            {
                leapYearCheck = true;
            }
            //we need to see if the year the user inputed is divisible by 4 unless it is evenly divisible by 100  else if 
            else if (userYearInput % 4 == 0 && userYearInput % 100 != 0)
            {
                leapYearCheck = true;
            }
            //we need to let the user know that the year is either a leap year or not (if/else)
            if (leapYearCheck == true)
            {
                Console.WriteLine("That year is a leap year!");
            }
            else
            {
                Console.WriteLine("This year is not a leap year");
            }

        }
        //Problem 3: Check if the users array is a perfect sequence ugh maths
        private static void perfectSequence()
        {
            // user needs to decide how many numbers are in their array -> convert to int
            Console.WriteLine("How many numbers would you like in your array?" );
            int userArrayLength = int.Parse(Console.ReadLine());

            //user needs to enter that amount of numbers to complete their array, for loop to make sure they have entered enough numbers 
            int[] userNumberInputsArray = new int[userArrayLength];
            for(int i = 0; i < userArrayLength; i++)
            {
                Console.WriteLine("Please enter a number for your sequence, This will be aked until your array has been filled! ");
                userNumberInputsArray[i] = int.Parse(Console.ReadLine());
            }


            //check product and sum of those numbers
            int userArraySum = 0;
            int userArrayProduct = 1;

            foreach(int num in userNumberInputsArray)
            {
                userArraySum += num;
                userArrayProduct *= num;
            }
            // let user know if they have a perfect sequence, is this like winning the lottery?
            if(userArraySum > 0 && userArraySum == userArrayProduct)
            {
                Console.WriteLine("That is a perfect sequence!");
            }
            else
            {
                Console.WriteLine("Defiitely not a perfect sequence, sorry.f");
            }

        }

    }
} 
