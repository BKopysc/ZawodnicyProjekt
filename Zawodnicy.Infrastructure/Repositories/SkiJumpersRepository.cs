using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zawodnicy.Core.Domain;
using Zawodnicy.Core.Repository;
using Zawodnicy.Infrastructure.Commands;
using Microsoft.EntityFrameworkCore;

namespace Zawodnicy.Infrastructure.Repositories
{
    public class SkiJumpersRepository : ISkiJumpersRepository
    {
        private AppDbContext _appDbContext;

        public SkiJumpersRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public async Task<SkiJumper> AddSync(SkiJumper sj)
        {

            try
            {
                _appDbContext.SkiJumper.Add(sj);
                _appDbContext.SaveChanges();

                Console.WriteLine(sj.Id);

                //Task.CompletedTask;
                return await Task.FromResult(_appDbContext.SkiJumper.FirstOrDefault(x => x.Id == sj.Id));
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
                return null;
            }
        }

        public async Task<IEnumerable<SkiJumper>> BrowseAllAsync()
        {
            return await Task.FromResult(_appDbContext.SkiJumper);
        }

        public async Task<IEnumerable<SkiJumper>> BrowseWithFilterAsync(string name, string country)
        {
            var s = _appDbContext.SkiJumper.Where(x => x.Name == name || x.Country == country).AsEnumerable();
            return await Task.FromResult(s);
        }

        public async Task DelAsync(int id)
        {
            try
            {
                _appDbContext.Remove(_appDbContext.SkiJumper.FirstOrDefault(x => x.Id == id));
                _appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            } 
        }

        public async Task<SkiJumper> GetAsync(int id)
        {
            try
            {
                return await Task.FromResult(_appDbContext.SkiJumper.FirstOrDefault(x => x.Id == id));

            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
                return null;
            }
        }

        public async Task UpdateAsync(SkiJumper sj, int id)
        {

            try {
                var z = _appDbContext.SkiJumper.FirstOrDefault(x => x.Id == sj.Id);

                z.Name = sj.Name;
                z.Surname = sj.Surname;
                z.Id = sj.Id;
                z.Height = sj.Height;
                z.Weight = sj.Weight;
                z.Country = sj.Country;
                z.DateBirth = sj.DateBirth;

                _appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
            } 

        }

    }
}
