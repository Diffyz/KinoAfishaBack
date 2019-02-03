using KinoAfisha.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KinoAfisha.Controllers
{
    [Route("api")]
    [ApiController]
    [EnableCors("AllowAll")]
    [Produces("application/json")]
    public class KinoAfishaController : Controller
    {
        private readonly IKinoAfishaService kinoAfishaService;

        public KinoAfishaController(IKinoAfishaService kinoAfishaService)
        {
            this.kinoAfishaService = kinoAfishaService;
        }

        [HttpGet]
        [Route("kinoafisha_load")]
        public async Task<IActionResult> Get(string Criteria)
        {
            var result = await kinoAfishaService.Get(Criteria);
            return Ok(result);
        }

        private JsonResult JsonResult(object data)
        {
            var jsonResult = Json(data);

            return jsonResult;
        }
    }
}
