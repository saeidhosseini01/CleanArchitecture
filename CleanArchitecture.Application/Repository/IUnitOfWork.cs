using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Repository
{


    public interface IUnitOfWork
    {
        Task SaveChange(CancellationToken cancellationToken );
    }
}
