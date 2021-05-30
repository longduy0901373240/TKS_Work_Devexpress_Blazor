using Controller.Danh_Muc;
using Controller.DX;
using Controller.XNK;
using Entity.DX;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Utility;
using Web.Data;

namespace Web
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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddDevExpressBlazor();

            services.AddSingleton<CDM_Don_Vi_Tinh_Controller>();
            services.AddSingleton<CDM_Drill_Down_Controller>();
            services.AddSingleton<CDM_Kho_Controller>();
            services.AddSingleton<CDM_Loai_San_Pham_Controller>();
            services.AddSingleton<CDM_Mau_Column_Controller>();
            services.AddSingleton<CDM_Nha_Cung_Cap_Controller>();
            services.AddSingleton<CDM_San_Pham_Controller>();
            //--------------------------------------------------------------------
            services.AddSingleton<CXNK_Nhap_Kho_Controller>();
            services.AddSingleton<CXNK_Nhap_Kho_Chi_Tiet_Controller>();
            services.AddSingleton<CXNK_Xuat_Kho_Controller>();
            services.AddSingleton<CXNK_Xuat_Kho_Chi_Tiet_Controller>();
            //--------------------------------------------------------------------
            services.AddSingleton<CDX_DO_Controller>();
            services.AddSingleton<CDX_DO_Chi_Tiet_Controller>();
            services.AddSingleton<CDX_Giao_Hang_Controller>();
            services.AddSingleton<CDX_Nhan_Hang_Controller>();
            services.AddSingleton<CDX_Tai_Xe_Controller>();
            services.AddSingleton<CDX_Trip_Controller>();
            services.AddSingleton<CDX_Xe_Controller>();
            //--------------------------------------------------------------------
            services.AddHttpContextAccessor();

            services.AddSingleton(CConfig.g_strTKS_Thuc_Tap_Data_Conn_String = Configuration.GetConnectionString("TKS_Thuc_Tap_Data_Conn_String").ToString());
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
