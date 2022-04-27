namespace CarrosFactoryMethod
{
    public class TeslaCarroSUV : Veiculo
    {
        public TeslaCarroSUV()
        {
            Modelo = "Tesla Model X";
            Categoria = "SUV";
            cor = "Azul";
            tipoPintura = "Perolado";
            Pecas.Add("Rodas de liga leve");
            Pecas.Add("Escapamento metálico");
            Pecas.Add("Inteligencia Artificial");
            Pecas.Add("Sensores de movimento");
            Pecas.Add("Cambio CVT");
            Pecas.Add("Injeção eletrônica");
        }
    }
}
