using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            var numArray = new int[50];
            Populater(numArray);

            //Print the first number of the array
            //Console.WriteLine(randArray[0]);

            //Print the last number of the array            
            //Console.WriteLine(randArray[randArray.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(numArray);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(numArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            CustomReverseArray(numArray);

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numArray);

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numArray);
            NumberPrinter(numArray);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            var numList = new List<int>();

            //Print the capacity of the list to the console
            Console.WriteLine(numList.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numList);

            //Print the new capacity
            Console.WriteLine(numList.Capacity);


            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            var userInput = int.Parse(Console.ReadLine());
            NumberChecker(numList, userInput);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            OddKiller(numList);
            NumberPrinter(numList);
            
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            numList.Sort();
            Console.WriteLine(numList);

            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            

            //Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            foreach(int num in numbers)
            {
                for(int i = 0; i < numbers.Length; i++)
                {
                    if(numbers[i] % 3 == 0)
                    {
                        numbers[i] = 0;
                    }
                    else
                    {
                        continue;
                    }
                }

                Console.WriteLine(num);
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.RemoveAt(i--);
                }
            }

        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool isInList = false;

            foreach(int num in numberList)
            {
                if(num == searchNumber)
                {
                    Console.WriteLine("Your number is in the list.");
                    isInList = true;
                }
            }
            if(isInList == false)
            {
                Console.WriteLine("Your number is not in the list.");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                var num = rng.Next(0, 50);
                numberList.Add(i);
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for(int i = 0; i < numbers.Length; i++)
            {
                var num = rng.Next(0, 50);
                numbers[i] = num;
            }

            
        }        

        private static void ReverseArray(int[] array)
        {
            var length = array.Length;
            var newArray = new int[length];
            var newIndex = 0;
            
            for(int i = array.Length - 1; i >= 0; i--)
            {
                newArray[newIndex] = array[i];
                ++newIndex;
            }
            NumberPrinter(newArray);
        }

        public static void CustomReverseArray(int[] array)
        {
 
            Array.Reverse(array);
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }    
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
