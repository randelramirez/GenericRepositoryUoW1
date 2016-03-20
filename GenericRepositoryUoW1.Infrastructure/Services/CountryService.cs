using GenericRepositoryUoW1.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositoryUoW1.Infrastructure.Services
{
    public class CountryService : EntityService<Country>, ICountryService
    {
        IUnitOfWork unitOfWork;
        ICountryRepository countryRepository;

        public CountryService(IUnitOfWork unitOfWork, ICountryRepository countryRepository)
            : base(unitOfWork, countryRepository)
        {
            this.unitOfWork = unitOfWork;
            this.countryRepository = countryRepository;
        }


        public Country GetById(int Id)
        {
            return this.countryRepository.GetById(Id);
        }
    }
}
