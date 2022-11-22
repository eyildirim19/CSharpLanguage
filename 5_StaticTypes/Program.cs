namespace _5_StaticTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Statics");

            Test t = new Test();
            t.A = 1; // => t nesnesinin A üyesine eriştik...

            Test.B = "Deneme"; //  test nesnesinin B üyesine eriştik...

            Demo.Test = "Deneme";

            string deger = Demo.Test;
            Console.WriteLine(deger);

            //Demo d; // değişken oluşturulamaz........
            Yazdir();
        }

        static void Yazdir()
        {
            Console.WriteLine(Demo.Test);
        }
    }
}