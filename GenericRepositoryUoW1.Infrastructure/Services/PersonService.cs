using GenericRepositoryUoW1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryUoW1.Infrastructure.Services
{
    public class PersonService : EntityService<Person>, IPersonService
    {
        IUnitOfWork unitOfWork;
        IPersonRepository personRepository;

        public PersonService(IUnitOfWork unitOfWork, IPersonRepository personRepository)
            : base(unitOfWork, personRepository)
        {
            this.unitOfWork = unitOfWork;
            this.personRepository = personRepository;
        }


        public Person GetById(long Id)
        {
            return personRepository.GetById(Id);
        }
    }
}
