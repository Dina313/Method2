using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklrasai variabel
            int hasil;

            // membuat objek dari class Calculator
            Class_calculator calculator = new Class_calculator();

            // panggil method Penjumlah
            hasil = calculator.Penjumlah(10, 2);
            CetakHasil("Hasil Penjumlah: " + hasil);

            // panggil method Penjumlah dg 3 parameter (overload method)
            hasil = calculator.Penjumlah(10, 2, 3);
            CetakHasil("Hasil Penjumlah overload: " + hasil);

            // panggil method Pengurangan 
            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("Hasil Pengurangan: " + hasil);

            // panggil static method, langsung dari nama classnya
            hasil = Class_calculator.Perkalian(5, 2);
            CetakHasil("Hasil Perkalian: " + hasil);

            Console.ReadKey();

        }
        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
