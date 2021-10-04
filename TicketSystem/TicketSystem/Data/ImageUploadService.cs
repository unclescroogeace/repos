using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlazorInputFile;
using Microsoft.AspNetCore.Hosting;

namespace TicketSystem.Data
{
    public class ImageUploadService : IImageUploadService
    {
        private readonly IWebHostEnvironment _environment;
        public ImageUploadService(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public async Task UploadAsync(IFileListEntry fileEntry, string randomFileName)
        {
            var path = Path.Combine(_environment.ContentRootPath, "Upload", randomFileName);
            MemoryStream ms = new();
            await fileEntry.Data.CopyToAsync(ms);
            using FileStream file = new(path, FileMode.Create, FileAccess.Write);
            ms.WriteTo(file);
        }
    }
}
