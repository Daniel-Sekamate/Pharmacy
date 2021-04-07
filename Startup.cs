using Blazored.Toast;
using BlazorStrap;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pharmacy.Areas.Identity;
using Pharmacy.Data;
using Pharmacy.Models;
using Syncfusion.Blazor;
using System;
using static Pharmacy.Pages.Ordering.NewSupplierOrder;
using static Pharmacy.Pages.Ordering.PhysicalCountPage;
using static Pharmacy.Pages.Ordering.ProductWastagePage;
using static Pharmacy.Pages.Ordering.ReceivedOrdersPage;
using static Pharmacy.Pages.Sales.PosOrdersPage;
using static Pharmacy.Pages.Sales.PosPage;
using static Pharmacy.Pages.Utilities.Product;
using static Pharmacy.Pages.Utilities.Staff;

namespace Pharmacy
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"), sqloptions => sqloptions.CommandTimeout(3000)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.AddDbContext<PharmacyContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("DefaultConnection"), sqloptions => sqloptions.CommandTimeout(3000)).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            //services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();
            services.Configure<IdentityOptions>(options =>
            {
                // Default Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(60);
                options.Lockout.MaxFailedAccessAttempts = 4;
                options.Lockout.AllowedForNewUsers = false;
            });
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<UserManagement>();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddSingleton<WeatherForecastService>();
            services.AddSyncfusionBlazor();
            services.AddBootstrapCss();
            services.AddBlazoredToast();
            services.AddMvc(options => options.EnableEndpointRouting = false).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddScoped<StaffAdapter>();
            services.AddScoped<StaffRoleAdapter>();

            services.AddScoped<ProductAdapter>();
            services.AddScoped<SupplierAdapter>();
            services.AddScoped<ProductClassificationAdapter>();
            services.AddScoped<ProductCategoryAdapter>();
            services.AddScoped<PhysicalCountAdapter>();
            services.AddScoped<StoreSupplierNewOrderAdapter>();
            services.AddScoped<StoreSupplierOrderDetailsAdapter>();
            services.AddScoped<ProductWastageAdapter>();
            services.AddScoped<OrderPOSDetailsAdapter>();
            services.AddScoped<ReceivedOrderAdapter>();
            services.AddScoped<ReceivedOrderDetailsAdapter>();
            services.AddScoped<BatchDetailAdapter>();
            services.AddScoped<POSOrderHeaderAdapter>();
            services.AddScoped<OrderPOSDetailAdapter>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mzc5MzM0QDMxMzgyZTM0MmUzMEF4OXdkNmFvQzlkQjZhZU9qZHFqVTU2SmpYLzVOdVIvWVMrdk1aUUx4VGM9");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
//Scaffold-DbContext "Server=.;Database=Pharmacy;User Id=sa;password=root85;Trusted_Connection=False;MultipleActiveResultSets=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models -f -context "PharmacyContext"

//IConfigurationRoot configuration = new ConfigurationBuilder()
//                               .SetBasePath(Directory.GetCurrentDirectory())
//                               .AddJsonFile("appsettings.json")
//                               .Build();
//var connectionString = configuration.GetConnectionString("DefaultConnection");
//optionsBuilder.UseSqlServer(connectionString);

//using Microsoft.Extensions.Configuration;
//using System.IO;

//SPToCore.exe scan -cnn "Data Source=IBS;Initial Catalog=Pharmacy;Persist Security Info=True;User ID=sa;Password=root85;" -sch * -nsp Pharmacy -ctx PharmacyContext -sf Models -pf D:\CoreProjects\Pharmacy\Models\ -f SPToCoreContext.cs