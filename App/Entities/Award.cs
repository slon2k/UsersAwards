using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Award : EntityBase
    {
        public Award()
        {
        }

        public Award(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public virtual Image Image { get; set; }
        public int? ImageId { get; set; }
    }
}
