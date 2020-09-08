using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razorpages_FileUpload.Data;
using Razorpages_FileUpload.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Razorpages_FileUpload.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Razorpages_FileUploadContext _context;
        private readonly IWebHostEnvironment _environment;

        public IndexModel(Razorpages_FileUploadContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IList<ImageSave> ImageSave { get; set; }

        public async Task OnGetAsync()
        {
            ImageSave = await _context.ImageSave.ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync(IFormFile uploadfiles, ImageSave img)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            string imgext = Path.GetExtension(uploadfiles.FileName);
            //if (imgext == ".jpg" || imgext == ".png" || imgext == ".gif")
            //{
                var imgsave = Path.Combine(_environment.WebRootPath, "Images", uploadfiles.FileName);
                var stream = new FileStream(imgsave, FileMode.Create);
                await uploadfiles.CopyToAsync(stream);
                stream.Close();
                img.Imgname = uploadfiles.FileName;
                img.Imgpath = imgsave;
                await _context.ImageSave.AddAsync(img);
                await _context.SaveChangesAsync();
            //}
            return RedirectToPage("./Index");
        }
    }
}