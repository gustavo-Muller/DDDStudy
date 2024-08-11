using DDStudy.Application.Dtos;
using DDStudy.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DDDStudy.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExampleController : Controller
    {
        private readonly IApplicationServiceExample _applicationServiceExample;

        public ExampleController(IApplicationServiceExample applicationServiceExample)
        {
            _applicationServiceExample = applicationServiceExample;
        }

        [HttpGet("/getAll")]
        public IEnumerable<ExampleDTO> GetAll()
        {
            return _applicationServiceExample.GetAll();
        }
    }
}
