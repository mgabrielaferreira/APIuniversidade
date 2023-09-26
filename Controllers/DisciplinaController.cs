using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiUniversidade2.Model;
using Microsoft.AspNetCore.Mvc;

namespace apiUniversidade2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplinaController : ControllerBase
    {
        
   [HttpGet (Name = "disciplinas")]

    public List<Disciplina> GetDisciplina()
    {
        List<Disciplina> diciplinas = new List<Disciplina>();

        Disciplina d1 = new Disciplina();
            d1.Nome= "Banco de dados";
            d1.CargaHoraria= 60;
            d1.Semestre= 4;
        Disciplina d2 = new Disciplina();
            d2.Nome= "Biologia";
            d2.CargaHoraria= 80;
            d2.Semestre= 3;
        Disciplina d3 = new Disciplina();
            d3.Nome= "Sociologia";
            d3.CargaHoraria= 90;
            d3.Semestre= 2;


            diciplinas.Add(d1);
            diciplinas.Add(d2);
            diciplinas.Add(d3);

            return diciplinas;

    }



 
    
}}

