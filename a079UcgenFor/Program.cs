﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a079UcgenFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz:");
            int girilenDeger = int.Parse(Console.ReadLine());

            for (int i = 0; i < girilenDeger; i++)
            {
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
