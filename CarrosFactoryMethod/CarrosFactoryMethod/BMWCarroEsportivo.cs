namespace CarrosFactoryMethod
{
    public class BMWCarroEsportivo : Veiculo
    {
        public BMWCarroEsportivo()
        {
            Modelo = "BMW Z4";
            Categoria = "Esportivo";
            cor = "Branco";
            tipoPintura = "Geada";
            Pecas.Add("Rodas de liga leve");
            Pecas.Add("Escapamento duplo");
            Pecas.Add("Partida Start-Stop");
            Pecas.Add("Suspensão tecnologica");
            Pecas.Add("Injeção eletrônica");
        }
    }
}
