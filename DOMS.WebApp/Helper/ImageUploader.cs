using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace DOMS.WebApp.Helper
{
    public class ImageUploader
    {
        public static async Task<string> UploadImage(IFormFile image, string imgFolder)
        {
            var fileName = string.Empty;
            if (image != null && image.Length > 0)
            {
                fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(image.FileName);
                using (var fileStream = new FileStream(Path.Combine(imgFolder, fileName), FileMode.Create))
                {
                    await image.CopyToAsync(fileStream).ConfigureAwait(false);
                }
            }

            return fileName;
        }
    }
}
