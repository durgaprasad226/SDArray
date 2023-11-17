using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================== Single Dimensional Arrays=============================");

            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            int[] marks = new int[10];  //DECLARATION of an array....
            marks[0] = 69;
            marks[1] = 35;
            marks[2] = 76;
            marks[3] = 24;
            marks[4] = 26;
            marks[5] = 91;
            marks[6] = 70;
            marks[7] = 53;
            marks[8] = 80;
            marks[9] = 69;
            Console.WriteLine(marks.Sum());
            Console.WriteLine(marks.Min());
            Console.WriteLine(marks.Max());
            Console.WriteLine(marks.Average());
            Console.WriteLine(marks[0]=100);
            Console.WriteLine(marks.Sum());
            Console.WriteLine(marks.Contains(101));
            Console.WriteLine(marks.Contains(100));
            Array.Sort(marks);
            Array.Reverse(marks);
            Console.WriteLine(Array.LastIndexOf(marks, 80));
            Console.WriteLine(Array.LastIndexOf(marks, 69));
            Console.WriteLine("========================foreach===========================");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.ReadKey();

            string[] cars = new string[5] { "MG Hector", "Verna", "Baleno", "BMW", "Audi" }; //DECLARATION and INITIALIZATION at the same time....
            Console.WriteLine(cars[0]);                                                 //Finding a particular element using index numbers....
            Console.WriteLine(cars[4]);
            cars[4] = "Benz";                                                           //Assigning a new value to 5th element....
            Console.WriteLine(cars.Length);                                             //Finding the length of an array....
            Array.Sort(cars);                                                           //Sorting the array elements....
            Array.Reverse(cars);                                                        //Reversing the elements of an array....
            Console.WriteLine(Array.IndexOf(cars, "MG Hector"));                        //Finding the index of particular element....
            Console.WriteLine(cars.Contains("MG Hector"));                              //Checking whether an element is present or not. Returns bool value....
            Console.WriteLine(cars.Contains("Swift"));                                  //Returns false bcoz Swift is not present....
            Console.WriteLine(Array.Find(cars, name => name.StartsWith("V")));          //Returns elements with starting letter "V"....
            foreach (string car in cars)                                                //Prints all the elements of an array....
            {
                Console.WriteLine(car);
            }
            Console.ReadKey();
        }
    }
}
