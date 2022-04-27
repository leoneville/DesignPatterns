namespace CarrosFactoryMethod
{
    public class TeslaCarroEsportivo : Veiculo
    {
        public TeslaCarroEsportivo()
        {
            Modelo = "Tesla Model S";
            Categoria = "Esportivo";
            cor = "Vermelho";
            tipoPintura = "Fosco";
            Pecas.Add("Bateria de 103,9 kWh");
            Pecas.Add("Partida Elétrica (Start-Stop)");
            Pecas.Add("Piloto Automático");
            Pecas.Add("Freio a Disco");
            Pecas.Add("Escapamento Duplo");
            Pecas.Add("Computador de bordo");
        }
    }
}
