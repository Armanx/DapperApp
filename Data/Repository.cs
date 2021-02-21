using DomeinCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Reflection;

namespace Data
{
    public class Repository<T>
    {
        private readonly string ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = MoviesDb; Integrated Security = True;";

        public void Insert(T element)
        {
            var fields = typeof(T).GetProperties().Select(f => new { Name = f.Name, }).ToArray();
            var sql = $"Insert into {typeof(T).Name} ({string.Join(",", fields.Select(x => x.Name))}) values ({string.Join(",", fields.Select(x => $"@{x.Name}"))})";
            using (var con = new SqlConnection(ConnectionString))
            {
                con.Execute(sql, new[] { element });
            }

        }

        public void InsertMany(IEnumerable<T> elements)
        {
            var fields = typeof(T).GetProperties().Select(f => new { Name = f.Name, }).ToArray();
            var sql = $"Insert into {typeof(T).Name} ({string.Join(",", fields.Select(x => x.Name))}) values ({string.Join(",", fields.Select(x => $"@{x.Name}"))})";

            using (var con = new SqlConnection(ConnectionString))
            {
                con.Execute(sql, elements);
            }
        }

        public void Update(T element, bool UpdateToNull = false)
        {

            var fields = typeof(T).GetProperties().Where(f => UpdateToNull ? true : f.GetValue(element) != null).Select(f => new { f.Name });
            var updates = string.Join(",", fields.Where(f => f.Name.ToLower() != "id").Select(x => $"{x.Name} = @{x.Name}"));
            var sql = $"update {typeof(T).Name} set {updates} where id = @id";

            using (var con = new SqlConnection(ConnectionString))
            {
                con.Execute(sql, new[] { element });
            }
        }


        public void HardDelete(T element)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                var delete = $"delete from {typeof(T).Name} where id = @id";
                con.Execute(delete, new[] { element });
            }
        }

        public void HardDeleteById(Guid Id)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                var delete = $"delete from {typeof(T).Name} where id = @id";
                con.Execute(delete, new { Id });
            }
        }

        public async Task HardDeleteByIdAsync(Guid id)
        {
            //using (var con = new SqlConnection(ConnectionString))
            //{
            //    var delete = $"delete from {typeof(T).Name} where id = @id";

            //    con.Execute(delete, new { Id });
            //}

           


        }

        private Task<T> baseHardDeleteById(Guid Id, Func<SqlConnection, string, Task<T>> func)
        {
            string sqlQuery = $"delete from {typeof(T).Name} where id = @id"; ;
            return func.Invoke(new SqlConnection(ConnectionString), sqlQuery);
        }








        #region GetAll and GetById

        public T GetItemById(Guid Id)
        {
            return baseGet(Id, (connection, s) => Task.FromResult<T>(connection.QuerySingle<T>(s))).Result;
        }

        public Task<T> GetItemByIdAsync(Guid Id)
        {
            return baseGet(Id, (connection, s) => connection.QuerySingleAsync<T>(s));
        }

        private Task<T> baseGet(Guid Id, Func<SqlConnection, string, Task<T>> func)
        {
            string sqlQuery = $"select * from {typeof(T).Name} where Id = '{Id}'";
            return func.Invoke(new SqlConnection(ConnectionString), sqlQuery);
        }

        public List<T> GetAll()
        {
            return BaseGetAll((connection, s) => Task.FromResult<List<T>>(connection.Query<T>(s).ToList())).Result;
        }

        public async Task<List<T>> GetAllAsync()
        {

            return await BaseGetAll(async (connection, s) =>
            {
                var collection = await connection.QueryAsync<T>(s); return collection.ToList();
            });
        }

        private Task<List<T>> BaseGetAll(Func<SqlConnection, string, Task<List<T>>> func)
        {
            var sqlQuery = $"select * from { typeof(T).Name }";
            return func.Invoke(new SqlConnection(ConnectionString), sqlQuery);
        }
        #endregion
    }
}



