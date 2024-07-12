using CoreWebAPIDemo.DatabaseRepository.DBContextRepos;
using CoreWebAPIDemo.DatabaseRepository.ModelDtos;
using CoreWebAPIDemo.DatabaseRepository.Models;
using CoreWebAPIDemo.Mapper;

namespace CoreWebAPIDemo.DataAccessLayer.Services
{
    public class CandidateService : ICandidateService
    {
        private readonly CandidateDbContext _candidateDbContext;
        public CandidateService(CandidateDbContext candidateDbContext)
        {
            _candidateDbContext = candidateDbContext;
        }
        public string CreateCandidate(CandidateDto candidate)
        {
            Candidate candidate1 = CandidateMapper.MapCandidateDto(candidate);
            _candidateDbContext.Candidates.Add(candidate1);
            _candidateDbContext.SaveChanges();
            return "Save Successful";
        }

        public string DeleteCandidate(int id)
        {
            Candidate dboCandidate = _candidateDbContext.Candidates.Where(x => x.CandidateId == id).FirstOrDefault<Candidate>();
            if (dboCandidate == null)
                return "No record found";
            _candidateDbContext.Candidates.Remove(dboCandidate);
            _candidateDbContext.SaveChanges();
            return "Delete Successful";
        }

        public Candidate GetCandidateByID(int id)
        {
            return _candidateDbContext.Candidates.Where(x => x.CandidateId == id).FirstOrDefault();
        }

        public IList<Candidate> GetCandidates()
        {
            return _candidateDbContext.Candidates.ToList();
        }

        public string UpdateCandidate(int id, CandidateDto candidate)
        {
            Candidate dboCandidate = _candidateDbContext.Candidates.Where(x => x.CandidateId == id).FirstOrDefault<Candidate>();
            if (dboCandidate == null)
                return "No record found";
            dboCandidate.UpdateCandidate(candidate);
            _candidateDbContext.SaveChanges();
            return "Update Successful";
        }
    }
}
