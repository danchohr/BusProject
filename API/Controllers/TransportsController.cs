using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransportsController : ControllerBase
    {
        private readonly BusContext _context;
        public TransportsController(BusContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Transport>>> GetTransports(){
            var transports = await _context.Transports.ToListAsync();
            return Ok(transports);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Transport>> GetTransport(int id){
            var transport = await _context.Transports.FindAsync(id);
            if(transport == null)
            {
                return NotFound();
            }
            return Ok(transport);
        }
    }
}