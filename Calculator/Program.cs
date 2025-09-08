static void Menu()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Executar:\n(1) Adição\n(2) Subtração\n(3) Divisão\n(4) Multiplicação\n(5) Sair");

        float operation = GetFloat();

        if (operation == 5) Environment.Exit(0);
        if (operation < 1 || operation > 5) continue;

        Console.Write("N1: ");
        float x1 = GetFloat();
        Console.Write("N2: ");
        float x2 = GetFloat();

        float res = operation switch
        {
            1 => Add(x1, x2),
            2 => Subtract(x1, x2),
            3 => Divide(x1, x2),
            4 => Multiply(x1, x2),
            _ => 0f
        };

        Console.WriteLine($"\nO resultado é {res}");
        Console.ReadKey();
    }
}

static float GetFloat()
{
    while (true)
    {
        if (float.TryParse(Console.ReadLine(), out float entry))
        {
            return entry;
        }
    }

}

static float Add(float n1, float n2)
{
    return n1 + n2;
}

static float Subtract(float n1, float n2)
{
    return n1 - n2;
}

static float Divide(float n1, float n2)
{
    if (n2 == 0)
    {
        Console.WriteLine("Erro: divisão por zero");
        return 0f;
    }
    return n1 / n2;
}

static float Multiply(float n1, float n2)
{
    return n1 * n2;
}

Menu();
