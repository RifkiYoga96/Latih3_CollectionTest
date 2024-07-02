// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> Siswa = new List<string>()
        {
            "Rifki","Yoga","Lathif","Dhafa","Agung"
        };

        //Menampilkan Semua
        Console.WriteLine(string.Join("\n",Siswa));
    }
}

