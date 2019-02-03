using KinoAfishaServices.Models;
using System.Threading.Tasks;

namespace KinoAfisha.Services.Interfaces
{
    public interface IKinoAfishaService
    {
        Task<KinoAfishaModel> Get(string searchCriteria);
    }
}
