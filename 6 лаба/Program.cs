using System;

namespace _5_лаба
{
    struct Elprimo
    {
        public int health;
        public int damage;
        public int hits;
    }

    struct Spike
    {
        public int health;
        public int damage;
        public int hits;
    }



    enum zxc { kaneki, haise_sasaki, One_Eyed_King };

    class Ghoul
    {
        public zxc Kaneki_Names;

        public Ghoul(zxc Kaneki_Names)
        {
            this.Kaneki_Names = Kaneki_Names;
        }

        public void Print_Kaneki_Names()
        {
            Console.WriteLine(Kaneki_Names);
        }
    }








    interface IHasInfo
    {
        void ShowInfo();
    }




    abstract class Wearpon : IHasInfo
    {
        public abstract int Damage { get; }
        public abstract void Fire();

        public void ShowInfo()
        {
            Console.WriteLine(GetType().Name);
            Console.WriteLine($"Урон\t{Damage}");
        }

    }


    class Gun : Wearpon
    {

        public override int Damage => 3;

        public override void Fire()
        {
            Console.WriteLine("Пиу пиу пиу");
        }
    }

    class Kagune : Wearpon
    {
        public override int Damage => 993;

        public override void Fire()
        {
            Console.WriteLine("Познай боль от моего кагуне");
        }
    }


    class Bow : Wearpon
    {
        public override int Damage => 5;

        public override void Fire()
        {
            Console.WriteLine("Вввввтыыыычччч");
        }
    }





    class Player
    {
        public void Fire(Wearpon weapon)
        {
            weapon.Fire();

        }

        public void CheckInfo(IHasInfo HasInfo)
        {
            HasInfo.ShowInfo();
        }

    }
    class avtobot
    {
        internal void zxc()
        {
           
        }
    }



    class Program
    {
        static void Main(string[] args)
        {


            Player Jungle = new Player();

            Wearpon[] invertoty = { new Gun(), new Kagune(), new Bow() };
            foreach (var item in invertoty)
            {
                Console.ForegroundColor = ConsoleColor.White;


                Console.WriteLine("Jungle стреляет из");
                Jungle.CheckInfo(item);
                Jungle.Fire(item);
                Console.WriteLine();
            }




            //...................Эльпримо.................//


                Elprimo info;
                info.health = 7000;
                info.damage = 800;
                info.hits = 3;


                Console.ForegroundColor = ConsoleColor.Blue;

                int ElprimoTotalDamage = info.damage * info.hits;
                Console.WriteLine($"Информация о бравлере Эльпримо:\nЗдоровье\t{info.health}\nУрон от 1-го попадания\t{info.damage}\nКоличество ударов с 1-й атаки\t{info.hits}\n" +
                    $"Общий урон при всех попаданий\t{ElprimoTotalDamage}\n\n");



            //...................Спайк...................//



            Console.ForegroundColor = ConsoleColor.Green;

            Spike SpikeInfo;
            SpikeInfo.health = 4000;
            SpikeInfo.damage = 480;
            SpikeInfo.hits = 5;

            int SpikeTotalDamage = SpikeInfo.damage * SpikeInfo.hits;

            Console.WriteLine($"Информация о бравлере Спайк:\nЗдоровье\t{SpikeInfo.health}\nУрон от 1-го попадания\t{SpikeInfo.damage}\nКоличество ударов с 1-й атаки\t{SpikeInfo.hits}\n" +
                    $"Общий урон при всех попаданий\t{SpikeTotalDamage}\n\n");


            //.................Макс урон................//

            Console.ForegroundColor = ConsoleColor.Magenta;


            Console.WriteLine("Максимальный урон \n");

            if (SpikeTotalDamage > ElprimoTotalDamage)
            {
                Console.WriteLine("Максимальный урон имеет спайк");
            }
            if (SpikeTotalDamage < ElprimoTotalDamage)
            {
                Console.WriteLine("Максимальный урон имеет эльпримо");
            }
            if (SpikeTotalDamage == ElprimoTotalDamage)
            {
                Console.WriteLine($"Урон у 2-х блавлеров одинаковый, и равен\t{SpikeTotalDamage}\n\n");
            }


            //................Перечисления................//


            Console.ForegroundColor = ConsoleColor.Red;

            Ghoul FirstSeason = new Ghoul(zxc.kaneki);
            Ghoul ThirtSeason = new Ghoul(zxc.haise_sasaki);
            Ghoul FourthSeason = new Ghoul(zxc.One_Eyed_King);

            Console.WriteLine("Имя kaneki в 1м и 2м сезоне\n");
            FirstSeason.Print_Kaneki_Names();
            
            Console.WriteLine("Имя kaneki в 3м сезоне\n");
            ThirtSeason.Print_Kaneki_Names();
            
            Console.WriteLine("Имя kaneki в 4м сезоне\n");
            FourthSeason.Print_Kaneki_Names();
            
        }
    }
}







