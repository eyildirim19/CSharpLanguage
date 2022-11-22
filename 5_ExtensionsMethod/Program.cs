namespace _5_ExtensionsMethod
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Extensions Method...");


            int a = Convert.ToInt32("55");
            string temo = a.ToString();

            string b = "345";

            int c = Convert.ToInt32(b);


            //DonusumIslemi islem = new DonusumIslemi();
            //islem.ToInt(b);

            //DonusumIslemi islem1 = new DonusumIslemi();
            //islem1.ToInt(b);

            int x = DonusumIslemi.InteDonustur(b);
            int y = DonusumIslemi.InteDonustur(temo);


            // stringe uzantı yaptığımız metotlarımızı çağırdık...

            int v = b.ToInt();
            int n = temo.ToInt();

            // ConvertOperation.ToInt() // exntesionmetodu sınıf üzerinden parametre ile çağırabiliriz..

            byte bt = v.ToByte();
            byte bt1 = n.ToByte();



            Console.WriteLine(bt);
            Console.WriteLine(bt1);

        }
    }
}