using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Razorpages_FileUpload.Models
{
    public class ImageSave
    {
        [Key]
        public int Imgid { get; set; }

        public string Imgname { get; set; }
        public string Imgpath { get; set; }
    }
}