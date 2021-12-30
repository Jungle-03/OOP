using System;
using System.Linq;
using System.Text;

namespace Лаба_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Jungle";


            string a;
            Console.WriteLine("Введите значение переменной типа string");
            a = Console.ReadLine();
            Console.WriteLine("Вы ввели...");
            Console.WriteLine(a);

            int b;
            Console.WriteLine("Введите значение переменнорй типа int");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вы ввели...");
            Console.WriteLine(b);

            bool c;
            c = true;
            Console.WriteLine("Значение переменнорй типа bool");
            Console.WriteLine(c);

            Console.WriteLine();


            Console.WriteLine("Значение переменнорй типа float");
            float f = 1000.7f;//для флота нужно писать f 
            Console.WriteLine(f);
            Console.WriteLine();

            Console.WriteLine("Значение long равно");
            long l = 988989898989909090L;// l можно писать а можно и не писать
            Console.WriteLine(l);
            Console.WriteLine();

            Console.WriteLine("Значение типа double равно");
            double d = 1000.993;
            Console.WriteLine(d);
            Console.WriteLine();

            decimal dd;
            dd = 32.36276328M;
            Console.WriteLine("Вы ввели заначение " + dd);

            //
            int value = 1000;
            object boxValue = (object)value;
            //это запаковка

            int unboxValue = (int)boxValue;
            //распаковка

            //
            var zxc = 9; // неявно типизорованная переменная 
            var cxz = "dkkd";

            int hdsf = 7;
            long eweweee = 9l;
            eweweee = hdsf;//не явное
            hdsf = (int)eweweee;//явное 
            //

            int? lll = null;
            //

            //var qqq = 347398;
            //qqq = "kdskdsk";

            //


            



            Console.WriteLine("Для перехода к заданиям строк нажмите люблую клавишу ( Но Enter лучше :)) )");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;





            string jjj = "Привет чел";
            string zzz = "dek4";

            bool aqaq = jjj.Equals(zzz);
            Console.WriteLine(aqaq);

            //


            string s1 = "Строка 1";
            string s2 = " Строка 2";
            string s3 = "Строка 3";
            Console.WriteLine(s1 + s2 + s3);//сцепление
            string s4 = s1;//типо скопировал
            Console.WriteLine(s4);

           ///////////////////// начнем выделение строк
            string string1 = "this is numger 1";
            Console.WriteLine(string1);
            Console.WriteLine("Это строка number 1\n");
            string string2 = string1.Substring(6, 8);
            Console.WriteLine(string2);
            Console.WriteLine("Это строка number 2\n");

            string s = "ora ora ora muda muda muda. yare yare dazai";

            string[] subs = s.Split(' ');

            foreach (var sub in subs)
            {
                Console.WriteLine(sub);
            }

            //Вставка подстроки в заданную позицию

            string bb = "Eren Yeager";
            Console.WriteLine("Оригинальная строка: " + bb + '\n');
            string bbM1 = bb.Insert(4, " JOOOOOJOOO ");
            Console.WriteLine("Модифицированная строка при помощи Insert: \t" + bbM1 + '\n');

            //удаление заданнойподстроки

            string bbD1 = bb.Remove(4);
            Console.WriteLine("Строка с удалением:\t" + bbD1 + '\n');

            //интерполирование строк 
            Console.WriteLine($"Вывод строки с помощью интерполирования\t{bb} \n");

            //пустые и null строки

            string s12 = "abcd";
            string s22 = "";
            string s32 = null;

            Console.WriteLine("String s1 {0}.", Test(s12));
            Console.WriteLine("String s2 {0}.", Test(s22));
            Console.WriteLine("String s3 {0}.", Test(s32));

            String Test(string s)//конструктор объекта 
            {
                if (String.IsNullOrEmpty(s))
                    return "is null or empty";
                else
                    return String.Format("(\"{0}\") не является ни нулевым, ни пустым", s);
            }

            Console.WriteLine("\n");



            StringBuilder sbbb = new StringBuilder("Jungle");
            Console.WriteLine(sbbb + "\n");




            Console.WriteLine("Для перехода к заданиям массивов  нажмите люблую клавишу ( Но Enter лучше :)) )");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();



            //
            int n = 5;
            int m = 4;
            int[,] mas = new int[n, m];
            Random rn = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    mas[i, j] = rn.Next(10) * 10;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("{0,3}", mas[i, j]);
                Console.WriteLine();
            }


            Console.WriteLine("\n");
            //



            string[] persons = new string[] { "Eren", "Mikasa", "Adam", "Levi" };
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = persons[i];
                Console.WriteLine(persons[i] + "\t" + "Это элемент №" + i);

            }
            Console.WriteLine("Колличество элементов :" + persons.Length);




            var arrayStepwise = new int[3][];

            arrayStepwise[0] = new int[2];
            arrayStepwise[1] = new int[3];
            arrayStepwise[2] = new int[4];

            Console.WriteLine("Enter :");

            for (int i = 0; i < arrayStepwise.Length; i++)
            {
                for (int j = 0; j < arrayStepwise[i].Length; j++)
                {
                    arrayStepwise[i][j] = rn.Next(50);
                }

            }

            Console.WriteLine();

            for (int i = 0; i < arrayStepwise.Length; i++)
            {
                for (int j = 0; j < arrayStepwise[i].Length; j++)
                {
                    Console.Write(arrayStepwise[i][j] + " ");

                }
                Console.WriteLine();
            }





            /////////////////////

            Console.WriteLine("Для перехода к заданиям кортежи  нажмите люблую клавишу ( Но Enter лучше :)) )");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();


            (int, string, char, string, ulong) tuple = (993, "Kaneki", '?', "JoJo", 50);
            Console.WriteLine(tuple);
            Console.WriteLine(tuple.Item1 + "\t" + tuple.Item2 + "\t" + tuple.Item3);



            var (qwer, name, symbol, surname, number) = tuple; //распаковка 1
            Console.WriteLine($"qwer: {qwer} symbol: {symbol} ");
            (qwer, name) = (1000, "Tilted"); //распаковка 2

            var tuple2 = (14, who: "Jungle", sex: 'M', Tilted: "yes", Convert.ToUInt64(123456789));
            Console.WriteLine($"{tuple} == {tuple2} {tuple == tuple2}");

            //////////////////////

            Console.WriteLine("Для перехода к последниму заданию нажмите люблую клавишу ( Но Enter лучше :)) )");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();


            (int, int, int, char) foo(int[] arr, string str)
            {
                return (arr.Max(), arr.Min(), arr.Sum(), str[0]);
            }
            var arr = new int[10];
            var rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(30);
                Console.Write(arr[i] + " ");
            }
            string str = "Jungle";
            var res = foo(arr, str);
            Console.WriteLine("\n" + res);

           
            
            
           
            int rrr = 6;

            unsafe
            {
                int* iiii  = &rrr;
            }

             

        }







    }
}
