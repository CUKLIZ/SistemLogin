using System;
class Login
{
    static void Main(string[] args)
    {
        int pilihan, password, dataPass = 0;
        string username, dataUser = null;
        int a = 0;
        Boolean kondisi = true;

        while (kondisi)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("     PROGRAM SEDERHANA SISTEM LOGIN");
            Console.WriteLine("========================================");
            Console.WriteLine();
            Console.WriteLine("Selamat Datang");
            Console.WriteLine();
            Console.WriteLine("Apakah Sudah Ada Akun?");

            Console.WriteLine(" 1. Login\n 2. Buat Akun");
            Console.Write("Masukan Pilihan Anda : ");
            pilihan = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("=========================");
                    Console.WriteLine("          LOGIN          ");
                    Console.WriteLine("=========================");
                    Console.Write("Masukan Username : ");
                    username = Console.ReadLine();
                    Console.Write("Masukan Password : ");
                    password = int.Parse(Console.ReadLine());

                    if (username == dataUser &&  password == dataPass)
                    {
                        Console.WriteLine("\nLogin Telah Berhasil");
                    } 
                    else 
                    {
                        Console.WriteLine("\nLogin Gagal");
                    }
                break;

                case 2:
                    Console.WriteLine("=========================");
                    Console.WriteLine("       BUAT AKUN         ");
                    Console.WriteLine("=========================");
                    Console.WriteLine("Silahkan Di Isi ");
                    Console.WriteLine();
                    Console.Write("Masukan Username : ");
                    dataUser = Console.ReadLine();
                    Console.Write("Masukan Password : ");
                    dataPass = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nAkun Anda Telah di Buat");
                    Console.Clear();
                    Console.WriteLine();

                    Console.WriteLine("=========================================");
                    Console.WriteLine("  Apakah Ingin Kembali Ke Menu Pilihan?  ");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("1. YES\n 2. NO");
                    Console.Write("Masukan Pilihan Anda : ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (a == 1)
                    {
                        kondisi = true;
                    } else if (a == 2)
                    {
                        kondisi = false;
                        Console.WriteLine("Terima Kasih Telah Mendaftar");
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Pilihan Anda Belum Tersedia");
                    Console.WriteLine("Apakah Anda Ingin Login/Buat Akun?");
                    Console.Write("1. YES\n 2. NO");
                    a = int.Parse(Console.ReadLine());
                    
                    if (a == 1)
                    {
                        kondisi = true;
                    } else if (a == 2)
                    {
                        kondisi = false;
                    }
                    break;
            }
        }
    }
}