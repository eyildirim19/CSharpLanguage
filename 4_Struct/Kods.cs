using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Struct
{
    struct Urun
    {
        //public Urun()
        //{
        //}
        //1. structlarda default constructor tanımlanamaz..ama parametre alan constructor tanımlanabilir

        // 2. constructor tanımlanıyorsa üyelerin varsalayılan değerleri ctor'da başlatılmalıdır...

        public Urun(string a, decimal f)
        {
            Adi = a;
            Fiyat = f;
            Stok = 1;
        }
        public string Adi;
        public decimal Fiyat;
        public int Stok { get; set; }
    }



    // üyelerin değerleri sadece constructorda atanabilir...
    readonly struct Categories
    {
        //public string test;
        // ctor tab tab yaparsanız constructor oluşturur..
        public Categories(string n, string d)
        {
            Name = n;
            Desc = d;
        }

        public string Name { get; }
        public string Desc { get; }
    }

    class Product
    {
        public Product()
        {
        }
        public Product(string a, decimal b)
        {
        }

        public string Name;
        public decimal Price;
    }



    // 3. Stuructlar kalıtım yapılamaz...miras veremez, başka bir structran veya classtan miras alamaz..Ancak interfacelerden miras alabilir
    //struct Test : Urun
    //{
    //}

    interface ITest { }
    struct Test : ITest
    {
    }

}
