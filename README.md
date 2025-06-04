# MySQL Database Viewer & Manager

Bu proje, Windows Forms (C#) kullanılarak geliştirilmiş basit bir MySQL veritabanı görüntüleyici ve yönetim aracıdır. Kullanıcılar, MySQL sunucusundaki veritabanlarını ve tabloları listeleyebilir, yeni veritabanları ve tablolar oluşturabilir, tablolardaki verileri görüntüleyebilir.

## Özellikler

- MySQL sunucusuna bağlanma
- Veritabanlarını listeleme
- Tabloları listeleme
- Tablo içeriğini `DataGridView` ile görüntüleme
- Yeni veritabanı oluşturma
- Yeni tablo oluşturma (otomatik artan ID sütunlu)
- Temiz kullanıcı arayüzü ile kolay kullanım

## Kurulum

1. **Gereksinimler**  
   - .NET Framework 4.7.2 veya üzeri  
   - MySQL Server  
   - MySQL.Data NuGet paketi (yüklenmiş olmalı)

2. **Bağlantı Ayarları**  
   - `Form1.cs` dosyasındaki `connectionString` satırını kendi MySQL yapılandırmanıza göre güncelleyin:

     ```csharp
     private string connectionString = "Server=localhost;Uid=root;Pwd='';";
     ```

3. **Projeyi Çalıştırma**  
   - Visual Studio'da projeyi açın  
   - Gerekli NuGet paketlerini yükleyin (`MySql.Data`)  
   - `Form1` arayüzü üzerinden işlemlerinizi gerçekleştirin

## Kullanım

1. Program açıldığında sol listede mevcut veritabanları listelenir.  
2. Bir veritabanı seçildiğinde, o veritabanına ait tablolar ikinci listede gösterilir.  
3. Bir tablo seçildiğinde, o tabloya ait tüm veriler alt kısımdaki tabloda (`DataGridView`) görüntülenir.  
4. Yeni veritabanı oluşturmak için adını yazıp **"Create Database"** butonuna tıklayın.  
5. Yeni tablo oluşturmak için tablo adını yazıp **"Create Table"** butonuna tıklayın (yalnızca `ID` sütunu içerir).


## Katkıda Bulunma

Pull request'ler her zaman kabul edilir. Lütfen önce neyi değiştirmek istediğinizi belirtin.

## Lisans

Bu proje kişisel kullanım ve eğitim amaçlıdır. Açık kaynak olarak dağıtılabilir.
