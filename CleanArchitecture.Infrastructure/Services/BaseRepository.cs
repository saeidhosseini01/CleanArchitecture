using CleanArchitecture.Application.Repository;
using CleanArchitecture.Domain.Entitis.Common;
using CleanArchitecture.Persistence.DataDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Services
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {


            protected  readonly  DataDbContext dbContext;
        public BaseRepository(DataDbContext Context)
        {
                dbContext=Context;
        }
        public void Create(T entity)
        {
            dbContext.Add<T>(entity);
            dbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            entity.IsDeleted = true;
            dbContext.Update<T>(entity);
            dbContext.SaveChanges();
        }

        public Task<List<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            return dbContext.Set<T>().ToListAsync(cancellationToken);
        }

        public Task<T> GetByGuidAsync(Guid guid, CancellationToken cancellationToken)
        {
          return  dbContext.Set<T>().FirstOrDefaultAsync(t => t.Guid == guid,cancellationToken);
        }

        public void Update(T entity)
        {
            dbContext.Update(entity);
            dbContext.SaveChanges();
        }
    }
}
