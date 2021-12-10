using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repository;

namespace Zawodnicy.Infrastructure.Repositories
{
    public class CoachesRepository : ICoachesRepository
    {
        private AppDbContext _appDbContext;

        public CoachesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Coach> AddAsync(Coach c)
        {
            try
            {
                _appDbContext.Coach.Add(c);
                _appDbContext.SaveChanges();

                //Task.CompletedTask;
                return await Task.FromResult(_appDbContext.Coach.FirstOrDefault(x => x.Id == c.Id));
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
                return null;
            }
        }
        public async Task<IEnumerable<Coach>> BrowseAllAsync()
        {
            return await Task.FromResult(_appDbContext.Coach);
        }

        public async Task DelAsync(int id)
        {
            try
            {
                _appDbContext.Remove(_appDbContext.Coach.FirstOrDefault(x => x.Id == id));
                _appDbContext.SaveChanges();
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }
        }

        public async Task<Coach> GetAsync(int id)
        {
            try
            {
                return await Task.FromResult(_appDbContext.Coach.FirstOrDefault(x => x.Id == id));

            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
                return null;
            }
        }

        public async Task UpdateAsync(Coach c, int id)
        {

            try
            {
                var z = _appDbContext.Coach.FirstOrDefault(x => x.Id == id);

                z.Name = c.Name;
                z.Surname = c.Surname;
                //z.Id = c.Id;
                z.DateBirth = c.DateBirth;

                _appDbContext.SaveChanges();
                await Task.CompletedTask;
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            }

        }

    }
}
