using SnusSmartAPI.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnusSmartAPI.Services
{
    public class Repository : IRepository
    {
        protected readonly SnusSmartContext _snusSmartContext;

        public Repository(SnusSmartContext context)
        {
            _snusSmartContext = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _snusSmartContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _snusSmartContext.Remove(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _snusSmartContext.Update(entity);
        }

        public async Task<bool> Save()
        {
            return (await _snusSmartContext.SaveChangesAsync()) >= 0;
        }

    }
}
