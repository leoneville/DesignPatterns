namespace Exercicio_4
{
    public abstract class CriadorLanche
    {
        protected Lanche lanche;

        public Lanche Lanche
        {
            get { return lanche; }
        }

        public abstract void AddPao();
        public abstract void AddRecheio();
        public abstract void AddVegetais();
        public abstract void AddCondimentos();
    }
}
