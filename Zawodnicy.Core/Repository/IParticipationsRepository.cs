using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repository
{
    public interface IParticipationsRepository
    {
        Task UpdateAsync(Participation p);
        Task AddSync(Participation p);
        Task DelAsync(Participation p);
        Task<Participation> GetAsync(int id);
        Task<IEnumerable<Participation>> BrowseAllAsync();
    }
}
