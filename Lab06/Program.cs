using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 2, 1, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            array = insertionSort(array);
            int iteration = 1;
            Console.WriteLine("--Sorted Array--");
            PrintArray(array);
            Console.WriteLine("Number of steps: " + Math.Pow(array.Length,2));
            while (true)
            {
                Console.WriteLine("Do you want to impove the no of steps? (Y/N)");
                string input = Console.ReadLine();
                if (input == "Y")
                {

                }
                else
                {
                    break;
                }
            }
            
        }
        static private int[] insertionSort(int[] array)
        {
            int val, flag;
            for (int i = 1; i < array.Length; i++)
            {
                val = array[i];
                flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            return array;
        }
        static private void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
