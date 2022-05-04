using System.Collections.Generic;

namespace Exercicio_2
{
    public class Univ1Quimica : IAluno
    {
        public List<string> Cursos()
        {
            return new List<string> { "Química Orgânica", "Química Analítica", "Química Inorgânica" };
        }
    }
}
