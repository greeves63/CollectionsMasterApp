using System;
using System.Collections.Generic;

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
            // Create an integer Array of size 50

            int[] Array1 = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(Array1);

            //Print the first number of the array
            Console.WriteLine($"\nFirstArrayNumber: {Array1[0]} \n---------------");
            //Print the last number of the array            
            Console.WriteLine($"LastArrayNumber: {Array1[^1]} \n---------------");
            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists
            NumberPrinter(Array1);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */
            Array.Reverse(Array1);

            Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(Array1);

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(Array1);
            NumberPrinter(Array1);
            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(Array1);
            NumberPrinter(Array1);
            Console.WriteLine();
            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(Array1);
            NumberPrinter(Array1);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List
            List<int> integerList = new List<int>();

            //Print the capacity of the list to the console

            Console.WriteLine($"Capacity of the list: {integerList.Capacity}");

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(integerList);

            //Print the new capacity
            Console.WriteLine($"Capcity after the population: {integerList.Capacity}");

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" on accident, your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int searchNumber = int.Parse(Console.ReadLine());
            NumberChecker(integerList, searchNumber);
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(integerList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
            OddKiller(integerList);
            NumberPrinter(integerList);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");
            integerList.Sort();
            NumberPrinter(integerList);
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable
            var arrayStoreVari = integerList.ToArray();

            //Clear the list
            integerList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
        }

        private static void OddKiller(List<int> integerList)
        {
            for (int i = 0; i < integerList.Count; i++)
            {
                if (integerList[i] % 2 == 0)
                {
                    integerList.Remove(integerList[i]);
                }
            }
        }

        private static void NumberChecker(List<int> integerList, int searchNumber)
        {
            if (integerList.Contains(searchNumber))
            {
                Console.WriteLine("\n Number is found!!!!! \n");
            }
            else
            {
                Console.WriteLine("404 NOT FOUND!!!!!!");
            }
        }

        private static void Populater(List<int> integerList)
        {
            Random rng = new Random();
            for (int i = 0; i < integerList.Length; i++)
            {
                int rando = rng.Next(100);
                integerList[i] = rando;

            }

            private static void Populater(int[] Array1)
            {
                Random rng = new Random();
                for (int i = 0; i < Array1.Length; i++)
                {
                    int rando = rng.Next(100);
                    Array1[i] = rando;
                }
            }

            private static void ReverseArray(int[] array)
            {
                int variTemp = 0;
                int lastIndex = array.Length - 1;
                for (int i = 0; i < array.Length / 2; i++)
                {
                    variTemp = array[i];
                    array[i] = array[lastIndex - i];
                    array[lastIndex - i] = variTemp;
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
}