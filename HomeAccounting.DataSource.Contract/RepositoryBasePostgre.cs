using Dapper;
using HomeAccounting.DataSource.Contract.Entity;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HomeAccounting.DataSource.Contract
{
    public class RepositoryBasePostgre : IRepository
    {
        private readonly string _connectionString = "Host=localhost; Username=postgres; Password=1; Database=Buh";

        public void CreateAccount(DbAccount account)
        {
            using(var db = new NpgsqlConnection(_connectionString))
            {                
                db.Execute($"insert into accounts(name, creationdate) Values(@Name, @CreationDate)",  account);
            }
        }

        public DbAccount GetAccountById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveAccount(DbAccount account)
        {
            throw new NotImplementedException();
        }
    }
}
