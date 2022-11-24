namespace _6_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");
            #region "açıklama"
            /*
                Language Integrated Query(Dile engtegre query) // Veriler üzerinden query yapısına benzer sorgulamalar için kullanılır..
                    LINQ 3 ana grupta incelenir
                    LINQ TO OBJECT => OBJELER 
                    LINQ TO XML => XML VERİLERİ
                    LINQ TO SQL => SQL VERİLERİ
             */
            #endregion
            List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // nums dizisindeki değerli ints dizine aktarıyoruz..
            List<int> ints = new List<int>();
            foreach (int item in ints)
                ints.Add(item);

            #region "açıklama"
            // select * from koleksiyon
            // nums dizisindeki deperi arr dizisine aktarıyoruz..
            // default linq sorgusu IEnumerable dönmektedir...ancak dönen listede eğer kayıt üzerinden işlem yapılacaksa IENumerable'dan listeye dönmek gerekir...çünkü IEnumerable sadece kayıt okumak (sıralma, gruplama vb..) için kullanır
            #endregion
            IEnumerable<int> arr = (from n in nums // numstaki verileri n'e aktar
                                    select n); // n'den seç
            Write(arr.ToList());
            //IEnumarble tipinde gelen sonucu List'e dön...
            List<int> arr1 = (from sayi in nums select sayi).ToList();
            Write(arr1);

        }

        static void Write(List<int> param)
        {
            foreach (var item in param)
                Console.WriteLine(item);
        }
    }
}