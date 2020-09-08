using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Razorpages_FileUpload.Data;
using Razorpages_FileUpload.Models;

namespace Razorpages_FileUpload.Pages
{
    public class EditModel : PageModel
    {
        private readonly Razorpages_FileUpload.Data.Razorpages_FileUploadContext _context;

        public EditModel(Razorpages_FileUpload.Data.Razorpages_FileUploadContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ImageSave).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ImageSaveExists(ImageSave.Imgid))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ImageSaveExists(int id)
        {
            return _context.ImageSave.Any(e => e.Imgid == id);
        }
    }
}
