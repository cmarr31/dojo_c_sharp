using System;
using System.Collections.Generic;
using System.Linq;

namespace collectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to hold integer values 0 through 9.
            int[] arr1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            Console.WriteLine(names[3]);

            // Create an array of length 10 that alternates between true and false values, starting with true.
            bool[] array = {true, false, true, false, true, false, true, false, true, false};
            Console.WriteLine(array[3]);

            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("Butterscotch");
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Strawberry");
            flavors.Add("Rocky Road");

            // Output the length of this list after building it.
            Console.WriteLine(flavors.Count);

            // Output the third flavor in the list, then remove this value.
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors[2]);

            // Output the new length of the list
            Console.WriteLine(flavors.Count);

            // Create a dictionary that will store both string keys as well as string values.
            Dictionary<string,string> dict1 = new Dictionary<string,string>();
            
            // For each name in the array of names you made previously, add it as a new key in this dictionary with value null.
            foreach (string name in names){
                dict1.Add(name, null);
            }
        }
    }
}
