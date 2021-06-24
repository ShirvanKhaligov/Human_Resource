using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Projectt.Services;
using InternalSystem.Areas.Admin.Models;
using InternalSystem.Areas.InternalHR.DAL;
using InternalSystem.Areas.InternalHR.Models.MailRu;
using InternalSystem.Areas.InternalHR.Services;
using InternalSystem.Security;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InternalSystem
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
            services.AddSingleton<IEmailConfiguration>(Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>());
            services.AddTransient<IEmailService, EmailService>();
            services.AddMemoryCache();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            });
            //services.ConfigureApplicationCookie(options =>
            //{
            //    options.LoginPath = new PathString("/MainAccount/Login");
            //    options.AccessDeniedPath = new PathString("");
            //    options.Cookie.Expiration = TimeSpan.FromDays(1);
            //    options.ExpireTimeSpan = new TimeSpan(2, 20, 10);

            //});
            services.AddIdentity<AppUser, IdentityRole>(options =>
            {

                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredLength = 4;
                options.Password.RequireUppercase = true;


                options.User.RequireUniqueEmail = true;
                // options.User.AllowedUserNameCharacters = "asdfghjkASDFGHJK12345678_-";


                options.Lockout.MaxFailedAccessAttempts = 3;
                options.Lockout.AllowedForNewUsers = false;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);


            })
                .AddEntityFrameworkStores<InternalSysDBContext>()
                .AddDefaultTokenProviders();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(15);
                options.Cookie.IsEssential = true;
                options.Cookie.HttpOnly = true;
                options.IOTimeout = TimeSpan.FromSeconds(2);

            });
            services.AddSingleton<DataProtectionPurposeSetting>();
          //  services.AddScoped<InternalSysDBContext>();
            //SMTP
            services.AddSingleton<IEmailSender, EmailSender>(e => new EmailSender(
               Configuration["EmailSettings:Host"],
               Configuration.GetValue<int>("EmailSettings:Port"),
               Configuration.GetValue<bool>("EmailSettings:SSL"),
               Configuration["EmailSettings:Username"],
               Configuration["EmailSettings:Password"]
                ));

            services.AddDbContext<InternalSysDBContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });



            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/account/loginsec";
                options.LogoutPath = $"/account/logoutsec";
                options.AccessDeniedPath = $"/account/accessDenied";
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error/ErrorPage");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute("areaRoute", "{area:exists}/{controller}/{action}/{id?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=Login}/{id?}");
            });
        }
    }
}
