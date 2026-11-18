# 🚀 ASP.NET Core MVC Dinamik Portfolyo Projesi

Bu proje, Murat Yücedağ'ın "ASP.NET Core ile Portfolyo Uygulamanızı Geliştirin" adlı Udemy kursu kapsamında modern web geliştirme prensipleriyle geliştirilmiş; dinamik bileşenlere ve yönetim paneline sahip kapsamlı bir kişisel portfolyo web sitesi projesidir.

![.NET 8](https://img.shields.io/badge/.NET-8.0-purple)
![ASP.NET Core MVC](https://img.shields.io/badge/ASP.NET%20Core-MVC-blue)
![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework-Core-green)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-red)

<img src="screenshots/Screenshot_1.png" alt="Ekran Görüntüsü 1" width="100%"/>
<br/>
<img src="screenshots/Screenshot_4.png" alt="Ekran Görüntüsü 4" width="100%"/>

## 🎯 Proje Hakkında

Proje, kişisel portfolio içeriklerini ziyaretçilere sunan ve gelen mesajların yönetilebildiği bir yönetim alanı sağlar. Veriler Entity Framework Core üzerinden SQL Server'da saklanır.

## ✨ Özellikler

- Hakkımda, deneyim, yetenek, portfolio, referans ve iletişim içerileri
- Deneyim kayıtlarını listeleme, ekleme, düzenleme ve silme
- Gelen mesajları görüntüleme, okundu durumunu değiştirme ve silme
- Yapılacaklar listesi oluşturma, güncelleme, silme ve tamamlandı durumunu değiştirme
- Yetenek ve mesaj sayılarını gösteren istatistik ekranı
- Entity Framework Core migration'larıyla veritabanı şeması yönetimi

## 🛠️ Kullanılan Teknolojiler ve Araçlar

Proje geliştirilirken aşağıdaki modern teknoloji ve altyapılar kullanılmıştır:

C# · .NET · ASP.NET Core MVC · Entity Framework Core · SQL Server · LINQ · Razor · Bootstrap · HTML, CSS ve JavaScript

---
<img src="screenshots/Screenshot_2.png" alt="Ekran Görüntüsü 2" width="100%"/>
<br/>
<img src="screenshots/Screenshot_3.png" alt="Ekran Görüntüsü 3" width="100%"/>


---

## 📂 Proje Yapısı

```text
MyPortfolioUdemy/
│
├── Controllers/         # MVC Controller sınıfları (Vitrin ve Admin)
├── DAL/                 # Veri Erişim Katmanı (Data Access Layer)
│   ├── Context/         # Entity Framework Core Veritabanı Bağlamı (MyPortfolioContext)
│   └── Entities/        # Veritabanı tabloları (About, Contact, Experience, Portfolio vb.)
├── ViewComponents/      # Modüler parça görünüm sınıfları (About, Works, Contact vb.)
├── Views/               # Razor Görünüm dosyaları (Layout, Default ve Admin panelleri)
└── wwwroot/             # CSS, JavaScript, görseller ve statik dosyalar
 ```
---


<h2 align="center">👨‍💻 Geliştirici</h2>

<p align="center">
  <strong>Ahmet Yasin Parlak</strong> · Bilgisayar Mühendisi
</p>

<p align="center">
  <a href="https://github.com/AhmetYasinParlak">
    <img src="https://img.shields.io/badge/GitHub-333333?style=for-the-badge&logo=github&logoColor=white" />
  </a>
  &nbsp;&nbsp;
  <a href="https://www.linkedin.com/in/ahmetyasinparlak/">
    <img src="https://img.shields.io/badge/LinkedIn-blue?style=for-the-badge&logo=linkedin&logoColor=white" />
  </a>
</p>
