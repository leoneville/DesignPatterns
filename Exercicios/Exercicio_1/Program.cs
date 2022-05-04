using System;

namespace Exercicio_1
{
    // 1 - Qual o padrão de projeto foi usado na implmentação do Logger? R: Padrão Factory (Simple Factory)
    // 2 - Qual o problema que essa implementação pode causar?
    //      R: O problema é que para cada objeto cliente criado será criado uma nova instância da classe 
    //      Logger que deverá escrever no mesmo arquivo. Podemos ter assim muitos objetos na memória e
    //      também conflitos na escrita da mensagem no arquivo.
    // 3 - Refaça a implementação da classe Logger usando o padrão Singleton.
    // 4 - Justifique porque o padrão Singleton seria mais indicado?
    //      R: A implementação do Logger usando o padrão Singleton permite criar apenas uma única instância
    //      da classe Logger e assim além de termos apenas um objeto na memória, não temos que nos preocupar
    //      em ter vários objetos tentando escrever em um único arquivo.
    // 5 - Existe outra alternativa ao padrão Singleton para implementar o Logger? Qual?
    // Comente se ela seria melhor ou pior que o Singleton. 
    //      R: Sim, existe. A opção mais pertinente ao caso seria usar uma classe Global ou estática.
    //      Esta opção geralmente leva a práticas de programação ruins. Depois de um tempo, essas classes
    //      tendem a conter muitas informações e objetos não relacionados.
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Maria");
            cliente1.AtualizaEndereco("Rua Equador, 44", "Santos");
        }
    }
}
