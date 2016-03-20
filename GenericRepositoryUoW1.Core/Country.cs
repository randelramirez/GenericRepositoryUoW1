using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryUoW1.Core
{
    public class Country : Entity<int>
    {

        //[Required]
        //[MaxLength(100)]
        //[Display(Name = "Country Name")]
        public string Name { get; set; }

        public virtual IEnumerable<Person> Persons { get; set; }
    }
}
