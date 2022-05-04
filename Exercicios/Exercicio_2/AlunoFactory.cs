using System;

namespace Exercicio_2
{
    public abstract class AlunoFactory
    {
        public abstract IAluno GetAluno(string alunoDepartamento);
        public static AlunoFactory CreateAlunoFactory(string alunoUniversidade)
        {
            return alunoUniversidade switch
            {
                "UNIV1" => new Univ1Factory(),
                "UNIV2" => new Univ2Factory(),
                _ => throw new ArgumentException("Universidade indisponível!")
            };
        }
    }
}
