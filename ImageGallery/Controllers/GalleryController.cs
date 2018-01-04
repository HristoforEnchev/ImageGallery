namespace ImageGallery.Controllers
{
    using ImageGallery.Models.Gallery;
    using ImageGallery.Services;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    public class GalleryController : Controller
    {
        private readonly IImageService images;

        public GalleryController(IImageService images)
        {
            this.images = images;
        }


        public IActionResult Index()
        {
            return View(new GalleryIndexModel
            {
                Images = this.images.GetAll()
            });
        }

        public IActionResult Details(int id)
        {
            var image = this.images.GetById(id);

            var model = new GalleryDetailsModel
            {
                Image = image
            };

            return View(model);
        }
    }
}
