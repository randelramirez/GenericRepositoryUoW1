using GenericRepositoryUoW1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryUoW1.Infrastructure.Services
{
    public interface IPersonService : IEntityService<Person>
    {
        Person GetById(long Id);
    }
}
