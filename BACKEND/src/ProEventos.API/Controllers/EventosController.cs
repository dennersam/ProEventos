using System;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using System.Collections.Generic;
using System.Linq;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;
        public EventosController(DataContext context)
        {
            _context = context;
        }

        /*         private IEnumerable<Evento> _evento = new Evento[]{
                    new Evento(){
                        EventoId = 1,
                        Tema = "Angular 11 e .NET 5",
                        Local = "Belo Horizonte",
                        Lote = "Lote 1",
                        QtdPessoas = 250,
                        DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                        ImagemURL = "foto.img"
                    },
                    new Evento(){
                        EventoId = 2,
                        Tema = "Angular Updates",
                        Local = "Rio de Janeiro",
                        Lote = "Lote 2",
                        QtdPessoas = 350,
                        DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                        ImagemURL = "foto2.img"
                    }
                }; */

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(
                evento => evento.EventoId == id
            );
        }

        [HttpPost]
        public string Post()
        {
            return "Post test!!!";
        }
    }
}
