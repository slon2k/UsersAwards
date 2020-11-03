using System;

namespace App.Entities
{
    public class Image : EntityBase
    {
        public string FileName { get; set; }
        public string Path { get; set; }

        public string Url => System.IO.Path.Combine(this.Path, FileName);
    }
}
