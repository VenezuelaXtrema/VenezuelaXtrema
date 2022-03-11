using Store.Domain.Base;
using Store.Domain.Interfaces;
using Store.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.Data
{
    public class UnitOfWork
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IAsyncRepository<T> AsyncRepository<T>() where T : BaseEntity
        {
            return new RepositoryBase<T>(_applicationDbContext);
        }

        public Task<int> SaveChangesAsync()
        {
            return _applicationDbContext.SaveChangesAsync();
        }
    }
}
