namespace ImageGallery.Controllers
{
    using ImageGallery.Models.Image;
    using Microsoft.AspNetCore.Mvc;

    public class ImageController : Controller
    {
        public IActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Upload(ImageUploadModel model)
        {
            return View();
        }
    }
}
