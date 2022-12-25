using Electronics_Shop.DataBaseContext;
using Electronics_Shop.Interfaces;
using Electronics_Shop.Models.Product;
using Electronics_Shop.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Threading.Tasks;

namespace Electronics_Shop
{
    public class Startup
    {
        private IConfigurationRoot confString;
        public static int? IdUser { get; set; }
        public static string StatusUser { get; set; }
        public static int IdProduct { get; set; }
        public static int IdUserSetings { get; set; }
        public static int IdProductUser { get; set; }

        public static List<Products> ShopCart = new List<Products>();
        public Startup(IConfiguration configuration, IHostEnvironment hostEnv)
        {
            Configuration = configuration;
            confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbSettings.json").Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(confString.GetConnectionString("DefaultConnection")));

            services.AddTransient<IProducts, ProductsRepository>();
            services.AddTransient<IUsers, UsersRepository>();
            services.AddTransient<IBuyProducts, BuyProductsRepository>();

            services.AddControllersWithViews();
            services.AddMvc();
            services.AddMemoryCache();

            services.AddRazorPages(options =>
            {
                options.Conventions.AuthorizePage("/List");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });

            using(var scope = app.ApplicationServices.CreateScope())
            {
                ApplicationContext context = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                DBObjects.Initial(context);
            }
        }
    }
}
