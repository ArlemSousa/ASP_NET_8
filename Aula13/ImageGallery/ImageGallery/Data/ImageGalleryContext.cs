using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ImageGallery.Models;

namespace ImageGallery.Data
{
    public class ImageGalleryContext : DbContext
    {
        public ImageGalleryContext (DbContextOptions<ImageGalleryContext> options)
            : base(options)
        {
        }

        public DbSet<ImageGallery.Models.ImageModel> ImageModel { get; set; } = default!;
    }
}
