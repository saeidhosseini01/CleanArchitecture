using CleanArchitecture.Domain.Entitis;

namespace CleanArchitecture.Application.Repository
{
    public interface IUserRepository:IBaseRepository<User>
    {
        Task<User> GetByEmail(string email,CancellationToken cancellationToken);
    }
}
