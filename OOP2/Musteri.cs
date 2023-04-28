using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        //ortak özellikleri buraya koyduk çünkü müşterideki özellikler artık
        //gerçek müşteri ve tüzel müşterideki özelliklere aktarılsın dedik
        public int Id { get; set; }
        public string MusteriNo { get; set; }
    }
}
