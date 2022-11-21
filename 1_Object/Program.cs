namespace _1_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object => sınıfı c# dilinde bütün tiplerin atasıdır....
          

            int[] nums = { 1, 2, 3 }; // reference type
            Ogrenci ogr = new Ogrenci(); // reference type
            ogr.Adi = "İsmail";
            ogr.SoyAdi = "Kurtoğlu";

            int a = 1000;
            string tem = ogr.ToString();
            string temp2 = a.ToString();

            // boxing işlemi (objecte dönüşümdür)
            object obj = ogr;
            object o = 1;
            object isim = "bt";
            object c = 'A';
            object d = 3.1f;
            object e = new string[4];

            // unboxing (objectten dönüşümdür)
            int i = (int)o;
            Ogrenci ogr2 = (Ogrenci)obj;
           
            // Console.WriteLine metodu ekranda gösterilen değişkenleri string'e dönüştürerek yazdırır...

            Console.WriteLine(o);
            Console.WriteLine(isim);
            Console.WriteLine(obj);
            Console.WriteLine(nums);

        }
    }
}