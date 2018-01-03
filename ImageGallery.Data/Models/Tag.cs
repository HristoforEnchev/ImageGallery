using System;
using System.Collections.Generic;
using System.Text;

namespace ImageGallery.Data.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<TagImage> Images { get; set; }
    }
}
