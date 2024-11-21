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
    wwwroot: Uygulamanın statik dosyalarının (CSS, JS, img vb.) bulunduğu klasördür.Fronend gibi
    builder.Build(): Uygulama yapılandırmasını tamamlar ve bir WebApplication örneği oluşturur.
    app.Run(): Uygulamayı çalıştırır
*/