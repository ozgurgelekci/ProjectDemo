using System;
using System.Data.Entity.Infrastructure;

namespace Demo.Data.GenericRawSql.Abstract
{
    public interface IGenericRawSql
    {
        /// <summary>
        /// Harici sorgulamalar yapmak için kullanılır.
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="t"></param>
        /// <param name="sql"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        DbRawSqlQuery Execute(string connectionString, Type t, string sql, params object[] parameter);
    }
}
