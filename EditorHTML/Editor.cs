using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("Editando Arquivo: \n");
            Start();
        }

        static void Start()
        {
            var text = new StringBuilder();

            do
            {
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            while (true)
            {
                Viewer.Show(text.ToString());
                Console.Write("\nDeseja salvar o arquivo? s/N: ");
                string save = Console.ReadLine().ToLower();

                if (save.Equals("n") || string.IsNullOrEmpty(save))
                {
                    break;
                }

                if (save.Equals("s"))
                {
                    Console.WriteLine("Entro o caminho para salvar o arquivo: ");
                    string path = Console.ReadLine();

                    using (var file = new StreamWriter(path))
                    {
                        file.Write(text);
                    }

                    Console.WriteLine($"Arquivo {path} salvo com sucesso.");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
