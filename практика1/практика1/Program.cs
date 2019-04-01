using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика1
{

    class Program
    {
        private static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите нужное дейсвие:");
                Console.WriteLine("2. Регистрация оружия");
                Console.WriteLine("0 выход");

                int c = Int32.Parse(Console.ReadLine());
                switch (c)
                {

                    case 2:
                        examen lol = new examen();
                        lol.GetInfo();
                        break;
                    case 0:
                        flag = false;
                        break;
                }
            }
            Console.ReadKey();
        }

        class examen
        {
            public string name { get; set; }
            public float coll { get; set; }
            public double ozz { get; set; }

            //Конструктор с параметрами
            public examen(string firm, float adr, double god)
            {
                name = firm;
                coll = adr;
                ozz = god;
            }

            public examen()
            {
                name = null;
                coll = 0;
                ozz = 0;

                SetInfo();
            }


            public void SetInfo()
            {
                Console.WriteLine("Введите название:");
                name = Console.ReadLine();

                Console.WriteLine("введите калибр:");
                coll = float.Parse(Console.ReadLine());

                Console.WriteLine("введите дальность");
                ozz = Int32.Parse(Console.ReadLine());
            }

            public void GetInfo()
            {
                Console.WriteLine($"название: {name}");
                Console.WriteLine($"калибр: {coll}");
                Console.WriteLine($"дальность : {ozz}");
            }
        }
    }
}


