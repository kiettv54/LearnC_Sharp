using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Razorpages_FileUpload.Data;
using Razorpages_FileUpload.Models;

namespace Razorpages_FileUpload.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Razorpages_FileUpload.Data.Razorpages_FileUploadContext _context;

        public CreateModel(Razorpages_FileUpload.Data.Razorpages_FileUploadContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ImageSave ImageSave { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ImageSave.Add(ImageSave);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
