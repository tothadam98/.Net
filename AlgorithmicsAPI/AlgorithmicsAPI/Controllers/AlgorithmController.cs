using AlgorithmicsAPI.Data.Request;
using AlgorithmicsAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AlgorithmicsAPI.Controllers
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
        [HttpPost(Name = "add-new-algorithm")]

        public IActionResult AddNewAlgorithm(AlgorithmRequest newAlgorithm)
        {
            _algorithmService.AddNewAlgorithm(newAlgorithm);
            return Ok();
        }
    }
}
