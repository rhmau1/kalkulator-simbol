using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATOR SIMBOL");
            Console.WriteLine("--------------------\n");
            Console.WriteLine("Menu: ");
            Console.WriteLine("\t1. + ");
            Console.WriteLine("\t2. - ");
            Console.WriteLine("\t3. * ");
            Console.WriteLine("\t4. : ");
            string ulang;

            do
            {
                Console.Write("Masukkan angka pertama: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan angka kedua: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Masukkan simbol operasi yang ingin dilakukan: ");
                string PilOperasi = Console.ReadLine();
                if (PilOperasi == "+" || PilOperasi == "-" || PilOperasi == "*" || PilOperasi == ":")
                {
                    switch (PilOperasi)
                    {
                        case "+":
                            int jumlah = num1 + num2;
                            Console.WriteLine($"Hasil penjumlahan {num1} + {num2} = " + jumlah);
                            break;
                        case "-":
                            int kurang = num1 - num2;
                            Console.WriteLine($"Hasil pengurangan {num1} - {num2} = " + kurang);
                            break;
                        case "*":
                            int kali = num1 * num2;
                            Console.WriteLine($"Hasil perkalian {num1} * {num2} = " + kali);
                            break;
                        case ":":
                            decimal bagi = Convert.ToDecimal(num1) / Convert.ToDecimal(num2);
                            Console.WriteLine($"Hasil pembagian {num1} : {num2} = " + bagi);
                            break;
                        default:
                            Console.WriteLine("Maaf pilihan operasi hitung yang anda masukkan tidak tersedia");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Pilihan tidak tersedia");
                }                                    
                Console.Write("Apakah anda ingin melakukan perhitungan lagi? [Y/N] :  ");
                ulang = Console.ReadLine().ToUpper();
            } while (ulang == "Y");
        }
    }
}
