using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repository;
using Zawodnicy.Infrastructure.Commands;
using Zawodnicy.Infrastructure.DTO;

namespace Zawodnicy.Infrastructure.Services
{
    public class CoachService : ICoachService
    {
        private readonly ICoachesRepository _coachesRepository;

        public CoachService(ICoachesRepository coachesRepository)
        {
            _coachesRepository = coachesRepository;
        }
        private CoachDTO MakeDTO(Coach z)
        {
            CoachDTO coachDTO = new CoachDTO()
            {
                Id = z.Id,
                Name = z.Name,
                Surname = z.Surname,
                DateBirth = z.DateBirth
            };

            return coachDTO;
        }
        public async Task<CoachDTO> AddCoach(CreateCoach c)
        {
            Coach cc = new Coach()
            {
                Id = c.Id,
                Name = c.Name,
                Surname = c.Surname,
                DateBirth = c.DateBirth
            };

            var z = await _coachesRepository.AddAsync(cc);
            
            if (z == null)
            {
                return null;
            }

            return MakeDTO(z);
        }

        public async Task<IEnumerable<CoachDTO>> BrowseAll()
        {
            var z = await _coachesRepository.BrowseAllAsync();
            
            return z.Select(X => new CoachDTO {
                Id = X.Id,
                Name = X.Name,
                Surname = X.Surname,
                DateBirth = X.DateBirth
            });


        }

        public async Task DeleteCoach(int id)
        {
            await _coachesRepository.DelAsync(id);
        }

        public async Task<CoachDTO> GetCoach(int id)
        {
            var z = await _coachesRepository.GetAsync(id);

            if (z == null)
            {
                return null;
            }
            return MakeDTO(z);
        }

        public async Task UpdateCoach(UpdateCoach c, int id)
        {
            Coach cc = new Coach()
            {
                Id = c.Id,
                Name = c.Name,
                Surname = c.Surname,
                DateBirth = c.DateBirth
            };

            await _coachesRepository.UpdateAsync(cc, id);
        }
    }
}
