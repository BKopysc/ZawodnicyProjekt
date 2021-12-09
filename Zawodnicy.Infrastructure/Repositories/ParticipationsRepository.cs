using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repository;

namespace Zawodnicy.Infrastructure.Repositories
{
    class ParticipationsRepository : IParticipationsRepository
    {
        public Task AddSync(Participation p)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Participation>> BrowseAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task DelAsync(Participation p)
        {
            throw new NotImplementedException();
        }

        public Task<Participation> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Participation p)
        {
            throw new NotImplementedException();
        }
    }
}
