namespace _6_Linq_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq");
            List<int> nums = new List<int>() { 1, 2, 33, 4, 45, 6, 19, 15, 23 };

            List<int> values = new List<int>();
            foreach (var item in nums)
                if (item < 3)
                    values.Add(item);

            List<int> ints = (from a in nums
                              where a < 3 // kriter belirlemek için kullanılır...
                              select a).ToList();

            int limit = 3;
            // intse tekrar atıyorum
            ints = (from a in nums
                    where a > limit && a < 6
                    select a).ToList();



            // elemanları küçükten büyüğe sıralaylım... sıralı alalım..

            // verileri order by ifadesi ile sıralanır..
            // order by iki tür sıralama yapar;
            // ascending => artan sıralama
            // descending => azalan sıralama

            // NOT : DEFAULT SIRALAMA ASCENDİNG SIRALAMADIR...EĞER ASCENDING BELİRTMEZSEK BU TİPTE SIRALAMA YAPACAKTIR..

            ints = (from b in nums
                    where b > 20
                    orderby b ascending//  sıralama ifadesidir. verileri sıralamak için kullanılır
                    select b).ToList();

            foreach (var item in ints)
                Console.WriteLine(item);

            ints = (from b in nums
                    where b < 20
                    orderby b descending
                    select b).ToList();
        }
    }
}