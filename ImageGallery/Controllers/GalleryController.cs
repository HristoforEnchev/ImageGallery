namespace ImageGallery.Controllers
{
    using ImageGallery.Models.Gallery;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;

    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTags = new List<TagViewModel>();
            var cityImageTags = new List<TagViewModel>();

            var tag1 = new TagViewModel()
            {
                Description = "Adventure",
                Id = 1
            };

            var tag2 = new TagViewModel()
            {
                Description = "Urban",
                Id = 2
            };

            var tag3 = new TagViewModel()
            {
                Description = "New York",
                Id = 3
            };

            hikingImageTags.Add(tag1);
            cityImageTags.AddRange(new List<TagViewModel> { tag2, tag3 });

            var imageList = new List<ImageViewModel>()
            {
                new ImageViewModel()
                {
                    Title = "Hiking Trip",
                    Url = "https://static.pexels.com/photos/554609/pexels-photo-554609.jpeg",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },

                new ImageViewModel()
                {
                    Title = "On The Trail",
                    Url = "https://static.pexels.com/photos/34511/norway-mountain-sky-blue.jpg",
                    Created = DateTime.Now,
                    Tags = hikingImageTags
                },

                new ImageViewModel()
                {
                    Title = "Downtown",
                    Url = "https://static.pexels.com/photos/421927/pexels-photo-421927.jpeg",
                    Created = DateTime.Now,
                    Tags = cityImageTags
                }
            };



            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };


            return View(model);
        }
    }
}
