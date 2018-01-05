namespace ImageGallery.Models.Image
{
    using Microsoft.AspNetCore.Http;

    public class ImageUploadModel
    {
        public string Title { get; set; }

        public string Tags { get; set; }

        public IFormFile FormFile { get; set; }
    }
}
