using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIChallenge.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIChallenge.Controllers
{
    [Route("api/Player")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerContext _context;

        public PlayerController(PlayerContext context)
        {
            _context = context;

            if (_context.Players.Count() == 0)
            {
                _context.Players.Add(new Player{ ID = 1, FirstName = "Collin", LastName = "Handel"});
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            return await _context.Players.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var player = await _context.Players.FindAsync(id);

            if (player == null)
            {
                return NotFound();
            }

            return player;
        }

        [HttpPost]
        public async Task<ActionResult<Player>> AddPlayer(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPlayer), new {id = player.ID}, player);
        }
    }
}
