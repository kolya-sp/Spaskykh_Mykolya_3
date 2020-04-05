using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_3
{
    class Program
    {
        static void Main(string[] args)
        {                          
            Console.WriteLine("Обробляючи тільки додатні числа, отримати послідовність їх останніх цифр і видалити в отриманої послідовності всі входження однакових цифр, крім першого. Порядок отриманих цифр повинен відповідати порядку вихідних чисел ");
            int[] numbers = { 1, 333, -2, 3, -4, -10, 34, 55, -66, 77, -88, 33 };
            Console.Write("mas: "); foreach (var a in numbers) Console.Write(a + ",");
            Console.WriteLine();
            IEnumerable<int> evens = (from n in numbers
                                      where n > 0
                                      select n % 10).Distinct();
            Console.Write("rez: ");
            foreach ( var a in evens)
            {
                Console.Write(a+",");
            }
            Console.ReadKey();
        }
    }
}
