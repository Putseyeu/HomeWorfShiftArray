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
            const int numberElement = 5;
            int[] array = new int[numberElement] { 1, 2, 3, 4, 5 };
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
                int numberLast = array[array.Length - 1];
                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = numberLast;
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
