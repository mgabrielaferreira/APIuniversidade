using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiUniversidade2.Model
{
     public class Curso
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Area { get; set; }
    public int Duracao { get; set; }
    public List<Disciplina> disciplinas;
    public List<Aluno> alunos;

    public Curso()
    {
       disciplinas = new List<Disciplina> ();
       alunos = new List<Aluno> ();
    }

    
}






}