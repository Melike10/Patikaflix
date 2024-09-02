# Patikaflix Dizi Listesi Uygulaması
Bu proje, kullanıcıdan alınan dizi verileriyle bir dizi listesi oluşturan ve bu listeden komedi dizilerini seçerek sıralayan bir konsol uygulamasıdır. Proje, temel C# ve LINQ kullanımıyla verileri işlemenizi sağlar.

## Kullanılan Teknolojiler
C#: Uygulama dili olarak kullanıldı.
.NET Core: Proje altyapısını oluşturmak için kullanıldı.
LINQ: Dizi listesi üzerinde veri sorgulama ve sıralama işlemleri için kullanıldı.
## Sınıflar
### 1. Movie Sınıfı
Bu sınıf, bir dizinin temel özelliklerini tutar:

MovieName: Dizinin adı.
ProductionYear: Dizinin yapım yılı.
Type: Dizinin türü (Komedi, Drama, Aksiyon, vb.).
PublicationYear: Dizinin yayınlanmaya başladığı yıl.
DirectorName: Dizinin yönetmeni.
FirstPlatform: Dizinin ilk olarak yayınlandığı platform.

### 2. ComedyMovie Sınıfı
Bu sınıf, yalnızca komedi dizilerini tutmak için kullanılır ve daha basit bir yapıya sahiptir:

MovieName: Dizinin adı.
Type: Dizinin türü.
DirectorName: Dizinin yönetmeni.
## Uygulama Akışı

Kullanıcıdan Girdi Alma: Kullanıcıya sırayla dizi bilgileri (adı, yapım yılı, türü, yönetmeni, vb.) sorulur ve alınan bilgilerle bir Movie nesnesi oluşturulur. Kullanıcı her bir dizi girdikten sonra yeni bir dizi eklemek isteyip istemediği sorulur.

Komedi Dizilerini Filtreleme: Oluşturulan Movie listesi içerisinde türü "komedi" olan diziler seçilir ve bu diziler ComedyMovie nesnelerine dönüştürülerek ayrı bir listeye eklenir.

Komedi Dizilerini Sıralama ve Yazdırma: Komedi dizileri, dizi adı ve yönetmen adına göre sıralanır. Sıralanan liste, tüm özellikleriyle birlikte ekrana yazdırılır.

## Örnek Kullanım
Kullanıcı bir dizi eklediğinde program aşağıdaki şekilde çalışır:

```bash

Dizinin Adı: Avrupa Yakası
Yapım Yılı: 2004
Türü: Komedi
Yayınlanmaya Yılı: 2004
Yönetmen: Gülse Birsel
İlk Yayınlandığı Platform: ATV
Yeni bir dizi eklemek ister misiniz? (E/H): H
```

Sonuç olarak ekrana:

```bash

Komedi Dizileri:
Dizi Adı: Avrupa Yakası, Türü: Komedi, Yönetmen: Gülse Birsel
```
şeklinde bir çıktı alınır.
