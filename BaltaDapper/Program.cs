using BaltaDapper.Repositories;
using BaltaDapper.Models;
using Microsoft.Data.SqlClient;
using Dapper.Contrib.Extensions;

namespace BaltaDapper
{
    class Program
    {
        private const string CONNECTION_STRING = @"Data Source=localhost,1433;Initial Catalog=BaltaBlog;User ID=sa;Password=1q2w3e4r@#$;Encrypt=True;TrustServerCertificate=True";

        public static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();

            ReadUsers(connection);
            // ReadTags(connection);
            // DeleteRole(connection, 1);
            // CreateRole(connection, new Role()
            // {
            //     Name = "Test role",
            //     Slug = "test-role-slug"
            // });
            // ReadRoles(connection);
            connection.Close();
        }

        public static void CreateRole(SqlConnection connection, Role role)
        {
            var repository = new Repository<Role>(connection);
            repository.Create(role);
        }

        public static void DeleteRole(SqlConnection connection, int id)
        {
            var repository = new Repository<Role>(connection);
            repository.Delete(id);
        }

        public static void ReadTags(SqlConnection connection)
        {
            var repository = new Repository<Tag>(connection);
            var items = repository.GetAll();
            foreach (var user in items)
            {
                Console.WriteLine(user.Name);
            }
        }

        public static void ReadRoles(SqlConnection connection)
        {
            var repository = new Repository<Role>(connection);
            var items = repository.GetAll();
            foreach (var role in items)
                Console.WriteLine(role.Name);
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repository = new UserRepository(connection);
            var items = repository.GetWithRoles();
            foreach (var user in items)
            {
                Console.WriteLine(user.Name);
                foreach (var role in user.Roles)
                    Console.WriteLine($"{role.Name}");
            }
        }
    }
}
