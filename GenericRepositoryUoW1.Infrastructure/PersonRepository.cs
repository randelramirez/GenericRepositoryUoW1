using GenericRepositoryUoW1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace GenericRepositoryUoW1.Infrastructure
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext context)
            : base(context)
        {

        }

        public override IEnumerable<Person> GetAll()
        {
            return this.entities.Set<Person>().Include(x => x.Country).AsEnumerable();
        }

        public Person GetById(long id)
        {
            return this.dbset.Include(x => x.Country).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
