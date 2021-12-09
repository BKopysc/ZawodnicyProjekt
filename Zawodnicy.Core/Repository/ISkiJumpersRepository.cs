using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;

namespace Zawodnicy.Core.Repository
{
    public interface ISkiJumpersRepository
    {
        Task UpdateAsync(SkiJumper sj, int id);
        Task<SkiJumper> AddSync (SkiJumper sj);
        Task DelAsync(int id);
        Task<SkiJumper> GetAsync(int id);
        Task<IEnumerable<SkiJumper>> BrowseAllAsync();

        Task<IEnumerable<SkiJumper>> BrowseWithFilterAsync(string name, string country);
    }
}
