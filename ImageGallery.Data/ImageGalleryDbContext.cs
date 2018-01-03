namespace ImageGallery.Data
{
    using ImageGallery.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class ImageGalleryDbContext : DbContext
    {
        public ImageGalleryDbContext(DbContextOptions options) 
            : base(options)
        {

        }

        public DbSet<Image> Images { get; set; }

        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<TagImage>()
                .HasOne(ti => ti.Tag)
                .WithMany(t => t.Images)
                .HasForeignKey(ti => ti.TagId);

            builder
                .Entity<TagImage>()
                .HasOne(ti => ti.Image)
                .WithMany(i => i.Tags)
                .HasForeignKey(ti => ti.ImageId);

            builder
                .Entity<TagImage>()
                .HasKey(ti => new { ti.TagId, ti.ImageId });
            

            base.OnModelCreating(builder);
        }
    }
}
