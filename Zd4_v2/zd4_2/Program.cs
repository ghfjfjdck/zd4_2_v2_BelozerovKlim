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

            StreamReader sr = File.OpenText("input.txt");//Чтение из файла input.txt
            
            string text = sr.ReadLine().ToUpper(); // Присваивание переменной text строку из файла
            sr.Close();// Закрытие файла
            string start = " ";//Переменная start нужна для проверки на повтор букв
            int count = 0; // Переменная count нужна для проверки
            List<string> permutations = new List<string>(); //Лист нужен для сохранения вариаций перемешивания
            if (text!=" " &&text.Length <= 26 && text.Length >= 1)//Если text не пустой и размер меньше или равен 26 и больше или равен 1
            {
                for (int j = 0; j < text.Length; j++)               
                {
                    start = text[j].ToString();
                    for (int i = 0; i < text.Length; i++)                   //Проверка на повторение букв
                    {                                                       //В первом цикле Переменная start присваивает букву из строки 
                        if (text[i].ToString() == start)                    //Во втором цикле идет проверка на повторение если буква повторяется count увеличивается. Если count>=2 цикл
                        {                                                   //останавливается и выводится сообщение 
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
            }
            else
            {
                count = 2;
                Console.WriteLine("Недопустимая длинна ");
            }
            

            if ( count <= 1)
            {
                for (int i = 1; i < text.Length; i++)
                {
                    string part1 = text.Substring(i);
                    string part2 = text.Substring(0, i);        //Сохранение в лист всех возможных перестановок
                    permutations.Add(part1 + part2);
                }
                permutations.Sort(); // Сортировка в лексикографическом порядке
                Console.WriteLine(text);
                Console.WriteLine();
                Console.WriteLine(permutations[0]);
                StreamWriter sw = File.AppendText("output.txt"); // Запись в файл
                sw.WriteLine(permutations[0]);
                sw.Close(); // Закрытие файла
            }
            

            Console.ReadLine();


        }
    }
}
