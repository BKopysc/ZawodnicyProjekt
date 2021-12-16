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
    public class SkiJumperService : ISkiJumperService {

        private readonly ISkiJumpersRepository _skiJumpersRepository;

        private SkiJumperDTO MakeDTO(SkiJumper z)
        {
            SkiJumperDTO skiDTO = new SkiJumperDTO()
            {
                Id = z.Id,
                Name = z.Name,
                Surname = z.Surname,
                Country = z.Country,
                Height = z.Height,
                Weight = z.Weight,
                DateBirth = z.DateBirth
            };

            return skiDTO;
        }

        public SkiJumperService(ISkiJumpersRepository skiJumpersRepository)
        {
             _skiJumpersRepository = skiJumpersRepository;
        }

        public async Task<SkiJumperDTO> AddSkiJumper(CreateSkiJumper CSkiJumper)
        {
            SkiJumper sj = new SkiJumper()
            {
                Id = CSkiJumper.Id,
                Name = CSkiJumper.Name,
                Surname = CSkiJumper.Surname,
                Country = CSkiJumper.Country,
                Height = CSkiJumper.Height,
                Weight = CSkiJumper.Weight,
                DateBirth = CSkiJumper.DateBirth
            };

            var z = await _skiJumpersRepository.AddSync(sj);

            if (z == null)
            {
                return null;
            }

            Console.WriteLine(z.Id);
            return MakeDTO(z);

        }

        public async Task<IEnumerable<SkiJumperDTO>> BrowseAll()
        {
            var z = await _skiJumpersRepository.BrowseAllAsync();

            return z.Select(X => new SkiJumperDTO()
            {
                Id = X.Id,
                Name = X.Name,
                Surname = X.Surname,
                Country = X.Country,
                Height = X.Height,
                Weight = X.Weight,
                DateBirth = X.DateBirth
            });
        }

        public async Task<SkiJumperDTO> GetSkiJumper(int id)
        {
            var z = await _skiJumpersRepository.GetAsync(id);

            if(z == null)
            {
                return null;
            }
            return MakeDTO(z);

        }

        public async Task UpdateSkiJumper(UpdateSkiJumper USkiJumper, int id)
        {
            SkiJumper sj = new SkiJumper()
            {
                Id = USkiJumper.Id,
                Name = USkiJumper.Name,
                Surname = USkiJumper.Surname,
                Country = USkiJumper.Country,
                Height = USkiJumper.Height,
                Weight = USkiJumper.Weight,
                DateBirth = USkiJumper.DateBirth
            };

            await _skiJumpersRepository.UpdateAsync(sj, id);


        }

        public async Task DeleteSkiJumper(int id)
        {
            await _skiJumpersRepository.DelAsync(id);

        }

        public async Task<IEnumerable<SkiJumperDTO>> BrowseWithFilter(string name, string country)
        {
            var z = await _skiJumpersRepository.BrowseWithFilterAsync(name, country);

            if(z == null)
            {
                return null;
            }
            return z.Select(X => new SkiJumperDTO()
            {
                Id = X.Id,
                Name = X.Name,
                Surname = X.Surname,
                Country = X.Country,
                Height = X.Height,
                Weight = X.Weight,
                DateBirth = X.DateBirth
            });

        }
    }
}
