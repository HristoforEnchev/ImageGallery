using System;
using System.Collections.Generic;
using System.Text;

namespace ImageGallery.Data.Models
{
    public class TagImage
    {
        public int TagId { get; set; }

        public Tag Tag { get; set; }

        public int ImageId { get; set; }

        public Image Image { get; set; }
    }
}
