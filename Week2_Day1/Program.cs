using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int favoriteNumber = 12;

            //int[] favoriteNumbers = { 61, 22, 3, 44, 105, 36 };

            //string[] studentNames = { "raz", "Monica", "David", "Brian", "Ali" };

            //Console.WriteLine(favoriteNumber);
            //Console.WriteLine(favoriteNumbers[0]);
            //Console.WriteLine(studentNames[2]);

            //string[] vacationSpots = { "Bali", "New Zealand", "Fiji", "South Africa", "Mongolia", "Lake Como", "Brazil", "Tahiti", "Mexico", "Morocco" };
            //Console.WriteLine(vacationSpots[0]);
            //Console.WriteLine(vacationSpots[9]);

            //int[] childAge = { 7, 4, 12 };
            //Console.WriteLine(childAge[0]);
            //Console.WriteLine(childAge[1]);
            //Console.WriteLine(childAge[2]);

            //int[] numbers = new int[4];
            //numbers[0] = 43;

            //int[] numbers = new int[4];
            //numbers[0] = 43;
            //numbers[1] = 12;
            //Console.WriteLine("Please enter a number.");
            //numbers[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter a number.");
            //numbers[3] = int.Parse(Console.ReadLine());

            //Console.WriteLine(numbers[3]);

            string[] days = new string[7];
            days[0] = "Wednesday";
            days[1] = "Friday";
            days[2] = "Sunday";
            days[3] = "Tuesday";
            days[4] = "Saturday";
            days[5] = "Monday";
            days[6] = "Thursday";

            int[] studentAges = new int[5];
            studentAges[0] = 10;
            studentAges[1] = 17;
            studentAges[2] = 3;
            studentAges[3] = 24;
            studentAges[4] = 8;

            //Console.WriteLine(days.Length);


            //char[] lastName = { 'M', 'c', 'w', 'i', 'l', 'l', 'i', 'a', 'm', 's' };
            //Console.WriteLine(lastName.Length);

            //string[] randomStuff = { "boots", "whales", "unicycles", "putty", "bank", };
            //int index = randomStuff.Length;
            //index = index - 2;
            //Console.WriteLine(randomStuff[index]);
            //Console.WriteLine("This is the last index " + (randomStuff.Length - 1));
            //Console.WriteLine(randomStuff[randomStuff.Length - 1]);

            //Console.WriteLine("Please enter the size of your array.");
            //int arraySize = int.Parse(Console.ReadLine());

            //int[] newArray = new int[arraySize];

            //Console.WriteLine("The array is of length " + newArray.Length);

            //string[] birthMonths = { "October", "July", "October", "May" };
            //Console.WriteLine(Array.IndexOf(birthMonths, "October"));

            //int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            //Console.WriteLine(Array.LastIndexOf(numbers, 4));


            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[0]);

            //Array.Sort(numbers);
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[numbers.Length - 1]);

            string[] firstNames = { "Dana", "Latifah", "Missy", "Remy", "Aisha" };
            Console.WriteLine(Array.IndexOf(firstNames, "Latifah"));

            int[] luckyNumbers = { 5, 9, 5, 15, 3, 15, 9, 3 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 9));

            char[] alphChars = { 'Q', 'T', 'R', 'A', 'F', 'Y', 'V', 'X', 'N', 'W' };
            Console.WriteLine(alphChars[0]);

            Array.Reverse(alphChars);
            Console.WriteLine(alphChars[0]);

            string[] studentNames = { "Raz", "Dan", "Ali", "Brian", "Lakshmi", "Teresa", "Cheria" };
            Array.Sort(studentNames);
            Console.WriteLine(studentNames[0]);
            Console.WriteLine(studentNames[studentNames.Length - 1]);

            int[] favNumbers = { 27, 63, 14, 99, 57, 4, 7, 36, 80, 2 };
            Array.Sort(favNumbers);
            Console.WriteLine(favNumbers[0]);
            Console.WriteLine(favNumbers[favNumbers.Length - 1]);



             


        }
    }
}
