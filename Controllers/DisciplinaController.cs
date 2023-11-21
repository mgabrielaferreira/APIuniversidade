using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiUniversidade.Model;
using ApiUniversidade.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiUniversidade.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class DisciplinaController : ControllerBase
    {
        private readonly Ilogger<DisciplinaController> _logger;

        private readonly ApiUniversidadeContext _context;

        public DisciplinaController(Ilogger<DisciplinaController> logger, ApiUniversidadeContext context)
        {
                _logger = logger;
                _context = context;
        }

        [HttpGet]
       public ActionResult<IEnurable<Disciplina>> Get()
        {
                var disciplinas = context.Disciplinas.ToList();
                if(disciplinas is null)
                return NotFound();

                return disciplinas;
        
        }

        [HttpGet ("(id:int)", Name="GetDisciplina")]
        public ActionResult<Disciplina> Get(int id)
        {
            var disciplina = _context.Disciplinas.FirstOrDefault(p => p.Id == id);
                if(disciplina is null)
                    return NotFound("Discilpina não encontrada.");

                return disciplina;
        }
        
        [HttpPost]
        public ActionResult Post(Discplina disciplina){
                _context.Disciplinas.Add(disciplina);
                _context.SaveChanges();

                return new CreatedAtRouteResult("GetDisciplina",
                    new{ id = disciplina.Id},
                    disciplina);
        }

        [HttpPut("(id:int)")]
        public ActionResult Put(int id, Discilpina disciplina){
            if(id != disciplina.Id)
                return BadRequest();

            _context.Entry(disciplina).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(disciplina);
        }

        [HttpDelete("(id:int)")]
        public ActionResult Delete(int id){
            var disciplina = _context.Disciplinas.FirstOrDefault(p=> p.Id == id);

            if(disciplina is null)
                return NotFound();

            _context.Disciplinas.Remove(disciplina);
            _context.SaveChanges();

            return Ok(disciplina);
        }
        



    }

