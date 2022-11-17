using System.Collections; // Collection classlarını kullanmak için dahil ediyoruz..

namespace _1_Collections
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 7, c = 1;

            // Array
            int[] nums = new int[5];
            nums[0] = a;
            nums[1] = b;
            nums[2] = c;
            nums[3] = 8;
            nums[4] = 10;
          

            // ArrayList =>birden fazla veriyi bir arada tutmak için kullanılan sınıftır...
            // KOleksiyonlar diziler gibi statik değil dinamik yapılardır. yani diziye eleman ekledikçe dizin uzunlu artar, sildikçe kısalır..

            ArrayList list = new ArrayList();
            list.Add(a);
            list.Add(b);
            list.Add(c);
            list.Add(40);
            list.Add(50);

            // eklenen elemanlar indexler üzerinden erişilebilir
            int besinci = (int)list[4]; // okuma yapıyoruz..

            // henüz koleksiyonda 5. index (6. eleman) oluşmadığı için index hatası fırlatır
            //int altinci = (int)list[5]; // okuma yapıyoruz..
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Umut";
            ogr.Not = 90;

            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "İsmail";
            ogr1.Not = 100;

            // object'e dönüşüm işlemine boxing işlemi denir
            // object'en dönüşüm işlemine'de unboxing denir..

            object o = 5; // boxing
            int n = (int)o; // unboxing

            ArrayList ogrList = new ArrayList();
            ogrList.Add(ogr);
            ogrList.Add(ogr1);



            for (int i = 0; i < ogrList.Count; i++)
            {
                Ogrenci tempO = (Ogrenci)ogrList[i]; // n. öğrenciyi oku
                Console.WriteLine(tempO.Not);
            }

            // Koleksiyonlar sürekli boxing ve unboxing işlemine tabi tutulduğu için performaslı objeler değildirler. yani koleksiyonlarda tip güvenliği yoktur...
        }
    }
}