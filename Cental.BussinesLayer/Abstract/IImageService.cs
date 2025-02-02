using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BussinesLayer.Abstract
{
    public interface IImageService
    {
        /// <summary>
        /// Saves and Image file from the computer to the project's wwwroot/Images folder
        /// </summary>
        /// <param name="file"></param>
        /// <returns>Returns a string value for the model's imageUrl property</returns>
        Task<string> SaveImage(IFormFile file);
    }
}
