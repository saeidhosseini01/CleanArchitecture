using CleanArchitecture.Application.Repository;
using CleanArchitecture.Infrastructure.Context;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataDbContext _dbContext;


        public UnitOfWork(DataDbContext dbContext)
        {
               _dbContext = dbContext;
        }
        public Task SaveChange(CancellationToken cancellationToken)
        {
         return    _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
