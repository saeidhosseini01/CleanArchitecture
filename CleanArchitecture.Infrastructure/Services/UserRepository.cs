using CleanArchitecture.Application.Repository;
using CleanArchitecture.Domain.Entitis;
using CleanArchitecture.Persistence.DataDbContext;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Services
{


    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        public UserRepository(DataDbContext context) : base(context) { }


        public Task<User> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return dbContext.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }
    }
}
