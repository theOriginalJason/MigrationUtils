using System.Collections.Generic;
using System.Data;
using Dapper;

namespace MigrationUtils.Dal
{
    public static class RepositoryUtil
    {
        public static IEnumerable<dynamic> Get(string sql, IDbConnection connection)
        {
            return connection.Query(sql, commandType: CommandType.Text);
        }
    }
}