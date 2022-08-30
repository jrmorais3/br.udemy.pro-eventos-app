using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proeventos.api.Models;

namespace proeventos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Net core 5",
                Local = "Fortaleza",
                Lote = "1º lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Today.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "net-core.png"
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular 11",
                Local = "São Paulo",
                Lote = "1º lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Today.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "angular.png"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("id")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(x => x.EventoId.Equals(id));
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("id")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("id")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }

    }
}