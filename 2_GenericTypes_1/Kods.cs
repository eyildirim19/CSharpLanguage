using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_GenericTypes_1
{

    // Generic Interface
    public interface IIslem<T>
    {
        T[] List();
    }
    public class Kategori : IIslem<Kategori>
    {
        public string Adi { get; set; }
        public Kategori[] List()
        {
            Kategori k = new Kategori();
            k.Adi = "A kategorisi";
            Kategori k1 = new Kategori();
            k1.Adi = "B Kategorisi";


            Kategori[] list = new Kategori[2];
            list[0] = k;
            list[1] = k1;

            return list;
        }
    }
    public class Urun : IIslem<Urun>
    {
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }

        public Urun[] List()
        {
            Urun u = new Urun();
            u.Adi = "A Ürünü";
            u.Fiyat = 500;

            Urun u1 = new Urun();
            u1.Fiyat = 300;
            Urun[] list = new Urun[2];
            list[0] = u;
            list[1] = u1;

            return list;
        }
    }
}

