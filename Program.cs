using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorfShiftArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numberElement = 4;
            int[] array = new int[numberElement] { 1, 2, 3, 4};
            int numberOffset;

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Введите число для сдвига");
            numberOffset = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < numberOffset; i++)
            {
                int numberTemp = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = numberTemp;
            }

            Console.WriteLine("Новый массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }

            Console.WriteLine();
        }
    }
}
