using System;
using System.Data.Entity.Infrastructure;
using Demo.Data.Context;
using Demo.Data.GenericRawSql.Abstract;


namespace Demo.Data.GenericRawSql.Concrete
{
    public class GenericRawSql : IGenericRawSql
    {
        private readonly CommonContext _context;

        public GenericRawSql(CommonContext context)
        {
            _context = context;
        }

        public DbRawSqlQuery Execute(string connectionString, Type t, string sql, params object[] parameter)
        {
            _context.Database.Connection.ConnectionString = connectionString;
            return _context.Database.SqlQuery(t, sql, parameter);
        }
    }
}
