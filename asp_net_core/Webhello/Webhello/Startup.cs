using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Webhello
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }
		//  // đang ký các dịch vụ
		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();// Thêm dịch vụ dùng bộ nhớ lưu cache (session sử dụng)
			services.AddSession(); // Thêm  dịch vụ Session
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
			// Thêm StaticFileMiddleware - nếu Request là yêu cầu truy cập file tĩnh,
			// Nó trả ngay về Response nội dung file và là điểm cuối pipeline, nếu  khác
			// nó gọi  Middleware phía sau trong Pipeline
			app.UseStaticFiles();
			// Thêm EndpointRoutingMiddleware: ánh xạ Request gọi đến Endpoint (Middleware cuối)
			// phù hợp định nghĩa bởi EndpointMiddleware
			app.UseRouting();

			app.UseAuthorization();
			// EndpointMiddleware: định nghĩa các EndPoint (là các Delegate), như là  điểm cuối của
			// pipeline - cho mỗi URL phù hợp
			app.UseEndpoints(endpoints =>
			{
				// EndPoint(1) - phù hợp khi truy cập / Home với phương thức GET -nó làm Middleware cuối Pipeline
				
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
