using Algorithmics.Data.Request;
using Algorithmics.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Algorithmics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgorithmController : ControllerBase
    {
        private readonly IAlgorithmService _algorithmService;
        public AlgorithmController(IAlgorithmService algorithmService)
        {
            _algorithmService = algorithmService;
        }
        [HttpPost,Route ("add-new-algorithm")]

        public IActionResult AddNewAlgorithm(AlgorithmRequest newAlgorithm)
        {
            _algorithmService.AddNewAlgorithm(newAlgorithm);
            return Ok();
        }
    }
}
