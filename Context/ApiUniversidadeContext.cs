using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiUniversidade2.Model;
using Microsoft.EntityFrameworkCore;

namespace apiUniversidade2.Contex
{
    public class ApiUniversidadeContex: DbContext
    {

        public ApiUniversidadeContex(DbContextOptions options) : base(options) {}
        public DbSet<Aluno> Alunos {get; set; }

        public DbSet<Curso> Cursos {get; set; }

        public DbSet<Disciplina> Disciplinas {get; set; }





        



    }
}