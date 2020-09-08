using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razorpages_FileUpload.Models;

namespace Razorpages_FileUpload.Data
{
    public class Razorpages_FileUploadContext : DbContext
    {
        public Razorpages_FileUploadContext (DbContextOptions<Razorpages_FileUploadContext> options)
            : base(options)
        {
        }

        public DbSet<Razorpages_FileUpload.Models.ImageSave> ImageSave { get; set; }
    }
}
