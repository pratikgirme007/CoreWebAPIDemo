using CoreWebAPIDemo.DatabaseRepository.ModelDtos;
using CoreWebAPIDemo.DatabaseRepository.Models;

namespace CoreWebAPIDemo.Mapper
{
    public static class CandidateMapper
    {
        public static Candidate MapCandidateDto(CandidateDto candidateDto)
        {
            return new Candidate
            {
                FirstName = candidateDto.FirstName,
                MiddleName = candidateDto.MiddleName,
                LastName = candidateDto.LastName,
                DateOfBirth = candidateDto.DateOfBirth,
                Gender = candidateDto.Gender,
            };
        }

        public static void UpdateCandidate(this Candidate candidate, CandidateDto candidateDto)
        {
            candidate.FirstName = candidateDto.FirstName;
            candidate.MiddleName = candidateDto.MiddleName;
            candidate.LastName = candidateDto.LastName;
            candidate.DateOfBirth = candidateDto.DateOfBirth;
            candidate.Gender = candidateDto.Gender;
        }
    }
}
