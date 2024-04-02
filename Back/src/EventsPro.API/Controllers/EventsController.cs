using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EventsPro.API.Models;
using EventsPro.API.Data;

namespace EventsPro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly DataContext _context;
        public EventsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events;
        }

        [HttpGet("{id}")]
        public Event GetById(int id)
        {
            return _context.Events.FirstOrDefault(evento => evento.EventId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo = {id}";
        }
    }
}
