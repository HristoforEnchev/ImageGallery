namespace ImageGallery.Models.Gallery
{
    using ImageGallery.Services.Models;
    using System.Collections.Generic;

    public class GalleryIndexModel
    {
        public IEnumerable<ImageServiceModel> Images { get; set; }

        public string SearchQuery { get; set; }
    }
}
