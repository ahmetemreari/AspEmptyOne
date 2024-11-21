# ASP.NET Core MVC Projesi

Bu proje, ASP.NET Core kullanarak oluşturulmuş bir MVC (Model-View-Controller) uygulamasıdır. Aşağıda, projenin yapılandırılması ve çalıştırılması için gerekli adımlar açıklanmıştır.

## Proje Yapısı

- **Controllers**: Kullanıcı isteklerini işleyen sınıfların bulunduğu klasör.
- **Models**: Uygulamanın veri yapısını temsil eden sınıfların bulunduğu klasör.
- **Views**: Kullanıcıya gösterilecek olan arayüz dosyalarının bulunduğu klasör.
- **wwwroot**: Uygulamanın statik dosyalarının (CSS, JS, img vb.) bulunduğu klasör.

## Program.cs Dosyası

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// MVC Servislerinin Eklenmesi
builder.Services.AddControllersWithViews();

// Uygulama oluşturuluyor
var app = builder.Build();

// Statik Dosyaların Kullanımının Belirtilmesi
app.UseStaticFiles();

// Routing Konfigürasyonu
app.UseRouting();

// Varsayılan Routing
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Uygulamanın çalıştırılması
app.Run();

/*
    Controller: Kullanıcı isteklerini işleyen sınıflardır. İş mantığını içerir ve model ile view arasında köprü görevi görür.
    Action: Controller içinde tanımlanan ve belirli bir isteği işleyen metotlardır.
    Model: Uygulamanın veri yapısını temsil eder. Veritabanı ile etkileşimi sağlar.
    View: Kullanıcıya gösterilecek olan arayüzü temsil eder. Razor kullanılarak oluşturulur.
    Razor: ASP.NET Core'da view'leri oluşturmak için kullanılan bir işaretleme dilidir.
    RazorView: Razor kullanılarak oluşturulan view dosyalarıdır.
    wwwroot: Uygulamanın statik dosyalarının (CSS, JS, img vb.) bulunduğu klasördür.
    builder.Build(): Uygulama yapılandırmasını tamamlar ve bir WebApplication örneği oluşturur.
    app.Run(): Uygulamayı çalıştırır ve gelen istekleri dinlemeye başlar.
*/
```

## Projeyi Çalıştırma

1. Projeyi oluşturduktan sonra, yukarıdaki `Program.cs` dosyasını kullanarak yapılandırın.
2. `Controllers`, `Models`, `Views` ve `wwwroot` klasörlerini oluşturun.
3. Projeyi çalıştırmak için `dotnet run` komutunu kullanın.

