using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ExtensionsMethod
{
    // Extension metot mantığı
    // c# dilinde ön tanımlı tipler'de değişiklik yapılamaz...(örn int tipinin içerisinde custom metot yazılamaz) ancak ön tanımlı tiplere ek metotlar yazılabilir.. yani ilgili tiple genişletilebilir....

    // gelen parametreye göre sabit işlem yapılacağı için InteDonustur metodu static tanımlandıı...
    public class DonusumIslemi
    {
        public static int InteDonustur(string deger)
        {
            return Convert.ToInt32(deger);
        }
    }

    // şimdide yazacağımız metodu bir sınıf üzerinden değil direk ilgili değişken üzerinden çağıracağız..
    public static class ConvertOperation
    {
        // this =>bulunulan instance üzerinden alınacak parametreyi ifade eder...
        // extension metod olduğunu  static ve this ketwordleri belirler...
        public static int ToInt(this string deger)
        {
            return Convert.ToInt32(deger);
        }

        public static byte ToByte(this int value)
        {
            if (value > 255)
                return 255;
            else
                return (byte)value;
        }
    }
}
