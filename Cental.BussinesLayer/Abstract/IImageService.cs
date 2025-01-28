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
        Task<string> SaveImage(IFormFile file);
    }
}
