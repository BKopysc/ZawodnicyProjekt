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

        /*
            new SkiJumper()
            {
                Id = 1,
                Name = "Martin",
                Surname = "Sommer",
                Country = "Germany",
                Height = 180,
                Weight = 70,
                DateBirth = new DateTime(1998, 10, 1)
            } 
        */
        public SkiJumpersRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;

        }
        public async Task AddSync(SkiJumper sj)
        {

            //int index = _skiJumpersMock.FindIndex(item => item.Id == sj.Id); //Zmienić na DateBase
            //if (index >= 0 || sj.Id < 0)
            //{
            //    return null;
            //}
            //else
            //{
            //    _skiJumpersMock.Add(sj);
            //    return await Task.FromResult(_skiJumpersMock.Find(x => x == sj));
            //}

            try
            {
                _appDbContext.SkiJumper.Add(sj);
                _appDbContext.SaveChanges();
                await Task.CompletedTask;
                return await Task.FromResult(_appDbContext.SkiJumper.FirstOrDefault(x => x.Id == sj.Id));
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
                return null;
            } //Mozna nic nie zwracać
        }

        public async Task<IEnumerable<SkiJumper>> BrowseAllAsync()
        {
            return await Task.FromResult(_appDbContext.SkiJumper);
        }

        public async Task<IEnumerable<SkiJumper>> BrowseWithFilterAsync(string name, string country)
        {
            throw new NotImplementedException();
            //List<SkiJumper> filteredList = new List<SkiJumper>();
            //foreach (SkiJumper skiJumper in _skiJumpersMock)
            //{
            //    if(skiJumper.Name == name && skiJumper.Country == country)
            //    {
            //        filteredList.Add(skiJumper);
            //    }
            //}
            //if(filteredList.Count > 0)
            //{
            //    return await Task.FromResult(filteredList);
            //}

            //return null;

            // var s = _skiJumperMock.Where(x=> x.Country.Contains(country) || x.Name.Contains(name)).AsEnumerable();
        }

        public async Task<bool> DelAsync(int id)
        {
            try
            {
                _appDbContext.Remove(_appDbContext.SkiJumper.FirstOrDefault(x => x.Id == id));
                _appDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
                return false;
            } //Mozna nic nie zwracać

            //int index = _skiJumpersMock.FindIndex(item => item.Id == id);
            //if (index >= 0)
            //{
            //    _skiJumpersMock.RemoveAt(index);
            //    return await Task.FromResult(true);
            //}
            //else
            //{
            //    return false;
            //}
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
            //int index = _skiJumpersMock.FindIndex(item => item.Id == id);
            //if (index >= 0)
            //{
            //    return await Task.FromResult(_skiJumpersMock.FirstOrDefault(x => x.Id == id));
            //}
            //else
            //{
            //    return null;
            //}
        }

        public async Task<SkiJumper> UpdateAsync(SkiJumper sj, int id)
        {

            try {
                var z = _appDbContext.SkiJumper.FirstOrDefault(x => x.Id == sj.Id);

                z.Name = sj.Name;
                z.Surname = sj.Name;
                z.Id = sj.Id;
                z.Height = sj.Height;
                z.Weight = sj.Weight;
                z.Country = sj.Country;
                z.DateBirth = sj.DateBirth;

                _appDbContext.SaveChanges();

                return await Task.FromResult(_appDbContext.SkiJumper.FirstOrDefault(x => x.Id == sj.Id));
            }
            catch (Exception ex)
            {
                await Task.FromException(ex);
                return null;
            } //Mozna nic nie zwracać

            //int index = _skiJumpersMock.FindIndex(item => item.Id == id);
            //if(index >= 0)
            //{
            //    _skiJumpersMock[index] = sj;
            //    return await Task.FromResult(_skiJumpersMock.Find(x => x == sj));
            //}

            //return null;
        }

    }
}
