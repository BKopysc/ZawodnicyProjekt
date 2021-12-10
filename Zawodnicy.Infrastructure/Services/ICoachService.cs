using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Infrastructure.Commands;
using Zawodnicy.Infrastructure.DTO;

namespace Zawodnicy.Infrastructure.Services
{
    public interface ICoachService
    {
        Task UpdateCoach(UpdateCoach c, int id);
        Task<CoachDTO> AddCoach(CreateCoach c);
        Task DeleteCoach(int id);
        Task<CoachDTO> GetCoach(int id);
        Task<IEnumerable<CoachDTO>> BrowseAll();
    }
}
