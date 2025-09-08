namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            while (true)
            {
                Console.Clear();

                DrawScreen();
                WriteOptions();

                if (!short.TryParse(Console.ReadLine(), out short entry))
                {
                    Console.SetCursorPosition(3, 11);
                    Console.Write("Entrada inválida.");
                    Console.ReadKey();
                    continue;
                }
                HandleMenuOption(entry);
            }
        }

        static void HandleMenuOption(short option)
        {
            Console.SetCursorPosition(3, 11);

            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.Write("Ler"); break;
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default: Console.Write("Entrada inválida."); break;
            }
        }

        static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Edit HTML\n");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("(1) - Novo Arquivo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("(2) - Abrir");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("(0) - Sair");

            Console.SetCursorPosition(3, 9);
            Console.Write("Opção: ");
        }

        static void DrawScreen()
        {
            int width = 30;
            int height = 20;

            DrawDashLine(width);
            DrawCanvas(height, width);
            DrawDashLine(width);
        }

        static void DrawCanvas(int height = 10, int width = 30)
        {
            for (int i = 0; i < height; i++)
            {
                Console.Write("|");

                for (int j = 0; j < width; j++)
                    Console.Write(" ");

                Console.Write("|\n");
            }
        }

        static void DrawDashLine(int width = 30)
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
                Console.Write("-");

            Console.Write("+\n");
        }
    }
}
