using System;

namespace Builder_Computer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancia do Director
            Fabricante fabricante = new Fabricante();

            //Instancia do Concrete Builder
            NotebookBuilder notebookBuilder = new NotebookBuilder();
            DesktopBuilder desktopBuilder = new DesktopBuilder();

            //Cria objetos conforme o builder
            fabricante.Build(notebookBuilder);
            fabricante.Build(desktopBuilder);
        }
    }
}
