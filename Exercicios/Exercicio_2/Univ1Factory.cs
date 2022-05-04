namespace Exercicio_2
{
    public class Univ1Factory : AlunoFactory
    {
        public override IAluno GetAluno(string alunoDepartamento)
        {
            return alunoDepartamento switch
            {
                "FISICA" => new Univ1Fisica(),
                "QUIMICA" => new Univ1Quimica(),
                _ => null
            };
        }
    }
}
