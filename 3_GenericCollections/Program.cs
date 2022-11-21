namespace _3_GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic Collection => Collections a göre daha kullanışlı olan tip güvenliğini sağlanan koleksiyon yapıdır..

            List<string> list = new List<string>();
            list.Add("Umut");
            list.Add("İsmail");
            list.Add("Ekrem");

            List<int> nums = new List<int>();
            nums.Add(10);
            nums.Add(20);
            nums.Add(30);

            List<bool> bools = new List<bool>();
            bools.Add(true);
            bools.Add(false);
            //bools.Add("aaaa"); // bools nesnemiz bool tipinde olduğu için string tipinde değer alamaz...

            Dictionary<int, string> dicList = new Dictionary<int, string>();
            dicList.Add(0, "Umut");
            dicList.Add(1, "İsmail");
            dicList.Add(2, "Ekrem");

            string temp = dicList[1]; // İsmail
            dicList[1] = "İsmail Kurtoğlu";


            Dictionary<string, string> dicList2 = new Dictionary<string, string>();
            dicList2.Add("A", "Umut");
            dicList2.Add("B", "İsmail");
            dicList2.Add("C", "Ekrem");

            temp = dicList2["B"];
            dicList2["B"] = "İsmail Kurtoğlu";


            // KeyValuePair => dictonary'nin elemanını temsil eder...
            foreach (KeyValuePair<string, string> item in dicList2)
            {

                Console.WriteLine($"{item.Key} {item.Value}");
            }



            Dictionary<int, List<string>> cenerik = new Dictionary<int, List<string>>();
            cenerik.Add(0, new List<string>() { "a", "b", "c" });
            cenerik.Add(1, list);


        }
    }
}