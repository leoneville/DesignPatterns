namespace FactoryMethod
{
    internal class NokiaFactory : CelularFactory
    {
        public override ICelular CriarCelular()
        {
            return new Nokia();
        }
    }
}
