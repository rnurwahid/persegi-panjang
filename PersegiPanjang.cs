// 4. Perhitungan Persegi Panjang
using System;

class PersegiPanjang
{
    static void Main()
    {
        Console.WriteLine("Perhitungan Bangun Datar Persegi Panjang");
        
        Console.Write("Masukkan panjang: ");
        double panjang = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Masukkan lebar: ");
        double lebar = Convert.ToDouble(Console.ReadLine());

        int pilihan;
        do
        {
            Console.WriteLine("\nOpsi Perhitungan:");
            Console.WriteLine("1. Hitung luas");
            Console.WriteLine("2. Hitung keliling");
            Console.WriteLine("3. Hitung panjang diagonal");
            Console.WriteLine("4. Keluar program");

            Console.Write("Ketikkan pilihan Anda (1/2/3/4): ");
            pilihan = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    double luas = panjang * lebar;
                    Console.WriteLine($"Luas persegi panjang adalah {luas}");
                    break;
                case 2:
                    double keliling = 2 * (panjang + lebar);
                    Console.WriteLine($"Keliling persegi panjang adalah {keliling}");
                    break;
                case 3:
                    double diagonal = Math.Sqrt((panjang * panjang) + (lebar * lebar));
                    Console.WriteLine($"Panjang diagonal persegi panjang adalah {diagonal}");
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }
            
        } while (pilihan != 4);
    }
}