using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.SampleMiddleware;

namespace WebApplication1.ExtensionMethod
{
	public static class SomeMiddleWareExtentioncs
	{
		public static IApplicationBuilder UseSimpleMiddleWare(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<MiddleWare>();
		}
	}
}
