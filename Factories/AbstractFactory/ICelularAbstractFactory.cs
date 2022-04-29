namespace AbstractFactory
{
    interface ICelularAbstractFactory
    {
        ICelularNokia CriarCelularNokia();
        ICelularApple CriarCelularApple();
    }
}
