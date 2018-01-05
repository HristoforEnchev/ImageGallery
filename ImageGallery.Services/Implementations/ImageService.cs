namespace ImageGallery.Services.Implementations
{
    using Data;
    using Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ImageGallery.Services.Models;

    public class ImageService : IImageService
    {
        private readonly ImageGalleryDbContext db;

        public ImageService(ImageGalleryDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<ImageServiceModel> GetAll()
        {
            return this.db
                .Images
                .Select(i => new ImageServiceModel
                {
                    Id = i.Id,
                    Title = i.Title,
                    Url = i.Url,
                    Created = i.Created,
                    Tags = i.Tags.Select(ti => ti.Tag.Description).ToList()
                })
                .ToList();
        }

        public ImageServiceModel GetById(int id)
        {
            return this.db
                .Images
                .Where(i => i.Id == id)
                .Select(i => new ImageServiceModel
                {
                    Id = i.Id,
                    Title = i.Title,
                    Url = i.Url,
                    Created = i.Created,
                    Tags = i.Tags.Select(ti => ti.Tag.Description).ToList()
                })
                .FirstOrDefault();
        }

        public IEnumerable<ImageServiceModel> GetByTag(string tag)
        {
            return this.db
                .Images
                .Where(i => i.Tags.Any(ti => ti.Tag.Description == tag))
                .Select(i => new ImageServiceModel
                {
                    Id = i.Id,
                    Title = i.Title,
                    Url = i.Url,
                    Created = i.Created,
                    Tags = i.Tags.Select(ti => ti.Tag.Description).ToList()
                })
                .ToList();
        }

        public void Save(string title, string url)
        {
            var image = new Image()
            {
                Title = title,
                Created = DateTime.Now,
                Url = url
            };

            this.db.Images.Add(image);
            this.db.SaveChanges();
        }
    }
}
