using DotNetEnv;
using Dapper;

namespace BaltaDapper
{
    class Program
    {
        public static void Main(string[] args)
        {
            Env.TraversePath().Load();
            var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
            Console.WriteLine(dbHost);
        }
    }
}
