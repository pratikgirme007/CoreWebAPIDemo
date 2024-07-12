using CoreWebAPIDemo.DataAccessLayer.Services;
using CoreWebAPIDemo.DatabaseRepository.DBContextRepos;
using CoreWebAPIDemo.DatabaseRepository.ModelDtos;
using CoreWebAPIDemo.DatabaseRepository.Models;
using CoreWebAPIDemo.Mapper;
using CoreWebAPIDemo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly CandidateRepository _candidateRepository;
        public CandidateController(ICandidateService candidateService)
        {
            _candidateRepository = new CandidateRepository(candidateService);
        }

        [HttpGet]
        [Route("GetCandidates")]
        public ActionResult<List<Candidate>> GetCandidates()
        {
            try
            {
                return Ok(_candidateRepository.GetList());
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet]
        [Route("GetCandidate/{id}")]
        public ActionResult<Candidate> GetCandidateById(int id)
        {
            try
            {
                return Ok(_candidateRepository.GetById(id));
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPost]
        [Route("SaveCandidate")]
        public ActionResult SaveCandidate([FromBody] CandidateDto candidate)
        {
            try
            {
                return Ok(_candidateRepository.Post(candidate));
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPut]
        [Route("UpdateCandidate/{id}")]
        public ActionResult UpdateCandidate(int id, CandidateDto candidate)
        {
            try
            {
                return Ok(_candidateRepository.Put(id, candidate));
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteCandidate/{id}")]
        public ActionResult DeleteCandidate(int id)
        {
            try
            {
                return Ok(_candidateRepository.Delete(id));
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
