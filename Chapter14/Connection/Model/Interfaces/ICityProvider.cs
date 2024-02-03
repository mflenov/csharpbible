using System.Collections.Generic;
using System.Threading.Tasks;
using MyWebSite.Model.DataModel;

namespace MyWebSite.Model.Interfaces
{
    public interface ICityProvider
    {
        Task<List<City>> GetCities();
        Task<City> GetCity(int id);
        Task<bool> SaveCity(City city);
        Task<bool> DeleteCity(int id);
    }
}
