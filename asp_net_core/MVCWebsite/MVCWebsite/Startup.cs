using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;

namespace MVCWebsite
{
	public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			//app.Run(async (context) =>
			//{
			//	await context.Response.WriteAsync("Hello World!");
			//});
			//app.UseMvcWithDefaultRoute();
			//You can use UseMvc or UseMvcWithDefaultRoute
			///khi client request url, routing sẽ hướng dẫn request này tìm đến controller thích hợp và method thích hợp trên controller đó,
			///method này nếu return View(...) thì nó sẽ tìm đến tên file view cshtml thích hợp trên mục /View/Share, /View/Home hoặc /Pages gì đó, xong cần làm gì thì làm tiếp cái đó.
			app.UseMvc(route =>
			{
				//route.MapRoute(name:"secure",template: "secure",defaults: new
				//{
				//	controller = "Admin",
				//	action = "Index"
				//});
				//route.MapRoute("default", "{controller=Home}/{action=Index}/{id:int?}");

				route.MapRoute("default", "{controller=Home}/{action=Index}/{id:alpha:minlength(6)?}");


				//route.MapRoute("default", "{controller}/{action}/{id?}", new { controller = "Home", action = "Index" },
				//	new {
				//		id= new CompositeRouteConstraint(new IRouteConstraint[] { 
				//		new AlphaRouteConstraint(),
				//		new MinLengthRouteConstraint(6)
				//		})

				//	});
				//route.MapRoute("default", 
				//	"{controller}/{action}/{year:regex(^\\d{{4}}$)}", new { controller = "Home", action = "Index" });
				//route.MapRoute("default", "post/{id:int}", new { controller = "Post", action = "PostByID" });
				//route.MapRoute("anotherRoute", "post/{id:alpha}", new { controller = "Post", action = "PostByPastName" });

			});
		}
	}
}
