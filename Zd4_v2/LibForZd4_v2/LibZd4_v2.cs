using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibForZd4_v2
{
    public class LibZd4_v2
    {

        public string Proverka(string txt)
        {
           
            string text = txt.ToUpper();
            List<string> permutations = new List<string>();
            string result="";
            string start = " ";
            int count = 0;
            if (text != " " && text.Length <= 26 && text.Length >= 1)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    start = text[j].ToString();
                    for (int i = 0; i < text.Length; i++)                                                            
                                                                         //Проверка на повторение букв
                    {                                                       //В первом цикле Переменная start присваивает букву из строки 
                        if (text[i].ToString() == start)                    //Во втором цикле идет проверка на повторение если буква повторяется count увеличивается. Если count>=2 цикл
                        {                                                   //останавливается и присваивает в переменную result сообщение 
                            count++;
                        }
                    }
                    if (count >= 2)
                    {
                        result=$"Буква {start} повторяется несколько раз";
                        break;
                    }
                    count = 0;
                }
            }
            else
            {
                count = 2;
                result="Недопустимая длинна";
            }
            if (count <= 1)
            {
                for (int i = 1; i < text.Length; i++)
                {
                    string part1 = text.Substring(i);
                    string part2 = text.Substring(0, i);
                    permutations.Add(part1 + part2);
                }
                permutations.Sort(); // Сортировка в лексикографическом порядке
                result = $"{permutations[0]}";
            }
            return result;
        }
        public bool FileExist()//Проверка на существование файла
        {
            bool b = true;
            if (!File.Exists("C:\\Users\\305-1\\Desktop\\ghfjfjdck\\zd4_2_v2_BelozerovKlim-main\\zd4_2\bin\\Debug\\output.txt") && !File.Exists("C:\\Users\\305-1\\Desktop\\ghfjfjdck\\zd4_2_v2_BelozerovKlim-main\\zd4_2\\bin\\Debug\\output.txt"))
                b = false;


            return b;
        }


    }
}
