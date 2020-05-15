using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApplication1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateWebHostBuilder(args).Build().Run();
		}
		
		//public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
		//	WebHost.CreateDefaultBuilder(args)
		//		.UseStartup<Startup>();
		

		//working configuration file Asp.net core
		public static IWebHostBuilder CreateWebHostBuilder(string[] args)
		{
			var builder = WebHost.CreateDefaultBuilder(args).ConfigureAppConfiguration((hostingcontext, config) =>
			{
				var env = hostingcontext.HostingEnvironment;
				config.AddJsonFile(path: "appsettings.json", optional: true, reloadOnChange: true)
				.AddJsonFile(path: $"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true);
				if (env.IsDevelopment())
				{
					var appAssembly = Assembly.Load(new AssemblyName(env.ApplicationName));
					if (appAssembly != null)
					{
						config.AddUserSecrets(appAssembly,optional: true);
					}
				}
				config.AddEnvironmentVariables();
				if (args != null)
				{
					config.AddCommandLine(args);
				}
			}).UseStartup<Startup>();
			return builder;
		}
	}
}
