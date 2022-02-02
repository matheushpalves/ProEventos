using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.Api.Models;

namespace Proeventos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {

            new Evento(){
                EventoId = 1,
                Tema     = "Teste",
                Local    = "Muriae",
                Lote     = "1º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "FOTO.PNG"
            },

            new Evento(){
                EventoId = 2,
                Tema     = "Teste2",
                Local    = "Muriae",
                Lote     = "2º Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy"),
                ImagemUrl = "FOTO.PNG"
    
            }
        };

        public EventoController()
        {          
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetbyId(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }


        [HttpPost]
        public String Post()
        {
            return "Exemplo de Post";
        }



}

}