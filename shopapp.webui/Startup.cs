using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.FileProviders;
using System.IO;
using shopapp.data.Abstract;
using shopapp.data.Concrete.SQL;
using shopapp.business.Abstract;
using shopapp.business.Concrete;

namespace shopapp.webui
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //IProductrepo cagırıldıgı zaman sqlProductRepo dan nesne uretıp gonderecegız 
            services.AddScoped<IProductRepository,SqlProductRepository>();
            services.AddScoped<IProductService,ProductManager>();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //wwwroot
            app.UseStaticFiles();
            
            //bootstrap kutuphanesını node js ile locale indirdik ve projeye import ettik
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
           Path.Combine(Directory.GetCurrentDirectory(),"node_modules")),
                RequestPath = "/modules"
            });



            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //localhost:5000/home/index

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            });
        }
    }
}
