static void Menu()
{
    Console.Clear();

    Console.WriteLine("Executar:\n(1) Adição\n(2) Subtração\n(3) Divisão\n(4) Multiplicação\n(5) Sair");
    short operation = short.Parse(Console.ReadLine());

    switch (operation)
    {
        case 1: break;
        case 2: break;
        case 3: break;
        case 4: break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }

    Console.Write("N1: ");
    float x1 = float.Parse(Console.ReadLine());
    Console.Write("N2: ");
    float x2 = float.Parse(Console.ReadLine());

    float res = 0f;

    switch (operation)
    {
        case 1: res = Add(x1, x2); break;
        case 2: res = Subtract(x1, x2); break;
        case 3: res = Divide(x1, x2); break;
        case 4: res = Multiply(x1, x2); break;
    }

    Console.WriteLine($"\nO resultado é {res}");
    Console.ReadKey();
    Menu();
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
    return n1 / n2;
}

static float Multiply(float n1, float n2)
{
    return n1 * n2;
}

Menu();
