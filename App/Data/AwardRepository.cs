using App.Entities;
using App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Data
{
    public class AwardRepository : Repository<Award>, IAwardRepository
    {
        public AwardRepository(AppDbContext context) : base(context)
        {
        }
    }
}
