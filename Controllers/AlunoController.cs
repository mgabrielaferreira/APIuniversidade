
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
    public class AlunoController : ControllerBase
    {
        
   [HttpGet (Name = "alunos")]

    public List<Aluno> GetAluno()
    {
        List<Aluno> alunos = new List<Aluno>();

        Aluno a1 = new Aluno();
            a1.Id= 20201031;
            a1.Nome= "Morgana";
            a1.Area= "Informatica";
            a1.DataDeNascimento= "8/8/1989";
            a1.CPF= "99999";
        Aluno a2 = new Aluno();
            a2.Id= 20201031;
            a2.Nome= "Morgana";
            a2.Area= "Informatica";
            a2.DataDeNascimento= "8/8/1989";
            a2.CPF= "99999";
        Aluno a3 = new Aluno();
            a3.Id= 20201031;
            a3.Nome= "Morgana";
            a3.Area= "Informatica";
            a3.DataDeNascimento= "8/8/1989";
            a3.CPF= "99999";


            alunos.Add(a1);
            alunos.Add(a2);
            alunos.Add(a3);

            return alunos;

    }



 
    
}}
   
