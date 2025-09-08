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
            case 2: NewFile(); break;
            default:
                Console.WriteLine("Opção inválida.");
                Console.ReadKey();
                break;
        }
    }
}

static void OpenFile() { }

static void NewFile() { }

Menu();
