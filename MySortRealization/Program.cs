using System;
using System.Collections.Generic;

namespace MySortRealization
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<double> sortList = new List<double>(); // create list to collect numbers to sort
            Console.Write("Enter the number of numbers you want to sort: ");
            bool properNumberOfNumbers = Int32.TryParse(Console.ReadLine(), out int numberOfNumbers); // how much numbers user want to sort
            while (!properNumberOfNumbers) // check of proper number entering
            {
                Console.Write("Try again: ");                
                properNumberOfNumbers = Int32.TryParse(Console.ReadLine(), out numberOfNumbers);
            }
            int counter = 1;
            while (numberOfNumbers > 0) // ask to enter such amount of numbers how user decided defore
            {
                if (counter == 1)
                {
                    Console.Write($"You should type {numberOfNumbers} number(s). Type the {counter}st number: ");
                }
                else if (counter == 2)
                {
                    Console.Write($"You should type {numberOfNumbers} number(s). Type the {counter}nd number: ");
                }
                else if (counter == 3)
                {
                    Console.Write($"You should type {numberOfNumbers} number(s). Type the {counter}rd number: ");
                }
                else
                {
                    Console.Write($"You should type {numberOfNumbers} number(s). Type the {counter}th number: ");
                }
                bool properNumberToSort = Double.TryParse(Console.ReadLine(), out double numberToSort);
                while (!properNumberToSort) // check of proper number entering
                {
                    Console.Write("You should type real number. Try aagain: ");
                    properNumberToSort = Double.TryParse(Console.ReadLine(), out numberToSort);
                }                
                sortList.Add(numberToSort); // add all entered numbers to list
                numberOfNumbers--;
                counter++;
            }

            Console.Write("Here is the sorted numbers in descending order: \n");
            // alghoritm of selection sort
            for (int i = 0; i < sortList.Count; i++)
            {
                for (int j = i + 1; j < sortList.Count; j++)
                {
                    if (sortList[j] > sortList[i])
                    {
                        double temp = sortList[j];
                        sortList[j] = sortList[i];
                        sortList[i] = temp;
                    }
                }
            }
            foreach (double num in sortList) // result of sorting
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
        }
    }
}
