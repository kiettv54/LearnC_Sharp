using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;

        public IndexModel(IWebHostEnvironment environment) => _environment = environment;

        public bool Success { get; private set; } = true;

        public void OnPostFile(IFormFile file)
        {
            try
            {
                var f = Path.Combine(_environment.ContentRootPath, "upload", file.FileName);
                using var fs = new FileStream(f, FileMode.Create);
                file.CopyTo(fs);
                ViewData["file"] = file.FileName;
            }
            catch (Exception)
            {
                Success = false;
            }
        }

        public void OnGet()
        {
        }
    }
}