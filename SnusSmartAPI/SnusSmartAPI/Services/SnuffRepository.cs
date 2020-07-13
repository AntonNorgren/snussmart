using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SnusSmartAPI.DAL;
using SnusSmartAPI.Models;

namespace SnusSmartAPI.Services
{
    public class SnuffRepository : Repository, ISnuffRepository
    {
        public SnuffRepository(SnusSmartContext snusSmartContext) : base (snusSmartContext)
        {

        }
        public async Task<IList<Snuff>> GetAllSnuff()
        {
            IQueryable<Snuff> query = _snusSmartContext.Snuff;
            return await query.ToListAsync();

        }
    }
}
