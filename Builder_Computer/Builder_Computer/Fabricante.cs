namespace Builder_Computer
{
    //Director
    class Fabricante
    {
        public void Build(ComputadorBuilder computadorBuilder)
        {
            computadorBuilder.BuildDispositivos();
            computadorBuilder.BuildSO();
        }
    }
}
