using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repository;

namespace Zawodnicy.Infrastructure.Repositories
{
    class CompetitionsRepository : ICompetitionsRepository
    {
        public Task AddSync(Competition c)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Competition>> BrowseAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task DelAsync(Competition c)
        {
            throw new NotImplementedException();
        }

        public Task<Competition> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Competition c)
        {
            throw new NotImplementedException();
        }
    }
}
