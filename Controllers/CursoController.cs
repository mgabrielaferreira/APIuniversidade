using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiUniversidade2.Model;
using ApiUniversidade.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiUniversidade2.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly Ilogger<CursoController> _logger;

        private readonly ApiUniversidadeContext _context;

        public CursoController(Ilogger<CursoController> logger, ApiUniversidadeContext context)
        {
                _logger = logger;
                _context = context;
        }

        [HttpGet]
       public ActionResult<IEnurable<Curso>> Get()
        {
                var cursos = context.Cursos.ToList();
                if(cursos is null)
                return NotFound();

                return cursos;
        
        }

        [HttpGet ("(id:int)", Name="GetCurso")]
        public ActionResult<Curso> Get(int id)
        {
            var curso = _context.Cursos.FirstOrDefault(p => p.Id == id);
                if(curso is null)
                    return NotFound("Curso não encontrado.");

                return curso;
        }
        
        [HttpPost]
        public ActionResult Post(Curso curso){
                _context.Cursos.Add(curso);
                _context.SaveChanges();

                return new CreatedAtRouteResult("GetCurso",
                    new{ id = curso.Id},
                    curso);
        }

    }

