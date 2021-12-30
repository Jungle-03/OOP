using System;
using System.Collections.Generic;
using System.Linq;


namespace _4_лаба
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;

            //создание 1-го листа
            List<string> socialNetworks = new List<string>();

            socialNetworks.Add("VK");
            socialNetworks.Add("Instagram");
            socialNetworks.Add("Telegram");




            Console.WriteLine("Список социальных сетей:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            //вывод
            foreach (string SOCIALnETWORKS in socialNetworks)
            {

                Console.WriteLine(SOCIALnETWORKS);

            }
            Console.ForegroundColor = ConsoleColor.White;

            //создание 2-го листа
            List<string> dotaHeros = new List<string>();


            dotaHeros.Add("Marci");
            dotaHeros.Add("Windranger");
            dotaHeros.Add("Skywrath Mage");


            Console.WriteLine("\nМикро список героев в доте:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            //вывод
            foreach (string Pers in dotaHeros)
            {

                Console.WriteLine(Pers);

            }
            Console.ForegroundColor = ConsoleColor.White;


            //проверка на равенство колличества элементов
            if (socialNetworks.Count == dotaHeros.Count)
            {
                Console.WriteLine("\nКолличество элементов в списках равны друг другу");

            }
            else
            {
                Console.WriteLine("\nКолличество элементов в списках не равны друг другу");
            }

            //проверка на равенство самих элементов

            if (socialNetworks == dotaHeros)
            {
                Console.WriteLine("\nЭлементы 2-х списков одинаковые ");
            }
            else
            {
                Console.WriteLine("\nЭлементы 2-х списков не одинаковые ");
            }

            //да/нет

            Console.ForegroundColor = ConsoleColor.Blue;
            bool zxc = dotaHeros.SequenceEqual(socialNetworks);
            Console.WriteLine($"\nДота и соц.цети\t{zxc}\n");
            Console.ForegroundColor = ConsoleColor.White;




            //удаление элемента из начала списка

            socialNetworks.RemoveAt(0);

            Console.WriteLine("\nСписок соц.сетей с удаленным 1-м элементом:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            //вывод
            foreach (string SOCIALnETWORKS in socialNetworks)
            {

                Console.WriteLine(SOCIALnETWORKS);

            }
            Console.ForegroundColor = ConsoleColor.White;


            //получаем(выделяем последний элемент наших листов

            Console.WriteLine("\nПервый элемент листа socialNetworks\n");
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(socialNetworks[0]);


            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nПервый элемент листа dotaHeros\n");
            Console.ForegroundColor = ConsoleColor.Cyan;


            Console.WriteLine(dotaHeros[0]);
            Console.ForegroundColor = ConsoleColor.White;


            //слияние 2-х листов

            socialNetworks.AddRange(dotaHeros);


            Console.WriteLine("\n\nОбъеденение листов");


            foreach (string bought in socialNetworks)
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine('\n');
                Console.Write(bought);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("\n\n\n\n");

            List<int> num = new List<int> { 1000, 993, 986, 979, 972, 965 };
            string str = "Лобби ?";


            DateTime.Now.Print();



            num.Diff();
            num.Sum();
            num.Elements();
            str.Upper();

                 
            Console.ForegroundColor = ConsoleColor.Yellow;



        }
    }

    class Owner
    {
        public string name;
        public string organization;
        public int id;
    }

    public class MYList<T> : List<T>
    {
        private Owner student = new Owner { name = "Jungle", organization = "BSTU", id = 9 };

        public static MYList<T> operator +(MYList<T> a, T b)
        {
            MYList<T> result = new MYList<T>();
            result = a;
            result.Add(b);
            return result;
        }
        public static MYList<T> operator --(MYList<T> a)
        {
            MYList<T> result = new MYList<T>();
            result = a;
            result.RemoveAt(result.Count() - 1);
            return result;
        }
        public static bool operator !=(MYList<T> a, MYList<T> b)
        {
            if (a.Equals(b))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool operator ==(MYList<T> a, MYList<T> b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }

    static class StatisticOperation
    {
        public static void Print(this DateTime date)
        {
            Console.WriteLine(date);
        }


        public static int Elements(this List<int> num)
        {
            int counter = 0;
            for (int i = 0; i < num.Count; i++)
            {
                counter++;
            }
            Console.WriteLine($"Элементы:\t {counter}");
            return counter;
        }
        public static int Diff(this List<int> num)
        {
            int max = num.Max();
            int min = num.Min();
            int diff = max - min;
            Console.WriteLine($"Разница между макс и мин\t {diff}");
            return diff;
        }
        public static int Sum(this List<int> num)
        {
            int sum = 0;
            for (int i = 0; i < num.Count; i++)
            {
                sum += num[i];
            }
            Console.WriteLine($"Сумма\t {sum}");
            return sum;
        }


        public static int Upper(this string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                    count++;
            }
            Console.WriteLine($"Слов с заглавной буквы:\t {count}");
            return count;

        }

       
    }
}
    
        