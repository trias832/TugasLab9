using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaji
{
    class Program
    {
        static void Main(string[] args)
        {
          /*Nama    :Trias Handayani
           NIM      :19.11.2733
           Kelas    : 19-IF-03*/
            
            List<Karyawan> karyawan = new List<Karyawan>();
            bool status = true;
           
            Console.WriteLine();

            do
            {
                Console.Clear();

                Console.WriteLine("===============================================");
                Console.WriteLine("\t\tSELAMAT DATANG");
                Console.WriteLine("===============================================");

                Console.WriteLine("");

                Console.WriteLine("Silahkan pilih menu Aplikasi :");
                Console.WriteLine("\n1. Tambah Data\n2. Hapus Data \n3. Tampilkan Data \n4. Keluar");

                Console.WriteLine();


            Pilihan:

                string Pil;
                Console.WriteLine("Maukan Pilihan [1-4] : ");
                Pil = Console.ReadLine();
                if (Pil == "1")
                {
                    Tambah(karyawan);
                    Keluar();
                }
                else if (Pil == "2")
                {
                    Hapus(karyawan);
                    Keluar();
                }
                else if (Pil == "3")
                {
                    tampil(karyawan);
                    Keluar();
                }
                else if (Pil == "4")
                {
                    
                    status = false;
                }
                else
                {
                    Console.WriteLine("Pilihan Tidak Tersedia");
                    goto Pilihan;
                }
            } while (status);

           
        }
        
            



            static void Tambah(List<Karyawan> karyawan)
            {
                Console.Clear();

                Console.WriteLine("===============================================");
                Console.WriteLine("=============Tambahkan Karyawan================");
                Console.WriteLine("===============================================");
                Console.WriteLine("Pilih Jenis karyawan :");
                Console.WriteLine("\n1. Karyawan Tetap \n2. Karyawan Harian \n3. Sales \n");
            Pilihan:
                string Pil;
                Console.WriteLine("Masukan Pilihan[1-3] : ");
                Pil = Console.ReadLine();
                Console.WriteLine();
                if (Pil == "1")
                {
                    KaryawanTetap karyawanTetap = new KaryawanTetap();
                    Console.WriteLine("Tambah Karyawan");

                    Console.WriteLine("Masukkan NIK : ");
                    karyawanTetap.Nik = Console.ReadLine();
                    Console.WriteLine("Masukkan Nama : ");
                    karyawanTetap.Nama = Console.ReadLine();
                    Console.WriteLine("MasukkanGaji : ");
                    karyawanTetap.GajiBulanan=Convert.ToDouble(Console.ReadLine());
                    karyawan.Add(karyawanTetap);
                    
                }
                else if (Pil == "2")
                {
                    KaryawanHarian karyawanHarian = new KaryawanHarian();
                    Console.WriteLine("Tambah Karyawan");

                    Console.WriteLine("Masukkan NIK : ");
                    karyawanHarian.Nik = Console.ReadLine();
                    Console.WriteLine("Masukkan Nama : ");
                    karyawanHarian.Nama = Console.ReadLine();
                    Console.WriteLine("MasukkanJumlah Jam Kerja : ");
                    karyawanHarian.JumlahJamKerja = Convert.ToDouble (Console.ReadLine());
                    Console.WriteLine("Masukkan Upah Perjam: ");
                    karyawanHarian.UpahPerJam = Convert.ToDouble(Console.ReadLine());

                    karyawan.Add(karyawanHarian);
                  
            }
                else if (Pil == "3")
                {
                    Sales sales = new Sales();
                    Console.WriteLine("Tambah Karyawan");

                    Console.WriteLine("Masukkan NIK : ");
                    sales.Nik = Console.ReadLine();
                    Console.WriteLine("Masukkan Nama : ");
                    sales.Nama = Console.ReadLine();
                    Console.WriteLine("Masukkan Jumlah Penjualan : ");
                    sales.JumlahPenjualan = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Masukkan Komisi : ");
                    sales.Komisi = Convert.ToDouble(Console.ReadLine());

                    karyawan.Add(sales);
                   
                 }
                else
                {
                    Console.WriteLine("Pilihan Tidak Tersedia");
                    goto Pilihan;
                }
            }

             static void Hapus(List<Karyawan> karyawan)
            {
                
                string hapus;
                Console.Clear();
                Console.WriteLine("===============================================");
                Console.WriteLine("=============Hapus Data Karyawan===============");
                Console.WriteLine("===============================================\n");

                Console.WriteLine("Masukan NIK Karyawan : ");
                hapus = Console.ReadLine();

                for (int i = 0; i < karyawan.Count; i++)
                {
                    if (karyawan[i].Nik == hapus)
                    {
                        karyawan.Remove(karyawan[i]);
                    Console.WriteLine("Terhapus");
                       // dihapus = true;
                         break;
                    }
                   else { Console.WriteLine("Data tidak ketemu"); }
                }
                    
            }


            static void tampil(List<Karyawan> karyawan)
            {
                Console.Clear();

                Console.WriteLine("========================================================");
                Console.WriteLine("\n No | NIK\t\t| Nama\t\t| Gaji\t\t|");
                Console.WriteLine("========================================================");
                for (int i = 0; i < karyawan.Count; i++)
                {
                    Console.WriteLine("{0}. | {1}\t\t| {2}\t\t| {3}\t|",i+1 ,karyawan[i].Nik, karyawan[i].Nama, karyawan[i].Gaji);
                }
            Console.WriteLine("========================================================");

        }

            static void Keluar()
            {
                Console.WriteLine("\nTekan Enter untuk Kembali ");
                Console.ReadKey();
            }

        }
    }
