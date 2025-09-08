static void Menu()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("[x]s para contar x segundos.\n[x]m para contar x minutos.\n'q' para sair.");

        string data = Console.ReadLine().ToLower();

        if (data == "q") Environment.Exit(0);

        if (string.IsNullOrEmpty(data) || data.Length < 2)
        {
            Console.WriteLine("Entrada inválida.");
            Console.ReadKey();
            continue;
        }

        char type = data[^1];
        if (type != 's' && type != 'm')
        {
            Console.WriteLine("Unidade de tempo inválida.");
            Console.ReadKey();
            continue;
        }

        if (!int.TryParse(data.Substring(0, data.Length - 1), out int time))
        {
            Console.WriteLine("Tempo inválido.");
            Console.ReadKey();
            continue;
        }

        int multiplier = type switch
        {
            'm' => 60,
            _ => 1
        };

        Start(time * multiplier);
    }
}

static void Start(int time)
{
    int currentTime = 0;

    while (currentTime != time)
    {
        Console.Clear();
        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
        currentTime++;
    }

    Console.Clear();
    Console.WriteLine(currentTime);
    Console.WriteLine("Stopwatch finalizado");
    Console.ReadKey();
}

Menu();
