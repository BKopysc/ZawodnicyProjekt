using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repository
{
    public interface ICoachesRepository
    {
        Task UpdateAsync(Coach c, int id);
        Task<Coach> AddAsync(Coach c);
        Task DelAsync(int id);
        Task<Coach> GetAsync(int id);
        Task<IEnumerable<Coach>> BrowseAllAsync();
    }
}
