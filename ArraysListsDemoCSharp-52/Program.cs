using System.Collections.Generic;

namespace ArraysListsDemoCSharp_52;

class Program
{
    static void Main(string[] args)
    {
        //arrays
        //arrays have a set size that you define at creation and that size cannot change

        int[] numbers = new int[5];

        numbers[4] = 5000;
        numbers[0] = 25;

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
        
        var names = new string[] { "John", "Jane", "Doe" };
        
        //arrays have a property called 'Length' that shows you the number of items in the array
        Console.WriteLine(names.Length);
        Console.WriteLine(names.Length - 1);

        for (int i = 0; i <= names.Length - 1; i++)
        {
            Console.WriteLine(names[i]);
        }
        
        //lists
        //lists have a size that can grow and shrink all you need
        List<int> numbersList = new List<int>();
        
        numbersList.Add(25);
        numbersList.Add(12);
        numbersList.Add(15);
        
        //lists have a property called 'Count' that shows you the numbers of elements in the list

        Console.WriteLine(numbersList.Count - 1);

        for (int i = 0; i <= numbersList.Count - 1; i++)
        {
            Console.WriteLine(numbersList[i]);
        }
       
    }
}
