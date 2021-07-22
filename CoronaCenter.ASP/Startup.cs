using CoronaCenter.Model.Forms;
using CoronaCenter.DataBase;
using CoronaCenter.Model.Entities;
using CoronaCenter.Services.Services;
using CoronaCenter.Services.Services.Bases;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Net.Http;
using System.Net.Mail;
using CoronaCenter.Model.Models;

namespace CoronaCenter.ASP
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("CoronaCenterDB"))
                );

            services.AddControllersWithViews();

            //Injection de nos services
            services.AddScoped<DataContext>();

            //services.AddScoped<Mailer>();
            services.AddScoped<HttpClient>();
            services.AddScoped<SmtpClient>();


            services.AddScoped<IService<AddressModel, AddressForm>, AddressService>();
            services.AddScoped<IService<PatientModel, PatientForm>, PatientService>();
            services.AddScoped<IService<MakerModel, MakerForm>, MakerService>();
            services.AddScoped<IService<StaffModel, StaffForm>, StaffService>();
            services.AddScoped<IService<MedicalStaffModel, MedicalStaffForm>, MedicalStaffService>();
            services.AddScoped<IService<UserModel, UserForm>, UserService>();
            services.AddScoped<IService<CenterModel, CenterForm>, CenterService>();
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
        }
    }
}
