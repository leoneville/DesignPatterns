namespace CarrosFactoryMethod
{
    public abstract class CarroFactoryMethod
    {
        public Veiculo MontaVeiculo(string categoria)
        {
            Veiculo veiculo = CriarVeiculo(categoria);
            return veiculo;
        }

        protected abstract Veiculo CriarVeiculo(string categoria);
    }
}
