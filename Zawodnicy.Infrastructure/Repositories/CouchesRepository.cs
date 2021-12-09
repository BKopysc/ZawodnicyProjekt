using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repository;

namespace Zawodnicy.Infrastructure.Repositories
{
    class CouchesRepository : ICoachesRepository
    {
        public Task AddAsync(Coach c)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Coach>> BrowseAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task DelAsync(Coach c)
        {
            throw new NotImplementedException();
        }

        public Task<Coach> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Coach c)
        {
            throw new NotImplementedException();
        }
    }
}
