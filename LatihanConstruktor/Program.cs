﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanConstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat object mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            CetakHasil(mhs1);

            Console.WriteLine(); //baris kosong

            //membuat objek mhs2
            Mahasiswa mhs2 = new Mahasiswa("12345", "paijo");
            CetakHasil(mhs2);

            Console.ReadKey();

        }

        static void CetakHasil(Mahasiswa mhs)
        {
            Console.WriteLine("Nim: {0}", mhs.Nim);
            Console.WriteLine("Nama: {0}", mhs.Nama);
        }

    }
}
