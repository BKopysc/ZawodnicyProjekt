using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repository;

namespace Zawodnicy.Infrastructure.Repositories
{
    class CitiesRepository : ICitiesRepository
    {
        public Task AddSync(City c)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<City>> BrowseAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task DelAsync(City c)
        {
            throw new NotImplementedException();
        }

        public Task<City> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(City c)
        {
            throw new NotImplementedException();
        }
    }
}
