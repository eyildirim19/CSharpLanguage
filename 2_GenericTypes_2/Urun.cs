using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_GenericTypes_2
{
    public class Urun
    {
        public Nullable<int> Stok { get; set; }
    }

    public class Notlar
    {
        public Nullable<float> Vize { get; set; }

        // Nullable
        public float? Final { get; set; }
    }
}