static void Menu()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Editor de Texto\n(1) Para abrir um arquivo.\n(2) Para criar um novo arquivo.\n(0) para sair.");

        if (!short.TryParse(Console.ReadLine(), out short entry))
        {
            Console.WriteLine("Entrada inválida.");
            Console.ReadKey();
            continue;
        }

        switch (entry)
        {
            case 0: Environment.Exit(0); break;
            case 1: OpenFile(); break;
            case 2: Edit(); break;
            default:
                Console.WriteLine("Opção inválida.");
                Console.ReadKey();
                break;
        }
    }
}

static void OpenFile()
{
    Console.Clear();
    Console.WriteLine("Insira o caminho do arquivo: ");
    string path = Console.ReadLine();

    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
    }

    Console.ReadKey();
}

static void Edit()
{
    Console.Clear();
    Console.WriteLine("Editando arquivo: ? - Pressione <Esc> para sair.");
    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Save(text);
}

static void Save(string text)
{
    Console.Clear();
    Console.WriteLine("Entre o caminho para salvar o arquivo: ");
    string path = Console.ReadLine();

    using (var file = new StreamWriter(path))
    {
        file.Write(text);
    }

    Console.WriteLine($"Arquivo {path} salvo com sucesso.");
    Console.ReadKey();
}

Menu();
