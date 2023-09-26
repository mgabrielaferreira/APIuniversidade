using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiUniversidade2.Model;
using Microsoft.AspNetCore.Mvc;

namespace apiUniversidade2.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class CursoController : ControllerBase
    {
        private readonly Ilogger<CursoController> _logger;

        private readonly apiUniversidadeContext _context;

        public CursoController(Ilogger<CursoController> logger, ApiUniversidadeContext context)
        {
                _logger = logger;
                _context = context;
        }

      {HttpGet}
       public ActionResult<IEnurable<Curso>> Get()
        {
                var cursos = context.Cursos.ToList();
                if(cursos is null)
                return NotFound();

                return cursos;
        
        }


        
    }

