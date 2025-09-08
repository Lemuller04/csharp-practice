static void Menu()
{
    Console.Clear();
    Console.WriteLine("[x]s para contar x segundos.\n[x]m para contar x minutos.\n'q' para sair.");

    string data = Console.ReadLine().ToLower();

    if (data == "q") Environment.Exit(0);

    char type = char.Parse(data.Substring(data.Length - 1, 1));
    int time = int.Parse(data.Substring(0, data.Length - 1));
    int multiplier = 1;

    if (type == 'm') multiplier = 60;
    Start(time * multiplier);
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
    Menu();
}

Menu();
