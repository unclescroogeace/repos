using BlazorInputFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Data
{
    public interface IImageUploadService
    {
        Task UploadAsync(IFileListEntry file, string name);
    }
}
