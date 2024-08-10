using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Polymorphism
{
    // Derived class for triangle
    // Üçgen için türetilmiş sınıf
    public class Ucgen : BaseGeometrikSekil
    {
        // Overriding the base method to calculate the area of a triangle
        // Üçgenin alanını hesaplamak için temel metodu geçersiz kılma

        public override double AlanHesapla()
        {
            return (Genislik * Uzunluk) / 2;
        }
    }
}
