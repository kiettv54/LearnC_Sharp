using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.SampleMiddleware
{
	public class MiddleWare
	{
		private readonly RequestDelegate _next;
		public MiddleWare(RequestDelegate next)
		{
			_next = next;
		}
		public async Task Invoke(HttpContext context)
		{
			await context.Response.WriteAsync(text: "<div>Hello world hahahaha</div>");
			await _next(context);
			await context.Response.WriteAsync(text: "<div>I'm Kiet</div>");

		}
	}
}
