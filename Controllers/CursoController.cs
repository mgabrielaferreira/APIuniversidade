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
      
        [HttpGet (Name = "cursos")]
        public  Curso GetCursos()
        {

        List<Disciplina> disciplinas = new List<Disciplina>();

        disciplinas.Add(new Disciplina {
                Nome= "Banco de dados",
                CargaHoraria= 60,
                Semestre= 4,
        });

        disciplinas.Add(new Disciplina{
                Nome= "Banco de dados",
                CargaHoraria= 60,
                Semestre= 4,
        });

        disciplinas.Add(new Disciplina {
                Nome= "Banco de dados",
                CargaHoraria= 60,
                Semestre= 4, 
        });

        List<Aluno> alunos = new List<Aluno>();
        alunos.Add(new Aluno {
                Id= 20201031,
                Nome= "Morgana",
                Area= "Informatica",
                DataDeNascimento= "8/8/1989",
                CPF= "99999",




        });


        Curso c = new Curso{
                Nome= "Programação para internet",
                Area= "TI",
                Duracao= 4,
                disciplinas= disciplinas,
        };

        


         return c;
    }
}
