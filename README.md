# CarBook - Araç Kiralama Projesi API

Bu proje, ASP.NET Core 8 kullanılarak geliştirilmiş modern bir araç kiralama platformunun backend servisidir. Yazılım mimarisi olarak **Onion Architecture (Soğan Mimarisi)** temel alınmış ve kod kalitesini artırmak için **CQRS (Command Query Responsibility Segregation)** ve **Mediator** tasarım desenleri uygulanmıştır.

---

## 📋 Temel Özellikler

- **Araç Yönetimi:** Araç listeleme, ekleme, güncelleme ve silme işlemleri.
- **Kategori ve Marka Yönetimi:** Araçları kategorilere ve markalara göre yönetme.
- **Kiralama Süreçleri:** Kullanıcıların araç kiralama talepleri oluşturması ve yönetimi.
- **Kullanıcı Yönetimi:** **ASP.NET Core Identity** ile üyelik, rol yönetimi ve token tabanlı kimlik doğrulama (JWT).
- **Gerçek Zamanlı Bildirimler:** **SignalR** ile anlık veri güncellemeleri ve bildirimler.
- **Gelişmiş Sorgulama:** CQRS ile optimize edilmiş okuma (Query) ve yazma (Command) operasyonları.

---

## 🛠️ Kullanılan Teknolojiler ve Konseptler

- **Framework:** ASP.NET Core 8
- **Mimari:** Onion Architecture
- **Tasarım Desenleri:**
  - **CQRS (Command Query Responsibility Segregation):** Yazma ve okuma operasyonlarını ayırarak daha performanslı ve yönetilebilir bir sistem sağlar.
  - **Mediator Pattern:** `MediatR` kütüphanesi ile katmanlar arası bağımlılığı azaltır ve merkezi bir istek-cevap yönetimi sunar.
- **Veritabanı:** [Kullandığın veritabanını yaz, örn: PostgreSQL, SQL Server]
- **ORM:** Entity Framework Core
- **Kimlik Doğrulama & Yetkilendirme:** ASP.NET Core Identity, JWT (JSON Web Tokens)
- **Gerçek Zamanlı İletişim:** SignalR
- **API Dökümantasyonu:** Swagger (OpenAPI) - Postman

---

## 🏛️ Mimari Yaklaşım

Proje, bağımlılıkların merkeze doğru (Domain katmanına) yöneldiği **Onion Architecture** üzerine kurulmuştur. Bu sayede:
- **Bağımsız Domain:** İş kuralları dış dünyadan (UI, Veritabanı vb.) tamamen bağımsızdır.
- **Test Edilebilirlik:** Katmanların ayrışması sayesinde unit ve entegrasyon testleri yazmak kolaylaşır.
- **Esneklik:** Veritabanı veya dış servisler gibi altyapı bileşenleri kolayca değiştirilebilir.

**CQRS Deseni** ile;
- **Command'ler:** Sistemin durumunu değiştiren operasyonlardır (Ekleme, Güncelleme, Silme).
- **Query'ler:** Sistemden veri okuyan, durumu değiştirmeyen operasyonlardır (Listeleme, Getirme).
Bu ayrım, özellikle karmaşık sorguların ve yazma işlemlerinin olduğu sistemlerde performansı ve kod okunabilirliğini ciddi ölçüde artırır.

---

## 🚀 Kurulum

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1. **Projeyi Klonlayın:**
   ```bash
   git clone [PROJENİN GITHUB LINKI]
   ```

2. **Gerekli Paketleri Yükleyin:**
   Proje dizinine gidin ve .NET CLI kullanarak paketleri yükleyin.
   ```bash
   cd CarBook.API
   dotnet restore
   ```

3. **Veritabanı Ayarları:**
   `CarBook.API` projesi içindeki `appsettings.json` dosyasında bulunan veritabanı bağlantı dizesini (`ConnectionString`) kendi yerel veritabanı bilgilerinize göre güncelleyin.

4. **Migration'ları Uygulayın:**
   Package Manager Console veya .NET CLI üzerinden veritabanını oluşturun.
   ```bash
   dotnet ef database update
   ```

5. **Projeyi Çalıştırın:**
   ```bash
   dotnet run
   ```
Uygulama varsayılan olarak `https://localhost:7001` ve `http://localhost:5001` portlarında çalışmaya başlayacaktır. API arayüzünü test etmek için `https://localhost:7001/swagger` adresini ziyaret edebilirsiniz.

---

