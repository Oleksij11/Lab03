﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals animal = new("Дориан", 3, "мужской", "кошачьи");
            animal.Information();

            Cats cat = new("Тихон", 6, "мужской", "кошачьи", "сибирский");
            cat.Information();

            Animals animal1 = cat;
            animal1.Information();

            Cats cat1 = (Cats)animal1;
            cat1.Information();

            Console.ReadLine();
        }
    }
}
