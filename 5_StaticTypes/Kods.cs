using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_StaticTypes
{
    // sınıf üyelerine erişmek için instance alınır. eğer instance alınmadan üyeye erişilmek isteniyorsa üye static tanımlanır..static üyeler instance ile değil uygulama ile ayağa kalkar...

    public class Test
    {
        public int A { get; set; }

        // üye static olduğunda sınıf ismi üzerinden erişilir. o üye için atana değer sabittir. 

        // static üyeler sabit değerler tutmak için tanımlanır. nesne bazlı özel değerden ziyade genel değer tutmak için kullanılır...adresi sürekli değişmeyeceği için performanslı çalışırlar...

        public static string B { get; set; }

        string name;
        static string surname;
        public static void Demo()
        {
            // static üyelerde non-static üyelere erişilemez...
            // name // non-static olduğu için buradan erişilemez..
            surname = "Deneme Deneme";
        }
    }

    // static classlar vardır. sadece static üye tanımlamak için kullanılır

    // new ifadesi ile instance alınmaz...
    public static class Demo
    {
        // static sınıflara constroctor static olarak tanımlanır..
        static Demo()
        {
        }
        public static string Test { get; set; }
    }

    // static classlarda kalıtım yoktur...
    //public static class AAA : Demo
    //{
    //}
}