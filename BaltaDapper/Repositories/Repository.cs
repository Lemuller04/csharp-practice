using Microsoft.Data.SqlClient;
using Dapper.Contrib.Extensions;

namespace BaltaDapper.Repositories
{
    public class Repository<TModel> where TModel : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<TModel> GetAll()
            => _connection.GetAll<TModel>();

        public TModel Get(int id)
            => _connection.Get<TModel>(id);

        public long Create(TModel model)
            => _connection.Insert<TModel>(model);

        public bool Update(TModel model)
            => _connection.Update<TModel>(model);

        public bool Delete(TModel model)
            => _connection.Delete<TModel>(model);

        public bool Delete(int id)
        {
            var model = _connection.Get<TModel>(id);
            return _connection.Delete<TModel>(model);
        }
    }
}
