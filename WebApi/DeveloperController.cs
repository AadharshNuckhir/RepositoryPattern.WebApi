using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Services;

namespace WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IUnitOfWorkService _unitOfWorkService;

        public DeveloperController(IUnitOfWorkService unitOfWorkService)
        {
            _unitOfWorkService = unitOfWorkService;
        }

        [HttpGet]
        public IActionResult GetPopularDevelopers([FromQuery] int count)
        {
            return Ok(_unitOfWorkService.GetPopularDevelopers(count));
        }

        [HttpPost]
        public IActionResult AddDeveloperAndProject()
        {
            _unitOfWorkService.AddDeveloperAndProject();
            return Ok();
        }
    }
}
