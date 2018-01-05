namespace ImageGallery.Controllers
{
    using ImageGallery.Models.Image;
    using ImageGallery.Services;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using System.IO;
    using System.Threading;

    public class ImageController : Controller
    {
        private readonly IHostingEnvironment he;
        private readonly IImageService images;

        public ImageController(IHostingEnvironment he, IImageService images)
        {
            this.he = he;
            this.images = images;
        }

        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(ImageUploadModel model)
        {
            var imagePath = Path.Combine(he.WebRootPath, "images", model.FormFile.FileName);  //Path.GetFileName(model.FormFile.FileName)

            using(var stream = new FileStream(imagePath, FileMode.Create))
            {
                model.FormFile.CopyTo(stream);
            }

            var imagePathDB = $"/images/{model.FormFile.FileName}";

            this.images.Save(model.Title, imagePathDB);

            return RedirectToAction(nameof(GalleryController.Index), "Gallery");
        }
    }
}
