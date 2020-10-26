using App.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public override string ToString() => FullName;
        public int Age => BirthDate.YearsPassed();
    }
}
