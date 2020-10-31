using App.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace App.Services
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment env;

        public FileService(IWebHostEnvironment env)
        {
            this.env = env ?? throw new ArgumentNullException(nameof(env));
        }

        public string SaveFile(IFormFile file, string folder = "uploads")
        {
            var uploadPath = Path.Combine(env.WebRootPath, folder);
            if (!Directory.Exists(uploadPath))
                Directory.CreateDirectory(uploadPath);

            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var filePath = Path.Combine(uploadPath, fileName);

            using (var stream = File.Create(filePath))
            {
                file.CopyTo(stream);
            }
            return fileName;
        }
    }
}
