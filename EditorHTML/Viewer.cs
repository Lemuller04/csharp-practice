using System.Text.RegularExpressions;

namespace EditorHTML
{
    public static class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.WriteLine("Visualisando arquivo: \n");
            Replace(text);
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                            words[i].Substring(
                                words[i].IndexOf('>') + 1,
                                ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                                )
                            );
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(' ');
                }
                else
                {
                    Console.Write(words[i]);
                    Console.Write(' ');
                }
            }
        }
    }
}
