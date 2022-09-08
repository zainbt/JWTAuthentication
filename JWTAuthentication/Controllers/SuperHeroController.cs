using JWTAuthentication.Database;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace TestAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;
        public SuperHeroController(DataContext context)
        {
            _context = context;
        }



        [HttpGet("GetAllHeroes")]
        public async Task<ActionResult<List<Superhero>>> Get()
        {
            return Ok(await _context.Superheroes.ToListAsync());
        }

        [HttpPost("AddNewHero")]
        public async Task<ActionResult<List<Superhero>>> AddHero(Superhero hero)
        {
            _context.Superheroes.Add(hero);
            await _context.SaveChangesAsync();

            return Ok(await _context.Superheroes.ToListAsync());
        }

        [HttpGet("FindHeroById")]
        //[Route("FindHero")]
        public async Task<ActionResult<Superhero>> FindHero(int id)
        {
            var hero = await _context.Superheroes.FindAsync(id);
            if (hero == null)
            {
                return BadRequest("Hero not found");
            }
            return Ok(hero);
        }

        [HttpPut("UpdateHeroInfo")]
        public async Task<ActionResult<List<Superhero>>> UpdateHero(Superhero request)
        {
            var hero = await _context.Superheroes.FindAsync(request.id);
            if (hero == null)
            {
                return BadRequest("Hero not found");
            }

            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;

            await _context.SaveChangesAsync();

            return Ok(await _context.Superheroes.ToListAsync());
        }

        [HttpDelete("DeleteHero")]
        public async Task<ActionResult<List<Superhero>>> DestroyHero(int id)
        {
            var hero = await _context.Superheroes.FindAsync(id);
            if (hero == null)
            {
                return BadRequest("Hero not found");
            }
            _context.Superheroes.Remove(hero);
            await _context.SaveChangesAsync();
            return Ok(await _context.Superheroes.ToListAsync());
        }
    }
}
