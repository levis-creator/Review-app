using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Review_app.Repositories.Interfaces;

namespace Review_app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokomonController : ControllerBase
    {
        private readonly IPokomonRepository _pokomonRepository;
        public PokomonController(IPokomonRepository pokomonRepository)
        {
            _pokomonRepository = pokomonRepository;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_pokomonRepository.GetPokomons());
        }
    }
}
