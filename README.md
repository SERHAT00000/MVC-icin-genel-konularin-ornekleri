# 🚀 ASP.NET Core MVC: Genel Konular ve Uygulama Örnekleri

Bu repo, ASP.NET Core MVC mimarisinin temel ve ileri seviye kavramlarını uygulamalı olarak içeren bir eğitim ve referans projesidir. Proje içerisinde bir web uygulamasının sahip olması gereken temel katmanlar ve operasyonlar örneklenmiştir.

## 🏗️ Mimari Yapı (MVC)

Proje, yazılım mühendisliği standartlarına uygun olarak üç ana bölüme ayrılmıştır:

- **Model:** Veri tabanı şemalarını (Entity) ve veri doğrulama (Validation) kurallarını içerir.
- **View:** Kullanıcı arayüzü, Razor View Engine kullanılarak dinamik olarak oluşturulmuştur.
- **Controller:** Kullanıcı isteklerini (Request) işleyen, iş mantığını (Business Logic) yürüten ve sonucu View'a dönen köprü görevindedir.



## 🛠️ İşlenen Temel Konular

Bu proje içerisinde aşağıdaki konuların implementasyonu bulunmaktadır:

* **Routing:** Özelleştirilmiş ve varsayılan (default) route yapılandırmaları.
* **Controllers & Actions:** `IActionResult` türleri, `ViewData`, `ViewBag` ve `TempData` kullanımı.
* **Strongly Typed Views:** Modellerin View katmanına güvenli şekilde aktarılması.
* **Razor Tags & Helpers:** `asp-for`, `asp-action`, `asp-controller` gibi tag helper yapılarının kullanımı.
* **Layouts & Partial Views:** Kod tekrarını önleyen sayfa şablonları ve parçalı görünüm yönetimi.
* **Model Binding & Validation:** Form verilerinin yakalanması ve `Data Annotations` ile validasyon işlemleri.

## 🗄️ Veri Yönetimi ve Entity Framework Core

Projede veri tabanı işlemleri için modern yaklaşımlar tercih edilmiştir:
- **Code-First Yaklaşımı:** C# sınıfları üzerinden veri tabanı tablolarının oluşturulması.
- **Migrations:** Veri tabanı şemasının versiyon kontrolü ile güncellenmesi.
- **Dependency Injection:** Servislerin ve DbContext'in `Program.cs` üzerinde merkezi yönetimi.

## 🚀 Projeyi Yerelde Çalıştırma

1. Projeyi klonlayın:
   ```bash
   git clone [https://github.com/SERHAT00000/MVC-icin-genel-konularin-ornekleri.git](https://github.com/SERHAT00000/MVC-icin-genel-konularin-ornekleri.git)
