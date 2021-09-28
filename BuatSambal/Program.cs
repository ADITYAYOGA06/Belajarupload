using System;

namespace BuatSambal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MARI KITA NYAMBEL");

            Cabai cabai = new Cabai(100);
            Bawang bawang = new Bawang(100);
            Garam garam = new Garam(100);

            Sambal sambalEnak = new Sambal(bawang, cabai, garam);

            Console.WriteLine("Cek " + sambalEnak.checkTersedia());
            String hasil = sambalEnak.buatSambal();
            Console.WriteLine("Hasil " + hasil);

            Console.WriteLine("Cek " + sambalEnak.checkTersedia());
            hasil = sambalEnak.buatSambal();
            Console.WriteLine("Hasil " + hasil);

            Console.WriteLine("Cek " + sambalEnak.checkTersedia());
            hasil = sambalEnak.buatSambal();
            Console.WriteLine("Hasil " + hasil);

            Console.WriteLine("Cek " + sambalEnak.checkTersedia());
            hasil = sambalEnak.buatSambal();
            Console.WriteLine("Hasil " + hasil);

            Console.WriteLine("Cek " + sambalEnak.checkTersedia());
            hasil = sambalEnak.buatSambal();
            Console.WriteLine("Hasil " + hasil);

            Console.WriteLine("Cek " + sambalEnak.checkTersedia());
            hasil = sambalEnak.buatSambal();
            Console.WriteLine("Hasil " + hasil);

            Console.WriteLine("Cek " + sambalEnak.checkTersedia());
            hasil = sambalEnak.buatSambal();
            Console.WriteLine("Hasil " + hasil);

            Console.WriteLine("Cek " + sambalEnak.checkTersedia());


        }
    }
}
