using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace lab_3_2
{
    class Program
    {
        static async Task Main(string[] args) // для асинхронних методів
        {
            Console.Write("Введи строку: ");
            string s1 = Console.ReadLine();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (dic.Keys.Contains(s1[i].ToString())) dic[s1[i].ToString()] += 1;
                else dic.Add(s1[i].ToString(), 1);
            }
            string json = JsonSerializer.Serialize<Dictionary<string, int>>(dic); // джейсон відмовляеться сприймати Dictionary<char, int> тому перетворив в Dictionary<string, int>
            Console.WriteLine(json);
            using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate)) // асинхронно записав в файл user.json
            {
                await JsonSerializer.SerializeAsync<Dictionary<string, int>>(fs, dic);
                Console.WriteLine("Data has been saved to file");
            }
            Console.ReadKey();
        }
    }
}