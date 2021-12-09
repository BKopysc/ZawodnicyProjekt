using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repository
{
    public interface ICompetitionsRepository
    {
        Task UpdateAsync(Competition c);
        Task AddSync(Competition c);
        Task DelAsync(Competition c);
        Task<Competition> GetAsync(int id);
        Task<IEnumerable<Competition>> BrowseAllAsync();
    }
}
