using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zawodnicy.Infrastructure.Commands;
using Zawodnicy.Infrastructure.DTO;
using Zawodnicy.Infrastructure.Services;

namespace Zawodnicy.WebAPI.Controllers
{
    //[Authorize]
    [Route("[Controller]")]

    public class CoachController : Controller
    {
        private readonly ICoachService _coachService;

        public CoachController(ICoachService coachService)
        {
            _coachService = coachService;
        }

        [HttpGet]
        public async Task<IActionResult> BrowseAll()
        {
            Console.WriteLine("BrowseAllCoaches");
            IEnumerable<CoachDTO> z = await _coachService.BrowseAll();
            return Json(z);
        }

        //https://localhost:5001/coach/{id}

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCoach(int id)
        {
            Console.WriteLine($"get: {id}");
            CoachDTO z = await _coachService.GetCoach(id);
            return Json(z);
        }

        [HttpPost]
        public async Task<IActionResult> AddCoach([FromBody] CreateCoach coach)
        {
            Console.WriteLine($"Post: id - {coach.Id}");
            CoachDTO z = await _coachService.AddCoach(coach);
            return Json(z);
        }

        [HttpPut("{id}")]
        public async Task UpdateCoach([FromBody] UpdateCoach coach, int id)
        {
            Console.WriteLine($"Put: id {id}");
            await _coachService.UpdateCoach(coach, id);
            //return Json(z);
        }

        [HttpDelete("{id}")]
        public async Task DeleteCoach(int id)
        {
            Console.WriteLine($"Delete: id {id}");
            await _coachService.DeleteCoach(id);
            //return Json(z);
        }
    }
}
