using SnusSmartAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnusSmartAPI.Services
{
    public interface ISnuffRepository
    {
        Task<IList<Snuff>> GetAllSnuff();
    }
}
