using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Infrastructure.Commands;
using Zawodnicy.Infrastructure.DTO;

namespace Zawodnicy.Infrastructure.Services
{
    public interface ISkiJumperService
    {
        Task<IEnumerable<SkiJumperDTO>> BrowseAll();

        Task<SkiJumperDTO> GetSkiJumper(int id);

        Task<SkiJumperDTO> AddSkiJumper(CreateSkiJumper skiJumper);

        Task<SkiJumperDTO> UpdateSkiJumper(UpdateSkiJumper skiJumper, int id);

        Task<bool> DeleteSkiJumper(int id);

        Task<IEnumerable<SkiJumperDTO>> BrowseWithFilter(string name, string country);
    }
}
