namespace BilgeAdam.HelloAspNetCore;

public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.UseStaticFiles(); // Uygulama kendi kök dizininden dosyalara erişebilir
        app.UseRouting(); // Uygulama'da adres yönlendirmesi kullanılsın
        app.UseEndpoints(endpoints => // Uygulamada isteğe cevap verecek adresler olsun
        { 
            endpoints.MapDefaultControllerRoute(); // Cevap verilecek adreslerin MVC mantığında bir Controller'dan yönetilmesi sağlansın
        });
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
    }
}