using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekMVC_1
{
    //Controller=> Uygulamaya gelen istekleri karþýlayabilmek için kullandýðýmýz sýnýflardýr.
    //Controller sýnýflarý genellikle Controllers klasörü altýnda tutulurlar.
    //Controlers kalsörüne sað týk add deðidiðinde controller sýnýfý oluþturabiliriz.
    //Controller sýnýflarýnda sýnýf isminin yanýna controller konulmasý gelenekseldir.


    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
       
        
        
        public void ConfigureServices(IServiceCollection services)
        {          

            //Asp.Net Core uygulamasýnda MVC mimarisini kullanabilmek için uygulamada Controller ve View yapýlanmalarýnýn eklenmesi gerekmektedir. bunun için öncelikle bu servis uygulamaya ekleniyor.Böylece uygulama MVC davranýþý sergileyebilecektir.
            services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Startup>());
            
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //Gelen isteðin rotasý bu middleware sayesinde belirlenir.
            app.UseRouting();

            app.UseAuthorization();


            //Endpoint=> Yapýlan isteðin varýþ noktasý. URL. Ýstek adresi.
            //Bu uygulamya gelen isteklerin hangi rotalar/þablonlar eþliðinde gelebileceðini buradan bildireceðiz.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("CustomRoute","{controller=Home}/{action=Index}/{a}/{b}/{id}");
                
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
