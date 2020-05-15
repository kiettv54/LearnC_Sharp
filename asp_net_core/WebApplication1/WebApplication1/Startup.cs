using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1.ExtensionMethod;
using WebApplication1.SampleMiddleware;

namespace WebApplication1
{
	public class Startup
	{
		//using appsettings.json
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.Configure<CookiePolicyOptions>(options =>
			{
				// This lambda determines whether user consent for non-essential cookies is needed for a given request.
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});


			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			//How to use Static Files
			app.UseStaticFiles();
			//app.Use(async (context, next) =>
			//{
			//	//using file appsettings.json, call value of Message in appsettings.json
			//	//	await context.Response.WriteAsync(Configuration.GetSection(key:"Message").Value);
			//	//read key child
			//	//await context.Response.WriteAsync(Configuration.GetSection(key: "ConnectionStrings:SQLServerConnectionString").Value);
			//	////create Array of Students in appsetting.json and get data 
			//	////input Arg1 if you use cmd in document
			//	//await context.Response.WriteAsync(Configuration.GetSection(key: "Arg1").Value);
			//	///You can Read path of project
			//	//await context.Response.WriteAsync(Configuration.GetSection(key: "PATH").Value);
			//	//await next.Invoke();
			//}
			//);
			///MiddleWare using class 
			///app.UseMiddleWare<MiddleWare>();
			app.UseSimpleMiddleWare();


			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseCookiePolicy();

			app.UseMvc();
		}
	}
}
