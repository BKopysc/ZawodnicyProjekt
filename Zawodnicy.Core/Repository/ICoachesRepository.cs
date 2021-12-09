using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repository
{
    public interface ICoachesRepository
    {
        Task UpdateAsync(Coach c);
        Task<Coach> AddAsync(Coach c);
        Task DelAsync(Coach c);
        Task<Coach> GetAsync(int id);
        Task<IEnumerable<Coach>> BrowseAllAsync();
    }
}
