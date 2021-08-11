using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUD_DAL.Data;
using CRUD_DAL.Entities;
using CRUD_DAL.Repository;
using CRUD_DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_BAL.Interface;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.OpenApi.Models;
using CRUD_BAL.Service;
// using Microsoft.OpenApi.Models;

namespace CRUDAspNetCore5WebAPI
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        

         //This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            services.AddHttpClient();


            services.AddScoped<IRepository<Manager>, Repository<Manager>>();
            services.AddTransient<IManagerService, ManagerService>();

            services.AddTransient<IRepository<Employee>, Repository<Employee>>();
            services.AddTransient<IEmployeeService, EmployeeService>();

            services.AddTransient<IRepository<EmployeeSkill>, Repository<EmployeeSkill>>();
            services.AddTransient<IEmployeeSkillService, EmployeeSkillService>();

            services.AddTransient<IRepository<Company>, Repository<Company>>();
            services.AddTransient<ICompanyService, CompanyService>();

            services.AddTransient<IRepository<Skill>, Repository<Skill>>();
            services.AddTransient<ISkillService, SkillService>();

            

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CRUDAspNetCore5WebAPI", Version = "v1" });
            });

        }

         //This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
               app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CRUDAspNetCore5WebAPI v1"));
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
