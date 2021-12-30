using System;
using System.IO;

namespace _7_лаба
{
    class Program
    {




        static void Main(string[] args)
        {
            Console.WriteLine("Напишите число!");

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Вы ввели число\t{num}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы болван, вам же было сказано написать число!");
            }




            String line;
            try
            {

                StreamReader sr = new StreamReader("C:/Users/User/Desktop/zxc.txt");

                line = sr.ReadLine();

                while (line != null)
                {

                    Console.Write($"{line} ");

                    line = sr.ReadLine();
                }

                sr.Close();
                Console.ReadLine();
                Console.WriteLine("\nНа консоль была выведена вся информация из файла zxc");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }





            try
            {
                Console.WriteLine("\nПопробуем поделить на 0");
                int a = 10; int b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nDivideByZeroException");
            }




            try
            {
                int[] mass = { 1, 2, 3, 4, 5 };
                Console.WriteLine("\nЭлемент 5 = " + mass[5]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nIndexOutOfRangeException");
            }

            try
            {
                object obj = "zxc";
                int num = (int)obj;     
                Console.WriteLine($"\nРезультат: {num}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nИсключение: {ex.Message}");
            }
        }
    }
}
