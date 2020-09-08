using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Razorpages_FileUpload.Data;
using Razorpages_FileUpload.Models;

namespace Razorpages_FileUpload.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Razorpages_FileUpload.Data.Razorpages_FileUploadContext _context;

        public DetailsModel(Razorpages_FileUpload.Data.Razorpages_FileUploadContext context)
        {
            _context = context;
        }

        public ImageSave ImageSave { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ImageSave = await _context.ImageSave.FirstOrDefaultAsync(m => m.Imgid == id);

            if (ImageSave == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
