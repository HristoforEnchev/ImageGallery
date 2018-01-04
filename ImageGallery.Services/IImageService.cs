namespace ImageGallery.Services
{
    using ImageGallery.Data.Models;
    using ImageGallery.Services.Models;
    using System.Collections.Generic;

    public interface IImageService
    {
        IEnumerable<ImageServiceModel> GetAll();

        IEnumerable<ImageServiceModel> GetByTag(string tag);

        ImageServiceModel GetById(int id);
    }
}
