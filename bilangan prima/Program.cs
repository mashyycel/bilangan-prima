using System;

namespace bilangan_prima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mengecek bilangan prima, masukkan angka: ");
            int angka = Convert.ToInt32(Console.ReadLine());
            int hitung = 0;
            for (int i = 1; i<=angka;i++)
            {
                if (angka % i == 0)
                {
                    hitung = hitung +1 ;
                }
               
            }
            if (hitung == 2)
            {
                Console.Write("Angka bilangan prima");
            }
            else
            {
                Console.Write("Angka bukan bilangan prima");
            }
        }
    }
}
