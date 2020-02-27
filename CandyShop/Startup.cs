using CandyShop.Persistence;
using CandyShop.Persistence.Repository;
using CandyShop.Persistence.Repository.Implementation;
using CandyShop.Service.Services;
using CandyShop.Service.Services.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CandyShop
{
    public class Startup
    {
        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connections = _config["ConnectionStrings:Default"];
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connections));

            services.AddControllersWithViews();
            services.AddScoped<ICandyRepo, CandyRepo>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IShoppingCartItemRepo, ShoppingCartItemRepo>();
            services.AddScoped<IShoppingCartRepo, ShoppingCartRepo>(sc => ShoppingCartRepo.GetCart(sc));
            services.AddScoped<IOrderRepo, OrderRepo>();
            services.AddScoped<IOrderDetailRepo, OrderDetailRepo>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICandyService, CandyService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IShoppingCartService, ShoppingCartService>();

            services.AddHttpContextAccessor();
            services.AddSession();
            //var config = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
            //services.AddSingleton(c => config.CreateMapper());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();

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
