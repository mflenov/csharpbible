using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using MyWebSite.Model.Interfaces;

namespace MyWebSite.Model.Implementation
{
    public class DbConnection : IDbConnection
    {
        IConfiguration configuration;
        public DbConnection(IConfiguration configuration) {
            this.configuration = configuration;
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection(
                configuration.GetConnectionString("DefaultConnection")
                );
            connection.Open();
            return connection;
        }
    }
}
