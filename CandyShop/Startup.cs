using CandyShop.GlobalException;
using CandyShop.Persistence;
using CandyShop.Persistence.Repository;
using CandyShop.Persistence.Repository.Implementation;
using CandyShop.Service.Services;
using CandyShop.Service.Services.Implementation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

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

            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(option =>
            {
                option.Password.RequiredLength = 8;
                option.Password.RequireDigit = true;
                option.Password.RequireNonAlphanumeric = false;
                option.Password.RequireUppercase = false;
                option.Password.RequireLowercase = true;
                option.Password.RequiredUniqueChars = 2;

                option.Lockout.AllowedForNewUsers = true;
                option.Lockout.MaxFailedAccessAttempts = 5;
                option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);

                option.User.RequireUniqueEmail = true;

                option.SignIn.RequireConfirmedEmail = false;
            });
            services.AddAuthentication().AddFacebook(option =>
            {
                option.AppId = _config["FacebookAppId"];
                option.AppSecret = _config["FacebookAppSecret"];
            }).AddGoogle(option => 
            {
                option.ClientId = _config["GoogleClientId"];
                option.ClientSecret = _config["GoogleClientSecret"];
            });

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
            services.AddRazorPages();
            //var config = new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile()));
            //services.AddSingleton(c => config.CreateMapper());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.ConfigureExceptionMiddleware(logger);

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );

                endpoints.MapRazorPages();
            });
        }
    }
}
