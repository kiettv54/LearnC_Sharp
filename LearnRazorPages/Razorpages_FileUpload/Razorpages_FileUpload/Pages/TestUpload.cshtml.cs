using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razorpages_FileUpload.Pages
{
    public class TestUploadModel : PageModel
    {
        private IWebHostEnvironment _environment;
        public TestUploadModel(IWebHostEnvironment environment) => _environment = environment;
        [BindProperty]
        public string noidung { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost(string noidungct)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            noidung = noidungct;
            return Page();
        }
        public string Upload(IFormFile file)
        {
            string path;
            string saveloc = @"hinh\\baiviet";
            string relativeloc = "/hinhbaiviet/";
            string filename = file.FileName;

            if (file != null && file.Length > 0)
            {
                try
                {
                    path = Path.Combine(_environment.WebRootPath,saveloc, Path.GetFileName(filename));
                    var stream = new FileStream(path, FileMode.Create);
                    file.CopyTo(stream);
                }
                catch (Exception e)
                {
                    return "<script>alert('Failed: " + e + "');</script>";
                }
            }
            else
            {
                return "<script>alert('Failed: Unkown Error. This form only accepts valid images.');</script>";
            }

            return "<script>top.$('.mce-btn.mce-open').parent().find('.mce-textbox').val('" + relativeloc + filename + "').closest('.mce-window').find('.mce-primary').click();</script>";
        }
    }
}