﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
                        Examen lol = new Examen();
                        lol.GetInfo();
                        break;
                    case 0:
                        flag = false;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
