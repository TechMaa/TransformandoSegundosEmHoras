﻿using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, horas, resto, minutos, segundos;

            Console.WriteLine("DIGITE OS SEGUNDOS");
            n = int.Parse(Console.ReadLine());

            horas = n / 3600;
            resto = n % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

            Console.ReadLine();
        }
    }
}