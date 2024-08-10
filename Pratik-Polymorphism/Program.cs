using Pratik_Polymorphism;

// Create an instance of the square shape
// Kare şeklinin bir örneğini oluştur
BaseGeometrikSekil kare = new Kare();

kare.Genislik = 5;
kare.Uzunluk = 5;

// Create an instance of the rectangle shape
// Dikdörtgen şeklinin bir örneğini oluştur
BaseGeometrikSekil dikdortgen = new Dikdortgen();

dikdortgen.Genislik = 5;
dikdortgen.Uzunluk = 10;

// Create an instance of the triangle shape
// Üçgen şeklinin bir örneğini oluştur
BaseGeometrikSekil ucgen = new Ucgen();

ucgen.Genislik = 7.5;
ucgen.Uzunluk = 8.07;

// Print the area of the square
// Karenin alanını yazdır
Console.WriteLine("Kare alanı : " + kare.AlanHesapla());
Console.WriteLine("");

// Print the area of the rectangle
// Dikdörtgenin alanını yazdır
Console.WriteLine("Dikdörtgen alanı : " + dikdortgen.AlanHesapla());

// Print the area of the triangle
// Üçgenin alanını yazdır
Console.WriteLine("Üçgen alanı : " + ucgen.AlanHesapla());
