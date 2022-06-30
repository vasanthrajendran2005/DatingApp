using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
   [ Route("api/[Controller]")]
    public class Users : ControllerBase
    {
        private readonly DataContext _context;

        public Users(DataContext context)
        {
           _context = context;
        }

        [HttpGet]
        public async Task<List<AppUser>> GetUsers()
        {
          return await _context.Users.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>>  GetUsers(int id)
        {
          return  await _context.Users.FindAsync(id);
        }
    }
}