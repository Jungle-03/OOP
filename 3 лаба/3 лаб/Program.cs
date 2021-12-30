using System;

namespace _3_лаб
{

    public class Car
    {
        //начнем объявления свойств

        private string marka;
        public string Marka
        {
            get { return marka; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    marka = value;
                else
                    Console.WriteLine("Неккоретные данные");
            }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }

        }

        private int dateOfmade;
        public int DateOfmade
        {
            get { return dateOfmade; }
            set { dateOfmade = value; }
        }
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private string number;
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public static int Counter { get; private set; }

        public void Print()
        {
            Console.WriteLine($"Марка\t{marka} ");
            Console.WriteLine($"Модель\t{model} ");
            Console.WriteLine($"Номер\t{number} ");
            Console.WriteLine($"Дата производства\t{dateOfmade} ");
            Console.WriteLine($"Цвет\t{color} ");
            Console.WriteLine($"Цена\t{price} ");

        }

        public Car(string marka, string model, int dateOfmade, string color, int price, string number) 
        {

            Marka = marka;
            Model = model;
            DateOfmade = dateOfmade;
            Color = color;
            Price = price;
            Number = number;

            Counter++;
        }
        //делаю 2й конструктор
        public Car()//конструктор без параметров
        {
            
        }
        // 3й (параметры по умолчанию)
        public Car(string marka = "Kakein", string model="1234",int dateOfmade = 2010,string color ="Pink", int price = 4000,string number ="JOJO DIO-5",string kyzov ="pupe") 
        {


            Marka = marka;
            Model = model;
            DateOfmade = dateOfmade;
            Color = color;
            Price = price;
            Number = number;


            Counter++;
         }
        // саттический конструктор
        static Car()
        {
           
        }

        
     
    }



        class Program
        {

            static void Main(string[] args)
            {


                Car[] cars = new Car[3];


                Console.WriteLine("Информация о машинах", "\n");

                cars[0] = new Car("Merin", "228X", 2020, "White", 10000, "1000 AV-7");



                cars[1] = new Car("BMW", "QWE", 2021, "Black", 12000, "1032 AG-6");


                cars[2] = new Car("Merin", "ZXC", 2021, "Black", 993000, "1000 ZXC-7");



                //Вывод всех машин

                for (int i = 0; i < cars.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    cars[i].Print();

                    Console.WriteLine('\n');

                }

                Console.WriteLine($"Колличество машин: {Car.Counter}", "\n");



                // вывод определеннх машин



                string zzz;
                Console.WriteLine("Напишите Название марки");
                zzz = Console.ReadLine();
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Red;

                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i].Marka == zzz)
                        cars[i].Print();
                }

                Console.WriteLine("\n");

                Console.WriteLine("Напишите дату изготовления с которой начтется наш список", "\n");

                int DDData;
                DDData = int.Parse(Console.ReadLine());


                for (int i = 0; i < cars.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (cars[i].DateOfmade >= DDData)

                        cars[i].Print();
                    Console.WriteLine('\n');
                }
                Console.ForegroundColor = ConsoleColor.White;




            }


        }

    }







        