using Microsoft.Data.SqlClient;

namespace MyWebSite.Model.Interfaces
{
    public interface IDbConnection
    {
        SqlConnection CreateConnection();
    }
}
