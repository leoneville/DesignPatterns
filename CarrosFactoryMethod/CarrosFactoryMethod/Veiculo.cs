using System.Collections;
using System.Text;

namespace CarrosFactoryMethod
{
    public abstract class Veiculo
    {
        protected string Modelo { get; set; }
        protected string Categoria { get; set; }
        protected string cor;
        protected string tipoPintura;
        protected ArrayList Pecas = new ArrayList();

        public string Fabricar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Fabricando modelo {Modelo} na categoria {Categoria}\n");
            sb.Append($"Fabricando as peças do veículo:\n");

            foreach (var peca in Pecas)
                sb.Append($"\t{peca}\n");

            sb.Append($"Pintando as peças de {cor} {tipoPintura}\n");
            sb.Append(Montagem());
            sb.Append(Teste());
            sb.Append(Transporte());

            return sb.ToString();
        }

        protected virtual string Montagem()
        {
            return "Realizando montagem do veículo.\n";
        }
        protected virtual string Teste()
        {
            return "Realizando testes do veículo.\n";
        }
        protected virtual string Transporte()
        {
            return "O veículo está sendo transportado até a concessionária.\n";
        }
    }
}
