using System;
using System.Collections;

namespace Koleksiyon3
{
    class koleksiyonlar3
    {
        static void Main(string[] args)
        {
            ArrayList dizi = new ArrayList();
            Console.Write("Bir cümle giriniz: ");
            string metin=Console.ReadLine();
            string sesli = "aeıioöuüAEIİOÖUÜ";
            int sayac = 0;
            for (int i=0;i<metin.Length;i++)
            {
                if (sesli.Contains(metin[i]))
                {
                    sayac++;
                    dizi.Add(metin[i]);
                }

            }

            Console.WriteLine("Bu kelime içerisinde toplam " + sayac + " tane sesli harf vardır.");
            Console.WriteLine("Bu sesli harfler şunlardır:");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}