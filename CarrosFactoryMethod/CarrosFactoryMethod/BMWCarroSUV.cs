namespace CarrosFactoryMethod
{
    public class BMWCarroSUV : Veiculo
    {
        public BMWCarroSUV()
        {
            Modelo = "BMW X5";
            Categoria = "SUV";
            cor = "Cinza";
            tipoPintura = "Metalico";
            Pecas.Add("Rodas de fibra de carbono");
            Pecas.Add("Escapamento metálico");
            Pecas.Add("Cambio CVT");
            Pecas.Add("Acentos revestidos em couro");
            Pecas.Add("Injeção eletrônica");
        }
    }
}
