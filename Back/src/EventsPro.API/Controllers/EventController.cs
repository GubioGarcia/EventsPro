using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EventsPro.API.Models;

namespace EventsPro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        public EventController()
        {
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return new Event[] {
                new Event () {
                    EventId = 1,
                    Tema = "Angular e .Net Core",
                    Local = "Goiânia",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvent = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "Foto.img"
                }
            };
        }
    }
}
