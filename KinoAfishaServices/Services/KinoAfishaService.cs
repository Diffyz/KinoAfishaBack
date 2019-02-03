using KinoAfisha.Services.Interfaces;
using KinoAfishaServices.APIServices;
using KinoAfishaServices.Models;
using System.Threading.Tasks;

namespace KinoAfisha.Services
{
    public class KinoAfishaService : IKinoAfishaService
    {
        private readonly IKinoAfishaApiService kinoAfishaApiService;

        public KinoAfishaService(IKinoAfishaApiService kinoAfishaApiService)
        {
            this.kinoAfishaApiService = kinoAfishaApiService;
        }

        public async Task<KinoAfishaModel> Get(string searchCriteria)=>
            await kinoAfishaApiService.ReturnApiResult(searchCriteria);    
    }
}
