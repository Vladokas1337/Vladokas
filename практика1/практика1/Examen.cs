using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Examen
    {
        public string Name { get; set; }
        public float Coll { get; set; }
        public double Ozz { get; set; }

        //Конструктор с параметрами
        public Examen(string firm, float adr, double god)
        {
            Name = firm;
            Coll = adr;
            Ozz = god;
        }

        public Examen()
        {
            Name = null;
            Coll = 0;
            Ozz = 0;

            SetInfo();
        }


        public void SetInfo()
        {
            Console.WriteLine("Введите название:");
            Name = Console.ReadLine();

            Console.WriteLine("введите калибр:");
            Coll = float.Parse(Console.ReadLine());

            Console.WriteLine("введите дальность");
            Ozz = Int32.Parse(Console.ReadLine());
        }

        public void GetInfo()
        {
            Console.WriteLine($"название: {Name}");
            Console.WriteLine($"калибр: {Coll}");
            Console.WriteLine($"дальность : {Ozz}");
        }
    }
}
