using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3_1
{
    class Mnogochlen
    {
        public List<int> mnogochlen;
        public Mnogochlen()
        {
            mnogochlen = new List<int>();
        }
        public Mnogochlen(int k)
        {
            mnogochlen = new List<int>(k+1);
            for (int i = 0; i < k+1; i++) mnogochlen.Add(0);
        }
        public void vvod()
        {
            Console.Write("введи степень многочлена:");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("введи коефициенты многочлена:");
            for (int i = 0; i <= k; i++)
            {
                Console.Write("x^" + i + ": ");
                mnogochlen.Add(int.Parse(Console.ReadLine()));
            }
        }
        public override string ToString()
        {
            string s = "" + mnogochlen[0];
            for (int i = 1; i < mnogochlen.Count; i++)
            {
                if (mnogochlen[i] != 0)
                    s += "+" + mnogochlen[i] + "x^" + i;
            }
            if (s[0] == '0') s = s.Substring(2);
            return s;
        }
        public static Mnogochlen operator *(Mnogochlen a, Mnogochlen b)
        {
            Mnogochlen rez = new Mnogochlen(a.mnogochlen.Count-1 + b.mnogochlen.Count-1);         
            for (int i = 0; i < a.mnogochlen.Count; i++)
                for (int j = 0; j < b.mnogochlen.Count; j++)
                {
                    rez.mnogochlen[i + j] += a.mnogochlen[i] * b.mnogochlen[j];
                }
            return rez;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mnogochlen a = new Mnogochlen();
            Mnogochlen b = new Mnogochlen();
            a.vvod();
            Console.WriteLine(a);
            b.vvod();
            Console.WriteLine(b);
            Console.WriteLine("(" + a + ")*(" + b + ")=" + (a * b));
            Console.ReadKey();
        }
    }
}
