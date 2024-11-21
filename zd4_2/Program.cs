using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zd4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = File.OpenText("input.txt");
            string text = sr.ReadLine();
            sr.Close();
            int n = text.Length;
            string start = " ";
            int count = 0;
            List<string> permutations = new List<string>();


            for (int j = 0; j < text.Length; j++)
            {
                start = text[j].ToString();
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i].ToString() == start)
                    {
                        count++;
                    }


                }
                    if (count >= 2)
                {

                    Console.WriteLine($"Буква {start} повторяется несколько раз");
                   
                    break;
                }
                count = 0;


            }

            if (n <= 26 && n >= 1&&count<=1)
            {
                for (int i = 1; i < n; i++)
                {
                    string part1 = text.Substring(i);
                    string part2 = text.Substring(0, i);
                    permutations.Add(part1 + part2);
                }
                permutations.Sort(); // Сортировка в лексикографическом порядке
                Console.WriteLine(text);
                Console.WriteLine();
                Console.WriteLine(permutations[0]);
            }

            


        }
    }
}
