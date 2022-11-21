using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_GenericTypes
{
    public class Hesap
    {
        public object Sayi1 { get; set; }
        public object Sayi2 { get; set; }

        public object Toplam
        {
            get
            {
                return (double)Sayi1 + (double)Sayi2;
            }
        }
    }
    //C# dilinde <> operatörü generic operatörüdür..tipin generic olduğunu söyler. eğer bu operatörü görüyorsanız alacağınız instance'da tip belirlemeniz gerekir..


    // Sınıf artık generic bir sınıf. Generic yapılarda üyelerde generic olabilir. buda o sınıf üzerinde birden farklı tiple çalışabilecğeimiz söyler
    public class Hesapla<Tip>
    {
        // Generic tipli vardlığımızın üyeleri generic olduğu için farklı tipleri üye olarak kullanabiliriz..

        public Tip Sayi1 { get; set; }
        public Tip Sayi2 { get; set; }

    }

    // genelde T (type) kısaltması ile tanımlanırlar.

    // where ifadesi ile T'nin hangi türde olabileceğini beliritsiniz. Bu örneğimiz T'nin struct yapı olabileceğini belirttik....
    public class Hesaplamali<T> where T : struct
    {
        public T Value { get; set; }
    }


    // Multiple generic tip....
    public class Test<T, A, B, C>
    {

    }
}