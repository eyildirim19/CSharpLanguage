namespace _2_GenericTypes_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nullable ve Non-Nullable");

            // Reference Typelar nullable iken, Value Typeler Non-NUllable'dir..

            // null => bir değeri olmayan boş....

            // NUllable Type => Value Type'ları null olabilir şekilde ayarlamaktır

            string str = null;
            object o = null;
            Urun u = null;

            // NOT : VALUE type'lar null olamazlar...
            Nullable<int> a = null;


            // Nullable bir value alınırken değeri var mı bakılır
            if (a.HasValue)
            {
                int z = a.Value;
            }

            // NUllable yapmanın 2. yolu
            float? b = null;

            // decimal c = null; // c değişkenimiz nullable tip olmadığı için null değeri atanamaz....

            float? d = null;
            d = 10;
            if (d.HasValue)
            {
                float e = d.Value;
            }

            Urun urun = new Urun();
            urun.Stok = null;
        }
    }
}