using MyWebSite.Model.Interfaces;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using MyWebSite.Model.DataModel;
using System.Threading.Tasks;
using Dapper;
using System.Linq;

namespace MyWebSite.Model.Implementation
{
    public class CityProvider: ICityProvider
    {
        IDbConnection connection;
        public CityProvider(IDbConnection connection)
        {
            this.connection = connection;
        }


        public async Task<City> GetCity(int id)
        {
            using (var connection = this.connection.CreateConnection())
            {
                return await connection.QueryFirstAsync<City>("select CityId, CityName from City where CityId = @id", 
                    new { id = id });
            }
        }

        public async Task<List<City>> GetCities()
        {
            using (var connection = this.connection.CreateConnection())
            {
                var result = await connection.QueryAsync<City>("select CityId, CityName from City");
                return result.ToList();
            }
        }


        public async Task<bool> AddCity(City city)
        {
            using (var connection = this.connection.CreateConnection())
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "insert into city (CityName) values (@cityname)";
                command.Parameters.AddWithValue("@cityname", city.CityName);
                int rows = await command.ExecuteNonQueryAsync();
                return rows == 1;
            }
        }

        public async Task<bool> UpdateCity(City city)
        {
            using (var connection = this.connection.CreateConnection())
            {
                SqlTransaction transation = connection.BeginTransaction();
                SqlCommand command = connection.CreateCommand();
                command.Transaction = transation;
                command.CommandText = "update city set CityName = @cityname where cityid = @id";
                command.Parameters.AddWithValue("@id", city.CityId);
                command.Parameters.AddWithValue("@cityname", city.CityName);
                int rows = await command.ExecuteNonQueryAsync();
                transation.Commit();
                return rows == 1;
            }
        }

        public async Task<bool> DeleteCity(int id)
        {
            using (var connection = this.connection.CreateConnection())
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "delete from City where cityid = @id";
                command.Parameters.AddWithValue("@id", id);
                int rows = await command.ExecuteNonQueryAsync();
                return rows == 1;
            }
        }

        public async Task<bool> SaveCity(City city)
        {
            if (city.CityId == null)
            {
                await AddCity(city);
            }
            else
            {
                await UpdateCity(city);

            }
            return true;
        }
    }
}
