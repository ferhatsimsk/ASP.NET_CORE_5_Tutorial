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
    //Controller=> Uygulamaya gelen istekleri kar��layabilmek i�in kulland���m�z s�n�flard�r.
    //Controller s�n�flar� genellikle Controllers klas�r� alt�nda tutulurlar.
    //Controlers kals�r�ne sa� t�k add de�idi�inde controller s�n�f� olu�turabiliriz.
    //Controller s�n�flar�nda s�n�f isminin yan�na controller konulmas� gelenekseldir.


    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
       
        
        
        public void ConfigureServices(IServiceCollection services)
        {          

            //Asp.Net Core uygulamas�nda MVC mimarisini kullanabilmek i�in uygulamada Controller ve View yap�lanmalar�n�n eklenmesi gerekmektedir. bunun i�in �ncelikle bu servis uygulamaya ekleniyor.B�ylece uygulama MVC davran��� sergileyebilecektir.
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

            //Gelen iste�in rotas� bu middleware sayesinde belirlenir.
            app.UseRouting();

            app.UseAuthorization();


            //Endpoint=> Yap�lan iste�in var�� noktas�. URL. �stek adresi.
            //Bu uygulamya gelen isteklerin hangi rotalar/�ablonlar e�li�inde gelebilece�ini buradan bildirece�iz.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("CustomRoute","{controller=Home}/{action=Index}/{a}/{b}/{id}");
                
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
