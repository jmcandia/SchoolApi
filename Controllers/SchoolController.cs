using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolApi.Data;
using SchoolApi.Dtos;
using SchoolApi.Models;

namespace SchoolApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        private readonly IGenericRepository<School> _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<SchoolController> _logger;

        public SchoolController(IGenericRepository<School> repository, IMapper mapper, ILogger<SchoolController> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            IEnumerable<School> schools = await _repository.GetAll();
            // The error occurs on the following line
            //IEnumerable<SchoolForListDto> schoolsToReturn = _mapper<IEnumerable<SchoolForListDto>>.Map(schools);
            return Ok(schools);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] string id)
        {
            School school = await _repository.Get(id);
            SchoolForListDto schoolToReturn = _mapper.Map<SchoolForListDto>(school);
            return Ok(schoolToReturn);
        }
    }
}