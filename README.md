# CarParkProject_OnlyQueue

*Bu uygulama Data Structures (Veri Yapıları) dersi için sadece queue data structer (kuyruk veri yapısı) kulanılarak geliştirilmiştir.*

### AÇIKLAMA

#### Gerçekleştirilen Platform
Microsoft Visual Studio Community 2017 - Version 15.4.1 - C#

#### Projenin Tanımı
Bir otoparka “n” tane arabanın eklenmesi sonucu normal ve öncelikli sıraya göre çıkışlarını düzenleyen ve kazançlarını hesaplayan otopark projesi.

#### Veri Yapısı Kataloğu
#### Kullanılan Veri Yapıları
<ul>
  <li>Dairesel kuyruk</li>
  <li>Öncelikli kuyruk</li>
</ul>

#### Sınıflar ve Metotlar
<ul>
  <li>Araba Sınıfı: Arabanın özeliklerini temsil eder.</li>
  <li>IQueue Arayüzü :</li>
  <ul>
    <li>void Insert(Araba a);</li>
    <li>Araba Remove();</li>
  </ul>
  <li>ArabaKuyrugu Sınıfı: Normal araba kuyruğunu temsil eder.</li>
  <ul>
    <li>void Insert(Araba a) : Kuyruğa araba ekler.</li>
    <li>Araba Remove(): Kuyruktan araba siler.</li>
  </ul>
  <li>OncelikliArabaKuyrugu Sınıfı: Öncelikli araba kuyruğunu temsil eder.</li>
  <ul>
    <li>void Insert(Araba a) : Kuyruğa araba ekler.</li>
    <li>Araba Remove(): Kuyruktan araba siler.</li>
  </ul>
  <li>TumArabalar Sınıfı: Tüm arabaları dizide tutar.</li>
</ul>
