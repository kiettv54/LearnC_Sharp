using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
namespace WebsiteTest
{
    public class Program
    {
       public static void main(string[] args)
       {
           CreateHostBuilder(args).Build().Run();
       }
       public static IHostBuilder CreateHostBuilder(string[] args)=>
       Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(WebBuilder=>{
           WebBuilder.UseStartup<Startup>();
       });
        
       
    }
}
