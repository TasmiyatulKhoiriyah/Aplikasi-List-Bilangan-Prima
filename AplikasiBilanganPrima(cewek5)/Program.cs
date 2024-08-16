﻿using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int n = 1000; // Ubah nilai n untuk mencari bilangan prima hingga angka tertentu
        List<int> bilanganPrima = new List<int>();

        for (int i = 2; i <= n; i++)
        {
            bool isPrima = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrima = false;
                    break;
                }
            }

            if (isPrima)
            {
                bilanganPrima.Add(i);
            }
        }
        Console.WriteLine("Nama:Tasmiyatul Khoiriyah");
        Console.WriteLine("No absen:35");
        Console.WriteLine("Kelas:10PPLG");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Bilangan prima hingga " + n + ":");
        foreach (int prima in bilanganPrima)
        {
            Console.WriteLine(prima + " ");
        }
    }
}
