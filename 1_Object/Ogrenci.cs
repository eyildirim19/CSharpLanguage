using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Object
{
    // bütün tipler gibi Ogrenci tipide object sınıfından türemiştir. çünkü object c# dilinde bütün tiplerin atasıdır..

    public class Ogrenci
    {
        public string Adi;
        public string SoyAdi;

        // base'den (objectten) gelen ToString() metodunu override ederek gövdesini değiştirdik...
        public override string ToString()
        {
            return $"{Adi} {SoyAdi}";
        }
    }
}
