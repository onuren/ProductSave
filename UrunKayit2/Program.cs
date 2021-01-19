using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunKayit2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ürün marka, model, fiyat, tedarikçi, stok bilgileri tutulacak
            Console.WriteLine("Kaç ürün gireceksiniz?");
            int adet = Convert.ToInt32(Console.ReadLine());

            Urun[] urunler = new Urun[adet];

            for (int i = 0; i < adet; i++)
            {
                Urun u = new Urun();

                Console.WriteLine("Lütfen " + (i + 1) + ". ürünün markasını yazınız.");
                u.Marka = Console.ReadLine();

                Console.WriteLine("Lütfen " + (i + 1) + ". ürünün modelini yazınız.");
                u.Model = Console.ReadLine();

                Console.WriteLine("Lütfen " + (i + 1) + ". ürünün tedarikçisini yazınız.");
                u.Tedarikçi = Console.ReadLine();

                Console.WriteLine("Lütfen " + (i + 1) + ". ürünün fiyatını yazınız.");
                u.Fiyat = Convert.ToDouble(Console.ReadLine());

                urunler[i] = u;
            }

            Console.Clear();
            Console.WriteLine("----Ürünler-----");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].Marka+" "+urunler[i].Model);
            }
        }
    }
}
