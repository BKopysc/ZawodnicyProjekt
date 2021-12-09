using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repository
{
    public interface ICitiesRepository
    {
        Task UpdateAsync(City c);
        Task AddSync(City c);
        Task DelAsync(City c);
        Task<City> GetAsync(int id);
        Task<IEnumerable<City>> BrowseAllAsync();
    }
}
