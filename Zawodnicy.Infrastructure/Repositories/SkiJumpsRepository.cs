using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repository;

namespace Zawodnicy.Infrastructure.Repositories
{
    class SkiJumpsRepository : ISkiJumpsRepository
    {
        public Task AddSync(SkiJump s)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SkiJump>> BrowseAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task DelAsync(SkiJump s)
        {
            throw new NotImplementedException();
        }

        public Task<SkiJump> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SkiJump s)
        {
            throw new NotImplementedException();
        }
    }
}
