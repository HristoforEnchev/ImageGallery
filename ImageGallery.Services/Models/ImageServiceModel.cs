namespace ImageGallery.Services.Models
{
    using System;
    using System.Collections.Generic;

    public class ImageServiceModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Created { get; set; }

        public string Url { get; set; }

        public List<string> Tags { get; set; } = new List<string>();
    }
}
