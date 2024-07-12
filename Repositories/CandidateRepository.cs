using CoreWebAPIDemo.DataAccessLayer.Services;
using CoreWebAPIDemo.DatabaseRepository.ModelDtos;
using CoreWebAPIDemo.DatabaseRepository.Models;

namespace CoreWebAPIDemo.Repositories
{
    public class CandidateRepository
    {
        private readonly ICandidateService _candidateService;
        public CandidateRepository(ICandidateService candidateService)
        {
            _candidateService = candidateService;
        }

        public IList<Candidate> GetList()
        {
            return _candidateService.GetCandidates();
        }

        public Candidate GetById(int id)
        {
            return _candidateService.GetCandidateByID(id);
        }

        public string Post(CandidateDto candidate)
        {
            return _candidateService.CreateCandidate(candidate);
        }

        public string Put(int id, CandidateDto candidate)
        {
            return _candidateService.UpdateCandidate(id, candidate);
        }

        public string Delete(int id)
        {
            return _candidateService.DeleteCandidate(id);
        }
    }
}
