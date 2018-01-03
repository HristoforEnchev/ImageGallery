using System;
using System.Collections.Generic;
using System.Text;

namespace ImageGallery.Data.Models
{
    public class Image
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Created { get; set; }

        public string Url { get; set; }

        public List<TagImage> Tags { get; set; } = new List<TagImage>();
    }
}
