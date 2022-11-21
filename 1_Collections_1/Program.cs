using System.Collections;

namespace _1_Collections_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections");

            ArrayList list = new ArrayList();
            list.Add("İsmail");
            list.Add("Ekrem");
            list.Add("Umut");

            list[0] = "İsmail Kurtoğlu";
            string isim = (string)list[0];
            // Hashtable => üyelerin keyleri tarafımızdan verilir. Dizilerden farkı budur...Elemanlara indexten değil keyleerden erişilir...
            // Hastable => genelde keyler tarafımızdan verileceğinde kullanınılır..
            Hashtable hashtable = new Hashtable();
            hashtable.Add("A", "İsmail");
            hashtable.Add("B", "Ekrem");
            hashtable.Add("C", "Umut");

            // hashtable.Add("A", "İsmail Kurtoğlu"); // burada A key'i daha önce oluştuğu için hata alacaktır. çünkü keyler (index) unique (benzersiz) olmalıdır.....

            hashtable["A"] = "İsmail Kurtuğlu";

            string name = (string)hashtable["A"];

            Hashtable odemeBilgisi = new Hashtable();
            odemeBilgisi.Add("KartNo", "123313131");
            odemeBilgisi.Add("İsim", "bt akademi");
            odemeBilgisi.Add("SKT", "112026");
            odemeBilgisi.Add("CVV", "345");
        }
    }
}