# PolymorphismExample

Bu proje, **C#** dilinde **Polymorphism** (Çok Biçimlilik) kavramını göstermek için geliştirilmiş basit bir konsol uygulamasıdır. Uygulama, farklı geometrik şekillerin (Kare, Dikdörtgen, Dik Üçgen) alanlarını hesaplamak için polymorphism prensibini kullanır.

## Proje Yapısı

Proje, aşağıdaki sınıflardan oluşmaktadır:

### 1. BaseGeometrikSekil

- **Özellikler:**
  - `double Genislik`: Geometrik şeklin genişliğini temsil eder.
  - `double Uzunluk`: Geometrik şeklin yüksekliğini temsil eder.

- **Metotlar:**
  - `virtual double AlanHesapla()`: Genişlik ve Uzunluk değerlerini çarparak alanı hesaplar. Bu metot türetilen sınıflarda override edilebilir.

### 2. Kare (BaseGeometrikSekil'den türetilmiştir)

- Kare sınıfı, `BaseGeometrikSekil` sınıfından türetilmiştir ve karenin alanını hesaplamak için temel sınıftaki `AlanHesapla()` metodunu kullanır.

### 3. Dikdortgen (BaseGeometrikSekil'den türetilmiştir)

- Dikdörtgen sınıfı, `BaseGeometrikSekil` sınıfından türetilmiştir ve dikdörtgenin alanını hesaplamak için temel sınıftaki `AlanHesapla()` metodunu kullanır.

### 4. Ucgen (BaseGeometrikSekil'den türetilmiştir)

- **Metotlar:**
  - `override double AlanHesapla()`: Üçgenin alanını `(Genislik * Uzunluk) / 2` formülüyle hesaplamak için temel metodu geçersiz kılar.

## Kullanım

1. `Program` sınıfındaki `Main` metodu, `Kare`, `Dikdortgen` ve `Ucgen` sınıflarından örnekler oluşturur ve bu örneklere `Genislik` ve `Uzunluk` değerleri atar.
2. Ardından, bu şekillerin alanlarını `AlanHesapla()` metodu ile hesaplar ve konsol ekranına yazdırır.


