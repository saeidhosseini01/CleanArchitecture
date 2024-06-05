using CleanArchitecture.Domain.Entitis.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;







namespace CleanArchitecture.Application.Repository;





public interface IBaseRepository<T> where T : BaseEntity
{
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<T> GetByGuidAsync(Guid guid,CancellationToken cancellationToken);
    Task<List<T>> GetAllAsync(CancellationToken cancellationToken );
}
