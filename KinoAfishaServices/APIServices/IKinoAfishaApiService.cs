using KinoAfishaServices.Models;
using System.Threading.Tasks;

namespace KinoAfishaServices.APIServices
{
    public interface IKinoAfishaApiService
    {
        Task<KinoAfishaModel> ReturnApiResult(string searchResult);
    }
}
