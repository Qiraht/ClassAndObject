using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Class
{
    public class Mahasiswa
    {
        public string NIM { get; set; }
        public string Nama { get; set; }
        public float IpK { get; set; }

        public void Registrasi()
        {
            Console.WriteLine("Nama : {0}", Nama);
            Console.WriteLine("NIM : {0}", NIM);
            Console.WriteLine("IPK : {0}", IpK);
            Console.WriteLine("Telah Melakukan Registrasi");
        }

        public void IsiKrs()
        {
            Console.WriteLine("{0} sedang melakukan proses Krs\n", Nama);
        }
    }
}
