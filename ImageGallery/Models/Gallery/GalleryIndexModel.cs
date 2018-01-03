namespace ImageGallery.Models.Gallery
{
    using System.Collections.Generic;

    public class GalleryIndexModel
    {
        public IEnumerable<ImageViewModel> Images { get; set; }

        public string SearchQuery { get; set; }
    }
}
