using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*15. Дан массив из n чисел как положительных, так и отрицательных. 
    Нужно сначала записать положительные числа, а затем 
    отрицательные в том же порядке, как они были записаны 
    в исходном массиве.*/

namespace Lab_4_1_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < array.Length; i++)
                if (array[i] >= 0)
                    Console.Write(array[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0)
                    Console.Write(array[i] + " ");
            Console.WriteLine("\n");

            // Тоже самое с помощью Linq:
            // С помощью операторов запроса
            var plus = from q in array 
                        where q >= 0 
                        select q;
            foreach (var item in plus)
                Console.Write(item + " ");
            Console.WriteLine();
            // Принудительный запрос
            var minus = (from q in array
                        where q < 0
                        select q).ToArray();
            foreach (var item in minus)
                Console.Write(item + " ");
            Console.WriteLine();

            // C использованием методов расширений
            var zero = array.Where(i => i == 0);
            foreach (var item in zero)
                Console.Write(item + " ");

            Console.ReadKey();
        }
    }
}
