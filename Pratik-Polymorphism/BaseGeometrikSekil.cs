using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Polymorphism
{
    // Base class for geometric shapes
    // Geometrik şekiller için temel sınıf
    public class BaseGeometrikSekil
    {
        public double Genislik {  get; set; } // Width property / Genişlik özelliği
        public double Uzunluk { get; set; } // Height property / Uzunluk özelliği

        // Virtual method to calculate area
        // Alan hesaplamak için sanal metod
        public virtual double AlanHesapla()
        {
            return Genislik*Uzunluk;
        }
    }
}
