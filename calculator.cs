using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pilih menu calculator : ");
            Console.Write("\n1. Penambahan");
            Console.Write("\n2. Pengurangan");
            Console.Write("\n3. Perkalian");
            Console.Write("\n4. Pembagian");
            Console.Write("\nInput nomor menu : ");
            int nomor = int.Parse(Console.ReadLine());

            Console.Write("Ïnputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Ïnputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (nomor == 1)
            {
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan( a, b));
            }

            else if (nomor == 2)
            {
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }

            else if (nomor == 3)
            {
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }

            else if (nomor == 4)
            {
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }

            else
            {
                Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
            }

            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }

    }
}
