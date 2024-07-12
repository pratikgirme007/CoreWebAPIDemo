using CoreWebAPIDemo.DatabaseRepository.ModelDtos;
using CoreWebAPIDemo.DatabaseRepository.Models;

namespace CoreWebAPIDemo.DataAccessLayer.Services
{
    public interface ICandidateService
    {
        IList<Candidate> GetCandidates();
        Candidate GetCandidateByID(int id);
        string CreateCandidate(CandidateDto candidate);
        string UpdateCandidate(int id, CandidateDto candidate);
        string DeleteCandidate(int id);
    }
}
