using Cental.BussinesLayer.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Concrete
{
    public class ImageService : IImageService
    {
        public async Task<string> SaveImage(IFormFile file)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
            if (extension!=".jpg" && extension!=".jpeg" && extension != ".png")
            {
                throw new Exception("Dosya Formatı Resim Olmalıdır.");
            }

            var ImageName = Guid.NewGuid() + extension;
            var imageFolder = Path.Combine(currentDirectory,"wwwroot/Images/");
            if (!Directory.Exists(imageFolder))
            {
                Directory.CreateDirectory(imageFolder);
            }
            var saveLocation=Path.Combine(currentDirectory, imageFolder, ImageName);
            var stream = new FileStream(saveLocation,FileMode.Create);
            await file.CopyToAsync(stream);
            return "/Images/" + ImageName;
        }
    }
}
