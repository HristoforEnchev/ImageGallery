namespace ImageGallery.Models.Gallery
{
    using System;
    using System.Collections.Generic;

    public class ImageViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Created { get; set; }

        public string Url { get; set; }

        public List<TagViewModel> Tags { get; set; } = new List<TagViewModel>();
    }
}
