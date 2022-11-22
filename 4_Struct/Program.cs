namespace _4_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct");

            //Urun urn;
            //Console.WriteLine(urn.Adi); // uygulama derlenmez çünkü struct tipndeki bir değişkenin eğer instance alınmadıysa veya üyesine başlangıç değeri atanmadıysa uygulana derlenmez..


            Urun u = new Urun();
            Console.WriteLine(u.Adi);

            Urun u1 = new Urun("Televizyon", 800);
            Console.WriteLine(u1.Adi);


            //Urun urn;
            //urn.Adi = "Tel";
            //Console.WriteLine(urn.Adi);

            Categories c = new Categories("İçecek", "İçecek Ürünleri");

            Console.WriteLine(c.Name); // İçecek

            //c.Name = "aksjl"; // değer atanamaz çünkü categories strcut'i readonly'dir.....


            //Product p;
            //Console.WriteLine(p.Adi);


            // Value Type     => değer tipler..değer tutan değişken

            // Reference Type => referans tip.. değer yerine referans tutan değişken



            Urun u2 = new Urun();
            u2.Adi = "Elma";

            // u2'nin değeri tutulur...

            Urun u3 = u2;
            u3.Adi = "Muz";

            Console.WriteLine(u2.Adi); // Elma
            Console.WriteLine(u3.Adi); // Muz
            Console.WriteLine("********************");

            Product p1 = new Product();
            p1.Name = "Armut";

            // p1'in referansı tutulur...
            Product p2 = p1;
            p2.Name = "Ayva";

            Console.WriteLine(p1.Name); // Ayva
            Console.WriteLine(p2.Name); // Ayva



            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);


        }
    }
}