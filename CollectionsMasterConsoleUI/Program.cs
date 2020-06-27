using System;
using System.Collections.Generic;
using System.Threading;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            // This creates an integer with an index of 50.
            int[] numbers = new int[10];
            Console.WriteLine("You have an empty array! Lets populate it! Press any key to do that!");
            Console.ReadLine();
            //this calls the method and connects the array to it. 
            Populater(numbers);
            Console.WriteLine("Array is populated, press any key to continue.");
            Console.ReadLine();

            //this prionts the first number in the array
            Console.WriteLine($"The first number in this Array is {numbers[0]}. Press any key to continue.");
            Console.ReadLine();
            //this prints that last number in the array           
            Console.WriteLine($"The last number in this array is {numbers[numbers.Length - 1]}. Press any key to continue.");
            Console.ReadLine();

            Console.WriteLine("All Numbers of the original Array");
            //this calls another method and connects it to the array
            NumberPrinter(numbers);
            Console.WriteLine("Press any key to continue");
            Console.WriteLine("-------------------------");
            Console.ReadLine();

            //this outputs the numbers of the array in reverse
            Array.Reverse(numbers);
            Console.WriteLine("All Numbers Reversed: Press any key to Continue.");
            Console.ReadLine();

            Console.WriteLine("---------REVERSE CUSTOM------------");
            //this calls the method and connects it to the array.
            Console.WriteLine("Here is the Array in reverse");
            ReverseArray(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("Press any key to continue");
            Console.WriteLine("--------------------------");
            Console.ReadLine();

            Console.WriteLine("We will now remove any multiples of three and replace them with 0. Press any key to continue. ");
            Console.ReadLine();
            //this calls the method and connects it to the array.
            ThreeKiller(numbers);
            NumberPrinter(numbers);
            Console.WriteLine("Wasnt that cool! Press any key to continue.");
            Console.WriteLine("-------------------------------------------");
            Console.ReadLine();
            //Sort the array in order now
            Array.Sort(numbers);
            Console.WriteLine("Numbers are sorted.");

            Console.WriteLine("\n************End Arrays*************** \n");
            Console.WriteLine("To continue to lists press any key");
            Console.ReadLine();
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            //This creates the list. it is currently empty.
            List<int> numberList = new List<int>();

            //This prints the capacity of the list to the console.
            Console.WriteLine($"Your list currently has a capacity of {numberList.Capacity}. We " +
                $"will now populate that list. Press any key to continue.");
            Console.ReadLine();

            //this calls the method to populate the list.            
            Populater(numberList);
            Console.WriteLine("The list is now populated. Press any key to continue");
            Console.ReadLine();

            //Print the new capacity
            Console.WriteLine($"Your new capacity is {numberList.Capacity}! Congrats!");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();

            //User input
            Console.WriteLine("What number will you search for in the number list?");
            int userNumber = int.Parse(Console.ReadLine());
            NumberChecker(numberList, userNumber);
            Console.WriteLine("-------------------");
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

            Console.WriteLine("Here is a list of all the Numbers on your list!");
            //Prints all numbers in the list
            NumberPrinter(numberList);
            Console.WriteLine("Isnt this cool?");
            Console.WriteLine("---------------");
            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();

            //Connects to the method
            Console.WriteLine("Do you know what I like? Even numbers. Lets get rid of those pesky oddy's");
            Console.WriteLine("Press anything to keep going!");
            Console.ReadLine();
            OddKiller(numberList);
            NumberPrinter(numberList);
            Console.WriteLine("Just look at that!");
            Console.WriteLine("------------------");
            Console.WriteLine("You know what to do.");
            Console.ReadLine();

            //Sorts list
            Console.WriteLine("Here are the odds sorted! Yay!");
            numberList.Sort();
            NumberPrinter(numberList);
            Console.WriteLine("This is the end isnt it?");
            Console.WriteLine("------------------------");

            //Converts the list to an array and stores that into a variable
            var arrayDromList = numberList.ToArray();

            //Clear the list
            numberList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers) //this method turns all the multiples of 3 to 0.
        {
            for(int i = 0; i < numbers.Length; i++) //this checks var i with the numbers in the list
            {
                if(numbers[i] % 3 == 0) //his selects the multiples of 3
                {
                    numbers[i] = 0;//this changes them to 0
                }
            }
        }

        private static void OddKiller(List<int> numberList) //This removes the odd numbers from the list
        {
            for(int i = 0; i < numberList.Count; i++)//issues with this one.
            {
                if(numberList[i] % 2 != 0) //this should single out the odds
                {
                    numberList.Remove(numberList[i]);//this should remove those numbers
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)//this makes sure the user input is valid
        {
            if (numberList.Contains(searchNumber)) //if the user input is in the list
            {
                Console.WriteLine("Number Found!");
            }
            else
            {
                Console.WriteLine("Number not found! Too bad.");//if the user input isnt in the list
            }
        }

        private static void Populater(List<int> numberList)//This populates the list with random numbers.
        {
            Random rng = new Random();//this generates a random number
            for(int i = 0; i < 10; i++)//this is the for loop for this
            {
                int rando = rng.Next(50);//this generates the number belwo 50
                numberList.Add(rando);//this adds these numbers to the list
            }
           
        }

        private static void Populater(int[] numbers)//This Method populates the array with random numbers.
        {
            Random rng = new Random();//sets up the random var
            for(int i = 0; i < numbers.Length; i++)//for loop
            {
                int rando = rng.Next(100);//this generates the numbers below 100
                numbers[i] = rando;//tjhis adds these numbers to the array
            }
        }        

        private static void ReverseArray(int[] array) // this method prints out the arrays numbers in reverse. 
        {
            int temp = 0;//makes the temp var
            int lastIndex = array.Length - 1;//makes the var that is the last number of the array
            for(int i = 0; i < array.Length / 2; i++) //the for loop for this
            {
                temp = array[i];//makes temp = the index of the array
                array[i] = array[lastIndex - i];//these two switch the numbers around....
                array[lastIndex - i] = temp;
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
