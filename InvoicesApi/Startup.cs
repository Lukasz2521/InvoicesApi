﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Invoices.Infrastructure.Repositories;
using Invoices.Core.Repositories;
using Invoices.Infrastructure.Mappers;
using Invoices.Infrastructure.Services;

namespace InvoicesApi
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
            services.AddCors();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IContractorRepository, ContractorRepository>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddSingleton(AutoMapperConfig.Initialize());
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseCors(builder =>
                    builder.WithOrigins("http://localhost:50823")
                           .AllowAnyHeader()
                    );
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
