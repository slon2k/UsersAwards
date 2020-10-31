using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Interfaces
{
    public interface IFileService
    {
        public string SaveFile(IFormFile file, string folder);
    }
}
