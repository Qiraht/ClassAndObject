using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();

            saya.NIM = "18.11.2350";
            saya.Nama = "Thariq";
            saya.IpK = 4f;

            kamu.NIM = "19.2666";
            kamu.Nama = "BOT";
            kamu.IpK = 4f;

            saya.Registrasi();
            saya.IsiKrs();

            kamu.Registrasi();
            kamu.IsiKrs();

            Console.ReadKey();
        }
    }
}
